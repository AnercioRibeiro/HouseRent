using HouseRent_API.Models;
using System.Linq.Expressions;

namespace HouseRent_API.Repository.IRepository
{
    public interface IPublicationRepository : IRepository<Property>
    {
        Task<Property> UpdateAsync(Property publication);
    }
}
