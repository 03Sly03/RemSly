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
        public async Task<int> Add(ReservationSession ReservationSession)
        {
            var addedObj = await _dbContext.ReservationSessions.AddAsync(ReservationSession);

            await _dbContext.SaveChangesAsync();
            return addedObj.Entity.SessionId;
        }
        public async Task<ReservationSession> GetById(int sessionid, int reservationid)
        {
            return await _dbContext.ReservationSessions.FirstOrDefaultAsync(rs => (rs.SessionId == sessionid && rs.ReservationId == reservationid));
        }

        public async Task<ReservationSession?> Get(Expression<Func<ReservationSession, bool>> predicate)
        {
            return await _dbContext.ReservationSessions.FirstOrDefaultAsync(predicate);
        }

        public async Task<List<ReservationSession>> GetAll(Expression<Func<ReservationSession, bool>> predicate)
        {
            return await _dbContext.ReservationSessions.Where(predicate).ToListAsync();
        }

        public async Task<List<ReservationSession>> GetAll()
        {
            return await _dbContext.ReservationSessions.ToListAsync();
        }

        public async Task<bool> Delete(int sessionid, int reservationid)
        {
            var ReservationSessionToDelete = await GetById(sessionid, reservationid);

            if (ReservationSessionToDelete == null)
                return false;

            _dbContext.ReservationSessions.Remove(ReservationSessionToDelete);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
