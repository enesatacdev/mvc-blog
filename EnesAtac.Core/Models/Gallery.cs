using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnesAtac.Core.Models
{
    public class Gallery
    {
        public Gallery()
        {
            GalleryImages = new Collection<GalleryImage>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<GalleryImage> GalleryImages{ get; set; }
    }
}
