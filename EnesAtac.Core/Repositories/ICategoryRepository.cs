using EnesAtac.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnesAtac.Core.Repositeries
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> GetWithArticlesByIdAsync(int id);
    }
}
