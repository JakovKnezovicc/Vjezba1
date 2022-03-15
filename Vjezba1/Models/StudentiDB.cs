using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vjezba1.Models
{

    public class StudentiDB
    {
        private List<Student> Lista = new List<Student>();
        public StudentiDB()
        {
            Lista.Add(new Student()
            {
                ID = 1,
                ime = "Ivan",
                prezime = "Matok",
                spol="m",
                oib=78392,
                DatumRodenja=new DateTime(1999,03,02),
                GodinaStudija=2,
                RedovanStudent=true

            }) ; 

        }

        public List<Student> VratiListu()
        {
            return Lista;
        }
    }
}