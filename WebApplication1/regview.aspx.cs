using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class regview : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=NIDHA\\SQLEXPRESS;Initial Catalog=register;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                grid();
            }

        }
        public void grid()
        {
            
                for (int i = 1; i <= 31; i++)
                {
                    day.Items.Add(i.ToString());
                }
                for (int j = 1; j <= 12; j++)
                {
                    month.Items.Add(j.ToString());
                }
                for (int k = 1995; k <= 2000; k++)
                {
                    year.Items.Add(k.ToString());
                }
                string query = "select * from reg_tabl";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();

            
        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            string gen = "";
            int r_id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            string query = "select * from reg_tabl where id='" +r_id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count>0)
            {
                TextID.Text = dt.Rows[0][0].ToString();
                TextNAME.Text = dt.Rows[0][1].ToString();

                string StringToSplit = dt.Rows[0][2].ToString();
                string[] arrayOfString = StringToSplit.Split('/');
                day.Text = arrayOfString[0];
                month.Text = arrayOfString[1];
                year.Text = arrayOfString[2];
                 gen = dt.Rows[0][3].ToString();
                if (gen =="male")
                {
                    male.Checked=true;
                }
                else
                {
                   female.Checked=true;
                }
                TextAGE.Text = dt.Rows[0][4].ToString();
                TextMOBILE.Text = dt.Rows[0][5].ToString();
                TextPASS.Text = dt.Rows[0][6].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string gend = "";
            if (male.Checked == true)
            {
                gend = "male";
            }
            else
            {
                gend = "female";
            }
            string date = day.Text + "/" + month.Text + "/" + year.Text;
            string query = "update reg_tabl set name='" + TextNAME.Text + "',dateofbirt='" + date + "',gender='" + gend + "',age='" + TextAGE.Text + "',mobile='" + TextMOBILE.Text + "',pass='" + TextPASS.Text + "'  where id='" + TextID.Text+ "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            string query = "delete  from reg_tabl where id='" + id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            grid();
        }




        


    }
}