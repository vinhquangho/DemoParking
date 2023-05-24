using DemoParking.Dtos;
using DemoParking.Dtos.Issue;
using DemoParking.EntityFramework;
using DemoParking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemoParking.Services
{
    public class IssueService
    {
        private AppDbContext _dbContext { get; set; }
        public IssueService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<ViewDto> GetAll(string text)
        {
            var query = _dbContext.Issues.Include("Employee").Where(f => f.IsDeleted == false);
            if (!string.IsNullOrEmpty(text))
                query = query.Where(f => f.Code.Contains(text));
            var list = query.ToList();
            return list.Select(f => new ViewDto()
            {
                Code = f.Code,
                Reason = f.Reason,
                Content = f.Content,
                CreationTime = f.CreationTime,
                EmployeeName = f.Employee.Name
            }).ToList();
        }
        public bool Create(Issue model)
        {
            _dbContext.Issues.Add(model);

            var inOut = _dbContext.InOuts.FirstOrDefault(f => f.Code == model.Code);
            if (inOut != null)
            {
                inOut.DateOut = DateTime.Now;
                inOut.Status = Models.Status.DeActive;
                _dbContext.SaveChanges();
            }
            _dbContext.SaveChanges();
            return true;
        }
        public List<SelectDto> GetCode()
        {
            var inout = _dbContext.InOuts.Where(f => f.IsDeleted == false && f.Status == Models.Status.Active).ToList();
            return inout.Select(f => new SelectDto() { Id = f.Id, Name = f.Code }).ToList();
        }
    }
}
