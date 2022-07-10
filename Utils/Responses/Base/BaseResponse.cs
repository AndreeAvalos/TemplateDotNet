using System.Text.Json.Serialization;

namespace Utils.Responses.Base;

public class BaseResponse
{
    [JsonPropertyName("operationId")] public string OperationId { get; set; } = null!;

    [JsonPropertyName("transactionId")] public string TransactionId { get; set; } = null!;
    [JsonPropertyName("statusCode")] public int StatusCode { get; set; }

    [JsonPropertyName("transactionName")] public string TransactionName { get; set; } = null!;

    protected BaseResponse(int statusCode, string operationId)
    {
        OperationId = operationId;
        TransactionId = Guid.NewGuid().ToString();
        StatusCode = statusCode;
        TransactionName = "Method:  - Path:  ";
    }

    [JsonConstructor]
    protected BaseResponse()
    {
    }
}