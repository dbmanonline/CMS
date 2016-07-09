using CMS.Domains;
using CMS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private IRepository<Category> _categoryRepository;
        private IRepository<Post> _postRepository;

        private readonly CMSContext _cmsContext;

        public UnitOfWork(CMSContext cmsContext)
        {
            _cmsContext = cmsContext;
        }

        public IRepository<Category> CategoryRepository
        {
            get
            {
                if (_categoryRepository == null)
                    _categoryRepository = new GenericRepository<Category>(_cmsContext);
                return _categoryRepository;
            }
        }

        public IRepository<Post> PostRepository
        {
            get
            {
                if (_postRepository == null)
                    _postRepository = new GenericRepository<Post>(_cmsContext);
                return _postRepository;
            }
        }

        public void Commit()
        {
            _cmsContext.SaveChanges();
        }

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _cmsContext.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
