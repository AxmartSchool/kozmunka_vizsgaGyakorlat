using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kozmunka
{
    public class MunkaModel
    {
        public int Id { get; set; }
        public int TanuloId { get; set; }
        public string Szervezet { get; set; }
        public string Megjegyzes { get; set; }
        public DateTime Mikor { get; set; }
        public int Oraszam { get; set; }

    }
}
