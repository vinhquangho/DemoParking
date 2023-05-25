using DemoParking.Dtos;
using DemoParking.Dtos.Ticket;
using DemoParking.EntityFramework;
using DemoParking.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace DemoParking.Services
{
    public class TicketService
    {
        private readonly AppDbContext _dbContext;
        public TicketService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<ViewDto> GetAll(string text, TypeTicket? status)
        {
            var query = _dbContext.Tickets.Include("Employee").AsQueryable();
            if (!string.IsNullOrEmpty(text))
                query = query.Where(f => f.Code.Contains(text) || f.Name.Contains(text));
            if (status.HasValue)
                query = query.Where(f => f.TypeTicket == status.Value);
            var list = query.ToList();
            return list.Select(f => new ViewDto()
            {
                Id = f.Id,
                Code = f.Code,
                Name = f.Name,
                StartDate = f.StartDate,
                EndDate = f.EndDate,
                Price = f.Price,
                TypeTicket = Global.GetDisplayName(f.TypeTicket),
                Status = DateTime.Now.Date > f.EndDate.Date ? "Hết hạn" : "Còn sử dụng",
                EmployeeName = f.Employee.Name
            }).ToList();
        }
        public Ticket GetById(int id)
        {
            return _dbContext.Tickets.FirstOrDefault(f => f.Id == id);
        }
        public bool Delete(int id)
        {
            if (_dbContext.Tickets.Any(f => f.Id == id))
            {
                var model = _dbContext.Tickets.FirstOrDefault(f => f.Id == id);
                _dbContext.Tickets.Remove(model);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Update(Ticket model)
        {
            if (_dbContext.Tickets.Any(f => f.Code == model.Code && f.Id != model.Id))
                return false;

            var enty = _dbContext.Tickets.FirstOrDefault(f => f.Id == model.Id);
            enty.Code = model.Code;
            enty.Name = model.Name;
            enty.StartDate = model.StartDate;
            enty.EndDate = model.EndDate;
            enty.Price = model.Price;
            enty.TypeTicket = model.TypeTicket;
            enty.EmployeeId = model.EmployeeId;
            _dbContext.SaveChanges();
            return true;
        }
        public bool Create(Ticket model)
        {
            if (_dbContext.Tickets.Any(f => f.Code == model.Code))
                return false;

            _dbContext.Tickets.Add(model);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
