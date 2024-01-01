using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();

        con = new SqlConnection(ConfigurationManager.ConnectionStrings["roshan_db"].ConnectionString);
        cmd.Connection = con;

        cmd.CommandText = "select * from EBC_Interface_Table;";
        con.Open();
        Repeater1.DataSource = cmd.ExecuteReader();
        Repeater1.DataBind();
        con.Close();
    }
}