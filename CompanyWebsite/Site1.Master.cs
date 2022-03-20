using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace CompanyWebsite
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\ShadowCrypt\CompanyWebsite\App_Data\Contact.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO [Table](Name,Email,Subject,Message) VALUES('"+TextBox1.Text+"', '"+TextBox2.Text+"', '"+TextBox3.Text+"', '"+TextBox4.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}