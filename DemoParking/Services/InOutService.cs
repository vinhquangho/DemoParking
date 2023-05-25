using DemoParking.Dtos.InOut;
using DemoParking.EntityFramework;
using DemoParking.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace DemoParking.Services
{
    public class InOutService
    {
        private readonly AppDbContext _dbContext;
        public InOutService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<ViewDto> GetAll(string text, Status? status, TypeTicket? typeTicket)
        {
            var query = _dbContext.InOuts.Include("Employee").Where(f => f.Status == Status.Active);
            if (!string.IsNullOrEmpty(text))
                query = query.Where(f => f.Code.Contains(text));
            if (status.HasValue)
                query = query.Where(f => f.Status == status.Value);
            if (typeTicket.HasValue)
                query = query.Where(f => f.TypeTicket == typeTicket.Value);
            var list = query.ToList();
            return list.Select(f => new ViewDto()
            {
                Id = f.Id,
                Code = f.Code,
                DateIn = f.DateIn,
                DateOut = f.DateOut,
                IsTicket = f.IsTicket,
                Status = f.Status == Status.Active ? "Đang gửi" : "Đã lấy xe",
                EmployeeName = f.Employee.Name
            }).ToList();
        }
        public InOut GetById(int id)
        {
            return _dbContext.InOuts.FirstOrDefault(f => f.Id == id);
        }
        public bool Delete(int id)
        {
            if (_dbContext.InOuts.Any(f => f.Id == id))
            {
                var model = _dbContext.InOuts.FirstOrDefault(f => f.Id == id);
                _dbContext.InOuts.Remove(model);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Create(InOut model)
        {
            if (_dbContext.InOuts.Any(f => f.Code == model.Code && f.Status == Status.Active))
                return false;

            var ticket = _dbContext.Tickets.FirstOrDefault(f => f.Code == model.Code);
            if(ticket != null && ticket.EndDate.Date >= DateTime.Now.Date)
            {
                model.IsTicket = true;
                model.TypeTicket = ticket.TypeTicket;
            }

            _dbContext.InOuts.Add(model);
            _dbContext.SaveChanges();
            return true;
        }
        public decimal GetPaymentByTicketType(TypeTicket typeTicket)
        {
            var priceList = _dbContext.PriceLists.FirstOrDefault(f => f.TypeTicket == typeTicket && f.DateOut.Hour > DateTime.Now.Hour);
            return priceList == null ? 0 : priceList.Price;
        }
        public void UpdateInOut(int id)
        {
            var model = _dbContext.InOuts.FirstOrDefault(f => f.Id == id);
            if (model != null)
            {
                model.DateOut = DateTime.Now;
                model.Status = Status.DeActive;
                _dbContext.SaveChanges();
            }
        }
        public void CreatePayment(Payment model)
        {
            _dbContext.Payments.Add(model);
            _dbContext.SaveChanges();
        }
    }
}
