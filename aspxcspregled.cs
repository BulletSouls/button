using System.Data;
using System.Data.SqlClient;

//pageload
			DataSet MyDataSet = new DataSet();
            MyDataSet.ReadXml(Server.MapPath("~/biblioteka.xml"));
            System.Data.DataView dv = new System.Data.DataView(MyDataSet.Tables[0]);
            dv.Sort = "citano DESC";
            GridView1.DataSource = dv;
            GridView1.DataBind();
			
//button1
if (Session["user"] != null)
            {
                Response.Redirect("~/Autor.aspx");
            }

//button2


            Session.Remove("user");
            Response.Redirect("~/Pocetna.aspx");
