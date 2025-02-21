using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class SubAbouth
    {
        [Key]
        public int SubAbouthId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
