using DemoParking.Dtos.EmployeeShift;
using DemoParking.EntityFramework;
using DemoParking.Models;
using System.Collections.Generic;
using System.Linq;

namespace DemoParking.Services
{
    public class EmployeeShiftService
    {
        private readonly AppDbContext _dbContext;
        public EmployeeShiftService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<ViewDto> GetByShiftId(int id)
        {
            var data = _dbContext.EmployeeShifts.Include("Employee").Include("Shift")
                .Where(f => f.ShiftId == id).ToList();
            return data.Select(f => new ViewDto()
            {
                Id = f.Id,
                EmployeeName = f.Employee.Name,
                ShiftName = f.Shift.Name
            }).ToList();
        }
        public bool Delete(int id)
        {
            if (_dbContext.EmployeeShifts.Any(f => f.Id == id))
            {
                var model = _dbContext.EmployeeShifts.FirstOrDefault(f => f.Id == id);
                _dbContext.EmployeeShifts.Remove(model);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Create(EmployeeShift model)
        {
            if (_dbContext.EmployeeShifts.Any(f => f.EmployeeId == model.EmployeeId && f.ShiftId == model.ShiftId))
                return false;

            _dbContext.EmployeeShifts.Add(model);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
