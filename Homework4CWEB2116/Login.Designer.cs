namespace Homework4CWEB2116
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.tbUsername = new System.Windows.Forms.TextBox();
			this.bExit = new System.Windows.Forms.Button();
			this.bLogin = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tbPassword
			// 
			this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPassword.Location = new System.Drawing.Point(369, 201);
			this.tbPassword.Multiline = true;
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(240, 32);
			this.tbPassword.TabIndex = 13;
			// 
			// tbUsername
			// 
			this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbUsername.Location = new System.Drawing.Point(369, 127);
			this.tbUsername.Multiline = true;
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.Size = new System.Drawing.Size(240, 32);
			this.tbUsername.TabIndex = 12;
			// 
			// bExit
			// 
			this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bExit.Location = new System.Drawing.Point(431, 317);
			this.bExit.Name = "bExit";
			this.bExit.Size = new System.Drawing.Size(110, 41);
			this.bExit.TabIndex = 11;
			this.bExit.Text = "Exit";
			this.bExit.UseVisualStyleBackColor = true;
			this.bExit.Click += new System.EventHandler(this.bExit_Click);
			// 
			// bLogin
			// 
			this.bLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bLogin.Location = new System.Drawing.Point(247, 317);
			this.bLogin.Name = "bLogin";
			this.bLogin.Size = new System.Drawing.Size(110, 41);
			this.bLogin.TabIndex = 10;
			this.bLogin.Text = "Login";
			this.bLogin.UseVisualStyleBackColor = true;
			this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(172, 201);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(178, 32);
			this.label2.TabIndex = 9;
			this.label2.Text = "PASSWORD";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(177, 127);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 32);
			this.label1.TabIndex = 8;
			this.label1.Text = "USERNAME";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Maroon;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbUsername);
			this.Controls.Add(this.bExit);
			this.Controls.Add(this.bLogin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login";
			this.Text = "Tool Inventory Management System";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.TextBox tbUsername;
		private System.Windows.Forms.Button bExit;
		private System.Windows.Forms.Button bLogin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

