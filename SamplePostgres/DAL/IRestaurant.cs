using SamplePostgres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamplePostgres.DAL
{
    public interface IRestaurant 
    {
        Task<IEnumerable<Restaurant>> GetAll();
    }
}
