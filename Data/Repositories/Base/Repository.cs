using Core.Entities.Base;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
namespace Data.Repositories.Base;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private readonly AppDbContext _context;
    private readonly DbSet<T> _dbTable;
    public Repository(AppDbContext context)
    {
        _context = context;
        _dbTable = _context.Set<T>();
    }

    public virtual List<T> GetAll()
    {
        return _dbTable.ToList();

    }
    public T Get(DateTime date)
    {
        return _dbTable.Find(date);
    }
    public T Get(int id)
    {
        return _dbTable.Find(id);
    }

    public void Add(T item)
    {
        _dbTable.Add(item);
    }
    public void Delete(T item)
    {
        _dbTable.Remove(item);
    }
}