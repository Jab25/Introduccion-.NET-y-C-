﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HolaWebApplication
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            lblid.Text = id;
            string Nombre = Request.QueryString["nom"];
            lblNombre.Text = Nombre;
            string Clave = Request.QueryString["Clave"];
            lblClave.Text = Clave;
        }
    }
}