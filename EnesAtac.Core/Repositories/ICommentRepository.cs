using EnesAtac.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnesAtac.Core.Repositeries
{
    public interface ICommentRepository : IRepository<Comment>
    {
        Task<Comment> GetArticleIdWithId(int id);

    }
}
