using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository.Base
{
    public interface IRepository <T> where T:class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(Predicate<T> predicate);
        Task<T> FindByIdAsync(Guid Id);
        Task<Guid> CreateAsync(T entity);
        Task<Guid> UpdateAsync(T entity);
        Task<Guid> DeleteAsync(T entity);
    }
}
