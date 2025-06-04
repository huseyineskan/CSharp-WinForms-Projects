using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryForm
{
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            InitializeComponent();
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            ListAllUsers();
            GetUserListToCombo();

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = textUserFirstname.Text.Trim();
            string lastname = textUserLastname.Text.Trim();
            string email = textUserEmail.Text.Trim();
            bool phone = int.TryParse(textUserPhone.Text.Trim(), out int userPhone);
            
            if(phone && !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(lastname) && !string.IsNullOrEmpty(email))
            {
                AddUser(username, lastname, email, userPhone);
            }
            else
            {
                MessageBox.Show("There is a problem. Try again!");
            }
        }

        // Methods

        SqlConnection connection = new SqlConnection("Data Source=ACER\\SQLEXPRESS; Initial Catalog=LibraryTS; Integrated Security=True");

        public void AddUser(string username, string lastname, string useremail, int userphone)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Users (UserFirstname, UserLastname, UserEmail, UserPhone) VALUES (@userFirstname, @userLastname, @userEmail, @userPhone)", connection);
            command.Parameters.AddWithValue("@userFirstname", username);
            command.Parameters.AddWithValue("@userLastname", lastname);
            command.Parameters.AddWithValue("@userEmail", useremail);
            command.Parameters.AddWithValue("@userPhone", userphone);
            command.ExecuteNonQuery();
            connection.Close();
            ListAllUsers();
            GetUserListToCombo();
            MessageBox.Show("User added.");
        }

        public void ListAllUsers()
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            userDataGridView.DataSource = table;
            connection.Close();
        }

        public void GetUserListToCombo()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Users", connection);
            SqlDataReader reader = command.ExecuteReader();
            comboUserList.Items.Clear();

            while (reader.Read())
            {
                comboUserList.Items.Add(reader["UserFirstname"] + " " + reader["UserLastname"]);
            }

            connection.Close();
        }

        void FillAutoInputs(int index = 0)
        {
            int selectedItem = index == 0 ? userDataGridView.SelectedCells[0].RowIndex : index;
            textUserFirstname.Text = userDataGridView.Rows[selectedItem].Cells[1].Value.ToString();
            textUserLastname.Text = userDataGridView.Rows[selectedItem].Cells[2].Value.ToString();
            textUserEmail.Text = userDataGridView.Rows[selectedItem].Cells[3].Value.ToString();
            textUserPhone.Text = userDataGridView.Rows[selectedItem].Cells[4].Value.ToString();
        }

        private void userDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FillAutoInputs();
        }

        private void comboUserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillAutoInputs((int)comboUserList.SelectedIndex);
        }
    }

}
