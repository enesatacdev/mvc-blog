using EnesAtac.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnesAtac.Core.Services
{
    public interface IGalleryService : IService<Gallery>
    {
        Task<Gallery> GetAllImagesById(int id);
    }
}
