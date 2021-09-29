using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnesAtac.Core.Models
{
    public interface GalleryImage
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int GalleryId { get; set; }
    }
}
