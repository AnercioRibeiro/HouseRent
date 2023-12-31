﻿using HouseRent_API.Data;
using HouseRent_API.Models;
using HouseRent_API.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HouseRent_API.Repository
{
    public class PublicationRepository : Repository<Publication>, IPublicationRepository
    {
        private readonly ApplicationDbContext _db;
        public PublicationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IReadOnlyList<Publication>> GetPublicationsAsync()
        {
            return await _db.Publications
            .Include(p => p.Property)
            .ToListAsync();
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



        public async Task<Publication> UpdateAsync(Publication publication)
        {

            _db.Publications.Update(publication);
            await _db.SaveChangesAsync();
            return publication;
        }
    }
}
