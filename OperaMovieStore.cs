using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OperaStore
{
   public class OperaMovieStore
    {
        //Connection string
        string connectionString = "Data Source = DESKTOP-A9K2FMI;Initial Catalog = Opera; Integrated Security = True";
        // connection variable
        SqlConnection sqlConnection;
        // reader object to read data from command object
        SqlDataReader sqlReader;
        // command object
        SqlCommand sqlCommand;
        string SQLQuery = ""; // for query strings
        public OperaMovieStore()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand();
        }
       
        

        // Retrive All Rented Records
        public DataTable _GetRentalData()
        {
            DataTable dtRentalData = new DataTable();
            try
            {
                sqlCommand.Connection = sqlConnection;
                SQLQuery = "SELECT * FROM RentedMovies Order by RMID DESC";
                sqlCommand.CommandText = SQLQuery;
                sqlConnection.Open();
                sqlReader = sqlCommand.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    dtRentalData.Load(sqlReader);
                }
                return dtRentalData;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return null;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }
        }
        // this method adds new rented movie in rented movies table
        public void _AddNewRentedMovie(int MovieIDFK, int CustIDFK, DateTime dateRented, int copies, int rented)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.Connection = sqlConnection;
                SQLQuery = "INSERT INTO RentedMovies(MovieIDFK, CustIDFK, DateRented,Rented) VALUES (@MovieIDFK,@CustIDFK,@DateRented,@Rented)";
                sqlCommand.Parameters.AddWithValue("@MovieIDFK", MovieIDFK);
                sqlCommand.Parameters.AddWithValue("@CustIDFK", CustIDFK);
                sqlCommand.Parameters.AddWithValue("@DateRented", dateRented);
                sqlCommand.Parameters.AddWithValue("@Rented", rented);
                sqlCommand.CommandText = SQLQuery;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }

        }
        // Select Top Customer from OperaStore
        // by counting no of movies rented by the customer
        public void _SelectTopCustomerFromStore()
        {
            int best = 0, maximum = 0, total = 0;
            string sqlQuery = "";
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.Connection = sqlConnection;
                string Val = "Select IDENT_CURRENT('Customer')";
                sqlCommand.CommandText = Val;
                sqlConnection.Open();
                total = Convert.ToInt32(sqlCommand.ExecuteScalar());
                for (int i = 1; i <= total; i++)
                {
                    sqlQuery = "select Count(*) from RentedMovies where CustIDFK= '" + i + "'";
                    sqlCommand.CommandText = sqlQuery;
                    int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    if (count > maximum)
                    {
                        maximum = count;
                        best = i;
                    }
                }
                this.SQLQuery = "Select FirstName from Customer where CustID ='" + best + "'";
                this.sqlCommand.CommandText = this.SQLQuery;
                String FirstName = Convert.ToString(sqlCommand.ExecuteScalar());
                MessageBox.Show("Customer who gets more frequently movies on rent is : " + FirstName + "\nHe has rented: " + maximum+" Movies", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Database Exception " + exception.Message);
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }

        }


        // Select Top Movie in Opera Store
        public void _SelectTopMovieFromStore()
        {
            int best = 0, Max = 0, Total = 0;
            string sqlQ = "";
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.Connection = sqlConnection;
                string Val = "Select IDENT_CURRENT('Movies')";

                sqlCommand.CommandText = Val;
                sqlConnection.Open();
                Total = Convert.ToInt32(sqlCommand.ExecuteScalar());

                for (int i = 1; i <= Total; i++)
                {

                    sqlQ = "select Count(*) from RentedMovies where MovieIDFK= '" + i + "'";


                    sqlCommand.CommandText = sqlQ;
                    int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    if (count > Max)
                    {
                        Max = count;
                        best = i;
                    }
                }

                this.SQLQuery = "Select Title from Movies where MovieID ='" + best + "'";
                this.sqlCommand.CommandText = this.SQLQuery;
                String Title = Convert.ToString(sqlCommand.ExecuteScalar());
                MessageBox.Show("Top of the list movie in Opera store is  " + Title + "\nThis movie is rented: " + Max + " times", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Database Exception " + exception.Message);
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }

        }
        // this function change rentedmovies record in table
        public void _UpdateRentedMovieRecord(int RMID, int MovieID, DateTime dateRented, DateTime dateReturned)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.Connection = sqlConnection;
                int TotalRent = 0, cost = 0;
                // find out rented days
                double daysOut = (dateReturned - dateRented).TotalDays;
                SQLQuery = "SELECT Rental_Cost FROM Movies WHERE MovieID = @MovieIDFK";
                sqlCommand.Parameters.AddWithValue("@MovieIDFK", MovieID);
                sqlCommand.CommandText = SQLQuery;
                sqlConnection.Open();
                cost = Convert.ToInt32(sqlCommand.ExecuteScalar());              
                if (Convert.ToInt32(daysOut) == 0)
                {
                       TotalRent = cost; // rent for 1 day is 2
                }
                else
                // rent for more than 1 day is 5
                {
                    TotalRent = Convert.ToInt32(daysOut) * cost;
                }
                // Movie Return data should be DateTime.Now
                SQLQuery = "UPDATE RentedMovies SET DateReturned = @DateReturned WHERE RMID = @RMID";
                sqlCommand.Parameters.AddWithValue("@DateReturned", dateReturned);
                sqlCommand.Parameters.AddWithValue("@RMID", RMID);
                sqlCommand.CommandText = SQLQuery;
                sqlCommand.ExecuteNonQuery();

                // Copies--;
                SQLQuery = "UPDATE Movies SET copies = copies+1 WHERE MovieID = @MovieIDFK";
                sqlCommand.CommandText = SQLQuery;
                sqlCommand.ExecuteNonQuery();
                // Set Movie Rented Status 1
                SQLQuery = "UPDATE RentedMovies SET Rented = 0 WHERE RMID = @RMID";
                sqlCommand.CommandText = SQLQuery;
                sqlCommand.ExecuteNonQuery();
                // Show customer total rent
                MessageBox.Show("CUSTOMER RENT: " + TotalRent,"Total RENT",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Exception: " + ex.Message);
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
    // This Method gets all the movies from Movies table in opera store
        public DataTable _GetAllMoviesRecord()
        { 
            DataTable temp = new DataTable();
            try
            {
                sqlCommand.Connection = sqlConnection;
                SQLQuery = "Select * from Movies";

                sqlCommand.CommandText = SQLQuery;
                //open connection
                sqlConnection.Open();

                // Execute Reader
                sqlReader = sqlCommand.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    temp.Load(sqlReader);
                }
                return temp;
            }
            catch (Exception ex)
            {
                // display message
                MessageBox.Show("Database Exception" + ex.Message);
                return null;
            }
            finally
            {
                // close reader object
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }

                // connection close finally
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }

        }

            // This function adds new movie to Movies Table in  Opera Store
        public void _AddNewMovieRecord(string Rating, string Title, string Year, string Rental_Cost, string Plot, string Genre, int copies)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.Connection = sqlConnection;
                SQLQuery = "Insert into Movies(Rating, Title, Year, Rental_Cost, Plot, Genre, copies) Values( @Rating, @Title, @Year, @Rental_Cost, @Plot, @Genre, @copies)";
                sqlCommand.Parameters.AddWithValue("@Rating", Rating);
                sqlCommand.Parameters.AddWithValue("@Title", Title);
                sqlCommand.Parameters.AddWithValue("@Year", Year);
                sqlCommand.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                sqlCommand.Parameters.AddWithValue("@Plot", Plot);
                sqlCommand.Parameters.AddWithValue("@Genre", Genre);
                sqlCommand.Parameters.AddWithValue("@copies", copies);

                sqlCommand.CommandText = SQLQuery;

                // open
                sqlConnection.Open();

                // execute
                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //  error
                MessageBox.Show("Database Exception" + ex.Message);
            }
            finally
            {
                // closing
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }

        // this method deletes a movie record from opera store by its id
        public void _DeleteMovieRecord(int MovieID)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.Connection = sqlConnection;
                string CheckisMovieRented = "select Count(*) from RentedMovies where MovieIDFK = @MovieID and Rented ='1' ";
                SqlParameter[] parameterArray = new SqlParameter[] { new SqlParameter("@MovieID", MovieID) };
                sqlCommand.Parameters.Add(parameterArray[0]);
                sqlCommand.CommandText = CheckisMovieRented;
                sqlConnection.Open();
                // if command finds a movie rented by a customer then this movie is not deleted
                int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                if (count == 0)
                {
                    String delQ = "Delete from Movies where MovieID like @MovieID";
                    sqlCommand.CommandText = delQ;
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Movie Deleted", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //display the message if movie is rented by someone
                    MessageBox.Show("This movie can not be deleted because is rented by someone", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Database Exception" + exception.Message);
            }
            finally
            {
                if (this.sqlConnection != null)
                {
                    this.sqlConnection.Close();
                }

            }
        }

         // this function updates movie record by its id
        public void _UpdateMovieRecord(int MovieID, string Rating, string Title, int Year, string Plot, string Genre, int copies)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.Connection = sqlConnection;
                // query to update record
                SQLQuery = "Update Movies Set Rating = @Rating, Title = @Title, Year = @Year,  Plot = @Plot, Genre = @Genre, copies = @copies where MovieID like @MovieID";
               // assign parameters
                sqlCommand.Parameters.AddWithValue("@MovieID", MovieID);
                sqlCommand.Parameters.AddWithValue("@Rating", Rating);
                sqlCommand.Parameters.AddWithValue("@Title", Title);
                sqlCommand.Parameters.AddWithValue("@Year", Year);
                sqlCommand.Parameters.AddWithValue("@Plot", Plot);
                sqlCommand.Parameters.AddWithValue("@Genre", Genre);
                sqlCommand.Parameters.AddWithValue("@copies", copies);

                sqlCommand.CommandText = SQLQuery;

                //open
                sqlConnection.Open();

                // Execute
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // display error
                MessageBox.Show("Database Exception" + ex.Message);
            }
            finally
            {
                // closing
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
        

       // This method gets customer records from opera store
        public DataTable _GetAllCustomersFromOperaStore()
        {
            DataTable dtCustRecords = new DataTable();
            try
            {
                sqlCommand.Connection = sqlConnection;
                SQLQuery = "SELECT * from Customer";
                sqlCommand.CommandText = SQLQuery;
                sqlConnection.Open();
                sqlReader = sqlCommand.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    dtCustRecords.Load(sqlReader);
                }
                return dtCustRecords;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return null;
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
        // this function insert new customer into opera store
        public void _AddNewCustomerRecord(string firstname, string lastname, string address, string phone)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.Connection = sqlConnection;
                // Insert Query
                SQLQuery = "INSERT INTO Customer(FirstName,LastName,Address,Phone) VALUES (@fname,@lname,@addr,@phone)";
                sqlCommand.Parameters.AddWithValue("@fname", firstname);
                sqlCommand.Parameters.AddWithValue("@lname", lastname);
                sqlCommand.Parameters.AddWithValue("@addr", address);
                sqlCommand.Parameters.AddWithValue("@phone", phone);
                sqlCommand.CommandText = SQLQuery;
                // open
                sqlConnection.Open();
                //execute
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            finally
            {
                // closing
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }
        }
        // This method deletes customer by its ID
        public void _DeleteCustomerRecord(int id)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.Connection = sqlConnection;
                SQLQuery = "SELECT Count(*) FROM RentedMovies WHERE CustIDFK=@custid";
                sqlCommand.Parameters.AddWithValue("@custid", id);
                sqlCommand.CommandText = SQLQuery;
                sqlConnection.Open();
                int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                if (count == 0)
                {
                    SQLQuery = "DELETE FROM Customer WHERE CustID = @custid";
                    sqlCommand.CommandText = SQLQuery;
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("A movie is linked to this customer", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }

            }
        }
            // This method changes cutomer record in opera store
        public void _UpdateCustomerRecord(int CustID, string FirstName, string LastName, string Address, string Phone)
        {
            try
            {
                sqlCommand.Parameters.Clear();
                sqlCommand.Connection = sqlConnection;
                SQLQuery = "Update Customer Set FirstName = @FirstName, LastName = @LastName, Address = @Address, Phone = @Phone where CustID = @CustID";
                sqlCommand.Parameters.AddWithValue("@CustID", CustID);
                sqlCommand.Parameters.AddWithValue("@FirstName", FirstName);
                sqlCommand.Parameters.AddWithValue("@LastName", LastName);
                sqlCommand.Parameters.AddWithValue("@Address", Address);
                sqlCommand.Parameters.AddWithValue("@Phone", Phone);
                sqlCommand.CommandText = SQLQuery;
                //conn open
                sqlConnection.Open();

                // Exe query
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // show error on exception
                MessageBox.Show("Database Exception" + ex.Message);
            }
            finally
            {
                // closing
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
       // this method is for unit testing
       // Testing Database Connection
        public bool testOperaStoreDatabaseConnection()
        {
            if(sqlConnection.State!=ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            return true;
        }
       
    }
}
