namespace WebApi.Dtos
{
    public sealed class ApiResponse<T>
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public string? ErrorCode { get; set; }
        public T Data { get; set; }

        private ApiResponse(T data, string? message = null)
        {
            Success = true;
            Message = message ?? "Operación exitosa.";
            Data = data;
        }

        public static ApiResponse<T> RespuestaExitosa(T data, string? message = null)
        {
            return new ApiResponse<T>(data, message);
        }
    }
}
