using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Homework4CWEB2116
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void bLogin_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Authenticate;Integrated Security=True;");

			conn.Open();

			SqlCommand sqlcmd = new SqlCommand("Select * from LoginDetails where Username='" + tbUsername.Text + "' and Password='" + tbPassword.Text + "'", conn);

			SqlDataAdapter da = new SqlDataAdapter(sqlcmd);

			DataTable dt = new DataTable();
			da.Fill(dt);

			if (dt.Rows.Count > 0)
			{
				this.Hide();
				CRUD view = new CRUD();
				view.Show();
			}
			else
			{
				MessageBox.Show("Please check your username and password");
			}

			conn.Close();
		}

		private void bExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
