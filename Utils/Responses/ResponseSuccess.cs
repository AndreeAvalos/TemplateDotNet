using System.Text.Json.Serialization;
using Utils.Responses.Base;

namespace Utils.Responses;
public class ResponseSuccess<TResponse> : BaseResponse
{
    [JsonPropertyName("data")] public TResponse Data { get; set; }

    public ResponseSuccess(int statusCode, string operationId, TResponse data) : base(statusCode, operationId)
    {
        Data = data;
    }
}