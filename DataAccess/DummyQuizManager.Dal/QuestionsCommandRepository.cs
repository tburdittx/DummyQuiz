using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DummyQuizManager.Dal.Interface;
using Entities;

namespace DummyQuizManager.Dal
{
    public class QuestionsCommandRepository : CommandBaseRepository<Questions>, IQuestionsCommandRepository
    {
        public Task<long> Create(Questions entity)
        {
            throw new NotImplementedException();
        }

        public Task<long> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<long> Update(Questions entity)
        {
            throw new NotImplementedException();
        }
    }
}
