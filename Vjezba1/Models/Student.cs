using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vjezba1.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string spol { get; set; }
        public int oib { get; set; }
        public DateTime DatumRodenja { get; set; }
        public int GodinaStudija { get; set; }
        public bool RedovanStudent { get; set; }

    }
}