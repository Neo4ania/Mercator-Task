using Microsoft.EntityFrameworkCore;
using ProvidusMerchantAPI.Data;
using ProvidusMerchantAPI.Domain.Entities;

namespace ProvidusMerchantAPI.Services.Repositories
{
    public class Repository : IRepository
    {
        private MerchantDBContext _ctx;
        public Repository(MerchantDBContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<int> AddAsync<T>(T entity) where T : class
        {
            await _ctx.Set<T>().AddAsync(entity);
            return await _ctx.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync<T>(T entity) where T : class
        {
            _ctx.Set<T>().Update(entity);
            return await (_ctx.SaveChangesAsync());
        }

        public async Task<int> DeleteAsync<T>(T entity) where T : class
        {
            _ctx.Set<T>().Remove(entity);
            return await (_ctx.SaveChangesAsync());
        }

        public async Task<IQueryable<T>> GetAsync<T>() where T : class
        {
            return await Task.Run(() => _ctx.Set<T>().AsQueryable());
        }

        public async Task<T?> GetAsync<T>(string Id) where T : class
        {
            return await _ctx.Set<T>().FindAsync(Id);
        }
    }
}

