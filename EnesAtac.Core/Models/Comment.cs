using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnesAtac.Core.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Mail { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime TimeToComment { get; set; }
        public int ArticleId { get; set; }
        public virtual Article Article{ get; set; }
    }
}
