using Hotel_Manager.FRONTEND_RESERVATIONModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
namespace Hotel_Manager
{
    public partial class Kitchen : Form
    {
        string? cleaning, towel, surprise, queryString;
        int breakfast, lunch, dinner, foodBill;
        public int primaryID;
        double totalBill;
        bool supply_status = false;

        readonly FRONTEND_RESERVATIONContext fRONTEND_RESERVATIONContext = new(new DbContextOptionsBuilder<FRONTEND_RESERVATIONContext>().UseSqlServer(ConfigurationManager.ConnectionStrings["Hotel_Manager.Properties.Settings.frontend_reservationConnectionString"].ConnectionString).Options);
        public Kitchen()
        {
            InitializeComponent();

        }
        private void kitchen_Load(object sender, EventArgs e)
        {
            LoadForDataGridView();
            listBoxFromDataBase();
            FormClosing += (sender, e) =>
            {
                fRONTEND_RESERVATIONContext.Dispose();
                Application.Exit();
            };
        }

        private void LoadForDataGridView()
        {
            try
            {
                BindingSource bindingSource = new()
                {
                    DataSource = fRONTEND_RESERVATIONContext.Reservations.Where(r => r.CheckIn == true && r.SupplyStatus == false).Select(Select => new
                    {
                        Select.Id,
                        Select.FirstName,
                        Select.LastName,
                        Select.PhoneNumber,
                        Select.RoomType,
                        Select.RoomFloor,
                        Select.RoomNumber,
                        Select.BreakFast,
                        Select.Lunch,
                        Select.Dinner,
                        Select.Cleaning,
                        Select.Towel,
                        Select.SSurprise,
                        Select.SupplyStatus,
                        Select.FoodBill
                    }).ToList()
                };
                overviewDataGridView.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                if (MessageBox.Show(this, "Error loading data", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.None) == DialogResult.Retry)
                    LoadForDataGridView();
                else
                    Application.Exit();
            }
        }

        private void resetEntries(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox box)
                    box.Clear();
                if (control.HasChildren)
                    resetEntries(control);
            }

        }
        private void listBoxFromDataBase()
        {
            queueListBox.Items.Clear();
            try
            {
                foreach (var item in fRONTEND_RESERVATIONContext.Reservations.Where(r => r.CheckIn == true && r.SupplyStatus == false))
                    queueListBox.Items.Add(item.Id + "  | " + item.FirstName + "  " + item.LastName + " | " + item.PhoneNumber);
            }
            catch (Exception ex)
            {
                MessageBox.Show("LISTBOX: + " + ex.Message);
            }
        }

        private void queueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetEntries(this);
            string getQuerystring = queueListBox.Text[..4].Replace(" ", string.Empty);
            queryString = "Select * from reservation where Id= '" + getQuerystring + "'";
            try
            {
                Reservation? reservation = fRONTEND_RESERVATIONContext.Reservations.Find(Convert.ToInt32(getQuerystring));
                if (reservation != null) {
                    if (reservation.Cleaning)
                    {
                        cleaning = "1";
                        cleaningCheckBox.Checked = true;
                    }
                    else cleaning = "0";
                    if (reservation.Towel)
                    {
                        towel = "1";
                        towelCheckBox.Checked = true;
                    }
                    else towel = "0";
                    if (reservation.SSurprise)
                    {
                        surprise = "1";
                        surpriseCheckBox.Checked = true;
                    }
                    else surprise = "0";
                    lunchTextBox.Text = Convert.ToString(reservation.Lunch);
                    breakfastTextBox.Text = Convert.ToString(reservation.BreakFast);
                    dinnerTextBox.Text = Convert.ToString(reservation.Dinner);
                    supplyCheckBox.Checked = reservation.SupplyStatus;
                    firstNameTextBox.Text = reservation.FirstName;
                    lastNameTextBox.Text = reservation.LastName;
                    phoneNTextBox.Text = reservation.PhoneNumber;
                    roomTypeTextBox.Text = reservation.RoomType;
                    floorNTextBox.Text = reservation.RoomFloor;
                    roomNTextBox.Text = reservation.RoomNumber;
                    totalBill = reservation.TotalBill;
                    foodBill = reservation.FoodBill;
                    totalBill -= foodBill;
                    primaryID = reservation.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("COMBOBOX Selection: + " + ex.Message);
            }
        }

        private void foodSelectionButton_Click(object sender, EventArgs e)
        {
            FoodMenu food_menu = new();
            food_menu.needPanel.Visible = false;
            food_menu.ShowDialog();
            breakfast = food_menu.BreakfastQ;
            lunch = food_menu.LunchQ;
            dinner = food_menu.DinnerQ;
            int bfast= 0, Lnch= 0, di_ner = 0;
            if (breakfast > 0)
                bfast = 7 * breakfast;
            if (lunch > 0)
                Lnch = 15 * lunch;
            if (dinner > 0)
                di_ner = 15 * dinner;
            foodBill += (bfast + Lnch + di_ner);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (primaryID > 1000)
            {
                try
                {
                    Reservation? reservation = fRONTEND_RESERVATIONContext.Reservations.Find(primaryID);
                    if (reservation != null)
                    {
                        reservation.TotalBill = totalBill + foodBill;
                        reservation.BreakFast = breakfast;
                        reservation.Lunch = lunch;
                        reservation.Dinner = dinner;
                        reservation.SupplyStatus = supply_status;
                        reservation.Cleaning = cleaning == "1";
                        reservation.Towel = towel == "1";
                        reservation.SSurprise = surprise == "1";
                        reservation.FoodBill = foodBill;
                        fRONTEND_RESERVATIONContext.SaveChanges();
                        MessageBox.Show(this, "Entry successfully updated into database. For the UNIQUE USER ID of: " + "\n\n" +
                        " " + primaryID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        listBoxFromDataBase();
                        LoadForDataGridView();
                        resetEntries(this);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error updating data. " + ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            else
                MessageBox.Show(this, "Selected ID doesn't exist.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }

        private void supplyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            cleaningCheckBox.Checked = false;
            cleaningCheckBox.Text = "Cleaned";
            towelCheckBox.Checked = false;
            towelCheckBox.Text = "Toweled";
            surpriseCheckBox.Checked = false;
            surpriseCheckBox.Text = "Surprised";
            supply_status = true;
        }
        private void kitchen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
