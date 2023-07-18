using Casgem.DataAccessLayer.Abstract;
using Casgem.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;
        public GenericRepository(Context context)
        {
            _context = context;
        }
        public void Delete(T t)
        {
            //_context.
        }

        public T GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(T t)
        {
            throw new NotImplementedException();
        }

        public void Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
