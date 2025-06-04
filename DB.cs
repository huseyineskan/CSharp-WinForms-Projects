using System;

public class DB
{
	public DB()
	{
		SqlConnection connection = new SqlConnection("Data Source=ACER\\SQLEXPRESS; Initial Catalog=LibraryDB; Integrated Security=True");
	}

	public AddUser()
	{
		connection.Open();
		SqlCommand command = new SqlCommand("INSERT INTO Users (UserFirstname, UserLastname, UserEmail, UserPhone) VALUES (@userFirstname, @userLastname, @userEmail, @userPhone)", connection);
		command.Parameters.AddWithValue("@userFirstname", username);
        command.Parameters.AddWithValue("@userLastname", lastname);
        command.Parameters.AddWithValue("@userEmail", useremail);
        command.Parameters.AddWithValue("@userPhone", userphone);
		command.ExecuteNonQuery();
		connection.Close();

		MessageBox.Show("User added.");

    }
}
