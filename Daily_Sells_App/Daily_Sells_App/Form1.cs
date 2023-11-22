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
using System.Diagnostics.Contracts;

namespace Daily_Sells_App
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			LoadData();
			SetupForm();
			// Set focus to the txtCustomer TextBox when the form loads
			txtCustomer.Focus();
		}

		SqlConnection conn = new SqlConnection("Data Source=LAPTOP-2CGJEL3R; Initial Catalog=Amol Electrics; User id=rushi; Password=Yadav@1122");
		SqlCommand cmd;
		SqlDataReader read;
		SqlDataAdapter drr;
		string id;
		bool Mode = true;
		string sql;


		public void LoadData()
		{
			try
			{
				DateTime date = DateTime.Now.Date;
				sql = "SELECT * FROM customer_sells_data WHERE Date = @Date";
				cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@Date", date);
				conn.Open();
				read = cmd.ExecuteReader();

				drr = new SqlDataAdapter(sql, conn);
				dataGridView1.Rows.Clear();

				while (read.Read())
				{
					
					dataGridView1.Rows.Add(read[0], read[1], read[2], read[3], read[4]);
				}
				conn.Close();

			

			}
			catch(Exception ex) 
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void getId(String id) 
		{
			sql = "select * from customer_sells_data where Id = '" + id + "'";
			cmd = new SqlCommand(sql, conn);
			conn.Open();
			read = cmd.ExecuteReader();

			while(read.Read()) 
			{ 
				txtCustomer.Text = read[1].ToString();
				txtMaterial.Text = read[2].ToString();
				txtAmount.Text = read[3].ToString();
				dateTimePicker1.Text = read[4].ToString();
			}
			conn.Close();
		}








		// if the mode is true means add records otherwise update the records

		private void button1_Click(object sender, EventArgs e)
		{
			string name = txtCustomer.Text;
			string material = txtMaterial.Text;
			string amount = txtAmount.Text;
			string date = dateTimePicker1.Value.ToString("yyyy-MM-dd"); // Format the date


			if (Mode == true)
			{
				sql = "INSERT INTO customer_sells_data ([Customers Name],[Matterials Name],[Amount], [Date]) VALUES (@CustomersName,@MatterialsName,@Amount,@Date);";
				conn.Open();
				cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@CustomersName", name);
				cmd.Parameters.AddWithValue("@MatterialsName", material);
				cmd.Parameters.AddWithValue("@Amount", amount);
				cmd.Parameters.AddWithValue("@Date", date);
				MessageBox.Show("Record Added Successfully...!");
				cmd.ExecuteNonQuery();

				txtCustomer.Clear();
				txtMaterial.Clear();
				txtAmount.Clear();
				// txtCustomer.Focus();

			}
			else
			{
				id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
				sql = "update customer_sells_data set [Customers Name] = @CustomersName, [Matterials Name] = @MatterialsName, [Amount] = @Amount, [Date] = @Date where id = @id";
				conn.Open();
				cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@CustomersName", name);
				cmd.Parameters.AddWithValue("@MatterialsName", material);
				cmd.Parameters.AddWithValue("@Amount", amount);
				cmd.Parameters.AddWithValue("@Date", date);
				cmd.Parameters.AddWithValue("@id", id);

				MessageBox.Show("Record Updated Successfully...!");
				cmd.ExecuteNonQuery();

				txtCustomer.Clear();
				txtMaterial.Clear();
				txtAmount.Clear();
				// txtCustomer.Focus();
				button1.Text = "Save";
				Mode = true;

			}
			conn.Close();



		}

		private void button2_Click(object sender, EventArgs e)
		{
			txtCustomer.Clear();
			txtMaterial.Clear();
			txtAmount.Clear();
			// txtCustomer.Focus();
			button1.Text = "Save";
			Mode = true;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
			{
				Mode = false;
				id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
				getId(id);
				button1.Text = "Edit";
			}
			else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
			{
				Mode = false;
				id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
				sql = "delete from customer_sells_data where Id = @id ";
				conn.Open();
				cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@id", id);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Record Deleted Successfully...!");
				conn.Close();
			}



		}

		private void button3_Click(object sender, EventArgs e)
		{
			LoadData();
		}
		private void label1_Click(object sender, EventArgs e)
		{
			
		}
		private void Form1_LoadData(object sender, EventArgs e)
		{

		}
		private void SetupForm()
		{
			// Set the size of Form1
			this.Size = new Size(1739, 707);  // Adjust the width and height as needed

			// Other setup code...
			dataGridView1.Size = new Size(980,350);

		}
	}
}
