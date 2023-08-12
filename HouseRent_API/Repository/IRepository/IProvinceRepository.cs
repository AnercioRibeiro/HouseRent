using HouseRent_API.Models;
using System.Linq.Expressions;

namespace HouseRent_API.Repository.IRepository
{
    public interface IProvinceRepository : IRepository<Province>
    {
        Task<Province> UpdateAsync(Province province);
    }
}
