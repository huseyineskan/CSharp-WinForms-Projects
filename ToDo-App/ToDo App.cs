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
            GetAllTasks();

            MessageBox.Show("Task added.");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = textTitle.Text;
            string description = textDescription.Text;
            bool status = radioYes.Checked ? true: false;
            AddATask(title, description, status);            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int taskId;
            bool taskIdinput = int.TryParse(textTaskId.Text, out taskId);

            string title = textTitle.Text.Trim();
            string description = textDescription.Text.Trim();
            bool status = radioYes.Checked ? true : false;

            if (taskIdinput && chechTask(taskId))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Tasks SET Title=@title, Description=@description, Status=@status WHERE Id=@id", connection);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@id", taskId);
                command.ExecuteNonQuery();
                connection.Close();
                GetAllTasks();
            }
            else
            {
                MessageBox.Show("Please enter a valid task id!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool taskIdinput = int.TryParse(textTaskId.Text, out int taskId);

            if(taskIdinput && chechTask(taskId))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Tasks WHERE Id=@id", connection);
                command.Parameters.AddWithValue("@id", taskId);
                command.ExecuteNonQuery();
                connection.Close();
                GetAllTasks();
                MessageBox.Show("The task was deleted. ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid task id!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool chechTask(int taskId)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Tasks WHERE Id = @id", connection);
            command.Parameters.AddWithValue("id", taskId);
            SqlDataReader reader = command.ExecuteReader();
            bool exists = reader.HasRows;

            reader.Close();
            connection.Close();

            return exists;

        }

        private void btnCleanInputs_Click(object sender, EventArgs e)
        {
            textTaskId.Text = null;
            textTitle.Text = null;
            textDescription.Text = null;
            radioYes.Checked = true;
        }

        private void dataViewPanel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedCell = dataViewPanel.SelectedCells[0].RowIndex;
            textTaskId.Text = dataViewPanel.Rows[selectedCell].Cells[0].Value.ToString();
            textTitle.Text = dataViewPanel.Rows[selectedCell].Cells[1].Value.ToString();
            textDescription.Text = dataViewPanel.Rows[selectedCell].Cells[2].Value.ToString();

            if (dataViewPanel.Rows[selectedCell].Cells[4].Value.ToString().Trim() == "False")
            {
                radioNo.Checked = true;
            }
            else
            {
                radioYes.Checked = true;
            }

        }
    }
}
