using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRegistrasiKursus
{
    internal class Peserta
    {
        //property
        int id;
        string nama;
        string bahasaPemrograman;
        string hariKursus;
        List<string> skill = new List<string>();

        //Konstruktor
        public Peserta()
        {

        }
        public Peserta(int id,string nama,string bahasaPemrograman,
            string hariKursus,List<string> skill)
        {
            this.id = id;
            this.nama = nama;
            this.bahasaPemrograman = bahasaPemrograman;
            this.hariKursus = hariKursus;
            this.skill = skill;
        }


    }
}
