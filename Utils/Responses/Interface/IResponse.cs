using Utils.Types;

namespace Utils.Responses.Interface;

public interface IResponse
{
    ResponseError GetResponseError(HttpTypes httpEnum, List<string> errors);
    ResponseSuccess<TResponse> GetResponseSuccess<TResponse>(HttpTypes httpEnum, TResponse data);
}