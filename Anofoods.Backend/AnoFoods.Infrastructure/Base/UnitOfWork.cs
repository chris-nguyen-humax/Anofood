using Anofoods.Core.Helpers;
using Anofoods.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;

namespace Anofoods.Infrastructure.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AnoFoodEntities _context;
        private readonly Dictionary<Type, object> _repository;
        private bool _disposed;
        public UnitOfWork(AnoFoodEntities entities)
        {
            _context = entities;
            _context.Configuration.ProxyCreationEnabled = false;
            _repository = new Dictionary<Type, object>();
            _disposed = false;
        }
        public DbContextTransaction BeginTransaction()
        {
            return _context.Database.BeginTransaction();
        }
        public bool Complete()
        {
            try
            {
                return _context.SaveChanges() > 0;
            }
            catch (DbEntityValidationException e)
            {
                LoggerHelper.Logger.Error(e);
                var newException = new FormattedDbEntityValidationException(_context, e);
                throw new Exception(newException.Message);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                LoggerHelper.Logger.Error(ex);
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                LoggerHelper.Logger.Error(ex);
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> CompleteAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposed = true;
            }
        }

        public IBaseRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            //Check if the Dictionary key contains the Model class
            if (_repository.Keys.Contains(typeof(TEntity)))
            {
                return _repository[typeof(TEntity)] as IBaseRepository<TEntity>;
            }
            // If the repository for that Model class doesn't exist, create it
            var repository = new BaseRepository<TEntity>(_context);

            _repository.Add(typeof(TEntity), repository);
            return repository;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
