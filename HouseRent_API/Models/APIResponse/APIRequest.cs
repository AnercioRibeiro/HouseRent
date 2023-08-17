using static HouseRent.Utility.SD;

namespace HouseRent_API.Models.APIResponse
{
    public class APIRequest
    {
            public ApiType ApiType { get; set; } = ApiType.GET;
            public string Url { get; set; }
            public object Data { get; set; }

    }
}
