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
    public partial class dropbindview : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=NIDHA\\SQLEXPRESS;Initial Catalog=register;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string query = "select s_id, name ,salary from emp_tabl right join reg_tabl  on reg_tabl.id=emp_tabl.id ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }

        }
    }
}