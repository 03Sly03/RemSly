using Microsoft.EntityFrameworkCore;
using RemSlyApi.Datas;
using RemSlyCore.Models;
using System.Linq.Expressions;

namespace RemSlyApi.Repositories
{
    public class CommentaryRepository : IRepository<Commentary>
    {
        private ApplicationDbContext _dbContext { get; }
        public CommentaryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Add(Commentary commentary)
        {
            var addedObj = await _dbContext.Commentaries.AddAsync(commentary);

            await _dbContext.SaveChangesAsync();
            return addedObj.Entity.Id;
        }
        public async Task<Commentary> GetById(int id)
        {
            return await _dbContext.Commentaries.Include(comment => comment.User).FirstOrDefaultAsync(comment => comment.Id == id);
        }

        public async Task<Commentary?> Get(Expression<Func<Commentary, bool>> predicate)
        {
            return await _dbContext.Commentaries.Include(comment => comment.User).FirstOrDefaultAsync(predicate);
        }

        public async Task<List<Commentary>> GetAll(Expression<Func<Commentary, bool>> predicate)
        {
            return await _dbContext.Commentaries.Where(predicate).ToListAsync();
        }

        public async Task<List<Commentary>> GetAll()
        {
            return await _dbContext.Commentaries.Include(comment => comment.User).ToListAsync();
        }

        public async Task<bool> Update(Commentary commentary)
        {
            var commentaryFromDb = await GetById(commentary.Id);

            if (commentaryFromDb == null)
                return false;

            if (commentaryFromDb.Content != commentary.Content)
                commentaryFromDb.Content = commentary.Content;
            if (commentaryFromDb.User != commentary.User)
                commentaryFromDb.User = commentary.User;
            if (commentaryFromDb.SessionId != commentary.SessionId)
                commentaryFromDb.SessionId = commentary.SessionId;
            if (commentaryFromDb.Session != commentary.Session)
                commentaryFromDb.Session = commentary.Session;
            if (commentaryFromDb.Created != commentary.Created)
                commentaryFromDb.Created = commentary.Created;

            return await _dbContext.SaveChangesAsync() > 0;

        }
        public async Task<bool> Delete(int id)
        {
            var commentary = await GetById(id);

            if (commentary == null)
                return false;

            _dbContext.Commentaries.Remove(commentary);
            return await _dbContext.SaveChangesAsync() > 0;
        }

    }
}
