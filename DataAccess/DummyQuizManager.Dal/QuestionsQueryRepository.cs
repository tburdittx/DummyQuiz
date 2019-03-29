using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DummyQuizManager.Dal.Interface;
using Entities;
using Microsoft.Extensions.Configuration;

namespace DummyQuizManager.Dal
{
    public class QuestionsQueryRepository : QueryRepositoryBase, IQuestionsQueryRepository
    {

        private const string uspQuestionsReadAll = "[dbo].[uspQuestionsReadAll]";
        private const string uspQuestionsRead = "[dbo].[uspQuestionsRead]";

    

        public QuestionsQueryRepository(Lazy<IConfiguration> configuration) : base(configuration)
        {
        }

        public Task<Questions> Read(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Questions>> ReadAllAsync()
        {  
                IEnumerable<Questions> result;

                using (var connection = new SqlConnection(DbConnectionString))
                {
                    await connection.OpenAsync();

                    result = await connection.QueryAsync<Questions>(uspQuestionsReadAll);
                }
                return result;            
        }
        
    }
}
