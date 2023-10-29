﻿using Microsoft.EntityFrameworkCore;
using RemSlyApi.Datas;
using RemSlyCore.Models;
using System.Linq.Expressions;

namespace RemSlyApi.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private ApplicationDbContext _dbContext { get; }
        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // CRUD


        // Create

        public async Task<int> Add(User user)
        {
            var addedObj = await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return addedObj.Entity.Id;
        }

        // Read

        public async Task<User?> GetById(int id)
        {
            return await _dbContext.Users.FindAsync(id);
        }
        public async Task<User?> Get(Expression<Func<User, bool>> predicate)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(predicate);
        }
        public async Task<List<User>> GetAll()
        {
            return await _dbContext.Users.ToListAsync();
        }
        public async Task<List<User>> GetAll(Expression<Func<User, bool>> predicate)
        {
            return await _dbContext.Users.Where(predicate).ToListAsync();
        }

        // Update

        public async Task<bool> Update(User user)
        {
            var userFromDb = await GetById(user.Id);

            if (userFromDb == null)
                return false;

            if (userFromDb.FirstName != user.FirstName)
                userFromDb.FirstName = user.FirstName;
            if (userFromDb.LastName != user.LastName)
                userFromDb.LastName = user.LastName;
            if (userFromDb.Email != user.Email)
                userFromDb.Email = user.Email;
            if (userFromDb.PassWord != user.PassWord)
                userFromDb.PassWord = user.PassWord;

            return await _dbContext.SaveChangesAsync() > 0;
        }

        // Delete

        public async Task<bool> Delete(int id)
        {
            var user = await GetById(id);

            if (user == null)
                return false;

            _dbContext.Users.Remove(user);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}