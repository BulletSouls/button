//button1
 if (Session["user"] != null)
            {
                Response.Redirect("~/Pregled.aspx");
            }
			
//button2

 Session.Remove("user");
 Response.Redirect("~/Pocetna.aspx");