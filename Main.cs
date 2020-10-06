using System;
using System.Data;
using System.Windows.Forms;
using OperaStore;

namespace Opera
{
    public partial class frmMain : Form
    {
        // OperaStore Instance created to access its member fucntions 
        OperaMovieStore _operaStoreObj = new OperaMovieStore();
        ListViewItem item;
        public frmMain()
        {
            InitializeComponent();
        }
        private void BtnUpdateCust_Click(object sender, EventArgs e)
        {   // see if user has left the input empty
            if (tbCFName.Text != "" && tbCLName.Text != "" && tbCAddress.Text != "" && tbCPhone.Text != "")
            {
                // save input in stirng variables
                string firstname = tbCFName.Text;
                string lastname = tbCLName.Text;
                string address = tbCAddress.Text;
                string phone = tbCPhone.Text;
                int custId = Convert.ToInt32(tbCID.Text);
                _operaStoreObj._UpdateCustomerRecord(custId, firstname, lastname, address, phone);
                _FillCustomerListView(_operaStoreObj._GetAllCustomersFromOperaStore());
                _ClearAllTextBoxes();    
            } else
            {
                MessageBox.Show("do not left any customer field blank","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        // Clear All Input TextBoxes
        private void _ClearAllTextBoxes()
        {
            tbMID.Text = ""; tbMTitle.Text = ""; tbMGenre.Text = "";
            tbMRating.Text = "";
            tbMYear.Text = ""; tbMCopies.Text = ""; tbMPlot.Text = "";
            tbCID.Text = "";
            tbCFName.Text = "";
            tbCAddress.Text = "";
            tbCLName.Text = "";
            tbCPhone.Text = "";
            
        }
        private void BtnAddCust_Click(object sender, EventArgs e)
        {
            if (tbCFName.Text != "" && tbCLName.Text != "" && tbCAddress.Text != "" && tbCPhone.Text != "")
            {
                _operaStoreObj._AddNewCustomerRecord(tbCFName.Text, tbCLName.Text, tbCAddress.Text, tbCPhone.Text);
                _FillCustomerListView(_operaStoreObj._GetAllCustomersFromOperaStore()); 
                _ClearAllTextBoxes();
            }
            else
            {
                MessageBox.Show("Please Fill All text boxes of Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDeleteCust_Click(object sender, EventArgs e)
        {
            if(tbCID.Text!="")
            {
                // Delete?
                int CID = Convert.ToInt32(tbCID.Text);
                DialogResult mbResult = MessageBox.Show("Delete?", "customer", MessageBoxButtons.YesNo);
                if(mbResult.ToString()=="Yes")
                {
                    _operaStoreObj._DeleteCustomerRecord(CID);
                    MessageBox.Show("Customer Removed!","Ok",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    _FillCustomerListView(_operaStoreObj._GetAllCustomersFromOperaStore());
                    _ClearAllTextBoxes();
                }
            }
        }

            // Fill all list view with data when MAin form loads    
        private void FrmMain_Load(object sender, EventArgs e)
        {
            _FillCustomerListView(_operaStoreObj._GetAllCustomersFromOperaStore());
            _FillMoviesListView(_operaStoreObj._GetAllMoviesRecord());
            _FillRentedMoviesListView(_operaStoreObj._GetRentalData()); 


        }

    
        private void BtnAddMovie_Click(object sender, EventArgs e)
        {
            // constraint to see if fields are empty
            if(tbMTitle.Text!="" && tbMGenre.Text!="" && tbMRating.Text!="" && tbMYear.Text!="" && tbMCopies.Text!="" && tbMPlot.Text!="")
            {
                int YearOfMovie = Convert.ToInt32(tbMYear.Text);
                int NoOfCopies = Convert.ToInt32(tbMCopies.Text);
                string rent;

               
                if(DateTime.Now.Date.Year-YearOfMovie > 5) 
                {
                    rent = "2"; // set rent to 2 if YearOfMovie is greater than 5
                }else
                {
                    rent = "5"; // set rent to 5 if movie is less than 5 years old
                }
                _operaStoreObj._AddNewMovieRecord(tbMRating.Text, tbMTitle.Text, tbMYear.Text, rent, tbMPlot.Text, tbMGenre.Text, NoOfCopies);
                _FillMoviesListView(_operaStoreObj._GetAllMoviesRecord());
                _ClearAllTextBoxes();
            }else
            {
                MessageBox.Show("Fill All Movies Text Boxes First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnUpdateMovie_Click(object sender, EventArgs e)
        {
            // constraint to see if fileds are left blank
            if (tbMID.Text != "" && tbMTitle.Text != "" && tbMGenre.Text != "" && tbMRating.Text != "" && tbMYear.Text != "" && tbMCopies.Text != "" && tbMPlot.Text != "")
            {

                // save input into  variables
                string title = tbMTitle.Text;
                string rating = tbMRating.Text;
                string genre = tbMGenre.Text;
                string plot = tbMPlot.Text;
                int movieId = Convert.ToInt32(tbMID.Text);
                int copies = Convert.ToInt32(tbMCopies.Text);
                int year = Convert.ToInt32(tbMYear.Text);
                 // Change  movie record in movies table
                _operaStoreObj._UpdateMovieRecord(movieId, rating, title, year, plot, genre, copies);
                MessageBox.Show("Movie record Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _FillMoviesListView(_operaStoreObj._GetAllMoviesRecord());
                _ClearAllTextBoxes();
            }else
            {
                MessageBox.Show("Movies text boxes are empty", "err", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnDeleteMovie_Click(object sender, EventArgs e)
        {
            if(tbMID.Text!="")
            {
                //Delete?
                DialogResult result = MessageBox.Show("Delete?", "Confirm", MessageBoxButtons.YesNo);
                if(result.ToString()=="Yes")
                {
                    int movieId = Convert.ToInt32(tbMID.Text);
                    // Delete movie Record by its id
                    _operaStoreObj._DeleteMovieRecord(movieId); 
                    _FillMoviesListView(_operaStoreObj._GetAllMoviesRecord());
                    _ClearAllTextBoxes();
                }
            }
            else
            {
                MessageBox.Show("Please select movie first","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }


        private void BtnIssueMovie_Click(object sender, EventArgs e)
        {
            //Empty constraint on movie id and custid
            if(tbMID.Text !="" && tbCID.Text!="")
            {
                if(tbMCopies.Text!="0")
                {
                    int movieId = Convert.ToInt32(tbMID.Text);
                    int custId = Convert.ToInt32(tbCID.Text);
                    int copies = Convert.ToInt32(tbMCopies.Text);
                    int isOut = 1; // set rented status to 1
                    _operaStoreObj._AddNewRentedMovie(movieId, custId, DateTime.Now, copies, isOut); 
                    _FillRentedMoviesListView(_operaStoreObj._GetRentalData()); // update list view
                    // clear all text boxes of customer and movies
                    _ClearAllTextBoxes();
                }
                else
                {
                    MessageBox.Show("No more copies left", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }else
            {
                MessageBox.Show("Please select customer and movie from list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
            }
        }

        private void BtnReturnMovie_Click(object sender, EventArgs e)
        {
            //Empty Constraint on fields
            if(tbMID.Text!="" && tbDateRented.Text!="" && tbRentedMovieID.Text!="")
            {
                int RentedMovieId = Convert.ToInt32(tbRentedMovieID.Text);
                int MovieId = Convert.ToInt32(tbMID.Text);
                String DateRented = tbDateRented.Text;
                // Date of Return = DateTime.Now
                _operaStoreObj._UpdateRentedMovieRecord(RentedMovieId, MovieId, Convert.ToDateTime(DateRented), DateTime.Now);
                _FillCustomerListView(_operaStoreObj._GetAllCustomersFromOperaStore());
                _FillMoviesListView(_operaStoreObj._GetAllMoviesRecord());
                _FillRentedMoviesListView(_operaStoreObj._GetRentalData());
                // clears all inputs
                _ClearAllTextBoxes();
                // clear id boxes
                tbRentedMovieID.Text = ""; 
                tbDateRented.Text = "";
            }else
            {
                MessageBox.Show("No movie selected to return", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close main app when form closed
            Application.Exit(); 
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            // close app when btn close is pressed
            Application.Exit();
        }

        
       OperaMovieStore oms = new OperaMovieStore();

        private void BtnBestCustomer_Click(object sender, EventArgs e)
        {
            oms._SelectTopCustomerFromStore();
        }

        private void BtnBestMoie_Click(object sender, EventArgs e)
        {
            oms._SelectTopMovieFromStore();
        }

        private void LvRentedMovies_ItemActivate(object sender, EventArgs e)
        {
            item= listViewRentals.SelectedItems[0];
            tbRentedMovieID.Text = item.SubItems[0].Text;
            tbDateRented.Text = item.SubItems[3].Text;
            tbMID.Text = item.SubItems[1].Text;
        }

        private void LvMovies_ItemActivate(object sender, EventArgs e)
        {

            item = listviewMovies.SelectedItems[0];
            tbMID.Text = item.SubItems[0].Text;
            tbMRating.Text = item.SubItems[1].Text;
            tbMTitle.Text = item.SubItems[2].Text;
            tbMYear.Text = item.SubItems[3].Text;
            tbMCopies.Text = item.SubItems[5].Text;
            tbMPlot.Text =  item.SubItems[6].Text;
            tbMGenre.Text = item.SubItems[7].Text;

        }

        private void LvCustomers_ItemActivate(object sender, EventArgs e)
        {
            item = listviewCustomers.SelectedItems[0];
            tbCID.Text = item.SubItems[0].Text;
            tbCFName.Text = item.SubItems[1].Text;
            tbCLName.Text = item.SubItems[2].Text;
            tbCAddress.Text = item.SubItems[3].Text;
            tbCPhone.Text = item.SubItems[4].Text;
        }

        
        private void _FillCustomerListView(DataTable d)
        { // clear previous items first
            listviewCustomers.Items.Clear();
            for (int i = 0; i < d.Rows.Count; i++)
            {

                listviewCustomers.Items.Add(d.Rows[i].ItemArray[0].ToString());
                listviewCustomers.Items[i].SubItems.Add(d.Rows[i].ItemArray[1].ToString());
                listviewCustomers.Items[i].SubItems.Add(d.Rows[i].ItemArray[2].ToString());
                listviewCustomers.Items[i].SubItems.Add(d.Rows[i].ItemArray[3].ToString());
                listviewCustomers.Items[i].SubItems.Add(d.Rows[i].ItemArray[4].ToString());
            }


        }
        private void _FillMoviesListView(DataTable tmp)
        { // clear previous items first
            listviewMovies.Items.Clear();
            foreach (DataRow row in tmp.Rows)
            {
                string[] items = { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString() };
                listviewMovies.Items.Add(new ListViewItem(items));
            }

        }
        private void _FillRentedMoviesListView(DataTable dt)
        {
            // clear previous items first
            listViewRentals.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string[] items = { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString() };
                listViewRentals.Items.Add(new ListViewItem(items));
            }

        }
     
    }
}
