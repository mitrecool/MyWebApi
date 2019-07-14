using Microsoft.EntityFrameworkCore;
using MyWebApi.Db.Repository;
using MyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApi.Db.DataManager
{
    public class GoodManager : IDataRepository<Good>
    {
        readonly MyWebApiContext _myWebApiContext;

        public GoodManager(MyWebApiContext context)
        {
            _myWebApiContext = context;
        }

        public async Task<IEnumerable<Good>> GetAllAsync()
        {
            return await _myWebApiContext.Goods.ToListAsync();
        }

        public async Task<Good> GetAsync(Guid id)
        {
            return await Task.FromResult(_myWebApiContext.Goods
                  .FirstOrDefault(e => e.GoodId == id));
        }

        public async Task AddAsync(Good entity)
        {
            _myWebApiContext.Goods.Add(entity);
            await _myWebApiContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Good good, Good entity)
        {
            good.Description = entity.Description;
            good.Name = entity.Name;
            good.Price = entity.Price;

            await _myWebApiContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Good good)
        {
            _myWebApiContext.Goods.Remove(good);
            await _myWebApiContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Good>> FindByNameAsync(string name)
        {
            return await _myWebApiContext.Goods
                .Where(p => EF.Functions.Like(p.Name, $"{name}%"))
                .ToListAsync();            
        }
    }
}
