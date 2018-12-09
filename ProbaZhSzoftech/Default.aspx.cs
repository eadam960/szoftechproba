using ProbaZhSzoftech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using ProbaZhSzoftech;

namespace ProbaZhSzoftech {
    public partial class _Default : Page {
        protected void Page_Load(object sender, EventArgs e) {


        }

        public IQueryable<Targy> GetTargyak() {
            var db = new ProbaZhSzoftech.Models.TargyContext();
            IQueryable<Targy> query = db.Targyak;
            return query;
        }
    }
}