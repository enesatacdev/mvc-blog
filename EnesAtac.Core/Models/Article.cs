using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnesAtac.Core.Models
{
    public class Article
    {
        public Article()
        {
            Comments = new Collection<Comment>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<Comment> Comments{ get; set; }
    }
}
