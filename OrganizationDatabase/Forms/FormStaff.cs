using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationDatabase.Forms
{
    public partial class FormStaff : Form
    {
        // SQL Connection String
        SqlConnection conn = new SqlConnection(@"Data Source=NICKS-COOL-LAPT;Initial Catalog=organizations;Integrated Security=True");
        public FormStaff()
        {
            InitializeComponent();
        }

        // Runs both the bind_data function and LoadTheme function when the form is first loaded
        private void FormStaff_Load(object sender, EventArgs e)
        {
            bind_data();
            LoadTheme();
        }

        // Bind_data function loads the data from the Organizations database and displays it in the dataGridView by defaulting to the select statement
        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("SELECT Staff_ID AS StaffID, fk_OrgID AS OrgID, Staff_First_Name AS FirstName, Staff_Last_Name AS LastName, Staff_Email AS Email, Staff_Phone AS PhoneNumber from StaffTable", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("arial", 8);
        }

        // Loads the style and theme colors for the child form buttons
        private void LoadTheme()
        {  
            // Loads the color theme for buttons
            buttonInsert.BackColor = Color.FromArgb(251, 137, 55);
            buttonInsert.ForeColor = Color.White;
            buttonSearch.BackColor = Color.FromArgb(251, 137, 55);
            buttonSearch.ForeColor = Color.White;
            buttonUpdate.BackColor = Color.FromArgb(251, 137, 55);
            buttonUpdate.ForeColor = Color.White;
            buttonDelete.BackColor = Color.FromArgb(251, 137, 55);
            buttonDelete.ForeColor = Color.White;
        }

        // When the Insert button is clicked, it runs an INSERT query to add the data the user entered into the StaffTable
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("INSERT INTO StaffTable(Staff_ID, fk_OrgID, Staff_First_Name, Staff_Last_Name, Staff_Email, Staff_Phone) VALUES(@Staff_ID, @fk_OrgID, @Staff_First_Name, @Staff_Last_Name, @Staff_Email, @Staff_Phone)", conn);
            cmd2.Parameters.AddWithValue("Staff_ID", textBox1.Text);
            cmd2.Parameters.AddWithValue("fk_OrgID", textBox7.Text);
            cmd2.Parameters.AddWithValue("Staff_First_Name", textBox2.Text);
            cmd2.Parameters.AddWithValue("Staff_Last_Name", textBox3.Text);
            cmd2.Parameters.AddWithValue("Staff_Email", textBox4.Text);
            cmd2.Parameters.AddWithValue("Staff_Phone", textBox5.Text);
            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();
            bind_data();

            // Clears the user input from each text box
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
        }

        // When the Update button is clicked, it runs an UPDATE query that updates any edited data within the StaffTable
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("UPDATE StaffTable SET Staff_First_Name=@Staff_First_Name, Staff_Last_Name=@Staff_Last_Name, Staff_Email=@Staff_Email, Staff_Phone=@Staff_Phone WHERE Staff_ID=@Staff_ID", conn);
            cmd3.Parameters.AddWithValue("Staff_ID", textBox1.Text);
            cmd3.Parameters.AddWithValue("Staff_First_Name", textBox2.Text);
            cmd3.Parameters.AddWithValue("Staff_Last_Name", textBox3.Text);
            cmd3.Parameters.AddWithValue("Staff_Email", textBox4.Text);
            cmd3.Parameters.AddWithValue("Staff_Phone", textBox5.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            conn.Open();
            cmd3.ExecuteNonQuery();
            conn.Close();
            bind_data();
        }

        // When the Delete button is clicked, it runs a DELETE query that deletes and removes a selected row from the StaffTable
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("DELETE FROM StaffTable WHERE Staff_ID=@Staff_ID", conn);
            cmd4.Parameters.AddWithValue("Staff_ID", textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            conn.Open();
            cmd4.ExecuteNonQuery();
            conn.Close();
            bind_data();
        }

        // When one of the rows within the dataGridView is clicked, it displays the information for that row automatically within the textboxes
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[index];
            textBox1.Text = selectedrow.Cells[0].Value.ToString();
            textBox7.Text = selectedrow.Cells[1].Value.ToString();
            textBox2.Text = selectedrow.Cells[2].Value.ToString();
            textBox3.Text = selectedrow.Cells[3].Value.ToString();
            textBox4.Text = selectedrow.Cells[4].Value.ToString();
            textBox5.Text = selectedrow.Cells[5].Value.ToString();
        }

        // When the Search button is clicked, it runs a SELECT query through the StaffTable based on the First or Last Name entered by the user
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT Staff_ID AS StaffID, fk_OrgID AS OrgID, Staff_First_Name AS FirstName, Staff_Last_Name AS LastName, Staff_Email AS Email, Staff_Phone AS PhoneNumber FROM VolTable WHERE Staff_Last_Name Like @LastName+ '%' OR Staff_First_Name Like @FirstName+ '%'", conn);
            cmd1.Parameters.AddWithValue("LastName", textBox6.Text);
            cmd1.Parameters.AddWithValue("FirstName", textBox6.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("arial", 8);
        }
    }
}
