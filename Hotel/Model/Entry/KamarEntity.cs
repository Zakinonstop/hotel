using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model.Entry
{
    public class KamarEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string No_Kamar { get; set; }
        public string Status { get; set; }
        public string Harga { get; set; }

    }
}
