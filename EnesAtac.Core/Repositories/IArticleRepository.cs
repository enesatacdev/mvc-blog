using EnesAtac.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnesAtac.Core.Repositeries
{
    public interface IArticleRepository : IRepository<Article>
    {
        Task<Article> GetCategoryIdByIdAsync(int id);
        Task<Article> GetCommentsById(int id);
    }
}
