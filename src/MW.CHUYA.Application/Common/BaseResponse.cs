namespace MW.CHUYA.Application.UseCases.Common;

public class BaseResponse<T>
{
    public bool IsSuccess { get; set; }
    public T? Data { get; set; }
    public string? Message { get; set; }
    public IEnumerable<BaseError>? Errors { get; set; }

    public BaseResponse() { }
}