﻿using HouseRent_API.Data;
using HouseRent_API.Models;
using HouseRent_API.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HouseRent_API.Repository
{
    public class PropertyRepository : Repository<Property>, IPropertyRepository
    {
        private readonly ApplicationDbContext _db;
        public PropertyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        //public async Task CreateAsync(Publication entity)
        //{
        //   await  _db.Publications.AddAsync(entity);
        //   await SaveAsync();

        //}

        //public async Task<Publication> GetAsync(Expression<Func<Publication, bool>> filter = null, bool tracked = true)
        //{
        //    IQueryable<Publication> query = _db.Publications;
        //    if (!tracked)
        //    {
        //        query = query.AsNoTracking();
        //    }
        //    if (filter != null)
        //    {
        //        query = query.Where(filter);
        //    }
        //    return await query.FirstOrDefaultAsync();
        //}

        //public async Task<List<Publication>> GetAllAsync(Expression<Func<Publication, bool>> filter = null)
        //{
        //    IQueryable <Publication> query = _db.Publications;

        //    if (filter !=null)
        //    {
        //        query = query.Where(filter);
        //    }
        //    return await query.ToListAsync();
        //}

        //public async Task RemoveAsync(Publication entity)
        //{
        //     _db.Publications.Remove(entity);
        //    await SaveAsync();
        //}

        //public async Task SaveAsync()
        //{
        //    await _db.SaveChangesAsync();
        //}

        public async Task<Property> Create(Property property)
        {
            await _db.AddAsync(property);
            await _db.SaveChangesAsync();

            return property;
        }

        public async Task<Property> UpdateAsync(Property property)
        {
            
             _db.Properties.Update(property);
            await _db.SaveChangesAsync();
            return property;
        }

        public async Task<IReadOnlyList<Property>> GetPropertiesAsync()
        {
            return await _db.Properties
            .Include(p => p.Province)
            .Include(p => p.Owner)
            .ToListAsync();
        }
    }
}
