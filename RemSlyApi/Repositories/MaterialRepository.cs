using Microsoft.EntityFrameworkCore;
using RemSlyApi.Datas;
using RemSlyCore.Models;
using System.Linq.Expressions;

namespace RemSlyApi.Repositories
{
    public class MaterialRepository : IRepository<Material>
    {
        private ApplicationDbContext _dbContext { get; }
        public MaterialRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Add(Material material)
        {
            var addedObj = await _dbContext.Materials.AddAsync(material);

            await _dbContext.SaveChangesAsync();
            return addedObj.Entity.Id;
        }
        public async Task<Material> GetById(int id)
        {
            return await _dbContext.Materials.FindAsync(id);
        }

        public async Task<Material?> Get(Expression<Func<Material, bool>> predicate)
        {
            return await _dbContext.Materials.FirstOrDefaultAsync(predicate);
        }

        public async Task<List<Material>> GetAll(Expression<Func<Material, bool>> predicate)
        {
            return await _dbContext.Materials.Where(predicate).ToListAsync();
        }

        public async Task<List<Material>> GetAll()
        {
            return await _dbContext.Materials.ToListAsync();
        }

        public async Task<bool> Update(Material material)
        {
            var materialFromDb = await GetById(material.Id);

            if (materialFromDb == null)
                return false;

            if (materialFromDb.Name != material.Name)
                materialFromDb.Name = material.Name;
            if (materialFromDb.Clubs != material.Clubs)
                materialFromDb.Clubs = material.Clubs;

            return await _dbContext.SaveChangesAsync() > 0;

        }
        public async Task<bool> Delete(int id)
        {
            var material = await GetById(id);

            if (material == null)
                return false;

            _dbContext.Materials.Remove(material);
            return await _dbContext.SaveChangesAsync() > 0;
        }

    }
}
