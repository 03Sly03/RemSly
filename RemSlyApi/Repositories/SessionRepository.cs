using Microsoft.EntityFrameworkCore;
using RemSlyApi.Datas;
using RemSlyCore.Models;
using System.Linq.Expressions;

namespace RemSlyApi.Repositories
{
    public class SessionRepository : IRepository<Session>
    {
        private ApplicationDbContext _dbContext { get; }
        public SessionRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Add(Session Session)
        {
            var addedObj = await _dbContext.Sessions.AddAsync(Session);

            await _dbContext.SaveChangesAsync();
            return addedObj.Entity.Id;
        }
        public async Task<Session> GetById(int id)
        {
            return await _dbContext.Sessions.Include(session => session.Comments).FirstOrDefaultAsync(session => session.Id == id);
        }

        public async Task<Session?> Get(Expression<Func<Session, bool>> predicate)
        {
            return await _dbContext.Sessions.Include(session => session.Comments).FirstOrDefaultAsync(predicate);
        }

        public async Task<List<Session>> GetAll(Expression<Func<Session, bool>> predicate)
        {
            return await _dbContext.Sessions.Where(predicate).ToListAsync();
        }

        public async Task<List<Session>> GetAll()
        {
            return await _dbContext.Sessions.ToListAsync();
        }

        public async Task<bool> Update(Session Session)
        {
            var SessionFromDb = await GetById(Session.Id);

            if (SessionFromDb == null)
                return false;

            if (SessionFromDb.Name != Session.Name)
                SessionFromDb.Name = Session.Name;
            if (SessionFromDb.Schedules != Session.Schedules)
                SessionFromDb.Schedules = Session.Schedules;
            if (SessionFromDb.CapacityMax != Session.CapacityMax)
                SessionFromDb.CapacityMax = Session.CapacityMax;
            if (SessionFromDb.IsComplete != Session.IsComplete)
                SessionFromDb.IsComplete = Session.IsComplete;
            if (SessionFromDb.Score != Session.Score)
                SessionFromDb.Score = Session.Score;
            if (SessionFromDb.Comments != Session.Comments)
                SessionFromDb.Comments = Session.Comments;
            if (SessionFromDb.ImageUrl != Session.ImageUrl)
                SessionFromDb.ImageUrl = Session.ImageUrl;

            return await _dbContext.SaveChangesAsync() > 0;

        }
        public async Task<bool> Delete(int id)
        {
            var Session = await GetById(id);

            if (Session == null)
                return false;

            _dbContext.Sessions.Remove(Session);
            return await _dbContext.SaveChangesAsync() > 0;
        }

    }
}
