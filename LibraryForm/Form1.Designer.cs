namespace LibraryForm
{
    partial class LibraryForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSelectedUserId = new System.Windows.Forms.Label();
            this.listUserBooksList = new System.Windows.Forms.ListBox();
            this.btnClearUserInputs = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.comboUserList = new System.Windows.Forms.ComboBox();
            this.textUserEmail = new System.Windows.Forms.TextBox();
            this.textUserPhone = new System.Windows.Forms.TextBox();
            this.textUserLastname = new System.Windows.Forms.TextBox();
            this.textUserFirstname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelAllUserSelectedId = new System.Windows.Forms.Label();
            this.labelBookOwnerId = new System.Windows.Forms.Label();
            this.labelSelectedBookId = new System.Windows.Forms.Label();
            this.comboAllUserListBookSection = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnReturnTheBook = new System.Windows.Forms.Button();
            this.btnLendTheBook = new System.Windows.Forms.Button();
            this.comboUserBorrow = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClearBookInputs = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.comboBookList = new System.Windows.Forms.ComboBox();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.textBookstore = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.textBookYear = new System.Windows.Forms.TextBox();
            this.textBookWriter = new System.Windows.Forms.TextBox();
            this.textBookName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bookDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSelectedUserId);
            this.groupBox1.Controls.Add(this.listUserBooksList);
            this.groupBox1.Controls.Add(this.btnClearUserInputs);
            this.groupBox1.Controls.Add(this.btnDeleteUser);
            this.groupBox1.Controls.Add(this.btnUpdateUser);
            this.groupBox1.Controls.Add(this.btnAddUser);
            this.groupBox1.Controls.Add(this.comboUserList);
            this.groupBox1.Controls.Add(this.textUserEmail);
            this.groupBox1.Controls.Add(this.textUserPhone);
            this.groupBox1.Controls.Add(this.textUserLastname);
            this.groupBox1.Controls.Add(this.textUserFirstname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USER SECTION";
            // 
            // labelSelectedUserId
            // 
            this.labelSelectedUserId.AutoSize = true;
            this.labelSelectedUserId.Location = new System.Drawing.Point(321, 173);
            this.labelSelectedUserId.Name = "labelSelectedUserId";
            this.labelSelectedUserId.Size = new System.Drawing.Size(55, 20);
            this.labelSelectedUserId.TabIndex = 6;
            this.labelSelectedUserId.Text = "userId";
            // 
            // listUserBooksList
            // 
            this.listUserBooksList.FormattingEnabled = true;
            this.listUserBooksList.ItemHeight = 20;
            this.listUserBooksList.Location = new System.Drawing.Point(108, 76);
            this.listUserBooksList.Name = "listUserBooksList";
            this.listUserBooksList.Size = new System.Drawing.Size(609, 84);
            this.listUserBooksList.TabIndex = 5;
            // 
            // btnClearUserInputs
            // 
            this.btnClearUserInputs.Location = new System.Drawing.Point(593, 259);
            this.btnClearUserInputs.Name = "btnClearUserInputs";
            this.btnClearUserInputs.Size = new System.Drawing.Size(124, 47);
            this.btnClearUserInputs.TabIndex = 3;
            this.btnClearUserInputs.Text = "Clear Inputs";
            this.btnClearUserInputs.UseVisualStyleBackColor = true;
            this.btnClearUserInputs.Click += new System.EventHandler(this.btnClearUserInputs_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(437, 259);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(124, 47);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(268, 259);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(124, 47);
            this.btnUpdateUser.TabIndex = 3;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(108, 259);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(124, 47);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // comboUserList
            // 
            this.comboUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboUserList.FormattingEnabled = true;
            this.comboUserList.Location = new System.Drawing.Point(109, 35);
            this.comboUserList.Name = "comboUserList";
            this.comboUserList.Size = new System.Drawing.Size(608, 28);
            this.comboUserList.TabIndex = 2;
            this.comboUserList.SelectedIndexChanged += new System.EventHandler(this.comboUserList_SelectedIndexChanged);
            // 
            // textUserEmail
            // 
            this.textUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textUserEmail.Location = new System.Drawing.Point(108, 206);
            this.textUserEmail.Name = "textUserEmail";
            this.textUserEmail.Size = new System.Drawing.Size(241, 27);
            this.textUserEmail.TabIndex = 1;
            // 
            // textUserPhone
            // 
            this.textUserPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textUserPhone.Location = new System.Drawing.Point(469, 206);
            this.textUserPhone.Name = "textUserPhone";
            this.textUserPhone.Size = new System.Drawing.Size(248, 27);
            this.textUserPhone.TabIndex = 1;
            // 
            // textUserLastname
            // 
            this.textUserLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textUserLastname.Location = new System.Drawing.Point(469, 166);
            this.textUserLastname.Name = "textUserLastname";
            this.textUserLastname.Size = new System.Drawing.Size(248, 27);
            this.textUserLastname.TabIndex = 1;
            // 
            // textUserFirstname
            // 
            this.textUserFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textUserFirstname.Location = new System.Drawing.Point(108, 166);
            this.textUserFirstname.Name = "textUserFirstname";
            this.textUserFirstname.Size = new System.Drawing.Size(241, 27);
            this.textUserFirstname.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(37, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "E-Post:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(404, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(382, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(13, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Firstname:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(0, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "User Books:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 304);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "USER LIST";
            // 
            // userDataGridView
            // 
            this.userDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.userDataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDataGridView.Location = new System.Drawing.Point(3, 18);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowHeadersWidth = 51;
            this.userDataGridView.RowTemplate.Height = 24;
            this.userDataGridView.Size = new System.Drawing.Size(732, 283);
            this.userDataGridView.TabIndex = 0;
            this.userDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGridView_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelAllUserSelectedId);
            this.groupBox3.Controls.Add(this.labelBookOwnerId);
            this.groupBox3.Controls.Add(this.labelSelectedBookId);
            this.groupBox3.Controls.Add(this.comboAllUserListBookSection);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btnReturnTheBook);
            this.groupBox3.Controls.Add(this.btnLendTheBook);
            this.groupBox3.Controls.Add(this.comboUserBorrow);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnClearBookInputs);
            this.groupBox3.Controls.Add(this.btnDeleteBook);
            this.groupBox3.Controls.Add(this.comboBookList);
            this.groupBox3.Controls.Add(this.btnUpdateBook);
            this.groupBox3.Controls.Add(this.textBookstore);
            this.groupBox3.Controls.Add(this.btnAddBook);
            this.groupBox3.Controls.Add(this.textBookYear);
            this.groupBox3.Controls.Add(this.textBookWriter);
            this.groupBox3.Controls.Add(this.textBookName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(781, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(781, 321);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BOOK SECTION";
            // 
            // labelAllUserSelectedId
            // 
            this.labelAllUserSelectedId.AutoSize = true;
            this.labelAllUserSelectedId.Location = new System.Drawing.Point(367, 122);
            this.labelAllUserSelectedId.Name = "labelAllUserSelectedId";
            this.labelAllUserSelectedId.Size = new System.Drawing.Size(55, 20);
            this.labelAllUserSelectedId.TabIndex = 12;
            this.labelAllUserSelectedId.Text = "userId";
            // 
            // labelBookOwnerId
            // 
            this.labelBookOwnerId.AutoSize = true;
            this.labelBookOwnerId.Location = new System.Drawing.Point(365, 81);
            this.labelBookOwnerId.Name = "labelBookOwnerId";
            this.labelBookOwnerId.Size = new System.Drawing.Size(55, 20);
            this.labelBookOwnerId.TabIndex = 11;
            this.labelBookOwnerId.Text = "userId";
            // 
            // labelSelectedBookId
            // 
            this.labelSelectedBookId.AutoSize = true;
            this.labelSelectedBookId.Location = new System.Drawing.Point(369, 165);
            this.labelSelectedBookId.Name = "labelSelectedBookId";
            this.labelSelectedBookId.Size = new System.Drawing.Size(57, 20);
            this.labelSelectedBookId.TabIndex = 7;
            this.labelSelectedBookId.Text = "bookId";
            // 
            // comboAllUserListBookSection
            // 
            this.comboAllUserListBookSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboAllUserListBookSection.FormattingEnabled = true;
            this.comboAllUserListBookSection.Location = new System.Drawing.Point(109, 119);
            this.comboAllUserListBookSection.Name = "comboAllUserListBookSection";
            this.comboAllUserListBookSection.Size = new System.Drawing.Size(284, 28);
            this.comboAllUserListBookSection.TabIndex = 10;
            this.comboAllUserListBookSection.SelectedValueChanged += new System.EventHandler(this.comboAllUserListBookSection_SelectedValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(44, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "Users:";
            // 
            // btnReturnTheBook
            // 
            this.btnReturnTheBook.Location = new System.Drawing.Point(428, 76);
            this.btnReturnTheBook.Name = "btnReturnTheBook";
            this.btnReturnTheBook.Size = new System.Drawing.Size(181, 30);
            this.btnReturnTheBook.TabIndex = 8;
            this.btnReturnTheBook.Text = "Return the book";
            this.btnReturnTheBook.UseVisualStyleBackColor = true;
            this.btnReturnTheBook.Click += new System.EventHandler(this.btnReturnTheBook_Click);
            // 
            // btnLendTheBook
            // 
            this.btnLendTheBook.Location = new System.Drawing.Point(428, 117);
            this.btnLendTheBook.Name = "btnLendTheBook";
            this.btnLendTheBook.Size = new System.Drawing.Size(181, 30);
            this.btnLendTheBook.TabIndex = 8;
            this.btnLendTheBook.Text = "Lend the book";
            this.btnLendTheBook.UseVisualStyleBackColor = true;
            this.btnLendTheBook.Click += new System.EventHandler(this.btnLendTheBook_Click);
            // 
            // comboUserBorrow
            // 
            this.comboUserBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboUserBorrow.FormattingEnabled = true;
            this.comboUserBorrow.Location = new System.Drawing.Point(109, 78);
            this.comboUserBorrow.Name = "comboUserBorrow";
            this.comboUserBorrow.Size = new System.Drawing.Size(284, 28);
            this.comboUserBorrow.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(44, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "User:";
            // 
            // btnClearBookInputs
            // 
            this.btnClearBookInputs.Location = new System.Drawing.Point(594, 259);
            this.btnClearBookInputs.Name = "btnClearBookInputs";
            this.btnClearBookInputs.Size = new System.Drawing.Size(124, 47);
            this.btnClearBookInputs.TabIndex = 3;
            this.btnClearBookInputs.Text = "Clear Inputs";
            this.btnClearBookInputs.UseVisualStyleBackColor = true;
            this.btnClearBookInputs.Click += new System.EventHandler(this.btnClearBookInputs_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(438, 259);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(124, 47);
            this.btnDeleteBook.TabIndex = 3;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            // 
            // comboBookList
            // 
            this.comboBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBookList.FormattingEnabled = true;
            this.comboBookList.Location = new System.Drawing.Point(109, 35);
            this.comboBookList.Name = "comboBookList";
            this.comboBookList.Size = new System.Drawing.Size(649, 28);
            this.comboBookList.TabIndex = 2;
            this.comboBookList.SelectedIndexChanged += new System.EventHandler(this.comboBookList_SelectedIndexChanged);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(269, 259);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(124, 47);
            this.btnUpdateBook.TabIndex = 3;
            this.btnUpdateBook.Text = "Update";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            // 
            // textBookstore
            // 
            this.textBookstore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBookstore.Location = new System.Drawing.Point(106, 206);
            this.textBookstore.Name = "textBookstore";
            this.textBookstore.Size = new System.Drawing.Size(288, 27);
            this.textBookstore.TabIndex = 1;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(109, 259);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(124, 47);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // textBookYear
            // 
            this.textBookYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBookYear.Location = new System.Drawing.Point(494, 206);
            this.textBookYear.Name = "textBookYear";
            this.textBookYear.Size = new System.Drawing.Size(261, 27);
            this.textBookYear.TabIndex = 1;
            // 
            // textBookWriter
            // 
            this.textBookWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBookWriter.Location = new System.Drawing.Point(491, 158);
            this.textBookWriter.Name = "textBookWriter";
            this.textBookWriter.Size = new System.Drawing.Size(264, 27);
            this.textBookWriter.TabIndex = 1;
            // 
            // textBookName
            // 
            this.textBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBookName.Location = new System.Drawing.Point(106, 158);
            this.textBookName.Name = "textBookName";
            this.textBookName.Size = new System.Drawing.Size(287, 27);
            this.textBookName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(9, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bookstore:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(436, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Year:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(424, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Writer:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(41, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(44, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Books:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bookDataGridView);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox4.Location = new System.Drawing.Point(781, 355);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(781, 304);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BOOK LIST";
            // 
            // bookDataGridView
            // 
            this.bookDataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookDataGridView.Location = new System.Drawing.Point(3, 19);
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.RowHeadersWidth = 51;
            this.bookDataGridView.RowTemplate.Height = 24;
            this.bookDataGridView.Size = new System.Drawing.Size(775, 282);
            this.bookDataGridView.TabIndex = 0;
            this.bookDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookDataGridView_CellDoubleClick);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 671);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "LibraryForm";
            this.Text = "Library Tracking System";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboUserList;
        private System.Windows.Forms.TextBox textUserEmail;
        private System.Windows.Forms.TextBox textUserPhone;
        private System.Windows.Forms.TextBox textUserLastname;
        private System.Windows.Forms.TextBox textUserFirstname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBookList;
        private System.Windows.Forms.TextBox textBookstore;
        private System.Windows.Forms.TextBox textBookYear;
        private System.Windows.Forms.TextBox textBookWriter;
        private System.Windows.Forms.TextBox textBookName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView bookDataGridView;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnClearUserInputs;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnClearBookInputs;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listUserBooksList;
        private System.Windows.Forms.Button btnReturnTheBook;
        private System.Windows.Forms.Button btnLendTheBook;
        private System.Windows.Forms.ComboBox comboUserBorrow;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboAllUserListBookSection;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelSelectedUserId;
        private System.Windows.Forms.Label labelSelectedBookId;
        private System.Windows.Forms.Label labelBookOwnerId;
        private System.Windows.Forms.Label labelAllUserSelectedId;
    }
}
