using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnesAtac.Core.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string MenuName { get; set; }
        public int MenuList { get; set; }
        public bool IsActive { get; set; }
        public string MetaName { get; set; }
        public string MetaTags { get; set; }
        public int MenuTypeId { get; set; }

    }
}
