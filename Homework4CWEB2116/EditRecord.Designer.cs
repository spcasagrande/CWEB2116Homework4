namespace Homework4CWEB2116
{
	partial class EditRecord
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRecord));
			this.bBack = new System.Windows.Forms.Button();
			this.bClear = new System.Windows.Forms.Button();
			this.bSave = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.btnImgUpload = new System.Windows.Forms.Button();
			this.rbOutofStock = new System.Windows.Forms.RadioButton();
			this.rbInStock = new System.Windows.Forms.RadioButton();
			this.cbCategory = new System.Windows.Forms.ComboBox();
			this.bLogout = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// bBack
			// 
			this.bBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bBack.Location = new System.Drawing.Point(12, 12);
			this.bBack.Name = "bBack";
			this.bBack.Size = new System.Drawing.Size(98, 34);
			this.bBack.TabIndex = 43;
			this.bBack.Text = "Back";
			this.bBack.UseVisualStyleBackColor = true;
			this.bBack.Click += new System.EventHandler(this.bBack_Click);
			// 
			// bClear
			// 
			this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bClear.Location = new System.Drawing.Point(710, 417);
			this.bClear.Name = "bClear";
			this.bClear.Size = new System.Drawing.Size(98, 34);
			this.bClear.TabIndex = 42;
			this.bClear.Text = "Clear";
			this.bClear.UseVisualStyleBackColor = true;
			this.bClear.Click += new System.EventHandler(this.bClear_Click);
			// 
			// bSave
			// 
			this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bSave.Location = new System.Drawing.Point(565, 417);
			this.bSave.Name = "bSave";
			this.bSave.Size = new System.Drawing.Size(98, 34);
			this.bSave.TabIndex = 41;
			this.bSave.Text = "Save";
			this.bSave.UseVisualStyleBackColor = true;
			this.bSave.Click += new System.EventHandler(this.bSave_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(124, 146);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(319, 356);
			this.pictureBox1.TabIndex = 40;
			this.pictureBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(457, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(206, 54);
			this.label5.TabIndex = 39;
			this.label5.Text = "Edit Tool";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(530, 299);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 25);
			this.label4.TabIndex = 38;
			this.label4.Text = "Image Upload";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(595, 361);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 25);
			this.label3.TabIndex = 37;
			this.label3.Text = "Status";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(571, 237);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 25);
			this.label2.TabIndex = 36;
			this.label2.Text = "Category";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(555, 177);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 25);
			this.label1.TabIndex = 35;
			this.label1.Text = "Tool Name";
			// 
			// tbName
			// 
			this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbName.Location = new System.Drawing.Point(710, 170);
			this.tbName.Multiline = true;
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(240, 32);
			this.tbName.TabIndex = 34;
			// 
			// btnImgUpload
			// 
			this.btnImgUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImgUpload.Location = new System.Drawing.Point(710, 294);
			this.btnImgUpload.Name = "btnImgUpload";
			this.btnImgUpload.Size = new System.Drawing.Size(170, 34);
			this.btnImgUpload.TabIndex = 33;
			this.btnImgUpload.Text = "Add new photo";
			this.btnImgUpload.UseVisualStyleBackColor = true;
			this.btnImgUpload.Click += new System.EventHandler(this.btnImgUpload_Click);
			// 
			// rbOutofStock
			// 
			this.rbOutofStock.AutoSize = true;
			this.rbOutofStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbOutofStock.ForeColor = System.Drawing.Color.White;
			this.rbOutofStock.Location = new System.Drawing.Point(836, 359);
			this.rbOutofStock.Name = "rbOutofStock";
			this.rbOutofStock.Size = new System.Drawing.Size(141, 29);
			this.rbOutofStock.TabIndex = 32;
			this.rbOutofStock.Text = "Out of Stock";
			this.rbOutofStock.UseVisualStyleBackColor = true;
			// 
			// rbInStock
			// 
			this.rbInStock.AutoSize = true;
			this.rbInStock.Checked = true;
			this.rbInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbInStock.ForeColor = System.Drawing.Color.White;
			this.rbInStock.Location = new System.Drawing.Point(710, 359);
			this.rbInStock.Name = "rbInStock";
			this.rbInStock.Size = new System.Drawing.Size(104, 29);
			this.rbInStock.TabIndex = 31;
			this.rbInStock.TabStop = true;
			this.rbInStock.Text = "In Stock";
			this.rbInStock.UseVisualStyleBackColor = true;
			// 
			// cbCategory
			// 
			this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbCategory.FormattingEnabled = true;
			this.cbCategory.Items.AddRange(new object[] {
            "Hand Tools",
            "Power Tools",
            "Saftey Gear"});
			this.cbCategory.Location = new System.Drawing.Point(710, 229);
			this.cbCategory.Name = "cbCategory";
			this.cbCategory.Size = new System.Drawing.Size(203, 33);
			this.cbCategory.TabIndex = 30;
			// 
			// bLogout
			// 
			this.bLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bLogout.Location = new System.Drawing.Point(1037, 12);
			this.bLogout.Name = "bLogout";
			this.bLogout.Size = new System.Drawing.Size(98, 34);
			this.bLogout.TabIndex = 29;
			this.bLogout.Text = "Logout";
			this.bLogout.UseVisualStyleBackColor = true;
			this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
			// 
			// EditRecord
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Maroon;
			this.ClientSize = new System.Drawing.Size(1147, 642);
			this.Controls.Add(this.bBack);
			this.Controls.Add(this.bClear);
			this.Controls.Add(this.bSave);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.btnImgUpload);
			this.Controls.Add(this.rbOutofStock);
			this.Controls.Add(this.rbInStock);
			this.Controls.Add(this.cbCategory);
			this.Controls.Add(this.bLogout);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EditRecord";
			this.Text = "Tool Inventory Management System";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bBack;
		private System.Windows.Forms.Button bClear;
		private System.Windows.Forms.Button bSave;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Button btnImgUpload;
		private System.Windows.Forms.RadioButton rbOutofStock;
		private System.Windows.Forms.RadioButton rbInStock;
		private System.Windows.Forms.ComboBox cbCategory;
		private System.Windows.Forms.Button bLogout;
	}
}