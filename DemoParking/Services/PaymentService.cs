using DemoParking.Dtos;
using DemoParking.Dtos.Payment;
using DemoParking.EntityFramework;
using DemoParking.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemoParking.Services
{
    internal class PaymentService
    {
        private AppDbContext _dbContext { get; set; }
        public PaymentService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<ViewDto> GetAll(DateTime dateFrom, DateTime dateTo, bool? isTicketMonth)
        {
            var query = _dbContext.Payments.Include("Employee").OrderByDescending(f => f.Id).AsQueryable();
            if (isTicketMonth.HasValue) query = query.Where(f => f.isTicketMonth == isTicketMonth).AsQueryable();

            var list = query.ToList();
            list = list.Where(f => f.CreationTime.Date >= dateFrom.Date.Date && f.CreationTime.Date <= dateTo.Date).ToList();
            return list.Select(f => new ViewDto()
            {
                Code = f.Code,
                CreationTime = f.CreationTime,
                Price = f.Price,
                IsTicketMonth = f.isTicketMonth,
                EmployeeName = f.Employee.Name
            }).ToList();
        }
    }
}
