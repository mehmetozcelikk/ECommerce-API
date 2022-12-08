using ECommerceAPI.WebHelper.WebDTO;
using RestSharp;

namespace ECommerceAPI.WebHelper;

public interface IApiHelper
{
    ResultDTO<List<T>> GetObjectResponseFromApi<T>(Method _method, string _url, object _body = null, string _token = "", bool _stringify = false) where T : new();
}
