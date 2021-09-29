using EnesAtac.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnesAtac.Core.Repositeries
{
    public interface IMenuTypeRepository : IRepository<MenuType>
    {
        Task<MenuType> GetAllWithMenuTypeId(int id);
    }
}
