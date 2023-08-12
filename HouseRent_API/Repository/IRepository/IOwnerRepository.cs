using HouseRent_API.Models;
using System.Linq.Expressions;

namespace HouseRent_API.Repository.IRepository
{
    public interface IOwnerRepository : IRepository<Owner>
    {
        Task<Owner> UpdateAsync(Owner owner);
    }
}
