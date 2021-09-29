using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnesAtac.Core.Models
{
    public class Category
    {
        public Category()
        {
            Articles = new Collection<Article>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Article> Articles{ get; set; }

    }
}
