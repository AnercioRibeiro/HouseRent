using AutoMapper;
using HouseRent_API.Models.APIResponse;

namespace HouseRent_API.Services.IServices
{
    public interface IBaseService
    {
        APIResponse responseModel { get; set; }
        Task<T> SendAsync<T>(APIRequest apiRequest);

    }
}
