using QPLate_Water.OracleIntegrationAPI.BL.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPLate_Water.OracleIntegrationAPI.BL.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<Response<List<T>>> GetAll();
        Task<Response<T>> GetById(int id);
        Task<Response<T>> Create(T entity);
        Task<Response<T>> Update(T entity);
        Task<Response<T>> Delete(int id);
    }
}
