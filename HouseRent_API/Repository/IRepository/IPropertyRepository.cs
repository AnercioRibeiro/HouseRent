using HouseRent_API.Models;
using System.Linq.Expressions;

namespace HouseRent_API.Repository.IRepository
{
    public interface IPropertyRepository : IRepository<Property>
    {
        Task<Property> UpdateAsync(Property property);
        Task<IReadOnlyList<Property>> GetPropertiesAsync();
        Task<Property> Create(Property property);
    }
}
