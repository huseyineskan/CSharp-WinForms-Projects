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
            // USER SECTION
            ListAllUsers();
            GetUserListToCombo();

            //BOOK SECTION
            ListAllBooks();
            GetBookListToCombo();
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

        void FillUserAutoInputs(int index = 0)
        {
            int selectedItem = index == 0 ? userDataGridView.SelectedCells[0].RowIndex : index;
            textUserFirstname.Text = userDataGridView.Rows[selectedItem].Cells[1].Value.ToString();
            textUserLastname.Text = userDataGridView.Rows[selectedItem].Cells[2].Value.ToString();
            textUserEmail.Text = userDataGridView.Rows[selectedItem].Cells[3].Value.ToString();
            textUserPhone.Text = userDataGridView.Rows[selectedItem].Cells[4].Value.ToString();

            int userId = int.Parse(userDataGridView.Rows[selectedItem].Cells[0].Value.ToString());
            GetUserAllBooks(userId);
        }

        private void userDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FillUserAutoInputs();
        }

        private void comboUserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillUserAutoInputs((int)comboUserList.SelectedIndex);
        }

        private void btnClearUserInputs_Click(object sender, EventArgs e)
        {
            textUserFirstname.Text = "";
            textUserLastname.Text = "";
            textUserEmail.Text = "";
            textUserPhone.Text = "";
            comboUserList.ResetText();
        }

        void GetUserAllBooks(int userId)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Books WHERE UserId=@userId", connection);
            command.Parameters.AddWithValue("@userId", userId);
            SqlDataReader reader = command.ExecuteReader();
            listUserBooksList.Items.Clear();

            while (reader.Read())
            {
                listUserBooksList.Items.Add(reader["BookName"] + ", " + reader["BookWriter"] + ", " + reader["BookYear"]);
            }
            connection.Close();
        }

        //BOOK SECTION
        public void ListAllBooks()
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Books", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            bookDataGridView.DataSource = table;
            connection.Close();
        }

        public void GetBookListToCombo()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Books", connection);
            SqlDataReader reader = command.ExecuteReader();
            comboBookList.Items.Clear();

            while (reader.Read())
            {
                comboBookList.Items.Add(reader["BookName"] + ", " + reader["BookWriter"] + ", " + reader["BookYear"]);
            }

            connection.Close();
        }

        void FillBookAutoInputs(int index = 0)
        {
            int selectedItem = index == 0 ? bookDataGridView.SelectedCells[0].RowIndex : index;
            textBookName.Text = bookDataGridView.Rows[selectedItem].Cells[1].Value.ToString();
            textBookWriter.Text = bookDataGridView.Rows[selectedItem].Cells[2].Value.ToString();
            textBookstore.Text = bookDataGridView.Rows[selectedItem].Cells[3].Value.ToString();
            textBookYear.Text = bookDataGridView.Rows[selectedItem].Cells[4].Value.ToString();
        }

        private void comboBookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillBookAutoInputs((int)comboBookList.SelectedIndex);
        }

        private void bookDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FillBookAutoInputs();
        }

        private void btnClearBookInputs_Click(object sender, EventArgs e)
        {
            textBookName.Text = "";
            textBookWriter.Text = "";
            textBookstore.Text = "";
            textBookYear.Text = "";
            comboBookList.ResetText();
        }
    }
}
