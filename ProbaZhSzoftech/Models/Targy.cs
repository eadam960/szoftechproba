using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ProbaZhSzoftech.Models {
    public class Targy {

        [Key]
        public int Id { get; set; }
        [MaxLength(40)]
        public string Nev { get; set; }
        public int KikialtasiAr { get; set; }
        [MaxLength(40)]
        public string KepNev { get; set; }
        public int EladasiAr { get; set; }
        public bool Licitalt { get; set; }

        

    }
}