using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnesAtac.Core.Models
{
    public interface User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Password { get; set; }
        public DateTime CreationDate { get; set; }
        public int IsActive { get; set; }
        public int UserType { get; set; }
    }
}
