namespace CinemaManagerApi.Models
{
  public class Response<T>
  {
    public bool isSuccess { get; set; }
    public int status { get; set; }
    public string errorMessage { get; set; }
    public T data { get; set; }

    public Response() { }

    public Response(bool isSuccess, int status, string errorMessage, T data)
    {
      this.isSuccess = isSuccess;
      this.status = status;
      this.errorMessage = errorMessage;
      this.data = data;
    }
  }
}