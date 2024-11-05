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
	public partial class InsertRecord : Form
	{
		string PicLoc = "";

		public InsertRecord()
		{
			InitializeComponent();
		}

		private void bLogout_Click(object sender, EventArgs e)
		{
			this.Close();
			Login log = new Login();
			log.Show();
		}

		private void bBack_Click(object sender, EventArgs e)
		{
			this.Close();
			CRUD view = new CRUD();
			view.Show();
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

		private void bSave_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Authenticate;Integrated Security=True");

			conn.Open();
			string Status = "";
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
					Status = "In Stock";
				}
				else
				{
					Status = "Out of Stock";
				}

				string insertQuery = "Insert into InventoryTable (InventoryName, Category, Picture, PicLoc, Status) values ('" + tbName.Text + "', '" + cbCategory.Text + "', @myImage, '" + PicLoc + "', '" + Status + "')";

				SqlCommand cmd = new SqlCommand(insertQuery, conn);
				cmd.Parameters.Add(new SqlParameter("@myImage", myImage));
				cmd.ExecuteNonQuery();

				tbName.Text = "";
				PicLoc = "";
				pictureBox1.ImageLocation = PicLoc;
				cbCategory.SelectedItem = null;
				rbInStock.Checked = true;
				MessageBox.Show("Data inserted successfully");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				conn.Close();
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
	}
}
