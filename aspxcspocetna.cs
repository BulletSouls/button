using System.Data.SqlClient;
using System.Configuration;

//pageload
 if (Session["user"] != null)
            {
                Response.Redirect("~/Pregled.aspx");
            }
			
//login
       SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
            con.Open();
            string query = "select count(*) from Korisnici where username='" + txtuser.Text + "'and password='" + txtpass.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            string output = cmd.ExecuteScalar().ToString();
            if (output == "1")
            {
                Session["user"] = txtuser.Text;
                Response.Redirect("~/Pregled.aspx");
            }
            else
                lblPoruka.Text = "Pogresan username ili pass,/npokusajte ponovo";