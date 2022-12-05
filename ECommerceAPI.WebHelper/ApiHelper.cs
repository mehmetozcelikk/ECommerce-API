using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System.Diagnostics;
using System.Net;
using System.Text.Json;

namespace ECommerceAPI.WebHelper;

public class ApiHelper : IApiHelper
{
    readonly RestClient _client;
    private readonly IHttpContextAccessor _accessor;

    public ApiHelper(RestClient client, IConfiguration config, IHttpContextAccessor accessor)
    {
        _accessor = accessor;
        var sadsadsa = new Uri(config.GetValue<string>("ApiSettings:Host"));
        var url = "";
        var options = new RestClientOptions(url);
        _client = new RestClient(options);
    }

    public T GetObjectResponseFromApi<T>(Method _method, string _url, object _body = null, string _token = "", bool _stringify = false) where T : new()
    {
        try
        {
            var client = new RestClient();
            //client.BaseUrl = "https://api.mailgun.net/v3";
            var request = new RestRequest(_url, _method);

            if (!string.IsNullOrEmpty(_token))
            {
                request.AddHeader("Authorization", "Bearer " + _token);
            }
            request.OnBeforeDeserialization = resp => { resp.ContentType = ",/json"; };
            request.AddHeader("Accept-Language", "en-us");
            request.AddHeader("Content-Type", "application/json");

            //request.UseDefaultCredentials = true;

            request.AddParameter("application\\json", JsonSerializer.Serialize(_body), ParameterType.RequestBody);

            request.AddJsonBody(_body);
            RestResponse response = _client.Execute(request);

            if ((int)response.StatusCode < 200 || (int)response.StatusCode >= 300)
            {
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    _accessor.HttpContext.Response.Redirect("/Security/Logoff");
                }
                return new T
                {
                    //Success = false,
                    //Message = response.ErrorMessage
                };
            }

            var resultData = default(T);

            //resultData = JsonSerializer.Deserialize<T>(response.Content, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            if (_stringify)
            {
                //if (typeof(BaseDTO).IsAssignableFrom(typeof(T)))
                //{
                //    BaseDTO baseDTO = resultData.Data as BaseDTO;
                //}
            }
            return resultData;

        }
        catch (Exception ex)
        {
            var st = new StackTrace(ex, true);
            var frame = st.GetFrame(0);
        }
        return default(T);
    }
}
