using HouseRent.Utility;
using HouseRent_API.Models.APIResponse;
using HouseRent_API.Models.Dto;
using HouseRent_API.Services.IServices;
using static HouseRent_API.Services.PublicationService;

namespace HouseRent_API.Services
{
        public class PublicationService : BaseService, IPublicationService
        {
            private readonly IHttpClientFactory _clientFactory;
            private string villaUrl;

            public PublicationService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
            {
                _clientFactory = clientFactory;
                villaUrl = configuration.GetValue<string>("ServiceUrls:Savi");

            }

            public Task<T> CreateAsync<T>(PublicationCreateDto dto)
            {
                return SendAsync<T>(new APIRequest()
                {
                    ApiType = SD.ApiType.POST,
                    Data = dto,
                    Url = villaUrl + "/api/PublicationAPI"
                });
            }

            public Task<T> DeleteAsync<T>(int id)
            {
                return SendAsync<T>(new APIRequest()
                {
                    ApiType = SD.ApiType.DELETE,
                    Url = villaUrl + "/api/PublicationAPI/" + id
                });
            }

            public Task<T> GetAllAsync<T>()
            {
                return SendAsync<T>(new APIRequest()
                {
                    ApiType = SD.ApiType.GET,
                    Url = villaUrl + "/api/PublicationAPI"
                });
            }

            public Task<T> GetAsync<T>(int id)
            {
                return SendAsync<T>(new APIRequest()
                {
                    ApiType = SD.ApiType.GET,
                    Url = villaUrl + "/api/PublicationAPI/" + id
                });
            }

        public Task<T> UpdateAsync<T>(PublicationUpdateDto dto)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = dto,
                Url = villaUrl + "/api/PublicationAPI/"
            });
        }

        }
        }
    

