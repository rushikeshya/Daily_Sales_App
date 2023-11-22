namespace Daily_Sells_App
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.txtMaterial = new System.Windows.Forms.TextBox();
			this.txtCustomer = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button3 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.OrangeRed;
			this.label1.Location = new System.Drawing.Point(605, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(540, 89);
			this.label1.TabIndex = 0;
			this.label1.Text = "DAILY SALES";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtAmount);
			this.groupBox1.Controls.Add(this.txtMaterial);
			this.groupBox1.Controls.Add(this.txtCustomer);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(27, 215);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(580, 340);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "DAILY SALES";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(238, 261);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(331, 30);
			this.dateTimePicker1.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(15, 266);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 25);
			this.label5.TabIndex = 7;
			this.label5.Text = "Date :-";
			// 
			// txtAmount
			// 
			this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAmount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAmount.Location = new System.Drawing.Point(241, 198);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(328, 34);
			this.txtAmount.TabIndex = 3;
			// 
			// txtMaterial
			// 
			this.txtMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMaterial.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaterial.Location = new System.Drawing.Point(241, 133);
			this.txtMaterial.Name = "txtMaterial";
			this.txtMaterial.Size = new System.Drawing.Size(328, 34);
			this.txtMaterial.TabIndex = 2;
			// 
			// txtCustomer
			// 
			this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCustomer.CausesValidation = false;
			this.txtCustomer.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCustomer.Location = new System.Drawing.Point(241, 69);
			this.txtCustomer.Name = "txtCustomer";
			this.txtCustomer.Size = new System.Drawing.Size(328, 34);
			this.txtCustomer.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(14, 201);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(200, 31);
			this.label4.TabIndex = 2;
			this.label4.Text = "Total Amount :-";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(227, 31);
			this.label3.TabIndex = 1;
			this.label3.Text = "Materials Name :-";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(229, 31);
			this.label2.TabIndex = 0;
			this.label2.Text = "Customer Name :-";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(24, 595);
			this.button1.Name = "button1";
			this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button1.Size = new System.Drawing.Size(105, 53);
			this.button1.TabIndex = 2;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(162, 595);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(108, 53);
			this.button2.TabIndex = 3;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Date,
            this.Edit,
            this.delete});
			this.dataGridView1.Location = new System.Drawing.Point(613, 215);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1062, 362);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(1282, 666);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(137, 66);
			this.button3.TabIndex = 5;
			this.button3.Text = "Refresh";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(39, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(431, 125);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// Column1
			// 
			dataGridViewCellStyle25.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column1.DefaultCellStyle = dataGridViewCellStyle25;
			this.Column1.HeaderText = "Sr. No.";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 60;
			// 
			// Column2
			// 
			dataGridViewCellStyle26.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column2.DefaultCellStyle = dataGridViewCellStyle26;
			this.Column2.HeaderText = "Customer name";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 250;
			// 
			// Column3
			// 
			dataGridViewCellStyle27.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column3.DefaultCellStyle = dataGridViewCellStyle27;
			this.Column3.HeaderText = "Materials";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Width = 200;
			// 
			// Column4
			// 
			dataGridViewCellStyle28.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle28.Format = "N2";
			dataGridViewCellStyle28.NullValue = null;
			this.Column4.DefaultCellStyle = dataGridViewCellStyle28;
			this.Column4.HeaderText = "Amount";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.Width = 125;
			// 
			// Date
			// 
			dataGridViewCellStyle29.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Red;
			dataGridViewCellStyle29.Format = "d";
			dataGridViewCellStyle29.NullValue = null;
			this.Date.DefaultCellStyle = dataGridViewCellStyle29;
			this.Date.HeaderText = "Date";
			this.Date.MinimumWidth = 6;
			this.Date.Name = "Date";
			this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Date.Width = 125;
			// 
			// Edit
			// 
			dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle30.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Red;
			this.Edit.DefaultCellStyle = dataGridViewCellStyle30;
			this.Edit.HeaderText = "Edit";
			this.Edit.MinimumWidth = 6;
			this.Edit.Name = "Edit";
			this.Edit.Text = "Edit";
			this.Edit.UseColumnTextForButtonValue = true;
			this.Edit.Width = 90;
			// 
			// delete
			// 
			this.delete.HeaderText = "Delete";
			this.delete.MinimumWidth = 6;
			this.delete.Name = "delete";
			this.delete.ReadOnly = true;
			this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.delete.Text = "Delete";
			this.delete.UseColumnTextForButtonValue = true;
			this.delete.Width = 90;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(1774, 744);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_LoadData);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.TextBox txtMaterial;
		private System.Windows.Forms.TextBox txtCustomer;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.DataGridViewButtonColumn Edit;
		private System.Windows.Forms.DataGridViewButtonColumn delete;
	}
}

