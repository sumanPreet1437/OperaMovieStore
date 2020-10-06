namespace Opera
{
    partial class frmMain
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
            this.tbCFName = new System.Windows.Forms.TextBox();
            this.tbCID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbCLName = new System.Windows.Forms.TextBox();
            this.tbCPhone = new System.Windows.Forms.TextBox();
            this.tbCAddress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMCopies = new System.Windows.Forms.TextBox();
            this.tbMGenre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMID = new System.Windows.Forms.TextBox();
            this.tbMRating = new System.Windows.Forms.TextBox();
            this.tbMTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMPlot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRentedMovieID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDateRented = new System.Windows.Forms.TextBox();
            this.listViewRentals = new System.Windows.Forms.ListView();
            this.RMID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MovieIDFK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustIDFK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateRented = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateReturned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rented = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewMovies = new System.Windows.Forms.ListView();
            this.MovieID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rental_Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Copies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewCustomers = new System.Windows.Forms.ListView();
            this.CustID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddCust = new OperaRentalStore.CircularButton();
            this.btnUpdateCust = new OperaRentalStore.CircularButton();
            this.btnDeleteCust = new OperaRentalStore.CircularButton();
            this.tabMoviesAndCustomers = new System.Windows.Forms.TabControl();
            this.tabStoreMovies = new System.Windows.Forms.TabPage();
            this.btnDeleteMovie = new OperaRentalStore.CircularButton();
            this.btnUpdateMovie = new OperaRentalStore.CircularButton();
            this.btnAddMovie = new OperaRentalStore.CircularButton();
            this.TabCustomers = new System.Windows.Forms.TabPage();
            this.btnReturnMovie = new OperaRentalStore.CircularButton();
            this.roundButton2 = new OperaRentalStore.CircularButton();
            this.btnBestCust = new OperaRentalStore.CircularButton();
            this.btnBestMovie = new OperaRentalStore.CircularButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabMoviesAndCustomers.SuspendLayout();
            this.tabStoreMovies.SuspendLayout();
            this.TabCustomers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCFName
            // 
            this.tbCFName.BackColor = System.Drawing.Color.Azure;
            this.tbCFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCFName.Location = new System.Drawing.Point(81, 324);
            this.tbCFName.Name = "tbCFName";
            this.tbCFName.Size = new System.Drawing.Size(139, 20);
            this.tbCFName.TabIndex = 4;
            // 
            // tbCID
            // 
            this.tbCID.BackColor = System.Drawing.Color.Azure;
            this.tbCID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCID.Location = new System.Drawing.Point(31, 19);
            this.tbCID.Name = "tbCID";
            this.tbCID.ReadOnly = true;
            this.tbCID.Size = new System.Drawing.Size(63, 20);
            this.tbCID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(8, 19);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(11, 327);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(13, 353);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // tbCLName
            // 
            this.tbCLName.BackColor = System.Drawing.Color.Azure;
            this.tbCLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCLName.Location = new System.Drawing.Point(81, 350);
            this.tbCLName.Name = "tbCLName";
            this.tbCLName.Size = new System.Drawing.Size(140, 20);
            this.tbCLName.TabIndex = 6;
            // 
            // tbCPhone
            // 
            this.tbCPhone.BackColor = System.Drawing.Color.Azure;
            this.tbCPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCPhone.Location = new System.Drawing.Point(81, 376);
            this.tbCPhone.Name = "tbCPhone";
            this.tbCPhone.Size = new System.Drawing.Size(124, 20);
            this.tbCPhone.TabIndex = 7;
            // 
            // tbCAddress
            // 
            this.tbCAddress.BackColor = System.Drawing.Color.Azure;
            this.tbCAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCAddress.Location = new System.Drawing.Point(80, 402);
            this.tbCAddress.Name = "tbCAddress";
            this.tbCAddress.Size = new System.Drawing.Size(140, 20);
            this.tbCAddress.TabIndex = 8;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(32, 380);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 13);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(22, 404);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 13);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(100, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Copies";
            // 
            // tbMCopies
            // 
            this.tbMCopies.BackColor = System.Drawing.Color.Azure;
            this.tbMCopies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMCopies.Location = new System.Drawing.Point(148, 425);
            this.tbMCopies.Name = "tbMCopies";
            this.tbMCopies.Size = new System.Drawing.Size(33, 20);
            this.tbMCopies.TabIndex = 31;
            // 
            // tbMGenre
            // 
            this.tbMGenre.BackColor = System.Drawing.Color.Azure;
            this.tbMGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMGenre.Location = new System.Drawing.Point(65, 399);
            this.tbMGenre.Name = "tbMGenre";
            this.tbMGenre.Size = new System.Drawing.Size(116, 20);
            this.tbMGenre.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Rating";
            // 
            // tbMID
            // 
            this.tbMID.BackColor = System.Drawing.Color.Azure;
            this.tbMID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMID.Location = new System.Drawing.Point(40, 17);
            this.tbMID.Name = "tbMID";
            this.tbMID.ReadOnly = true;
            this.tbMID.Size = new System.Drawing.Size(47, 20);
            this.tbMID.TabIndex = 14;
            // 
            // tbMRating
            // 
            this.tbMRating.BackColor = System.Drawing.Color.Azure;
            this.tbMRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMRating.Location = new System.Drawing.Point(65, 425);
            this.tbMRating.Name = "tbMRating";
            this.tbMRating.Size = new System.Drawing.Size(25, 20);
            this.tbMRating.TabIndex = 29;
            // 
            // tbMTitle
            // 
            this.tbMTitle.BackColor = System.Drawing.Color.Azure;
            this.tbMTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMTitle.Location = new System.Drawing.Point(65, 321);
            this.tbMTitle.Name = "tbMTitle";
            this.tbMTitle.Size = new System.Drawing.Size(168, 20);
            this.tbMTitle.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(34, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Plot";
            // 
            // tbMYear
            // 
            this.tbMYear.BackColor = System.Drawing.Color.Azure;
            this.tbMYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMYear.Location = new System.Drawing.Point(65, 347);
            this.tbMYear.Name = "tbMYear";
            this.tbMYear.Size = new System.Drawing.Size(89, 20);
            this.tbMYear.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(26, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Year";
            // 
            // tbMPlot
            // 
            this.tbMPlot.BackColor = System.Drawing.Color.Azure;
            this.tbMPlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMPlot.Location = new System.Drawing.Point(65, 373);
            this.tbMPlot.Name = "tbMPlot";
            this.tbMPlot.Size = new System.Drawing.Size(116, 20);
            this.tbMPlot.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Genre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(674, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Rented Movie ID";
            // 
            // tbRentedMovieID
            // 
            this.tbRentedMovieID.BackColor = System.Drawing.Color.Azure;
            this.tbRentedMovieID.Location = new System.Drawing.Point(783, 168);
            this.tbRentedMovieID.Name = "tbRentedMovieID";
            this.tbRentedMovieID.Size = new System.Drawing.Size(83, 20);
            this.tbRentedMovieID.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(671, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Date Rented";
            // 
            // tbDateRented
            // 
            this.tbDateRented.BackColor = System.Drawing.Color.Azure;
            this.tbDateRented.Location = new System.Drawing.Point(763, 194);
            this.tbDateRented.Name = "tbDateRented";
            this.tbDateRented.Size = new System.Drawing.Size(116, 20);
            this.tbDateRented.TabIndex = 35;
            // 
            // listViewRentals
            // 
            this.listViewRentals.BackColor = System.Drawing.Color.MintCream;
            this.listViewRentals.BackgroundImage = global::OperaStore.Properties.Resources._7114;
            this.listViewRentals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RMID,
            this.MovieIDFK,
            this.CustIDFK,
            this.DateRented,
            this.DateReturned,
            this.Rented});
            this.listViewRentals.ForeColor = System.Drawing.Color.Navy;
            this.listViewRentals.FullRowSelect = true;
            this.listViewRentals.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewRentals.HideSelection = false;
            this.listViewRentals.Location = new System.Drawing.Point(6, 6);
            this.listViewRentals.Name = "listViewRentals";
            this.listViewRentals.Size = new System.Drawing.Size(618, 444);
            this.listViewRentals.TabIndex = 1;
            this.listViewRentals.UseCompatibleStateImageBehavior = false;
            this.listViewRentals.View = System.Windows.Forms.View.Details;
            this.listViewRentals.ItemActivate += new System.EventHandler(this.LvRentedMovies_ItemActivate);
            // 
            // RMID
            // 
            this.RMID.Text = "RMID";
            // 
            // MovieIDFK
            // 
            this.MovieIDFK.Text = "MovieIDFK";
            this.MovieIDFK.Width = 75;
            // 
            // CustIDFK
            // 
            this.CustIDFK.Text = "CustIDFK";
            this.CustIDFK.Width = 79;
            // 
            // DateRented
            // 
            this.DateRented.Text = "DateRented";
            this.DateRented.Width = 131;
            // 
            // DateReturned
            // 
            this.DateReturned.Text = "DateReturned";
            this.DateReturned.Width = 147;
            // 
            // Rented
            // 
            this.Rented.Text = "Rented";
            // 
            // listviewMovies
            // 
            this.listviewMovies.BackColor = System.Drawing.Color.MintCream;
            this.listviewMovies.BackgroundImage = global::OperaStore.Properties.Resources._7114;
            this.listviewMovies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MovieID,
            this.Rating,
            this.Title,
            this.Year,
            this.Rental_Cost,
            this.Copies,
            this.Plot,
            this.Genre});
            this.listviewMovies.ForeColor = System.Drawing.Color.Navy;
            this.listviewMovies.FullRowSelect = true;
            this.listviewMovies.HideSelection = false;
            this.listviewMovies.Location = new System.Drawing.Point(6, 42);
            this.listviewMovies.Name = "listviewMovies";
            this.listviewMovies.Size = new System.Drawing.Size(621, 273);
            this.listviewMovies.TabIndex = 0;
            this.listviewMovies.UseCompatibleStateImageBehavior = false;
            this.listviewMovies.View = System.Windows.Forms.View.Details;
            this.listviewMovies.ItemActivate += new System.EventHandler(this.LvMovies_ItemActivate);
            // 
            // MovieID
            // 
            this.MovieID.Text = "MovieID";
            // 
            // Rating
            // 
            this.Rating.Text = "Rating";
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 98;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            // 
            // Rental_Cost
            // 
            this.Rental_Cost.Text = "Cost";
            // 
            // Copies
            // 
            this.Copies.Text = "Copies";
            // 
            // Plot
            // 
            this.Plot.Text = "Plot";
            this.Plot.Width = 146;
            // 
            // Genre
            // 
            this.Genre.Text = "Genre";
            // 
            // listviewCustomers
            // 
            this.listviewCustomers.BackColor = System.Drawing.Color.MintCream;
            this.listviewCustomers.BackgroundImage = global::OperaStore.Properties.Resources._7114;
            this.listviewCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustID,
            this.FirstName,
            this.LastName,
            this.Address,
            this.Phone});
            this.listviewCustomers.ForeColor = System.Drawing.Color.Navy;
            this.listviewCustomers.FullRowSelect = true;
            this.listviewCustomers.HideSelection = false;
            this.listviewCustomers.Location = new System.Drawing.Point(6, 45);
            this.listviewCustomers.Name = "listviewCustomers";
            this.listviewCustomers.Size = new System.Drawing.Size(590, 268);
            this.listviewCustomers.TabIndex = 1;
            this.listviewCustomers.UseCompatibleStateImageBehavior = false;
            this.listviewCustomers.View = System.Windows.Forms.View.Details;
            this.listviewCustomers.ItemActivate += new System.EventHandler(this.LvCustomers_ItemActivate);
            // 
            // CustID
            // 
            this.CustID.Text = "CustID";
            // 
            // FirstName
            // 
            this.FirstName.Text = "FirstName";
            this.FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastName.Width = 71;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Address.Width = 146;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Phone.Width = 115;
            // 
            // btnAddCust
            // 
            this.btnAddCust.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCust.Location = new System.Drawing.Point(256, 343);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(75, 50);
            this.btnAddCust.TabIndex = 45;
            this.btnAddCust.Text = "ADD";
            this.btnAddCust.UseVisualStyleBackColor = false;
            this.btnAddCust.Click += new System.EventHandler(this.BtnAddCust_Click);
            // 
            // btnUpdateCust
            // 
            this.btnUpdateCust.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCust.Location = new System.Drawing.Point(337, 343);
            this.btnUpdateCust.Name = "btnUpdateCust";
            this.btnUpdateCust.Size = new System.Drawing.Size(75, 50);
            this.btnUpdateCust.TabIndex = 46;
            this.btnUpdateCust.Text = "UPDATE";
            this.btnUpdateCust.UseVisualStyleBackColor = false;
            this.btnUpdateCust.Click += new System.EventHandler(this.BtnUpdateCust_Click);
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCust.Location = new System.Drawing.Point(418, 343);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(75, 50);
            this.btnDeleteCust.TabIndex = 47;
            this.btnDeleteCust.Text = "DELETE";
            this.btnDeleteCust.UseVisualStyleBackColor = false;
            this.btnDeleteCust.Click += new System.EventHandler(this.BtnDeleteCust_Click);
            // 
            // tabMoviesAndCustomers
            // 
            this.tabMoviesAndCustomers.Controls.Add(this.tabStoreMovies);
            this.tabMoviesAndCustomers.Controls.Add(this.TabCustomers);
            this.tabMoviesAndCustomers.Controls.Add(this.tabPage1);
            this.tabMoviesAndCustomers.Location = new System.Drawing.Point(12, 12);
            this.tabMoviesAndCustomers.Name = "tabMoviesAndCustomers";
            this.tabMoviesAndCustomers.SelectedIndex = 0;
            this.tabMoviesAndCustomers.Size = new System.Drawing.Size(638, 482);
            this.tabMoviesAndCustomers.TabIndex = 48;
            // 
            // tabStoreMovies
            // 
            this.tabStoreMovies.BackgroundImage = global::OperaStore.Properties.Resources._7114;
            this.tabStoreMovies.Controls.Add(this.btnDeleteMovie);
            this.tabStoreMovies.Controls.Add(this.btnUpdateMovie);
            this.tabStoreMovies.Controls.Add(this.btnAddMovie);
            this.tabStoreMovies.Controls.Add(this.listviewMovies);
            this.tabStoreMovies.Controls.Add(this.tbMTitle);
            this.tabStoreMovies.Controls.Add(this.tbMID);
            this.tabStoreMovies.Controls.Add(this.tbMPlot);
            this.tabStoreMovies.Controls.Add(this.label1);
            this.tabStoreMovies.Controls.Add(this.label5);
            this.tabStoreMovies.Controls.Add(this.tbMCopies);
            this.tabStoreMovies.Controls.Add(this.label2);
            this.tabStoreMovies.Controls.Add(this.tbMGenre);
            this.tabStoreMovies.Controls.Add(this.tbMYear);
            this.tabStoreMovies.Controls.Add(this.label7);
            this.tabStoreMovies.Controls.Add(this.label4);
            this.tabStoreMovies.Controls.Add(this.tbMRating);
            this.tabStoreMovies.Controls.Add(this.label3);
            this.tabStoreMovies.Controls.Add(this.label6);
            this.tabStoreMovies.Location = new System.Drawing.Point(4, 22);
            this.tabStoreMovies.Name = "tabStoreMovies";
            this.tabStoreMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabStoreMovies.Size = new System.Drawing.Size(630, 456);
            this.tabStoreMovies.TabIndex = 0;
            this.tabStoreMovies.Text = "OperaStoreMovies";
            this.tabStoreMovies.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMovie.Location = new System.Drawing.Point(387, 323);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(75, 67);
            this.btnDeleteMovie.TabIndex = 27;
            this.btnDeleteMovie.Text = "DELETE";
            this.btnDeleteMovie.UseVisualStyleBackColor = false;
            this.btnDeleteMovie.Click += new System.EventHandler(this.BtnDeleteMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMovie.Location = new System.Drawing.Point(316, 327);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(75, 66);
            this.btnUpdateMovie.TabIndex = 26;
            this.btnUpdateMovie.Text = "UPDATE";
            this.btnUpdateMovie.UseVisualStyleBackColor = false;
            this.btnUpdateMovie.Click += new System.EventHandler(this.BtnUpdateMovie_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMovie.Location = new System.Drawing.Point(248, 323);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(75, 70);
            this.btnAddMovie.TabIndex = 25;
            this.btnAddMovie.Text = "ADD";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.BtnAddMovie_Click);
            // 
            // TabCustomers
            // 
            this.TabCustomers.BackgroundImage = global::OperaStore.Properties.Resources._7114;
            this.TabCustomers.Controls.Add(this.listviewCustomers);
            this.TabCustomers.Controls.Add(this.btnDeleteCust);
            this.TabCustomers.Controls.Add(this.btnAddCust);
            this.TabCustomers.Controls.Add(this.btnUpdateCust);
            this.TabCustomers.Controls.Add(this.tbCAddress);
            this.TabCustomers.Controls.Add(this.tbCFName);
            this.TabCustomers.Controls.Add(this.tbCID);
            this.TabCustomers.Controls.Add(this.lblID);
            this.TabCustomers.Controls.Add(this.lblAddress);
            this.TabCustomers.Controls.Add(this.lblFirstName);
            this.TabCustomers.Controls.Add(this.lblLastName);
            this.TabCustomers.Controls.Add(this.lblPhone);
            this.TabCustomers.Controls.Add(this.tbCLName);
            this.TabCustomers.Controls.Add(this.tbCPhone);
            this.TabCustomers.Location = new System.Drawing.Point(4, 22);
            this.TabCustomers.Name = "TabCustomers";
            this.TabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.TabCustomers.Size = new System.Drawing.Size(630, 456);
            this.TabCustomers.TabIndex = 1;
            this.TabCustomers.Text = "OperaStore Customers";
            this.TabCustomers.UseVisualStyleBackColor = true;
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMovie.Location = new System.Drawing.Point(659, 51);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(111, 100);
            this.btnReturnMovie.TabIndex = 33;
            this.btnReturnMovie.Text = "RETURN";
            this.btnReturnMovie.UseVisualStyleBackColor = false;
            this.btnReturnMovie.Click += new System.EventHandler(this.BtnReturnMovie_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.Transparent;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Location = new System.Drawing.Point(776, 51);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(115, 98);
            this.roundButton2.TabIndex = 49;
            this.roundButton2.Text = "ISSUE";
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.BtnIssueMovie_Click);
            // 
            // btnBestCust
            // 
            this.btnBestCust.BackColor = System.Drawing.Color.Transparent;
            this.btnBestCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBestCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestCust.Location = new System.Drawing.Point(674, 240);
            this.btnBestCust.Name = "btnBestCust";
            this.btnBestCust.Size = new System.Drawing.Size(171, 125);
            this.btnBestCust.TabIndex = 50;
            this.btnBestCust.Text = "Customer On Top";
            this.btnBestCust.UseVisualStyleBackColor = false;
            this.btnBestCust.Click += new System.EventHandler(this.BtnBestCustomer_Click);
            // 
            // btnBestMovie
            // 
            this.btnBestMovie.BackColor = System.Drawing.Color.Transparent;
            this.btnBestMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBestMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestMovie.Location = new System.Drawing.Point(677, 362);
            this.btnBestMovie.Name = "btnBestMovie";
            this.btnBestMovie.Size = new System.Drawing.Size(168, 135);
            this.btnBestMovie.TabIndex = 51;
            this.btnBestMovie.Text = "Movie On Top";
            this.btnBestMovie.UseVisualStyleBackColor = false;
            this.btnBestMovie.Click += new System.EventHandler(this.BtnBestMoie_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewRentals);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(630, 456);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Opera Rented Records";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::OperaStore.Properties.Resources._7114;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(903, 509);
            this.Controls.Add(this.btnBestMovie);
            this.Controls.Add(this.btnBestCust);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.btnReturnMovie);
            this.Controls.Add(this.tabMoviesAndCustomers);
            this.Controls.Add(this.tbDateRented);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbRentedMovieID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opera Movie Rental Store";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabMoviesAndCustomers.ResumeLayout(false);
            this.tabStoreMovies.ResumeLayout(false);
            this.tabStoreMovies.PerformLayout();
            this.TabCustomers.ResumeLayout(false);
            this.TabCustomers.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbCFName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbCLName;
        private System.Windows.Forms.TextBox tbCPhone;
        private System.Windows.Forms.TextBox tbCAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbMID;
        private System.Windows.Forms.TextBox tbMTitle;
        private System.Windows.Forms.TextBox tbMGenre;
        private System.Windows.Forms.TextBox tbMYear;
        private System.Windows.Forms.TextBox tbMPlot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMRating;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMCopies;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRentedMovieID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDateRented;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listViewRentals;
        private System.Windows.Forms.ColumnHeader RMID;
        private System.Windows.Forms.ColumnHeader MovieIDFK;
        private System.Windows.Forms.ColumnHeader CustIDFK;
        private System.Windows.Forms.ColumnHeader DateRented;
        private System.Windows.Forms.ColumnHeader DateReturned;
        private System.Windows.Forms.ColumnHeader Rented;
        private System.Windows.Forms.ListView listviewMovies;
        private System.Windows.Forms.ColumnHeader MovieID;
        private System.Windows.Forms.ColumnHeader Rating;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Rental_Cost;
        private System.Windows.Forms.ColumnHeader Copies;
        private System.Windows.Forms.ColumnHeader Plot;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.ListView listviewCustomers;
        private System.Windows.Forms.ColumnHeader CustID;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Phone;
        private OperaRentalStore.CircularButton btnAddCust;
        private OperaRentalStore.CircularButton btnUpdateCust;
        private OperaRentalStore.CircularButton btnDeleteCust;
        private System.Windows.Forms.TabControl tabMoviesAndCustomers;
        private System.Windows.Forms.TabPage tabStoreMovies;
        private System.Windows.Forms.TabPage TabCustomers;
        private OperaRentalStore.CircularButton btnDeleteMovie;
        private OperaRentalStore.CircularButton btnUpdateMovie;
        private OperaRentalStore.CircularButton btnAddMovie;
        private OperaRentalStore.CircularButton btnReturnMovie;
        private OperaRentalStore.CircularButton roundButton2;
        private OperaRentalStore.CircularButton btnBestCust;
        private OperaRentalStore.CircularButton btnBestMovie;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

