using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnesAtac.Core.Models
{
    public interface Log
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string LogDetails { get; set; }
        public DateTime Time { get; set; }
    }
}
