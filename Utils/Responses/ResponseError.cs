using System.Text.Json.Serialization;
using Utils.Responses.Base;

namespace Utils.Responses;

public class ResponseError : BaseResponse
{
    [JsonPropertyName("errors")] public List<string> Errors { get; set; } = null!;

    public ResponseError(int statusCode, string operationId, List<string> errors)
        : base(statusCode, operationId)
    {
        Errors = errors;
    }

    [JsonConstructor]
    public ResponseError()
    {
    }
}