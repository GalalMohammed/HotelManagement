using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using Microsoft.Data.SqlClient;
using Hotel_Manager.FRONTEND_RESERVATIONModels;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;
using System.Configuration;
namespace Hotel_Manager
{
    public partial class Frontend : Form
    {
        readonly FRONTEND_RESERVATIONContext fRONTEND_RESERVATIONContext = new(new DbContextOptionsBuilder<FRONTEND_RESERVATIONContext>().UseSqlServer(ConfigurationManager.ConnectionStrings["Hotel_Manager.Properties.Settings.frontend_reservationConnectionString"].ConnectionString).Options);
        public Frontend()
        {
            InitializeComponent();
            CenterToScreen();
            entryDatePicker.MinDate = DateTime.Today;
            depDatePicker.MinDate = DateTime.Today.AddDays(1);

            LoadForDataGridView();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();

            roomOccupiedListBox.DrawMode = DrawMode.OwnerDrawFixed;
            roomOccupiedListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(roomOccupiedListBox_DrawItem);
            roomReservedListBox.DrawMode = DrawMode.OwnerDrawFixed;
            roomReservedListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(roomReservedListBox_DrawItem);
        }



        private void roomOccupiedListBox_DrawItem(object? sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            roomOccupiedListBox.IntegralHeight = false;
            roomOccupiedListBox.ItemHeight = 25;
            e.DrawBackground();
            Font listBoxFont;
            Brush brush;

            int i = e.Index;

            listBoxFont = new Font("Segoe UI Symbol", 12.0f, FontStyle.Regular);
            brush = Brushes.Black;
            e.Graphics.DrawString(roomOccupiedListBox.Items[i].ToString(), listBoxFont, brush, e.Bounds, StringFormat.GenericTypographic);

        }
        private void roomReservedListBox_DrawItem(object? sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            roomReservedListBox.IntegralHeight = false;
            roomReservedListBox.ItemHeight = 25;
            e.DrawBackground();
            Font listBoxFont;
            Brush brush;

            int i = e.Index;

            listBoxFont = new Font("Segoe UI Symbol", 12.0f, FontStyle.Regular);
            brush = Brushes.Black;
            e.Graphics.DrawString(roomReservedListBox.Items[i].ToString(), listBoxFont, brush, e.Bounds, StringFormat.GenericTypographic);

        }


        private string? getval;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? Getval
        {
            get { return getval; }
            set { getval = value; }
        }

        public string? towelS, cleaningS, surpriseS;

        public int foodBill;
        public string birthday = "";

        public string food_menu = "";
        public int totalAmount = 0;
        public int checkin = 0;
        public int foodStatus = 0;
        public int primartyID = 0;
        public bool taskFinder = false;
        public bool editClicked = false;
        public string? FPayment, FCnumber, FcardExpOne, FcardExpTwo, FCardCVC;
        private double finalizedTotalAmount = 0.0;
        private string? paymentType;
        private string? paymentCardNumber;
        private string? MM_YY_Of_Card;
        private string? CVC_Of_Card;
        private string? CardType;

        private int lunch = 0; private int breakfast = 0; private int dinner = 0;
        private string? cleaning; private string? towel;
        private string? surprise;

        private void MainTab_Load(object sender, EventArgs e)
        {
            foodSupplyCheckBox.Enabled = false;

        }

        public void foodMenuButton_Click(object sender, EventArgs e)
        {

            FoodMenu food_menu = new();
            if (taskFinder)
            {
                if (breakfast > 0)
                {
                    food_menu.breakfastCheckBox.Checked = true;
                    food_menu.breakfastQTY.Text = Convert.ToString(breakfast);
                }
                if (lunch > 0)
                {
                    food_menu.lunchCheckBox.Checked = true;

                    food_menu.lunchQTY.Text = Convert.ToString(lunch);
                }
                if (dinner > 0)
                {
                    food_menu.dinnerCheckBox.Checked = true;
                    food_menu.dinnerQTY.Text = Convert.ToString(dinner);
                }
                if (cleaning == "1")
                {
                    food_menu.cleaningCheckBox.Checked = true;
                }
                if (towel == "1")
                {
                    food_menu.towelsCheckBox.Checked = true;
                }
                if (surprise == "1")
                {
                    food_menu.surpriseCheckBox.Checked = true;
                }
            }
            food_menu.ShowDialog();

            breakfast = food_menu.BreakfastQ;
            lunch = food_menu.LunchQ;
            dinner = food_menu.DinnerQ;

            cleaning = food_menu.Cleaning.Replace(" ", string.Empty) == "Cleaning" ? "1" : "0";
            towel = food_menu.Towel.Replace(" ", string.Empty) == "Towels" ? "1" : "0";

            surprise = food_menu.Surprise.Replace(" ", string.Empty) == "Sweetestsurprise" ? "1" : "0";

            if (breakfast > 0 || lunch > 0 || dinner > 0)
            {
                int bfast = 7 * breakfast;
                int Lnch = 15 * lunch;
                int di_ner = 15 * dinner;
                foodBill = bfast + Lnch + di_ner;
            }
        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (roomTypeComboBox?.SelectedItem?.Equals("Single") == true)
            {
                totalAmount = 149;
                floorComboBox.SelectedItem = "1";
            }
            else if (roomTypeComboBox?.SelectedItem?.Equals("Double") == true)
            {
                totalAmount = 299;
                floorComboBox.SelectedItem = "2";
            }
            else if (roomTypeComboBox?.SelectedItem?.Equals("Twin") == true)
            {
                totalAmount = 349;
                floorComboBox.SelectedItem = "3";
            }
            else if (roomTypeComboBox?.SelectedItem?.Equals("Duplex") == true)
            {
                totalAmount = 399;
                floorComboBox.SelectedItem = "4";
            }
            else if (roomTypeComboBox?.SelectedItem?.Equals("Suite") == true)
            {
                totalAmount = 499;
                floorComboBox.SelectedItem = "5";
            }
            string? selected;
            bool temp = int.TryParse(qtGuestComboBox?.SelectedItem?.ToString(), out _);
            if (!temp)
            {
                MessageBox.Show(this, "Enter # of guests first", "Error parsing", MessageBoxButtons.OK);
            }
            else
            {
                selected = qtGuestComboBox?.SelectedItem?.ToString();
                int selectedTemp = Convert.ToInt32(selected);
                if (selectedTemp >= 3)
                {
                    totalAmount += (selectedTemp * 5);
                }
            }


        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editClicked = true;
            entryDatePicker.MinDate = new DateTime(2014, 4, 1);
            entryDatePicker.CustomFormat = "dd-MM-yyyy";
            entryDatePicker.Format = DateTimePickerFormat.Custom;

            depDatePicker.MinDate = new DateTime(2014, 4, 1);
            depDatePicker.CustomFormat = "dd-MM-yyyy";
            depDatePicker.Format = DateTimePickerFormat.Custom;

            submitButton.Visible = false;
            updateButton.Visible = true;
            deleteButton.Visible = true;
            resEditButton.Visible = true;

            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
        }


        private void finalizeButton_Click(object sender, EventArgs e)
        {
            if (breakfast == 0 && lunch == 0 && dinner == 0 && cleaning == "0" && towel == "0" && surprise == "0")
                foodSupplyCheckBox.Checked = true;
            updateButton.Enabled = true;

            FinalizePayment finalizebil = new()
            {
                totalAmountFromFrontend = totalAmount,
                foodBill = foodBill
            };
            if (taskFinder)
            {
                finalizebil.paymentComboBox.SelectedItem = FPayment?.Replace(" ", string.Empty);
                finalizebil.phoneNComboBox.Text = FCnumber;
                finalizebil.monthComboBox.SelectedItem = FcardExpOne;
                finalizebil.yearComboBox.SelectedItem = FcardExpTwo;
                finalizebil.cvcComboBox.Text = FCardCVC;
            }

            finalizebil.ShowDialog();

            finalizedTotalAmount = finalizebil.FinalTotalFinalized;
            paymentType = finalizebil?.PaymentType;
            paymentCardNumber = finalizebil?.PaymentCardNumber;
            MM_YY_Of_Card = finalizebil?.MMYYOfCard1;
            CVC_Of_Card = finalizebil?.CVCOfCard1;
            CardType = finalizebil?.CardType1;

            if (!editClicked)
                submitButton.Visible = true;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            birthday = (monthComboBox.SelectedItem) + "-" + (dayComboBox.SelectedIndex + 1) + "-" + yearTextBox.Text;
            try
            {
                Reservation reservation = new()
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    BirthDay = birthday,
                    Gender = genderComboBox?.SelectedItem?.ToString() ?? string.Empty,
                    PhoneNumber = phoneNumberTextBox.Text,
                    EmailAddress = emailTextBox.Text,
                    NumberGuest = qtGuestComboBox.SelectedIndex + 1,
                    StreetAddress = addTextBox.Text,
                    AptSuite = aptTextBox.Text,
                    City = cityTextBox.Text,
                    State = stateComboBox?.SelectedItem?.ToString() ?? string.Empty,
                    ZipCode = zipComboBox.Text,
                    RoomType = roomTypeComboBox?.SelectedItem?.ToString() ?? string.Empty,
                    RoomFloor = floorComboBox?.SelectedItem?.ToString() ?? string.Empty,
                    RoomNumber = roomNComboBox?.SelectedItem?.ToString() ?? string.Empty,
                    TotalBill = finalizedTotalAmount,
                    PaymentType = paymentType ?? string.Empty,
                    CardType = CardType ?? string.Empty,
                    CardNumber = paymentCardNumber ?? string.Empty,
                    CardExp = MM_YY_Of_Card ?? string.Empty,
                    CardCvc = CVC_Of_Card ?? string.Empty,
                    ArrivalTime = entryDatePicker.Value,
                    LeavingTime = depDatePicker.Value,
                    CheckIn = checkin == 1,
                    BreakFast = breakfast,
                    Lunch = lunch,
                    Dinner = dinner,
                    SupplyStatus = foodStatus == 1,
                    Cleaning = Convert.ToInt32(cleaning) == 1,
                    Towel = Convert.ToInt32(towel) == 1,
                    SSurprise = Convert.ToInt32(surprise) == 1,
                    FoodBill = foodBill
                };
                fRONTEND_RESERVATIONContext.Reservations.Add(reservation);
                fRONTEND_RESERVATIONContext.SaveChanges();
                MessageBox.Show(this, "Entry successfully inserted into database. " + "\n\n" +
                    "Provide this unique ID to the customer." + "\n\n" +
                "USER UNIQUE ID: " + reservation.Id, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }

            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            submitButton.Visible = false;
            updateButton.Visible = false;
            deleteButton.Visible = false;
            resEditButton.Visible = false;
            reset_frontend();
        }
        public void ClearAllTextBoxes(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox box)
                    box.Clear();
                if (control.HasChildren)
                    ClearAllTextBoxes(control);
            }
        }
        public void ClearAllComboBox(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control == roomTypeComboBox)
                    continue;
                else if (control is ComboBox box)
                    box.SelectedIndex = -1;
                if (control.HasChildren)
                    ClearAllComboBox(control);
            }
        }
        private void reset_frontend()
        {
            try
            {

                resEditButton.Items.Clear();
                checkinCheckBox.Checked = false;
                foodSupplyCheckBox.Checked = false;

                ClearAllComboBox(this);
                ClearAllTextBoxes(this);

                ComboBoxItemsFromDataBase();

            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
                if (MessageBox.Show(this, "An error occurred, try again", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    Application.Exit();
                else
                    Application.Restart();
            }
        }

        private void frontend_FormClosing(object sender, FormClosingEventArgs e)
        {
            fRONTEND_RESERVATIONContext.Dispose();
            Application.Exit();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (primartyID > 1000)
            {
                try
                {
                    Reservation? reservation = fRONTEND_RESERVATIONContext.Reservations.Find(primartyID);
                    if (reservation != null)
                    {
                        fRONTEND_RESERVATIONContext.Reservations.Remove(reservation);
                        fRONTEND_RESERVATIONContext.SaveChanges();
                        MessageBox.Show(this, "Reservation For the UNIQUE USER ID of: " + "\n\n" +
                    " " + primartyID + " is DELETED.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Selected ID doesn't exist." + ex.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }
            else if (MessageBox.Show(this, "Selected ID doesn't exist.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                Application.Exit();
            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            birthday = (monthComboBox.SelectedItem) + "-" + (dayComboBox.SelectedIndex + 1) + "-" + yearTextBox.Text;
            try
            {
                Reservation? reservation = fRONTEND_RESERVATIONContext.Reservations.Find(primartyID);
                if (reservation != null)
                {
                    reservation.FirstName = firstNameTextBox.Text;
                    reservation.LastName = lastNameTextBox.Text;
                    reservation.BirthDay = birthday;
                    reservation.Gender = genderComboBox?.SelectedItem?.ToString() ?? string.Empty;
                    reservation.PhoneNumber = phoneNumberTextBox.Text;
                    reservation.EmailAddress = emailTextBox.Text;
                    reservation.NumberGuest = qtGuestComboBox.SelectedIndex + 1;
                    reservation.StreetAddress = addTextBox.Text;
                    reservation.AptSuite = aptTextBox.Text;
                    reservation.City = cityTextBox.Text;
                    reservation.State = stateComboBox?.SelectedItem?.ToString() ?? string.Empty;
                    reservation.ZipCode = zipComboBox.Text;
                    reservation.RoomType = roomTypeComboBox?.SelectedItem?.ToString() ?? string.Empty;
                    reservation.RoomFloor = floorComboBox?.SelectedItem?.ToString() ?? string.Empty;
                    reservation.RoomNumber = roomNComboBox?.SelectedItem?.ToString() ?? string.Empty;
                    reservation.TotalBill = finalizedTotalAmount;
                    reservation.PaymentType = paymentType ?? string.Empty;
                    reservation.CardType = CardType ?? string.Empty;
                    reservation.CardNumber = paymentCardNumber ?? string.Empty;
                    reservation.CardExp = MM_YY_Of_Card ?? string.Empty;
                    reservation.CardCvc = CVC_Of_Card ?? string.Empty;
                    reservation.ArrivalTime = entryDatePicker.Value;
                    reservation.LeavingTime = depDatePicker.Value;
                    reservation.CheckIn = checkin == 1;
                    reservation.BreakFast = breakfast;
                    reservation.Lunch = lunch;
                    reservation.Dinner = dinner;
                    reservation.SupplyStatus = foodStatus == 1;
                    reservation.Cleaning = Convert.ToInt32(cleaning) == 1;
                    reservation.Towel = Convert.ToInt32(towel) == 1;
                    reservation.SSurprise = Convert.ToInt32(surprise) == 1;
                    reservation.FoodBill = foodBill;
                    fRONTEND_RESERVATIONContext.SaveChanges();
                    MessageBox.Show(this, "Entry successfully updated into database. For the UNIQUE USER ID of: " + "\n\n" +
                " " + primartyID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }

            ComboBoxItemsFromDataBase();

            reset_frontend();
            LoadForDataGridView();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }

        private void checkinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkinCheckBox.Checked)
            {
                checkinCheckBox.Text = "Checked in";
                checkin = 1;
            }
            else
            {
                checkin = 0;
                checkinCheckBox.Text = "Check in ?";
            }
        }

        private void resEditButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            getChecked();
            string getQuerystring = resEditButton.Text[..4].Replace(" ", string.Empty);
            try
            {
                Reservation? reservation = fRONTEND_RESERVATIONContext.Reservations.Find(Convert.ToInt32(getQuerystring));
                if (reservation != null)
                {
                    if (reservation.Cleaning)
                        cleaning = "1";
                    else cleaning = "0";
                    if (reservation.Towel)
                        towel = "1";
                    else towel = "0";
                    if (reservation.SSurprise)
                        surprise = "1";
                    else surprise = "0";
                    roomNComboBox.Items.Add(reservation.RoomNumber ?? string.Empty);
                    roomNComboBox.SelectedItem = reservation.RoomNumber;
                    FPayment = reservation.PaymentType;
                    FCnumber = reservation.CardNumber;
                    FCardCVC = reservation.CardCvc;
                    //FcardExpOne = reservation.CardExp[..reservation.CardExp.IndexOf('/')];
                    //FcardExpTwo = reservation.CardExp[^(Math.Min(2, reservation.CardExp.Length))..];
                    string check_in = reservation.CheckIn ? "True" : "False";
                    string supply_status = reservation.SupplyStatus ? "True" : "False";
                    string food_billD = reservation.FoodBill.ToString();
                    entryDatePicker.Value = reservation.ArrivalTime;
                    depDatePicker.Value = reservation.LeavingTime;
                    entryDatePicker.Value.ToShortDateString();
                    depDatePicker.Value.ToShortDateString();
                    breakfast = reservation.BreakFast;
                    lunch = reservation.Lunch;
                    dinner = reservation.Dinner;
                    foodBill = reservation.FoodBill;
                    foodSupplyCheckBox.Checked = reservation.SupplyStatus;
                    firstNameTextBox.Text = reservation.FirstName;
                    lastNameTextBox.Text = reservation.LastName;
                    phoneNumberTextBox.Text = reservation.PhoneNumber;
                    genderComboBox.SelectedItem = reservation.Gender;
                    monthComboBox.SelectedItem = reservation.BirthDay?[..reservation.BirthDay.IndexOf('-')];
                    dayComboBox.SelectedItem = reservation.BirthDay?.Substring(reservation.BirthDay.IndexOf('-') + 1, 2);
                    yearTextBox.Text = reservation.BirthDay?[^(Math.Min(4, reservation.BirthDay.Length))..];
                    emailTextBox.Text = reservation.EmailAddress;
                    qtGuestComboBox.SelectedItem = reservation.NumberGuest.ToString();
                    addTextBox.Text = reservation.StreetAddress;
                    aptTextBox.Text = reservation.AptSuite;
                    cityTextBox.Text = reservation.City;
                    stateComboBox.SelectedItem = reservation.State;
                    zipComboBox.Text = reservation.ZipCode;
                    roomTypeComboBox.SelectedItem = reservation.RoomType.ToString().Trim();
                    floorComboBox.SelectedItem = reservation.RoomFloor.ToString().Trim();
                    roomNComboBox.SelectedItem = reservation.RoomNumber;
                    checkinCheckBox.Checked = reservation.CheckIn;
                    primartyID = reservation.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("COMBOBOX Selection: + " + ex.Message);
            }
        }

        private void ComboBoxItemsFromDataBase()
        {
            resEditButton.Items.Clear();
            try
            {
                fRONTEND_RESERVATIONContext.Reservations.Load();
                foreach (var reservation in fRONTEND_RESERVATIONContext.Reservations.AsNoTracking())
                    resEditButton.Items.Add(reservation.Id + "  | " + reservation.FirstName + "  " + reservation.LastName + " | " + reservation.PhoneNumber);
            }
            catch (Exception ex)
            {
                MessageBox.Show("COMBOBOX Selection: + " + ex.Message);
            }
        }

        private void LoadForDataGridView()
        {
            try
            {
                fRONTEND_RESERVATIONContext.Reservations.Load();
                resTotalDataGridView.DataSource = fRONTEND_RESERVATIONContext.Reservations.Local.ToBindingList();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                if (MessageBox.Show(this, "Error loading data", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.Cancel)
                    Application.Exit();
                else
                    Application.Restart();
            }
        }

        private void foodSupplyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (foodSupplyCheckBox.Checked)
            {
                foodSupplyCheckBox.Text = "Food/Supply: Complete";
                foodStatus = 1;
            }
            else
            {
                foodStatus = 0;
                foodSupplyCheckBox.Text = "Food/Supply status?";
            }
        }

        private void GetOccupiedRoom()
        {
            roomOccupiedListBox.Items.Clear();
            try
            {
                foreach (var room in fRONTEND_RESERVATIONContext.Reservations.AsNoTracking().Where(r => r.CheckIn == true))
                {
                    roomOccupiedListBox.Items.Add("[" + room.RoomNumber + "]" +
                        " " + room.RoomType +
                        " " + room.Id +
                        " " + "[" + room.FirstName +
                        " " + room.LastName + "]" +
                        " " + room.PhoneNumber);
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }

        }

        private void ReservedRoom()
        {
            roomReservedListBox.Items.Clear();
            try
            {
                foreach (var room in fRONTEND_RESERVATIONContext.Reservations.AsNoTracking().Where(r => r.CheckIn == false))
                {
                    string arrival_date = Convert.ToDateTime(room.ArrivalTime).ToString("dd-MM-yyyy");
                    string leaving_date = Convert.ToDateTime(room.LeavingTime).ToString("dd-MM-yyy");
                    roomReservedListBox.Items.Add("[" + room.RoomNumber + "]" +
                        " " + room.RoomType +
                        " " + room.Id +
                        " " + room.FirstName +
                        " " + room.LastName +
                        " " + room.PhoneNumber +
                        " " + arrival_date +
                        " " + leaving_date);
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }

        }


        private void getChecked()
        {
            roomNComboBox.Items.Clear();
            try
            {
                List<string> roomList = [.. fRONTEND_RESERVATIONContext.Reservations.AsNoTracking().Where(r => r.CheckIn == true).Select(r => r.RoomNumber.Replace(" ", string.Empty))];
                roomNComboBox.Items.AddRange([.. Enumerable.Range(101, 410).Where(r => !roomList.Contains(r.ToString())).Select(r => r.ToString())]);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }

        private void phoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            phoneNumberTextBox.Text = string.Format("{0:(000)000-0000}", Convert.ToInt64(phoneNumberTextBox.Text.Replace(" ", string.Empty)));
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new()
            {
                DataSource = fRONTEND_RESERVATIONContext.Reservations.Where(r => r.Id.ToString().Contains(searchTextBox.Text) || r.LastName.Contains(searchTextBox.Text) || r.FirstName.Contains(searchTextBox.Text) || r.Gender.Contains(searchTextBox.Text) || r.State.Contains(searchTextBox.Text) || r.City.Contains(searchTextBox.Text) || r.RoomNumber.Contains(searchTextBox.Text) || r.RoomType.Contains(searchTextBox.Text) || r.EmailAddress.Contains(searchTextBox.Text) || r.PhoneNumber.Contains(searchTextBox.Text)).ToList()
            };
            searchDataGridView.DataSource = bindingSource;
            if (searchDataGridView.Rows.Count > 0)
            {
                searchButton.Location = new Point(752, 7);
                searchTextBox.Location = new Point(68, 7);
                searchDataGridView.Visible = true;
                SearchError.Visible = false;
            }
            else
            {
                searchDataGridView.Visible = false;
                SearchError.Visible = true;
                SearchError.Text = "SORRY DUDE :(" + "\n"
                    + "I ran out of gas trying to search for " + searchTextBox.Text + "\n"
                + "I sure will find it next time.";
            }
        }
    }
}
