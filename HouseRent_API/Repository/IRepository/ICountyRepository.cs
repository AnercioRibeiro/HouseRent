using HouseRent_API.Models;
using System.Linq.Expressions;

namespace HouseRent_API.Repository.IRepository
{
    public interface ICountyRepository : IRepository<County>
    {
        Task<County> UpdateAsync(County county);
    }
}
