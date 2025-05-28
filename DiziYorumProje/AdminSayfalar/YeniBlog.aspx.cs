using DiziYorumProje.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class YeniBlog : System.Web.UI.Page
    {
        BlogDiziEntities2 db = new BlogDiziEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var turler = (from x in db.TBLTUR
                              select new
                              {
                                  x.TURAD,
                                  x.TURID
                              }).ToList();
                DropDownList1.DataSource = turler;
                DropDownList1.DataBind();

                var kategoriler = (from x in db.TBLKATEGORI
                                   select new
                                   {
                                       x.KATEGORIAD,
                                       x.KATEGORIID
                                   }).ToList();
                DropDownList2.DataSource = kategoriler;
                DropDownList2.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //TBLBLOG t = new TBLBLOG();
            //t.BLOGBASLIK = TextBox1.Text;
            //t.BLOGGORSEL = TextBox3.Text;
            //t.BLOGICERIK = TextBox4.Text;
            //t.BLOGTARIH = DateTime.Parse(TextBox2.Text);
            //t.BLOGTUR = byte.Parse(DropDownList1.SelectedValue);
            //t.BLOGKATEGORI = byte.Parse(DropDownList2.SelectedValue);
            //db.TBLBLOG.Add(t);
            //db.SaveChanges();
            //Response.Redirect("Bloglar.Aspx");
            if (string.IsNullOrWhiteSpace(TextBox1.Text) || string.IsNullOrWhiteSpace(TextBox4.Text))
            {
                Response.Write("Başlık ve içerik boş olamaz.");
                return;
            }

            // Tarih kontrolü
            DateTime tarih;
            if (!DateTime.TryParse(TextBox2.Text, out tarih))
            {
                Response.Write("Geçerli bir tarih girin.");
                return;
            }

            // DropDown boş mu kontrolü
            if (string.IsNullOrEmpty(DropDownList1.SelectedValue) || string.IsNullOrEmpty(DropDownList2.SelectedValue))
            {
                Response.Write("Lütfen tür ve kategori seçin.");
                return;
            }

            // Veriyi doldur
            TBLBLOG t = new TBLBLOG();
            t.BLOGBASLIK = TextBox1.Text;
            t.BLOGGORSEL = TextBox3.Text;
            t.BLOGICERIK = TextBox4.Text;
            t.BLOGTARIH = tarih;
            t.BLOGTUR = byte.Parse(DropDownList1.SelectedValue);
            t.BLOGKATEGORI = byte.Parse(DropDownList2.SelectedValue);

            try
            {
                db.TBLBLOG.Add(t);
                db.SaveChanges();
                Response.Redirect("Bloglar.Aspx");
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Response.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage + "<br/>");
                    }
                }
            }
        }
    }
}