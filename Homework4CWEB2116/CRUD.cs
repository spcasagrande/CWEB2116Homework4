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
using System.IO;

namespace Homework4CWEB2116
{
	public partial class CRUD : Form
	{
		SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Authenticate;Integrated Security=True;");

		SqlCommand cmd;
		string id = "";
		string name = "";
		string category = "";
		string status = "";
		string existingPicLoc = "";

		public CRUD()
		{
			InitializeComponent();
		}

		public void display_data()
		{
			conn.Open();
			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "Select * from InventoryTable";
			cmd.ExecuteNonQuery();

			DataTable dt = new DataTable();
			SqlDataAdapter sda = new SqlDataAdapter(cmd);
			sda.Fill(dt);
			dataGrid_DispRec.DataSource = dt;

			cbSearch.SelectedItem = "";
			cbSearch.Text = "";
			pictureBox1.ImageLocation = null;

			conn.Close();
		}

		private void CRUD_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'authenticateDataSet.InventoryTable' table. You can move, or remove it, as needed.
            //this.inventoryTableTableAdapter.Fill(this.authenticateDataSet.InventoryTable);

        }

		private void bLogout_Click(object sender, EventArgs e)
		{
			this.Close();
			Login log = new Login();
			log.Show();
		}

		private void bDisplayAll_Click(object sender, EventArgs e)
		{
			display_data();
		}

		private void bSearch_Click(object sender, EventArgs e)
		{
			string cbsearch = cbSearch.Text;
			string tbsearch = tbSearch.Text;

			if (cbsearch == "")
			{
				MessageBox.Show("Please select a search category");
				return;
			}
			else if (cbsearch == "Name")
			{
				SqlCommand sqcmd = new SqlCommand("Select * from InventoryTable where InventoryName Like '%" + tbsearch + "%'", conn);
				SqlDataAdapter da = new SqlDataAdapter(sqcmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				if (dt.Rows.Count > 0)
				{
					dataGrid_DispRec.DataSource = dt;
					conn.Close();
				}
				else
				{
					MessageBox.Show("No record found");
					conn.Close();
				}
			}
			else if (cbsearch == "Category")
			{
				SqlCommand sqcmd = new SqlCommand("Select * from InventoryTable where Category Like '%" + tbsearch + "%'", conn);
				SqlDataAdapter da = new SqlDataAdapter(sqcmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				if (dt.Rows.Count > 0)
				{
					dataGrid_DispRec.DataSource = dt;
					conn.Close();
				}
				else
				{
					MessageBox.Show("No record found");
					conn.Close();
				}
			}
			else
			{
				SqlCommand sqcmd = new SqlCommand("Select * from InventoryTable where Status Like '%" + tbsearch + "%'", conn);
				SqlDataAdapter da = new SqlDataAdapter(sqcmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				if (dt.Rows.Count > 0)
				{
					dataGrid_DispRec.DataSource = dt;
					conn.Close();
				}
				else
				{
					MessageBox.Show("No record found");
					conn.Close();
				}
			}
		}

		public void dataGrid_DispRec_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			bEdit.Show();
			bDelete.Show();

			int myIndex = e.RowIndex;
			DataGridViewRow row = dataGrid_DispRec.Rows[myIndex];

			id = row.Cells[0].Value.ToString();
			name = row.Cells[1].Value.ToString();
			category = row.Cells[2].Value.ToString();
			status = row.Cells[3].Value.ToString();
			existingPicLoc = "";

			string showQuery = "Select * from InventoryTable where InventoryId='" + id + "'";
			conn.Open();
			cmd = new SqlCommand(showQuery, conn);

			try
			{
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					reader.Read();
					if (reader.HasRows)
					{
						existingPicLoc = reader[4].ToString();
						pictureBox1.ImageLocation = existingPicLoc;
						pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			conn.Close();
		}

		private void bInsert_Click(object sender, EventArgs e)
		{
			this.Close();
			InsertRecord insert = new InsertRecord();
			insert.Show();
		}

		private void bEdit_Click(object sender, EventArgs e)
		{
			this.Hide();
			EditRecord edit = new EditRecord(id);
			edit.Show();
		}

		private void bDelete_Click(object sender, EventArgs e)
		{
			try
			{
				string deleteQuery = "DELETE FROM InventoryTable WHERE InventoryId ='" + id + "'";
				conn.Open();
				cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = deleteQuery;
				cmd.ExecuteNonQuery();
				conn.Close();

				display_data();

				MessageBox.Show("Item deleted successfully");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				conn.Close();
			}
		}
	}
}
