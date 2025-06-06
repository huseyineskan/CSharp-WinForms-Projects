using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryForm
{
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=ACER\\SQLEXPRESS; Initial Catalog=LibraryTS; Integrated Security=True");

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            RefreshUserSection();
            RefreshBookSection();
            labelSelectedUserId.Text = "";
            labelSelectedUserId.Hide();

            labelSelectedBookId.Text = "";
            labelSelectedBookId.Hide();

            labelBookOwnerId.Text = "";
            labelBookOwnerId.Hide();

            labelAllUserSelectedId.Text = "";
            labelAllUserSelectedId.Hide();

        }

        private void RefreshUserSection()
        {
            // USER SECTION
            ListAllUsers();
            GetUserListToCombo();
        }

        private void RefreshBookSection()
        {
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
                AddUser(username, lastname, email, userPhone);
            else
                MessageBox.Show("There is a problem. Try again!");
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(labelSelectedUserId.Text, out int userId);

            if (isNumber)
            {
                string userFirstname = textUserFirstname.Text.Trim();
                string userLastname = textUserLastname.Text.Trim();
                string userEmail = textUserEmail.Text.Trim();
                bool phone = int.TryParse(textUserPhone.Text.Trim(), out int userPhone);

                if (phone && !string.IsNullOrEmpty(userFirstname) && !string.IsNullOrEmpty(userLastname) && !string.IsNullOrEmpty(userEmail))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE Users SET UserFirstname=@userFirstname, UserLastname=@userLastname, UserEmail=@userEmail, UserPhone=@userPhone WHERE UserId=@userId", connection);
                    command.Parameters.AddWithValue("@userFirstname", userFirstname);
                    command.Parameters.AddWithValue("@UserLastname", userLastname);
                    command.Parameters.AddWithValue("@UserEmail", userEmail);
                    command.Parameters.AddWithValue("@UserPhone", userPhone);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();

                    RefreshUserSection();
                    MessageBox.Show("User updated.");
                }
            }
            else
            {
                MessageBox.Show("Try again!");
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void DeleteUser()
        {
            bool isNumber = int.TryParse(labelSelectedUserId.Text, out int userId);

            if(isNumber)
            {
                if (!HasUserABook(userId))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE From Users WHERE UserId=@userId", connection);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.ExecuteNonQuery();

                    command.Dispose();
                    connection.Close();

                    RefreshUserSection();
                    ClearAllUserInputs();
                    MessageBox.Show("User Deleted.");
                }
                else
                {
                    MessageBox.Show("User has a book on loan. User cannot be deleted.");
                }
            }
            else
            {
                MessageBox.Show("Error. Try again.");
            }
        }

        private bool HasUserABook(int userId)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * From Books WHERE UserId=@userId", connection);
            command.Parameters.AddWithValue("@userId", userId);
            SqlDataReader reader = command.ExecuteReader();
            var result = reader.HasRows;
            command.Dispose();
            connection.Close();

            if (result)
                return true;

            return false;
        }

        public void AddUser(string username, string lastname, string useremail, int userphone)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Users (UserFirstname, UserLastname, UserEmail, UserPhone) VALUES (@userFirstname, @userLastname, @userEmail, @userPhone)", connection);
            command.Parameters.AddWithValue("@userFirstname", username);
            command.Parameters.AddWithValue("@userLastname", lastname);
            command.Parameters.AddWithValue("@userEmail", useremail);
            command.Parameters.AddWithValue("@userPhone", userphone);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();

            ClearAllUserInputs();
            RefreshUserSection();
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
            comboAllUserListBookSection.Items.Clear();

            while (reader.Read())
            {
                comboUserList.Items.Add(reader["UserFirstname"] + " " + reader["UserLastname"]);
                comboAllUserListBookSection.Items.Add(reader["UserFirstname"] + " " + reader["UserLastname"] + " - " + reader["UserId"]);
            }

            connection.Close();
        }

        void FillUserAutoInputs(int index = -1)
        {
            int selectedItem = index == -1 ? userDataGridView.SelectedCells[0].RowIndex : index;
            labelSelectedUserId.Text = userDataGridView.Rows[selectedItem].Cells[0].Value.ToString();
            textUserFirstname.Text = userDataGridView.Rows[selectedItem].Cells[1].Value.ToString();
            textUserLastname.Text = userDataGridView.Rows[selectedItem].Cells[2].Value.ToString();
            textUserEmail.Text = userDataGridView.Rows[selectedItem].Cells[3].Value.ToString();
            textUserPhone.Text = userDataGridView.Rows[selectedItem].Cells[4].Value.ToString();
            comboUserList.ResetText();

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
            ClearAllUserInputs();
        }

        private void ClearAllUserInputs()
        {
            textUserFirstname.Text = "";
            textUserLastname.Text = "";
            textUserEmail.Text = "";
            textUserPhone.Text = "";
            labelSelectedUserId.Text = "";
            listUserBooksList.Items.Clear();
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
            command.Dispose();
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
            adapter.Dispose();
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
            command.Dispose();
            connection.Close();
        }

        void FillBookAutoInputs(int index = -1)
        {
            int selectedItem = index == -1 ? bookDataGridView.SelectedCells[0].RowIndex : index;
            labelSelectedBookId.Text = bookDataGridView.Rows[selectedItem].Cells[0].Value.ToString();
            textBookName.Text = bookDataGridView.Rows[selectedItem].Cells[1].Value.ToString();
            textBookWriter.Text = bookDataGridView.Rows[selectedItem].Cells[2].Value.ToString();
            textBookstore.Text = bookDataGridView.Rows[selectedItem].Cells[3].Value.ToString();
            textBookYear.Text = bookDataGridView.Rows[selectedItem].Cells[4].Value.ToString();

            comboBookList.ResetText();
            comboAllUserListBookSection.ResetText();
            labelAllUserSelectedId.Text = "";


            bool isNumber = int.TryParse(bookDataGridView.Rows[selectedItem].Cells[6].Value.ToString(), out int userId);
            if(isNumber) 
                BorrowerOfTheBook(userId);
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
            ClearAllBookInputs();
        }

        private void ClearAllBookInputs() {
            textBookName.Text = "";
            textBookWriter.Text = "";
            textBookstore.Text = "";
            textBookYear.Text = "";
            labelSelectedBookId.Text = "";
            labelAllUserSelectedId.Text = "";
            comboUserBorrow.ResetText();
            comboUserBorrow.Items.Clear();
            comboBookList.ResetText();
            comboAllUserListBookSection.ResetText();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string bookname = textBookName.Text.Trim();
            string bookwriter = textBookWriter.Text.Trim();
            string bookstore = textBookstore.Text.Trim();
            bool year = int.TryParse(textBookYear.Text.Trim(), out int bookYear);

            if (year && !string.IsNullOrEmpty(bookname) && !string.IsNullOrEmpty(bookwriter) && !string.IsNullOrEmpty(bookstore))
            {
                AddBook(bookname, bookwriter, bookstore, bookYear);
            }
            else
            {
                MessageBox.Show("There is a problem. Try again!");
            }
        }

        public void AddBook(string bookname, string bookwriter, string bookstore, int bookYear)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Books (BookName, BookWriter, Bookstore, BookYear, BookStatus, UserId) VALUES (@bookName, @bookWriter, @bookstore, @bookYear, @bookStatus, @userId)", connection);
            command.Parameters.AddWithValue("@bookName", bookname);
            command.Parameters.AddWithValue("@bookWriter", bookwriter);
            command.Parameters.AddWithValue("@bookstore", bookstore);
            command.Parameters.AddWithValue("@bookYear", bookYear);
            command.Parameters.AddWithValue("@bookStatus", 1);
            command.Parameters.AddWithValue("@userId", 0);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();

            RefreshBookSection();
            MessageBox.Show("Book added.");
        }

        void BorrowerOfTheBook(int userId)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE UserId=@userId", connection);
            command.Parameters.AddWithValue("@userId", userId);
            SqlDataReader reader = command.ExecuteReader();
            comboUserBorrow.Items.Clear();
            comboUserBorrow.ResetText();

            while (reader.Read())
            {
                comboUserBorrow.Items.Add(reader["UserFirstname"] + ", " + reader["UserLastname"]);
                comboUserBorrow.SelectedIndex = 0;
                labelBookOwnerId.Text = reader["UserId"].ToString();
            }

            command.Dispose();
            connection.Close();
        }

        void LendTheBook(int bookId, int userId)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT UserId From Books WHERE UserId=@userId", connection);
            command.Parameters.AddWithValue("@userId", userId);
            SqlDataReader reader = command.ExecuteReader();
            var result = reader.HasRows;
            command.Dispose();
            connection.Close();

            if (!result)
            {
                connection.Open();
                command = new SqlCommand("Update Books SET BookStatus=@bookStatus, UserId=@userId WHERE BookId=@bookId", connection);
                command.Parameters.AddWithValue("@bookStatus", 0);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@bookId", bookId);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

                ListAllBooks();
                ClearAllBookInputs();
                MessageBox.Show("The book was loaned.");
            }
            else
            {
                MessageBox.Show("The book is somewhere else!");
            }
        }

        void ReturnTheBook(int bookId)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Update Books SET BookStatus=@bookStatus, UserId=@userId WHERE BookId=@bookId", connection);
            command.Parameters.AddWithValue("@bookStatus", 1);
            command.Parameters.AddWithValue("@userId", 0);
            command.Parameters.AddWithValue("@bookId", bookId);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();

            ListAllBooks();
            ClearAllBookInputs();
            MessageBox.Show("The book was returned.");
        }

        private void btnLendTheBook_Click(object sender, EventArgs e)
        {
            // Get user information and ID
            bool isNumberUserId = int.TryParse(labelAllUserSelectedId.Text, out int userId);

            // Get book information
            bool isNumberBookId = int.TryParse(labelSelectedBookId.Text, out int bookId);

            if (isNumberUserId && isNumberBookId)
            {
                LendTheBook(bookId, userId);
            }
            else
            {
                MessageBox.Show("The is a problem. Try again!");
            }
        }

        private void btnReturnTheBook_Click(object sender, EventArgs e)
        {
            // Get book information
            int bookId = int.Parse(labelSelectedBookId.Text);

            if (bookId > 0)
                ReturnTheBook(bookId);
        }

        private void comboAllUserListBookSection_SelectedValueChanged(object sender, EventArgs e)
        {
            string nameStr = comboAllUserListBookSection.SelectedItem.ToString();
            string[] words = nameStr.Split(' ');
            bool isNumber = int.TryParse(words[words.Length - 1], out int userId);
            
            if(isNumber) labelAllUserSelectedId.Text = userId.ToString();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DeleteBook();
        }

        private void DeleteBook()
        {
            bool isNumber = int.TryParse(labelSelectedBookId.Text, out int bookId);

            if (isNumber)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE From Books WHERE BookId=@bookId", connection);
                command.Parameters.AddWithValue("@bookId", bookId);
                command.ExecuteNonQuery();

                command.Dispose();
                connection.Close();

                RefreshBookSection();
                ClearAllBookInputs();
                MessageBox.Show("Book Deleted.");
            }
            else
            {
                MessageBox.Show("Error. Please try again!");
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(labelSelectedBookId.Text, out int bookId);

            if (isNumber)
            {
                string bookName = textBookName.Text.Trim();
                string bookWriter = textBookWriter.Text.Trim();
                string bookstore = textBookstore.Text.Trim();

                bool isNumberYear = int.TryParse(textBookYear.Text.Trim(), out int bookYear);

                if (isNumberYear && !string.IsNullOrEmpty(bookName) && !string.IsNullOrEmpty(bookWriter) && !string.IsNullOrEmpty(bookstore))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE Books SET BookName=@bookName, BookWriter=@bookWriter, Bookstore=@bookstore, BookYear=@bookYear WHERE BookId=@bookId", connection);
                    command.Parameters.AddWithValue("@bookName", bookName);
                    command.Parameters.AddWithValue("@bookWriter", bookWriter);
                    command.Parameters.AddWithValue("@bookstore", bookstore);
                    command.Parameters.AddWithValue("@bookYear", bookYear);
                    command.Parameters.AddWithValue("@bookId", bookId);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();

                    RefreshBookSection();
                    MessageBox.Show("Book updated.");
                }
                else
                {
                    MessageBox.Show("Error. Try again!");
                }
            }
            else
            {
                MessageBox.Show("Try again!");
            }
        }
    }
}
