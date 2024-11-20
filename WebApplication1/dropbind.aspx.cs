using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class dropview : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=NIDHA\\SQLEXPRESS;Initial Catalog=register;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                front();
            }
            

        }
        public void front()
        {

            string query = "select * from reg_tabl";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string query1 = "insert into emp_tabl values('" + DropDownList1.SelectedValue + "','" + TextBox1.Text + "')";
            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}