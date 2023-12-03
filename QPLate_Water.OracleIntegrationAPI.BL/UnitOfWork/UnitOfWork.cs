using QPLate_Water.OracleIntegrationAPI.BL.GenericRepository;
using QPLate_Water.OracleIntegrationAPI.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPLate_Water.OracleIntegrationAPI.BL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _context;
        
        private Dictionary<Type, object> _repositories;
        public UnitOfWork(ApplicationDBContext context)
        {
            _context = context;
            _repositories = new Dictionary<Type, object>();
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            // Rollback changes if needed
        }
        public IGenericRepository<T> GetRepository<T>() where T : class
        {
            if (_repositories.ContainsKey(typeof(T)))
            {
                return (IGenericRepository<T>)_repositories[typeof(T)];
            }

            var repository = new GenericRepository<T>(_context);
            _repositories.Add(typeof(T), repository);
            return repository;
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
