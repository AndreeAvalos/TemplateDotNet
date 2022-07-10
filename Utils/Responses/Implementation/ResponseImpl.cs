using Microsoft.AspNetCore.Http;
using Utils.Responses.Interface;
using Utils.Types;

namespace Utils.Responses.Implementation;

public class ResponseImpl : IResponse
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ResponseImpl(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public ResponseError GetResponseError(HttpTypes httpEnum, List<string> errors)
    {
        string operationId = _httpContextAccessor.HttpContext.Request.Headers["operationId"];
        return new ResponseError((int)httpEnum, operationId, errors);
    }

    public ResponseSuccess<TResponse> GetResponseSuccess<TResponse>(HttpTypes httpEnum, TResponse data)
    {
        string operationId = _httpContextAccessor.HttpContext.Request.Headers["operationId"];
        return new ResponseSuccess<TResponse>((int)httpEnum, operationId, data);
    }
}