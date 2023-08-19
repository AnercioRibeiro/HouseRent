using HouseRent_API.Models;
using System.Linq.Expressions;

namespace HouseRent_API.Repository.IRepository
{
    public interface IPublicationRepository : IRepository<Publication>
    {
        Task<Publication> UpdateAsync(Publication publication);
        Task<IReadOnlyList<Publication>> GetPublicationsAsync();
        
    }
}
