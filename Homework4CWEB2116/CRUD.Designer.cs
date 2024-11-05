namespace Homework4CWEB2116
{
	partial class CRUD
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD));
			this.dataGrid_DispRec = new System.Windows.Forms.DataGridView();
			this.inventoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inventoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inventoryTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.authenticateDataSet = new Homework4CWEB2116.AuthenticateDataSet();
			this.inventoryTableTableAdapter = new Homework4CWEB2116.AuthenticateDataSetTableAdapters.InventoryTableTableAdapter();
			this.bLogout = new System.Windows.Forms.Button();
			this.bDisplayAll = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.cbSearch = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.bSearch = new System.Windows.Forms.Button();
			this.bEdit = new System.Windows.Forms.Button();
			this.bDelete = new System.Windows.Forms.Button();
			this.bInsert = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_DispRec)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryTableBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.authenticateDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid_DispRec
			// 
			this.dataGrid_DispRec.AutoGenerateColumns = false;
			this.dataGrid_DispRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid_DispRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventoryIdDataGridViewTextBoxColumn,
            this.inventoryNameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
			this.dataGrid_DispRec.DataSource = this.inventoryTableBindingSource;
			this.dataGrid_DispRec.Location = new System.Drawing.Point(372, 260);
			this.dataGrid_DispRec.Name = "dataGrid_DispRec";
			this.dataGrid_DispRec.ReadOnly = true;
			this.dataGrid_DispRec.RowHeadersWidth = 51;
			this.dataGrid_DispRec.RowTemplate.Height = 24;
			this.dataGrid_DispRec.RowTemplate.ReadOnly = true;
			this.dataGrid_DispRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGrid_DispRec.Size = new System.Drawing.Size(739, 202);
			this.dataGrid_DispRec.TabIndex = 0;
			this.dataGrid_DispRec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_DispRec_CellContentClick);
			// 
			// inventoryIdDataGridViewTextBoxColumn
			// 
			this.inventoryIdDataGridViewTextBoxColumn.DataPropertyName = "InventoryId";
			this.inventoryIdDataGridViewTextBoxColumn.HeaderText = "ID";
			this.inventoryIdDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.inventoryIdDataGridViewTextBoxColumn.Name = "inventoryIdDataGridViewTextBoxColumn";
			this.inventoryIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.inventoryIdDataGridViewTextBoxColumn.Width = 125;
			// 
			// inventoryNameDataGridViewTextBoxColumn
			// 
			this.inventoryNameDataGridViewTextBoxColumn.DataPropertyName = "InventoryName";
			this.inventoryNameDataGridViewTextBoxColumn.HeaderText = "Tool Name";
			this.inventoryNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.inventoryNameDataGridViewTextBoxColumn.Name = "inventoryNameDataGridViewTextBoxColumn";
			this.inventoryNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.inventoryNameDataGridViewTextBoxColumn.Width = 125;
			// 
			// categoryDataGridViewTextBoxColumn
			// 
			this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
			this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
			this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
			this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
			this.categoryDataGridViewTextBoxColumn.Width = 125;
			// 
			// statusDataGridViewTextBoxColumn
			// 
			this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
			this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
			this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
			this.statusDataGridViewTextBoxColumn.ReadOnly = true;
			this.statusDataGridViewTextBoxColumn.Width = 125;
			// 
			// inventoryTableBindingSource
			// 
			this.inventoryTableBindingSource.DataMember = "InventoryTable";
			this.inventoryTableBindingSource.DataSource = this.authenticateDataSet;
			// 
			// authenticateDataSet
			// 
			this.authenticateDataSet.DataSetName = "AuthenticateDataSet";
			this.authenticateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// inventoryTableTableAdapter
			// 
			this.inventoryTableTableAdapter.ClearBeforeFill = true;
			// 
			// bLogout
			// 
			this.bLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bLogout.Location = new System.Drawing.Point(1037, 12);
			this.bLogout.Name = "bLogout";
			this.bLogout.Size = new System.Drawing.Size(98, 34);
			this.bLogout.TabIndex = 1;
			this.bLogout.Text = "Logout";
			this.bLogout.UseVisualStyleBackColor = true;
			this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
			// 
			// bDisplayAll
			// 
			this.bDisplayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bDisplayAll.Location = new System.Drawing.Point(633, 568);
			this.bDisplayAll.Name = "bDisplayAll";
			this.bDisplayAll.Size = new System.Drawing.Size(226, 34);
			this.bDisplayAll.TabIndex = 2;
			this.bDisplayAll.Text = "Display All Records";
			this.bDisplayAll.UseVisualStyleBackColor = true;
			this.bDisplayAll.Click += new System.EventHandler(this.bDisplayAll_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(24, 133);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(319, 356);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// tbSearch
			// 
			this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSearch.Location = new System.Drawing.Point(651, 185);
			this.tbSearch.Multiline = true;
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(325, 32);
			this.tbSearch.TabIndex = 9;
			// 
			// cbSearch
			// 
			this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSearch.FormattingEnabled = true;
			this.cbSearch.Items.AddRange(new object[] {
            "Name",
            "Category",
            "Status"});
			this.cbSearch.Location = new System.Drawing.Point(485, 184);
			this.cbSearch.Name = "cbSearch";
			this.cbSearch.Size = new System.Drawing.Size(139, 33);
			this.cbSearch.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(367, 188);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 25);
			this.label1.TabIndex = 7;
			this.label1.Text = "Search by";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(389, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(312, 54);
			this.label2.TabIndex = 10;
			this.label2.Text = "View Records";
			// 
			// bSearch
			// 
			this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bSearch.Location = new System.Drawing.Point(1012, 184);
			this.bSearch.Name = "bSearch";
			this.bSearch.Size = new System.Drawing.Size(99, 34);
			this.bSearch.TabIndex = 11;
			this.bSearch.Text = "Search";
			this.bSearch.UseVisualStyleBackColor = true;
			this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
			// 
			// bEdit
			// 
			this.bEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bEdit.Location = new System.Drawing.Point(590, 487);
			this.bEdit.Name = "bEdit";
			this.bEdit.Size = new System.Drawing.Size(98, 33);
			this.bEdit.TabIndex = 12;
			this.bEdit.Text = "Edit";
			this.bEdit.UseVisualStyleBackColor = true;
			this.bEdit.Visible = false;
			this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
			// 
			// bDelete
			// 
			this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bDelete.Location = new System.Drawing.Point(792, 487);
			this.bDelete.Name = "bDelete";
			this.bDelete.Size = new System.Drawing.Size(98, 33);
			this.bDelete.TabIndex = 13;
			this.bDelete.Text = "Delete";
			this.bDelete.UseVisualStyleBackColor = true;
			this.bDelete.Visible = false;
			this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
			// 
			// bInsert
			// 
			this.bInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bInsert.Location = new System.Drawing.Point(242, 568);
			this.bInsert.Name = "bInsert";
			this.bInsert.Size = new System.Drawing.Size(226, 34);
			this.bInsert.TabIndex = 14;
			this.bInsert.Text = "Insert New Record";
			this.bInsert.UseVisualStyleBackColor = true;
			this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
			// 
			// CRUD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Maroon;
			this.ClientSize = new System.Drawing.Size(1147, 642);
			this.Controls.Add(this.bInsert);
			this.Controls.Add(this.bDelete);
			this.Controls.Add(this.bEdit);
			this.Controls.Add(this.bSearch);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbSearch);
			this.Controls.Add(this.cbSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.bDisplayAll);
			this.Controls.Add(this.bLogout);
			this.Controls.Add(this.dataGrid_DispRec);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CRUD";
			this.Text = "Tool Inventory Management System";
			this.Load += new System.EventHandler(this.CRUD_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_DispRec)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryTableBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.authenticateDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGrid_DispRec;
		private AuthenticateDataSet authenticateDataSet;
		private System.Windows.Forms.BindingSource inventoryTableBindingSource;
		private AuthenticateDataSetTableAdapters.InventoryTableTableAdapter inventoryTableTableAdapter;
		private System.Windows.Forms.Button bLogout;
		private System.Windows.Forms.DataGridViewTextBoxColumn inventoryIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn inventoryNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button bDisplayAll;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.ComboBox cbSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bSearch;
		private System.Windows.Forms.Button bEdit;
		private System.Windows.Forms.Button bDelete;
		private System.Windows.Forms.Button bInsert;
	}
}