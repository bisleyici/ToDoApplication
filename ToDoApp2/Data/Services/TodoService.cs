using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ToDoApp2.Data.Domains;
using ToDoApp2.Data.Interfaces;

namespace ToDoApp2.Data.Services
{
    public class TodoService
    {
        IRepository<Todo> _repository;
        public TodoService(IRepository<Todo> repository)
        {
            _repository = repository;
        }
        public async Task Delete(Todo entityToDelete)
        {
            await _repository.Delete(entityToDelete);
        }

        public async Task Delete(object id)
        {
            await _repository.Delete(id);
        }

        public async Task<IEnumerable<Todo>> Get(Expression<Func<Todo, bool>> filter = null, Func<IQueryable<Todo>, IOrderedQueryable<Todo>> orderBy = null, string includeProperties = "")
        {
            return await _repository.Get(filter, orderBy, includeProperties);
        }

        public Task<Todo> GetByID(object id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(Todo entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(Todo entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
