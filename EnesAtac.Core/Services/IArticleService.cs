using EnesAtac.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnesAtac.Core.Services
{
    public interface IArticleService : IService<Article>
    {
        Task<Article> GetCategoryIdByIdAsync(int id);
        Task<Article> GetCommentsById(int id);
    }
}
