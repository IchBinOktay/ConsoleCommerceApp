using Core.Entities.Base;
namespace Core.Entities;
public class Category : BaseEntity
{
    public string CategoryName { get;  set; }
    public int CategoryId { get;  set; }
    public DateTime CreatedAt { get; set; }
}