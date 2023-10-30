using Microsoft.EntityFrameworkCore;
using RemSlyApi.Datas;
using RemSlyCore.Models;
using System.Linq.Expressions;

namespace RemSlyApi.Repositories
{
    public class ReservationSessionRepository
    {
        private ApplicationDbContext _dbContext { get; }
        public ReservationSessionRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> Add(ReservationSession ReservationSession)
        {
            var addedObj = await _dbContext.ReservationSessions.AddAsync(ReservationSession);

            await _dbContext.SaveChangesAsync();
            return addedObj.Entity.SessionId > 0 && addedObj.Entity.ReservationId > 0;
        //}
        //public async Task<ReservationSession> GetById(int sessionid, int reservation id)
        //{
        //    return await _dbContext.ReservationSessions.FirstOrDefaultAsync(rs => (rsession.Id == id);
        //}

        //public async Task<ReservationSession?> Get(Expression<Func<ReservationSession, bool>> predicate)
        //{
        //    return await _dbContext.ReservationSessions.FirstOrDefaultAsync(predicate);
        //}

        //public async Task<List<ReservationSession>> GetAll(Expression<Func<ReservationSession, bool>> predicate)
        //{
        //    return await _dbContext.ReservationSessions.Where(predicate).ToListAsync();
        //}

        //public async Task<List<ReservationSession>> GetAll()
        //{
        //    return await _dbContext.ReservationSessions.ToListAsync();
        //}

        //public async Task<bool> Update(ReservationSession ReservationSession)
        //{
        //    var ReservationSessionFromDb = await GetById(ReservationSession.Id);

        //    if (ReservationSessionFromDb == null)
        //        return false;

        //    if (ReservationSessionFromDb.Name != ReservationSession.Name)
        //        ReservationSessionFromDb.Name = ReservationSession.Name;
        //    if (ReservationSessionFromDb.Schedules != ReservationSession.Schedules)
        //        ReservationSessionFromDb.Schedules = ReservationSession.Schedules;
        //    if (ReservationSessionFromDb.CapacityMax != ReservationSession.CapacityMax)
        //        ReservationSessionFromDb.CapacityMax = ReservationSession.CapacityMax;


        //    return await _dbContext.SaveChangesAsync() > 0;

        //}
        //public async Task<bool> Delete(int id)
        //{
        //    var ReservationSession = await GetById(id);

        //    if (ReservationSession == null)
        //        return false;

        //    _dbContext.ReservationSessions.Remove(ReservationSession);
        //    return await _dbContext.SaveChangesAsync() > 0;
        //}
    }
}
