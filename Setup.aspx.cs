using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class Setup : System.Web.UI.Page
{
   
    SqlConnection con;
    string webconn = ConfigurationManager.ConnectionStrings["roshan_db"].ToString();

   protected void Page_Load(object sender, EventArgs e)
     {
        if (!IsPostBack)
        {
            con = new SqlConnection(webconn);
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_EBC_Interface", con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@EBC_CODE", "");
            cmd.Parameters.AddWithValue("@HOTEL_NAME", "");
            cmd.Parameters.AddWithValue("@HOTEL_CODE", "");
            cmd.Parameters.AddWithValue("@CHANNEL_CODE", "");
            cmd.Parameters.AddWithValue("@INTERFACE_ACTIVE_STATUS", "");
            cmd.Parameters.AddWithValue("@USERNAME", "");
            cmd.Parameters.AddWithValue("@PASSWORD", "");
            cmd.Parameters.AddWithValue("@FLAG", 5);

            SqlDataReader sdr = cmd.ExecuteReader();
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("select any one");


            while (sdr.Read())
            {
                DropDownList1.Items.Add(sdr[1].ToString());
            }
            sdr.Close();
            con.Close();
        }
    }
  
   protected void Button1_Click(object sender, EventArgs e)
   {
       int status = 0;
       if (CheckBox1.Checked == true)
       {
           status = 1;
       }
       else
       {
           status = 0;
       }
       con = new SqlConnection(webconn);
       con.Open();
       SqlCommand cmd = new SqlCommand("SP_EBC_Interface", con);
       cmd.CommandType = CommandType.StoredProcedure;
       cmd.Parameters.AddWithValue("@EBC_CODE", "");
       cmd.Parameters.AddWithValue("@HOTEL_NAME", DropDownList1.SelectedItem.ToString());
       cmd.Parameters.AddWithValue("@HOTEL_CODE", "");
       cmd.Parameters.AddWithValue("@CHANNEL_CODE", TextBox1.Text);
       cmd.Parameters.AddWithValue("@INTERFACE_ACTIVE_STATUS", status);
       cmd.Parameters.AddWithValue("@USERNAME", TextBox2.Text);
       cmd.Parameters.AddWithValue("@PASSWORD", TextBox3.Text);
       cmd.Parameters.AddWithValue("@FLAG", 2);
       cmd.ExecuteNonQuery();
       con.Close();
       
   }
   protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
   {
       con = new SqlConnection(webconn);
       con.Open();
       SqlCommand cmd = new SqlCommand("SP_EBC_Interface", con);
       cmd.CommandType = CommandType.StoredProcedure;
       cmd.Parameters.AddWithValue("@EBC_CODE", "");
       cmd.Parameters.AddWithValue("@HOTEL_NAME", DropDownList1.SelectedItem.ToString());
       cmd.Parameters.AddWithValue("@HOTEL_CODE", "");
       cmd.Parameters.AddWithValue("@CHANNEL_CODE", "");
       cmd.Parameters.AddWithValue("@INTERFACE_ACTIVE_STATUS", "");
       cmd.Parameters.AddWithValue("@USERNAME", "");
       cmd.Parameters.AddWithValue("@PASSWORD", "");
       cmd.Parameters.AddWithValue("@FLAG", 7);

       SqlDataReader sdr = cmd.ExecuteReader();
       int interface_value = 0;
       if (sdr.Read())
       {
           if (interface_value == (int)sdr[4])
           {
               CheckBox1.Checked = false;
           }
           else
           {
               CheckBox1.Checked = true;
           }
           TextBox1.Text = sdr[3].ToString();
           TextBox2.Text = sdr[5].ToString();
           TextBox3.Text = sdr[6].ToString();

       }

       sdr.Close();

       con.Close();
   }
   protected void Button2_Click(object sender, EventArgs e)
   {
       int status = 0;
       if (CheckBox1.Checked == true)
       {
           status = 1;
       }
       else
       {
           status = 0;
       }
       con = new SqlConnection(webconn);
       con.Open();
       SqlCommand cmd = new SqlCommand("SP_EBC_Interface", con);
       cmd.CommandType = CommandType.StoredProcedure;
       cmd.Parameters.AddWithValue("@EBC_CODE", "");
       cmd.Parameters.AddWithValue("@HOTEL_NAME", DropDownList1.SelectedItem.ToString());
       cmd.Parameters.AddWithValue("@HOTEL_CODE", "");
       cmd.Parameters.AddWithValue("@CHANNEL_CODE", TextBox1.Text);
       cmd.Parameters.AddWithValue("@INTERFACE_ACTIVE_STATUS", status);
       cmd.Parameters.AddWithValue("@USERNAME", TextBox2.Text);
       cmd.Parameters.AddWithValue("@PASSWORD", TextBox3.Text);
       cmd.Parameters.AddWithValue("@FLAG", 3);
       cmd.ExecuteNonQuery();
       con.Close();
   }

       
        public void clearAll()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        DropDownList1.SelectedIndex = 0;
        CheckBox1.Checked = false;
        CheckBox2.Checked = false;
    }


        protected void Button3_Click(object sender, EventArgs e)
        {
            clearAll();
        }
}