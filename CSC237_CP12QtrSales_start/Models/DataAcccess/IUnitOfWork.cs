
namespace CSC237_CP12QtrSales_start.Models
{
    public interface IUnitOfWork
    {
        Repository<Employee> Employees { get; }
        Repository<Sales> Sales { get; }

        void Save();
    }
}
