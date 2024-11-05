using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework4CWEB2116
{
	public partial class EditRecord : Form
	{
		SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Authenticate;Integrated Security=True;");

		SqlCommand cmd;
		string id = "";
		string name = "";
		string category = "";
		string status = "";
		string PicLoc = "";

		public EditRecord(string param)
		{
			InitializeComponent();
			id = param;

			string selectQuery = "SELECT * FROM InventoryTable WHERE InventoryId='" + id + "'";
			conn.Open();
			cmd = new SqlCommand(selectQuery, conn);

			try
			{
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					reader.Read();

					if (reader.HasRows)
					{
						tbName.Text = reader[1].ToString();
						cbCategory.SelectedItem = reader[2].ToString();
						PicLoc = reader[4].ToString();
						status = reader[5].ToString();

						pictureBox1.ImageLocation = PicLoc;
						pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

						if (status == "In Stock")
						{
							rbInStock.Checked = true;
							rbOutofStock.Checked = false;
						}
						else
						{
							rbInStock.Checked = false;
							rbOutofStock.Checked = true;
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			conn.Close();
		}

		private void bBack_Click(object sender, EventArgs e)
		{
			this.Close();
			CRUD view = new CRUD();
			view.Show();
		}

		private void bLogout_Click(object sender, EventArgs e)
		{
			this.Close();
			Login log = new Login();
			log.Show();
		}

		private void btnImgUpload_Click(object sender, EventArgs e)
		{
			OpenFileDialog fileSelect = new OpenFileDialog();

			fileSelect.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

			fileSelect.Title = "Select Picture";

			if (fileSelect.ShowDialog() == DialogResult.OK)
			{
				PicLoc = fileSelect.FileName.ToString();
				pictureBox1.ImageLocation = PicLoc;
				pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			}
		}

		private void bClear_Click(object sender, EventArgs e)
		{
			tbName.Text = "";
			PicLoc = "";
			pictureBox1.ImageLocation = PicLoc;
			cbCategory.SelectedItem = null;
			rbInStock.Checked = true;
		}

		private void bSave_Click(object sender, EventArgs e)
		{
			conn.Open();
			byte[] myImage = null;

			try
			{
				if (tbName.Text.Equals(""))
				{
					MessageBox.Show("Please name the item");
					return;
				}

				if (cbCategory.Text.Equals(""))
				{
					MessageBox.Show("Please select a category");
					return;
				}

				if (PicLoc.Equals(""))
				{
					MessageBox.Show("Please select an image to add");
					return;
				}
				else
				{
					FileStream fStream = new FileStream(PicLoc, FileMode.Open, FileAccess.Read);
					BinaryReader br = new BinaryReader(fStream);
					myImage = br.ReadBytes((int)fStream.Length);

				}

				if (rbInStock.Checked)
				{
					status = "In Stock";
				}
				else
				{
					status = "Out of Stock";
				}

				string editQuery = "UPDATE InventoryTable SET InventoryName ='" + tbName.Text + "', Category ='" + cbCategory.Text + "', Picture=@myImage, PicLoc ='" + PicLoc + "', Status='" + status + "' WHERE InventoryId='" + id + "'";

				SqlCommand cmd = new SqlCommand(editQuery, conn);
				cmd.Parameters.Add(new SqlParameter("@myImage", myImage));
				cmd.ExecuteNonQuery();

				tbName.Text = "";
				PicLoc = "";
				pictureBox1.ImageLocation = PicLoc;
				cbCategory.SelectedItem = null;
				rbInStock.Checked = true;
				MessageBox.Show("Data updated successfully");
				conn.Close();

				this.Close();
				CRUD view = new CRUD();
				view.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				conn.Close();
			}
		}
	}
}
