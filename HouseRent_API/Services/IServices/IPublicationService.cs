using HouseRent_API.Models.Dto;

namespace HouseRent_API.Services.IServices
{
    public interface IPublicationService
    {
        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreateAsync<T>(PublicationCreateDto dto);
        Task<T> UpdateAsync<T>(PublicationUpdateDto dto);
        Task<T> DeleteAsync<T>(int id);

    }
}
