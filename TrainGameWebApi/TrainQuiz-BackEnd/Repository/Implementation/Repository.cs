using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TrainQuiz_BackEnd.Data.Context;
using TrainQuiz_BackEnd.Repository.Abstraction;

namespace TrainQuiz_BackEnd.Repository.Implementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly TrainsQuizContext _context;
        private DbSet<T> _table = null;

        public Repository(TrainsQuizContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public async Task Add(T entity)
        {
            await _table.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(T entity)
        {
            _table.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _table.Update(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<T> GetAll()
        {
            return _table.AsQueryable();
        }
    }
}
