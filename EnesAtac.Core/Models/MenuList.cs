using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnesAtac.Core.Models
{
    public class MenuList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MenuId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int GalleryId { get; set; }
    }
}
