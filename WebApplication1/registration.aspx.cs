using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=NIDHA\\SQLEXPRESS;Initial Catalog=register;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            for(int i=1;i<=31;i++)
            {
                day.Items.Add(i.ToString());
            }
            for(int j=1;j<=12;j++)
                {
                month.Items.Add(j.ToString());
            }
            for(int k=1995;k<=2000;k++)
            {
                year.Items.Add(k.ToString());
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string gend="";
            if (male.Checked== true)
            {
                gend = "male";
            }
            else
            {
               gend="female";
            }
            string date = day.Text + "/" + month.Text + "/" + year.Text;
            string query = "insert into reg_tabl values('" + Textname.Text + "','" + date + "','" + gend + "','" + Textage.Text + "','" + Textno.Text + "','" + Textpass
                .Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Textname.Text = "";
            Textno.Text = "";
            Textpass.Text = "";

        }
    }
}