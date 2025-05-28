<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="DiziYorumProje.iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<div class="contact-content">
	 <div class="container">
		     <div class="contact-info">
			 <h2>İLETİŞİM</h2>
			 <p>Bizimle iletişime geçmekten çekinmeyin! Her türlü öneri, görüş veya işbirliği teklifiniz için size bir mesaj kadar yakınız. Sizin fikirlerinizi ve geri dönüşlerinizi duymaktan büyük mutluluk duyarız.</p>
		     </div>
			 <div class="contact-details">				 
			 <form runat="server">
				 <asp:TextBox ID="TextBox1" runat="server" placeholder="Ad Soyad" required=""></asp:TextBox>
				 <asp:TextBox ID="TextBox2" runat="server" placeholder="Mail" required=""></asp:TextBox>
				 <asp:TextBox ID="TextBox3" runat="server" placeholder="Telefon" required=""></asp:TextBox>
				 <asp:TextBox ID="TextBox4" runat="server" placeholder="Konu" required=""></asp:TextBox>
				 <asp:TextBox ID="TextBox5" runat="server" placeholder="Mesajınız" required="" TextMode="MultiLine"></asp:TextBox>
				 <asp:Button ID="Button1" runat="server" Text="Gönder" OnClick="Button1_Click" />
			 </form>
		  </div>
		  <div class="contact-details">
			  <div class="col-md-6 contact-map">
				 <h4>BİZ BURADAYIZ</h4>
				 <div style="max-width:100%;list-style:none; transition: none;overflow:hidden;width:500px;height:500px;"><div id="display-google-map" style="height:100%; width:100%;max-width:100%;"><iframe style="height:100%;width:100%;border:0;" frameborder="0" src="//////adres baglantısı////////"></iframe></div><a class="googlecoder" rel="nofollow" href="https://www.bootstrapskins.com/themes" id="enable-map-info">premium bootstrap themes</a><style>#display-google-map img.text-marker{max-width:none!important;background:none!important;}img{max-width:none}</style></div>
			  </div>
			  <div class="col-md-6 company_address">		 
					<h4>ADRES</h4>
					<p>TOKAT</p>
					<p>GAZİOSMANPAŞA ÜNİVERSİTESİ</p>
					<p>TR</p>
			 </div>
			  <div class="clearfix"></div>
	     </div>
	     </div>		 
			 </div>
</asp:Content>
