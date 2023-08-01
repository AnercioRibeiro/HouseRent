using HouseRent_API.Models;
using System.Linq.Expressions;

namespace HouseRent_API.Repository.IRepository
{
    public interface IPublicationRepository
    {
        Task CreateAsync(Publication entity);
        Task RemoveAsync(Publication entity);
        Task SaveAsync();
        Task<List<Publication>> GetAllAsync(Expression<Func<Publication, bool>> filter = null);
        Task<Publication> GetAsync(Expression<Func<Publication, bool>> filter = null, bool tracked=true);
        Task UpdateAsync(Publication publication);
    }
}
