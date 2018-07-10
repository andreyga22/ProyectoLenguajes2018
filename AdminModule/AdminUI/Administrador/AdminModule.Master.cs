using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminBL;

namespace AdminUI {
    public partial class AdminModule : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {
            revisaUI();
        }


        private void revisaUI() {
            BLCliente ses = (BLCliente)Session["usuarioLO"];
            if (ses == null) {
                btnCerrar.Visible = false;
            } else {
                btnCerrar.Visible = true;
            }
        }
    }
}