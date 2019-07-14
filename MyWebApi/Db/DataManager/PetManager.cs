using Microsoft.EntityFrameworkCore;
using MyWebApi.Db.Repository;
using MyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApi.Db.DataManager
{
    public class PetManager : IDataRepository<Pet>
    {
        readonly MyWebApiContext _myWebApiContext;

        public PetManager(MyWebApiContext context)
        {
            _myWebApiContext = context;
        }

        public async Task<IEnumerable<Pet>> GetAllAsync()
        {
            return await Task.FromResult(_myWebApiContext.Pets.ToList());
        }

        public async Task<Pet> GetAsync(Guid id)
        {
            return await Task.FromResult(_myWebApiContext.Pets
                  .FirstOrDefault(e => e.PetId == id));
        }

        public async Task AddAsync(Pet entity)
        {
            _myWebApiContext.Pets.Add(entity);
            await _myWebApiContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Pet pet, Pet entity)
        {
            pet.Description = entity.Description;
            pet.Name = entity.Name;
            pet.Price = entity.Price;

            await _myWebApiContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Pet pet)
        {
            _myWebApiContext.Pets.Remove(pet);
            await _myWebApiContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Pet>> FindByNameAsync(string name)
        {
            return await Task.FromResult(_myWebApiContext.Pets
                .Where(p => EF.Functions.Like(p.Name, $"%{name}%"))
                .ToList()
            );
        }
    }
}
