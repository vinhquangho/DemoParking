using DemoParking.Dtos;
using DemoParking.Dtos.Employee;
using DemoParking.EntityFramework;
using DemoParking.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoParking.Services
{
    public class EmployeeService
    {
        private readonly AppDbContext _dbContext;
        public EmployeeService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // lấy danh sách nhân viên với điều kiện name hoặc code và trạng thái
        public List<ViewDto> GetAll(string text, Status? status)
        {
            var query = _dbContext.Employee.Where(f => f.IsDeleted == false);
            if (!string.IsNullOrEmpty(text))
                query = query.Where(f => f.Code.Contains(text) || f.Name.Contains(text));
            if (status.HasValue)
                query = query.Where(f => f.Status == status.Value);
            return query.Select(f => new ViewDto()
            {
                Id = f.Id,
                Code = f.Code,
                Name = f.Name,
                Address = f.Address,
                Phone = f.Phone,
                Status = f.Status == Status.Active ? "Đang hoạt động" : "Ngừng hoạt đông",
                UserName = f.UserName,
                BirthDay = f.BirthDay
            }).ToList();
        }
        // lấy nhan viên với id
        public Employee GetById(int id)
        {
            return _dbContext.Employee.FirstOrDefault(f => f.Id == id);
        }
        // đăng nhập nhân viên
        public Employee FindEmployeeByLogin(LoginDto dto)
        {
            var result = _dbContext.Employee.FirstOrDefault(f => f.UserName == dto.UserName && f.Password == dto.Password && f.Status == Status.Active && f.IsDeleted == false);
            if (result != null)
                Global.EmployeeId = result.Id;
            return result;
        }
        // tạo mới mật khẩu cho nhân viên
        public string Reset(int id)
        {
            var random = new Random();
            var password = random.Next(0, 999999).ToString("D6");
            var employee = _dbContext.Employee.FirstOrDefault(f => f.Id == id);
            if (employee != null)
            {
                employee.Password = password;
                _dbContext.SaveChanges();

                return $"Mật khẩu mới của nhân viên {employee.Name} đã được thay đổi{Environment.NewLine}Mật khẩu mới: {password}";
            }
            return string.Empty;
        }
        // xóa nhân viên
        public bool Delete(int id)
        {
            if (_dbContext.Employee.Any(f => f.Id == id))
            {
                var model = _dbContext.Employee.FirstOrDefault(f => f.Id == id);
                model.IsDeleted = true;
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
        // cập nhật nhân viên
        public bool Update(Employee model)
        {
            if (_dbContext.Employee.Any(f => (f.Code == model.Code || f.UserName == model.UserName) && f.Id != model.Id))
                return false;

            var enty = _dbContext.Employee.FirstOrDefault(f => f.Id == model.Id);
            enty.Code = model.Code;
            enty.Name = model.Name;
            enty.Address = model.Address;
            enty.Phone = model.Phone;
            enty.Status = model.Status;
            enty.UserName = model.UserName;
            enty.Password = model.Password;
            enty.BirthDay = model.BirthDay;
            _dbContext.SaveChanges();
            return true;
        }
        // tạo mới nhân viên
        public bool Create(Employee model)
        {
            if (_dbContext.Employee.Any(f => f.Code == model.Code || f.UserName == model.UserName))
                return false;

            _dbContext.Employee.Add(model);
            _dbContext.SaveChanges();

            return true;
        }
        public List<SelectDto> GetForCombobox()
        {
            return _dbContext.Employee.Where(f => f.IsDeleted == false).Select(f => new SelectDto() { Id = f.Id, Name = f.Name }).ToList();
        }
    }
}
