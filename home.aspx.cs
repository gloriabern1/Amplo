﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
        {
          Response.Redirect("~/default.aspx");  
        }
    }
}