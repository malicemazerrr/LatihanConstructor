using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanConstructor
{
    internal class Mahasiswa
    {
        public Mahasiswa()
        {

        }

        public Mahasiswa(string nim, string nama)
        {
            Nim = nim;
            Nama = nama;
        }
          public Mahasiswa(string nim, string nama, double ipk)
        {
            Nim = nim;
            Nama = nama;
            Ipk= ipk;
          }
        public string Nim { get; set; }
        public string Nama { get; set;}
    }
}
