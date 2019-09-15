using System.Linq;
using System.Threading.Tasks;

namespace TrainQuiz_BackEnd.Repository.Abstraction
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        Task Add(T entity);
        Task Update(T entity);
        Task Remove(T entity);
    }
}
