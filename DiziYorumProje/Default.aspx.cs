﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class Default : System.Web.UI.Page
    {
        BlogDiziEntities2 db = new BlogDiziEntities2 ();
        protected void Page_Load(object sender, EventArgs e)
        {
            var bloglar = db.TBLBLOG.ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();

            var bloglar2 = db.TBLKATEGORI.ToList();
            Repeater2.DataSource = bloglar2;
            Repeater2.DataBind();

            var bloglar3 = db.TBLBLOG.Take(5).ToList();
            Repeater3.DataSource = bloglar3;
            Repeater3.DataBind();

            var bloglar4 = db.TBLYORUM.Take(3).ToList();
            Repeater4.DataSource = bloglar4;
            Repeater4.DataBind();
        }
    }
}