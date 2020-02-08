namespace Booking.API.Domain.Services.Communication
{
    public abstract class BaseResponse<T>
    {
        public bool Success { get; private set; }
        public string Message { get; private set; }
        public T Resource { get; set; }

        protected BaseResponse(T resource)
        {
            Success = true;
            Message = "success";
            Resource = resource;
        }
        
        protected BaseResponse(string message)
        {
            Success = false;
            Message = message;
            Resource = default;
        }
    }
}