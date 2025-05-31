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

namespace ToDo_App
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=ACER\\SQLEXPRESS; Initial Catalog=ToDoAppDb; Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllTasks();
        }
        void GetAllTasks()
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Tasks", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataViewPanel.DataSource = table;
            connection.Close();
        }

        void AddATask(string title, string description, bool status)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Tasks (Title, Description, Status) VALUES (@title, @description, @status)", connection);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@status", status);
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Task added.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textTitle.Text;
            string description = textDescription.Text;

            AddATask(title, description, false);
            GetAllTasks();
        }
    }
}
