using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DummyQuizManager.Dal.Interface;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace DummyQuizManager.Dal
{
    public class QueryRepositoryBase
    {
        private readonly Lazy<IConfiguration> configuration;

        private const string DbName = "DummyQuizManager";

        public QueryRepositoryBase(Lazy<IConfiguration> configuration)
        {
            this.configuration = configuration;
        }

        public IConfiguration Configuration => this.configuration.Value;

        public string DbConnectionString => this.Configuration.GetConnectionString(DbName);

    }
}
