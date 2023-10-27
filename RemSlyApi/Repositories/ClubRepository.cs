using Microsoft.EntityFrameworkCore;
using RemSlyApi.Datas;
using RemSlyCore.Models;
using System.Linq.Expressions;

namespace RemSlyApi.Repositories
{
    public class ClubRepository : IRepository<Club>
    {
        private ApplicationDbContext _dbContext { get; }
        public ClubRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Add(Club club)
        {
            var addedObj = await _dbContext.Clubs.AddAsync(club);

            await _dbContext.SaveChangesAsync();
            return addedObj.Entity.Id;
        }
        public async Task<Club> GetById(int id)
        {
            return await _dbContext.Clubs.Include(c => c.Sessions).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Club?> Get(Expression<Func<Club, bool>> predicate)
        {
            return await _dbContext.Clubs.Include(c => c.Sessions).FirstOrDefaultAsync(predicate);
        }

        public async Task<List<Club>> GetAll(Expression<Func<Club, bool>> predicate)
        {
            return await _dbContext.Clubs.Where(predicate).ToListAsync();
        }

        public async Task<List<Club>> GetAll()
        {
            return await _dbContext.Clubs.ToListAsync();
        }

        public async Task<bool> Update(Club club)
        {
            var clubFromDb = await GetById(club.Id);

            if (clubFromDb == null)
                return false;

            if (clubFromDb.Name != club.Name)
                clubFromDb.Name = club.Name;
            if (clubFromDb.Address != club.Address)
                clubFromDb.Address = club.Address;
            if (clubFromDb.PostalCode != club.PostalCode)
                clubFromDb.PostalCode = club.PostalCode;
            if (clubFromDb.PhoneNumber != club.PhoneNumber)
                clubFromDb.PhoneNumber = club.PhoneNumber;
            if (clubFromDb.Email != club.Email)
                clubFromDb.Email = club.Email;
            if (clubFromDb.OpeningHours != club.OpeningHours)
                clubFromDb.OpeningHours = club.OpeningHours;
            if (clubFromDb.IsLadiesOnly != club.IsLadiesOnly)
                clubFromDb.IsLadiesOnly = club.IsLadiesOnly;
            if (clubFromDb.Is24h != club.Is24h)
                clubFromDb.Is24h = club.Is24h;

            return await _dbContext.SaveChangesAsync() > 0;

        }
        public async Task<bool> Delete(int id)
        {
            var club = await GetById(id);

            if (club == null)
                return false;

            _dbContext.Clubs.Remove(club);
            return await _dbContext.SaveChangesAsync() > 0;
        }

    }
}
