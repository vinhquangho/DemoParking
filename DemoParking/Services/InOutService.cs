using DemoParking.Dtos.InOut;
using DemoParking.EntityFramework;
using DemoParking.Models;
using System.Collections.Generic;
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
        public List<ViewDto> GetAll(string text, Status? status)
        {
            var query = _dbContext.InOuts.Include("Employee").Where(f => f.IsDeleted == false);
            if (!string.IsNullOrEmpty(text))
                query = query.Where(f => f.Code.Contains(text));
            if (status.HasValue)
                query = query.Where(f => f.Status == status.Value);
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
                model.IsDeleted = true;
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Create(InOut model)
        {
            if (_dbContext.InOuts.Any(f => f.Code == model.Code && f.Status == Status.Active))
                return false;

            _dbContext.InOuts.Add(model);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
