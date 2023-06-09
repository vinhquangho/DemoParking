﻿using DemoParking.Dtos;
using DemoParking.Dtos.Shift;
using DemoParking.EntityFramework;
using DemoParking.Models;
using System.Collections.Generic;
using System.Linq;

namespace DemoParking.Services
{
    public class ShiftService
    {
        private readonly AppDbContext _dbContext;
        public ShiftService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<ViewDto> GetAll()
        {
            var data = _dbContext.Shifts.ToList();
            return data.Select(f => new ViewDto()
            {
                Id = f.Id,
                Name = f.Name,
                HourStart = f.HourStart.ToString("HH"),
                HourEnd = f.HourEnd.ToString("HH"),
                Price = f.Price
            }).ToList();
        }
        public Shift GetById(int id)
        {
            return _dbContext.Shifts.FirstOrDefault(f => f.Id == id);
        }
        public bool Delete(int id)
        {
            if (_dbContext.Shifts.Any(f => f.Id == id))
            {
                var model = _dbContext.Shifts.FirstOrDefault(f => f.Id == id);
                _dbContext.Shifts.Remove(model);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Update(Shift model)
        {
            var enty = _dbContext.Shifts.FirstOrDefault(f => f.Id == model.Id);
            if (enty != null)
            {
                enty.Price = model.Price;
                enty.HourStart = model.HourStart;
                enty.HourEnd = model.HourEnd;
                enty.Name = model.Name;
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Create(Shift model)
        {
            _dbContext.Shifts.Add(model);
            _dbContext.SaveChanges();
            return true;
        }
        public List<SelectDto> GetForCobobox()
        {
            return _dbContext.Shifts.Select(f => new SelectDto() { Id = f.Id, Name = f.Name }).ToList();
        }
    }
}
