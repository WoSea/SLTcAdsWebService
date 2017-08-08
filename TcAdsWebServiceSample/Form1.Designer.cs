namespace TcAdsWebServiceSample
{
	partial class Form1
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
			this.labelUrl = new System.Windows.Forms.Label();
			this.labelNetId = new System.Windows.Forms.Label();
			this.labelPort = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxUrl = new System.Windows.Forms.TextBox();
			this.textBoxNetId = new System.Windows.Forms.TextBox();
			this.textBoxPort = new System.Windows.Forms.TextBox();
			this.textBoxBool = new System.Windows.Forms.TextBox();
			this.textBoxInt = new System.Windows.Forms.TextBox();
			this.textBoxString = new System.Windows.Forms.TextBox();
			this.buttonRead = new System.Windows.Forms.Button();
			this.buttonWrite = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelUrl
			// 
			this.labelUrl.AutoSize = true;
			this.labelUrl.Location = new System.Drawing.Point(12, 9);
			this.labelUrl.Name = "labelUrl";
			this.labelUrl.Size = new System.Drawing.Size(79, 13);
			this.labelUrl.TabIndex = 0;
			this.labelUrl.Text = "WebServiceUrl";
			// 
			// labelNetId
			// 
			this.labelNetId.AutoSize = true;
			this.labelNetId.Location = new System.Drawing.Point(12, 41);
			this.labelNetId.Name = "labelNetId";
			this.labelNetId.Size = new System.Drawing.Size(61, 13);
			this.labelNetId.TabIndex = 1;
			this.labelNetId.Text = "Ams Net ID";
			// 
			// labelPort
			// 
			this.labelPort.AutoSize = true;
			this.labelPort.Location = new System.Drawing.Point(12, 73);
			this.labelPort.Name = "labelPort";
			this.labelPort.Size = new System.Drawing.Size(51, 13);
			this.labelPort.TabIndex = 2;
			this.labelPort.Text = "ADS Port";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "VarBool";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 176);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "VarInt";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 221);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "VarString";
			// 
			// textBoxUrl
			// 
			this.textBoxUrl.Location = new System.Drawing.Point(103, 9);
			this.textBoxUrl.Name = "textBoxUrl";
			this.textBoxUrl.Size = new System.Drawing.Size(437, 20);
			this.textBoxUrl.TabIndex = 6;
			// 
			// textBoxNetId
			// 
			this.textBoxNetId.Location = new System.Drawing.Point(103, 41);
			this.textBoxNetId.Name = "textBoxNetId";
			this.textBoxNetId.Size = new System.Drawing.Size(192, 20);
			this.textBoxNetId.TabIndex = 7;
			// 
			// textBoxPort
			// 
			this.textBoxPort.Location = new System.Drawing.Point(103, 73);
			this.textBoxPort.Name = "textBoxPort";
			this.textBoxPort.Size = new System.Drawing.Size(192, 20);
			this.textBoxPort.TabIndex = 8;
			// 
			// textBoxBool
			// 
			this.textBoxBool.Location = new System.Drawing.Point(68, 135);
			this.textBoxBool.Name = "textBoxBool";
			this.textBoxBool.Size = new System.Drawing.Size(192, 20);
			this.textBoxBool.TabIndex = 9;
			// 
			// textBoxInt
			// 
			this.textBoxInt.Location = new System.Drawing.Point(68, 177);
			this.textBoxInt.Name = "textBoxInt";
			this.textBoxInt.Size = new System.Drawing.Size(192, 20);
			this.textBoxInt.TabIndex = 10;
			// 
			// textBoxString
			// 
			this.textBoxString.Location = new System.Drawing.Point(68, 221);
			this.textBoxString.Name = "textBoxString";
			this.textBoxString.Size = new System.Drawing.Size(192, 20);
			this.textBoxString.TabIndex = 11;
			// 
			// buttonRead
			// 
			this.buttonRead.Location = new System.Drawing.Point(371, 73);
			this.buttonRead.Name = "buttonRead";
			this.buttonRead.Size = new System.Drawing.Size(102, 64);
			this.buttonRead.TabIndex = 12;
			this.buttonRead.Text = "Read";
			this.buttonRead.UseVisualStyleBackColor = true;
			this.buttonRead.Click += new System.EventHandler(this.Read_Click);
			// 
			// buttonWrite
			// 
			this.buttonWrite.Location = new System.Drawing.Point(371, 174);
			this.buttonWrite.Name = "buttonWrite";
			this.buttonWrite.Size = new System.Drawing.Size(102, 60);
			this.buttonWrite.TabIndex = 13;
			this.buttonWrite.Text = "Write";
			this.buttonWrite.UseVisualStyleBackColor = true;
			this.buttonWrite.Click += new System.EventHandler(this.Write_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(552, 261);
			this.Controls.Add(this.buttonWrite);
			this.Controls.Add(this.buttonRead);
			this.Controls.Add(this.textBoxString);
			this.Controls.Add(this.textBoxInt);
			this.Controls.Add(this.textBoxBool);
			this.Controls.Add(this.textBoxPort);
			this.Controls.Add(this.textBoxNetId);
			this.Controls.Add(this.textBoxUrl);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.labelPort);
			this.Controls.Add(this.labelNetId);
			this.Controls.Add(this.labelUrl);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelUrl;
		private System.Windows.Forms.Label labelNetId;
		private System.Windows.Forms.Label labelPort;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxUrl;
		private System.Windows.Forms.TextBox textBoxNetId;
		private System.Windows.Forms.TextBox textBoxPort;
		private System.Windows.Forms.TextBox textBoxBool;
		private System.Windows.Forms.TextBox textBoxInt;
		private System.Windows.Forms.TextBox textBoxString;
		private System.Windows.Forms.Button buttonRead;
		private System.Windows.Forms.Button buttonWrite;
	}
}

