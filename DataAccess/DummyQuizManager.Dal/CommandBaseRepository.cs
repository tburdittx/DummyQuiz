using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DummyQuizManager.Dal.Interface;

namespace DummyQuizManager.Dal
{
  public  abstract class CommandBaseRepository<T> 
    
    {
        public Task<long> Create(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<long> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<long> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
