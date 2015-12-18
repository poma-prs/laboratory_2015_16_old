using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    interface IDatabase
    {
        long Add(object obj);
        void Delete(object obj);
        object FindById(long id);
        object FindByUniqueProperty(string propertyName, object value);
        IEnumerable<object> GetAll(object _params);
    }
}
