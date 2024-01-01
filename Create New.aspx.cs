using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



public partial class Create_New : System.Web.UI.Page
{

    SqlConnection con;
    string webconn = ConfigurationManager.ConnectionStrings["roshan_db"].ToString();


    public int auto_code()
      {
        int code;
        con = new SqlConnection(webconn);
        con.Open();
        SqlCommand cmd = new SqlCommand("SP_EBC_Interface", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@EBC_CODE", "");
        cmd.Parameters.AddWithValue("@HOTEL_NAME", "");
        cmd.Parameters.AddWithValue("@HOTEL_CODE ", "");
        cmd.Parameters.AddWithValue("@CHANNEL_CODE", "");
        cmd.Parameters.AddWithValue("@INTERFACE_ACTIVE_STATUS", "");
        cmd.Parameters.AddWithValue("@USERNAME", "");
        cmd.Parameters.AddWithValue("@PASSWORD", "");
        cmd.Parameters.AddWithValue("@FLAG", 6);
        code = (int) cmd.ExecuteScalar();
        code++;
        con.Close();
        return code;
      }
   
    protected void Button1_Click1(object sender, EventArgs e)
     {
        int ebc_code = auto_code();
        string nm = DropDownList1.SelectedItem.ToString();
        string channel = DropDownList2.SelectedItem.ToString();
        int interface_val = 0;
        if (CheckBox1.Checked == true)
        {
            interface_val = 1;
        }
       else
        {
            interface_val = 0;
        }

        string hotel_code = TextBox1.Text.ToString();
        string user = TextBox2.Text.ToString();
        string pass = TextBox3.Text.ToString();

        con = new SqlConnection(webconn);
        con.Open();

        SqlCommand cmd = new SqlCommand();
        cmd.CommandText ="SP_EBC_Interface";
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@EBC_CODE", ebc_code);
        cmd.Parameters.AddWithValue("@HOTEL_NAME", nm);
        cmd.Parameters.AddWithValue("@HOTEL_CODE", hotel_code);
        cmd.Parameters.AddWithValue("@CHANNEL_CODE", channel);
        cmd.Parameters.AddWithValue("@INTERFACE_ACTIVE_STATUS", interface_val);
        cmd.Parameters.AddWithValue("@USERNAME", user);
        cmd.Parameters.AddWithValue("@PASSWORD", pass);
        cmd.Parameters.AddWithValue("@FLAG", 1);
       
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("Create_New.aspx");
      
    }
}