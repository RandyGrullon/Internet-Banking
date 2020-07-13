﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilidades;

namespace InternetBanking
{
    public partial class ConsultarCuentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cuentas.ListarCuentas() != null)
            {
                GV1.DataSource = Cuentas.ListarCuentas();
                GV1.DataBind();
            }
            DL.DataSource = Cuentas.ListarCuentas();
            DL.DataBind();

        }          
    }

}