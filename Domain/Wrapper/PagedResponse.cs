using System.Net;

namespace Domain.Wrapper;

public class PagedResponse<T> : Response<T>
{
    //public T Data { get; }
    public int TotalRecords { get; set; }
    public int PageSize { get; set; }
    public int PageNumber { get; set; }
    public int TotalPages { get; set; }

    public PagedResponse(T data, int totalRecords, int pageSize, int pageNumber) : base(data)
    {
        TotalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);
        TotalRecords = totalRecords;
        PageSize = pageSize;
        PageNumber = pageNumber;
    }

    public PagedResponse(HttpStatusCode statusCode, List<string> errors) : base(statusCode, errors)
    {
    }

    public PagedResponse(HttpStatusCode statusCode, string errors) : base(statusCode, errors)
    {
    }
}