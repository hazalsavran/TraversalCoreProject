using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Abouth2
    {
        [Key]
        public int Abouth2Id { get; set; }
        public string Title1 { get; set; }

        public string Title2 { get; set; }

        public string Description { get; set; }
        public string Image { get; set; }
    }
}
