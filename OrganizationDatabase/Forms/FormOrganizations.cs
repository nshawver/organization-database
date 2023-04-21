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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace OrganizationDatabase.Forms
{
    public partial class FormOrganizations : Form
    {
        // SQL Connection String
        SqlConnection conn = new SqlConnection(@"Data Source=NICKS-COOL-LAPT;Initial Catalog=organizations;Integrated Security=True");
        public FormOrganizations()
        {
            InitializeComponent();
        }

        // Bind_data function loads the data from the Organizations database and displays it in the dataGridView by defaulting to the select statement
        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("SELECT OrgID AS ID, OrgName AS Organization, City, Country, StreetAddress AS Address from OrgTable", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("arial", 8);
        }

        // Runs both the bind_data function and LoadTheme function when the form is first loaded
        private void FormOrganizations_Load(object sender, EventArgs e)
        {
            bind_data();
            LoadTheme();
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

        // When the Insert button is clicked, it runs an INSERT query to add the data the user entered into the OrgTable
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("INSERT INTO OrgTable(OrgID, OrgName, City, Country, StreetAddress) VALUES(@OrgID, @OrgName, @City, @Country, @StreetAddress)", conn);
            cmd2.Parameters.AddWithValue("OrgID", textBox1.Text);
            cmd2.Parameters.AddWithValue("City", textBox3.Text);
            cmd2.Parameters.AddWithValue("Country", textBox4.Text);
            cmd2.Parameters.AddWithValue("StreetAddress", textBox5.Text);
            cmd2.Parameters.AddWithValue("OrgName", textBox2.Text);
            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();
            bind_data();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        // When the Update button is clicked, it runs an UPDATE query that updates any edited data within the OrgTable
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("UPDATE OrgTable SET OrgName=@OrgName, City=@City, Country=@Country, StreetAddress=@StreetAddress WHERE OrgID=@OrgID", conn);

            cmd3.Parameters.AddWithValue("OrgID", textBox1.Text);
            cmd3.Parameters.AddWithValue("OrgName", textBox2.Text);
            cmd3.Parameters.AddWithValue("City", textBox3.Text);
            cmd3.Parameters.AddWithValue("Country", textBox4.Text);
            cmd3.Parameters.AddWithValue("StreetAddress", textBox5.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            conn.Open();
            cmd3.ExecuteNonQuery();
            conn.Close();
            bind_data();
        }

        // When the Delete button is clicked, it runs a DELETE query that deletes and removes a selected row from the OrgTable
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("DELETE FROM OrgTable WHERE OrgID=@OrgID", conn);
            cmd4.Parameters.AddWithValue("OrgID", textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
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
            textBox2.Text = selectedrow.Cells[1].Value.ToString();
            textBox3.Text = selectedrow.Cells[2].Value.ToString();
            textBox4.Text = selectedrow.Cells[3].Value.ToString();
            textBox5.Text = selectedrow.Cells[4].Value.ToString();
        }

        // When the Search button is clicked, it runs a SELECT query through the OrgTable based on the Organization Name entered by the user
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT OrgID AS ID, OrgName AS Organization, City, Country, StreetAddress AS Address FROM OrgTable WHERE OrgName Like @Organization+ '%'", conn);
            cmd1.Parameters.AddWithValue("Organization", textBox6.Text);
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
