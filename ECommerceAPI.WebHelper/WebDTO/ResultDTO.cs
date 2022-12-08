using System.Collections.Generic;

namespace ECommerceAPI.WebHelper.WebDTO;

public class ResultDTO <T>
{
    public int Id { get; set; }
    public bool Success { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}
