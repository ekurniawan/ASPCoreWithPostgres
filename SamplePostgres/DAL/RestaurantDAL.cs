using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SamplePostgres.Models;
using Npgsql;
using Dapper;

namespace SamplePostgres.DAL
{
    public class RestaurantDAL : IRestaurant
    {
        private IConfiguration _config;
        public RestaurantDAL(IConfiguration config)
        {
            _config = config;
        }

        private string GetConnStr()
        {
            return _config.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Restaurant>> GetAll()
        {
            using(var conn = new NpgsqlConnection(GetConnStr()))
            {
                var strSql = "select * from \"Restaurants\"";
                return await conn.QueryAsync<Restaurant>(strSql);
            }
        }
    }
}
