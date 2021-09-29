using EnesAtac.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnesAtac.Core.Services
{
    public interface IMenuTypeService : IService<MenuType>
    {
        Task<MenuType> GetAllWithMenuTypeId(int id);
    }
}
