using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Web;

namespace ProbaZhSzoftech.Models {

    public class DbFeltolt : DropCreateDatabaseIfModelChanges<TargyContext> {

        protected override void Seed(TargyContext context) {

            foreach (var item in Beolvas()) {
                context.Targyak.Add(item);

            }
        }



        private static List<Targy> Beolvas() {
            StreamReader reader = File.OpenText(HttpContext.Current.Server.MapPath("~/App_Data/licitTargyak.txt"));
            var targyak = new List<Targy>();
            string[] sor;
            Targy targy;
            int id = 1;
            while (!reader.EndOfStream) {
                sor = reader.ReadLine().Split(';');
                targy = new Targy() {
                    Id = id++,
                    Nev = sor[0],
                    KikialtasiAr = int.Parse(sor[1]),
                    KepNev = sor[2],
                    EladasiAr = int.Parse(sor[1]),
                    Licitalt = false
                };
                targyak.Add(targy);
            }

            reader.Close();
            return targyak;
        }


    }
}