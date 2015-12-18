using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Application.Implementation
{
    class Database : IDatabase
    {
        public long Add(object obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(object obj)
        {
            throw new NotImplementedException();
        }

        public object FindById(long id)
        {
            throw new NotImplementedException();
        }

        public object FindByUniqueProperty(string propertyName, object value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetAll(object _params)
        {
            throw new NotImplementedException();
        }
    }
}
