using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Model.Entry;
using Hotel.Model.Context;

namespace Hotel.Model.Entry
{
    public class Tamu
    {
        public string Nama { get; set; }
        public string KTP { get; set; }
        public string Alamat { get; set; }
        public string No_Hp { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
    }
}
