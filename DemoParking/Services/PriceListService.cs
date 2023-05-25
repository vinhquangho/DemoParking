using DemoParking.Dtos;
using DemoParking.Dtos.PriceList;
using DemoParking.EntityFramework;
using DemoParking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoParking.Services
{
    public class PriceListService
    {
        private readonly AppDbContext _dbContext;
        public PriceListService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<ViewDto> GetAll()
        {
            var data = _dbContext.PriceLists.ToList();
            return data.Select(f => new ViewDto()
            {
                Id = f.Id,
                TypeTicket = Global.GetDisplayName(f.TypeTicket),
                HourStart = f.DateIn.ToString("HH"),
                HourEnd = f.DateOut.ToString("HH"),
                Price = f.Price
            }).ToList();
        }
        public PriceList GetById(int id)
        {
            return _dbContext.PriceLists.FirstOrDefault(f => f.Id == id);
        }
        public bool Delete(int id)
        {
            if (_dbContext.PriceLists.Any(f => f.Id == id))
            {
                var model = _dbContext.PriceLists.FirstOrDefault(f => f.Id == id);
                _dbContext.PriceLists.Remove(model);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Update(PriceList model)
        {
            var enty = _dbContext.PriceLists.FirstOrDefault(f => f.Id == model.Id);
            if (enty != null)
            {
                enty.Price = model.Price;
                enty.DateIn = model.DateIn;
                enty.DateOut = model.DateOut;
                enty.TypeTicket = model.TypeTicket;
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Create(PriceList model)
        {
            _dbContext.PriceLists.Add(model);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
