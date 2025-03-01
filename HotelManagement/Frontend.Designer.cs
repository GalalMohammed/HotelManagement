using System.Windows.Forms;

namespace Hotel_Manager
{
    partial class Frontend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frontend));
            resPanel = new TabControl();
            reservationPage = new TabPage();
            rightMPanel = new Panel();
            resEditButton = new ComboBox();
            newButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            updateButton = new Button();
            middlePanel = new Panel();
            foodSupplyCheckBox = new CheckBox();
            checkinCheckBox = new CheckBox();
            foodMenuButton = new Button();
            qtGuestComboBox = new ComboBox();
            finalizeButton = new Button();
            metroLabel12 = new Label();
            submitButton = new Button();
            depDatePicker = new DateTimePicker();
            roomNComboBox = new ComboBox();
            floorComboBox = new ComboBox();
            entryDatePicker = new DateTimePicker();
            entryLabel = new Label();
            roomTypeComboBox = new ComboBox();
            choiceLabel = new Label();
            leftMPanel = new Panel();
            zipLabel = new Label();
            stateLabel = new Label();
            cityLabel = new Label();
            aptLabel = new Label();
            addLabel = new Label();
            emailLabel = new Label();
            nameLabel = new Label();
            emailTextBox = new TextBox();
            yearTextBox = new TextBox();
            monthComboBox = new ComboBox();
            genderComboBox = new ComboBox();
            birthdayLabel = new Label();
            dayComboBox = new ComboBox();
            phoneNumberLabel = new Label();
            firstNameTextBox = new TextBox();
            genderLabel = new Label();
            zipComboBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            stateComboBox = new ComboBox();
            lastNameTextBox = new TextBox();
            cityTextBox = new TextBox();
            metroLabel6 = new Label();
            aptTextBox = new TextBox();
            addTextBox = new TextBox();
            searchPage = new TabPage();
            SearchError = new Label();
            searchDataGridView = new DataGridView();
            searchButton = new Button();
            searchTextBox = new TextBox();
            metroTabPage2 = new TabPage();
            resTotalDataGridView = new DataGridView();
            roomPage = new TabPage();
            metroLabel13 = new Label();
            metroLabel11 = new Label();
            reservedLabel = new Label();
            roomReservedListBox = new ListBox();
            roomOccupiedListBox = new ListBox();
            occupiedLabel = new Label();
            qtGuestLabel = new Label();
            roomTypeLabel = new Label();
            floorLabel = new Label();
            roomNLabel = new Label();
            resPanel.SuspendLayout();
            reservationPage.SuspendLayout();
            rightMPanel.SuspendLayout();
            middlePanel.SuspendLayout();
            leftMPanel.SuspendLayout();
            searchPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).BeginInit();
            metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resTotalDataGridView).BeginInit();
            roomPage.SuspendLayout();
            SuspendLayout();
            // 
            // resPanel
            // 
            resPanel.Controls.Add(reservationPage);
            resPanel.Controls.Add(searchPage);
            resPanel.Controls.Add(metroTabPage2);
            resPanel.Controls.Add(roomPage);
            resPanel.Location = new System.Drawing.Point(9, 68);
            resPanel.Margin = new Padding(4, 3, 4, 3);
            resPanel.Name = "resPanel";
            resPanel.SelectedIndex = 0;
            resPanel.Size = new System.Drawing.Size(1148, 556);
            resPanel.TabIndex = 0;
            // 
            // reservationPage
            // 
            reservationPage.Controls.Add(rightMPanel);
            reservationPage.Controls.Add(middlePanel);
            reservationPage.Controls.Add(leftMPanel);
            reservationPage.Location = new System.Drawing.Point(4, 24);
            reservationPage.Margin = new Padding(4, 3, 4, 3);
            reservationPage.Name = "reservationPage";
            reservationPage.Size = new System.Drawing.Size(1140, 528);
            reservationPage.TabIndex = 0;
            reservationPage.Text = "Reservation";
            // 
            // rightMPanel
            // 
            rightMPanel.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            rightMPanel.BackgroundImageLayout = ImageLayout.None;
            rightMPanel.Controls.Add(resEditButton);
            rightMPanel.Controls.Add(newButton);
            rightMPanel.Controls.Add(deleteButton);
            rightMPanel.Controls.Add(editButton);
            rightMPanel.Controls.Add(updateButton);
            rightMPanel.Location = new System.Drawing.Point(826, 16);
            rightMPanel.Margin = new Padding(4, 3, 4, 3);
            rightMPanel.Name = "rightMPanel";
            rightMPanel.Size = new System.Drawing.Size(309, 486);
            rightMPanel.TabIndex = 34;
            // 
            // resEditButton
            // 
            resEditButton.FlatStyle = FlatStyle.Popup;
            resEditButton.ForeColor = System.Drawing.Color.Green;
            resEditButton.FormattingEnabled = true;
            resEditButton.ItemHeight = 15;
            resEditButton.Items.AddRange(new object[] { "[ID]    [NAME]    [PHONE NUMBER]" });
            resEditButton.Location = new System.Drawing.Point(12, 35);
            resEditButton.Margin = new Padding(4, 3, 4, 3);
            resEditButton.Name = "resEditButton";
            resEditButton.Size = new System.Drawing.Size(293, 23);
            resEditButton.TabIndex = 20;
            resEditButton.Visible = false;
            resEditButton.SelectedIndexChanged += resEditButton_SelectedIndexChanged;
            // 
            // newButton
            // 
            newButton.Location = new System.Drawing.Point(12, 433);
            newButton.Margin = new Padding(4, 3, 4, 3);
            newButton.Name = "newButton";
            newButton.Size = new System.Drawing.Size(286, 37);
            newButton.TabIndex = 22;
            newButton.Text = "New reservation";
            newButton.Click += newButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new System.Drawing.Point(12, 332);
            deleteButton.Margin = new Padding(4, 3, 4, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(286, 39);
            deleteButton.TabIndex = 23;
            deleteButton.Text = "Delete";
            deleteButton.Visible = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new System.Drawing.Point(12, 387);
            editButton.Margin = new Padding(4, 3, 4, 3);
            editButton.Name = "editButton";
            editButton.Size = new System.Drawing.Size(286, 37);
            editButton.TabIndex = 18;
            editButton.Text = "Edit existing Reservation";
            editButton.Click += editButton_Click;
            // 
            // updateButton
            // 
            updateButton.Enabled = false;
            updateButton.Location = new System.Drawing.Point(12, 283);
            updateButton.Margin = new Padding(4, 3, 4, 3);
            updateButton.Name = "updateButton";
            updateButton.Size = new System.Drawing.Size(286, 39);
            updateButton.TabIndex = 19;
            updateButton.Text = "Update";
            updateButton.Visible = false;
            updateButton.Click += updateButton_Click;
            // 
            // middlePanel
            // 
            middlePanel.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            middlePanel.BackgroundImageLayout = ImageLayout.None;
            middlePanel.Controls.Add(roomNLabel);
            middlePanel.Controls.Add(floorLabel);
            middlePanel.Controls.Add(roomTypeLabel);
            middlePanel.Controls.Add(qtGuestLabel);
            middlePanel.Controls.Add(foodSupplyCheckBox);
            middlePanel.Controls.Add(checkinCheckBox);
            middlePanel.Controls.Add(foodMenuButton);
            middlePanel.Controls.Add(qtGuestComboBox);
            middlePanel.Controls.Add(finalizeButton);
            middlePanel.Controls.Add(metroLabel12);
            middlePanel.Controls.Add(submitButton);
            middlePanel.Controls.Add(depDatePicker);
            middlePanel.Controls.Add(roomNComboBox);
            middlePanel.Controls.Add(floorComboBox);
            middlePanel.Controls.Add(entryDatePicker);
            middlePanel.Controls.Add(entryLabel);
            middlePanel.Controls.Add(roomTypeComboBox);
            middlePanel.Controls.Add(choiceLabel);
            middlePanel.Location = new System.Drawing.Point(414, 16);
            middlePanel.Margin = new Padding(4, 3, 4, 3);
            middlePanel.Name = "middlePanel";
            middlePanel.Size = new System.Drawing.Size(402, 486);
            middlePanel.TabIndex = 16;
            // 
            // foodSupplyCheckBox
            // 
            foodSupplyCheckBox.AutoSize = true;
            foodSupplyCheckBox.BackColor = System.Drawing.Color.Transparent;
            foodSupplyCheckBox.Location = new System.Drawing.Point(202, 336);
            foodSupplyCheckBox.Margin = new Padding(4, 3, 4, 3);
            foodSupplyCheckBox.Name = "foodSupplyCheckBox";
            foodSupplyCheckBox.Size = new System.Drawing.Size(136, 19);
            foodSupplyCheckBox.TabIndex = 34;
            foodSupplyCheckBox.Text = "Food/Supply status ?";
            foodSupplyCheckBox.UseVisualStyleBackColor = false;
            foodSupplyCheckBox.CheckedChanged += foodSupplyCheckBox_CheckedChanged;
            // 
            // checkinCheckBox
            // 
            checkinCheckBox.AutoSize = true;
            checkinCheckBox.BackColor = System.Drawing.Color.Transparent;
            checkinCheckBox.Location = new System.Drawing.Point(32, 336);
            checkinCheckBox.Margin = new Padding(4, 3, 4, 3);
            checkinCheckBox.Name = "checkinCheckBox";
            checkinCheckBox.Size = new System.Drawing.Size(80, 19);
            checkinCheckBox.TabIndex = 33;
            checkinCheckBox.Text = "Check in ?";
            checkinCheckBox.UseVisualStyleBackColor = false;
            checkinCheckBox.CheckedChanged += checkinCheckBox_CheckedChanged;
            // 
            // foodMenuButton
            // 
            foodMenuButton.Location = new System.Drawing.Point(19, 280);
            foodMenuButton.Margin = new Padding(4, 3, 4, 3);
            foodMenuButton.Name = "foodMenuButton";
            foodMenuButton.Size = new System.Drawing.Size(366, 39);
            foodMenuButton.TabIndex = 23;
            foodMenuButton.Text = "Food and menu";
            foodMenuButton.Click += foodMenuButton_Click;
            // 
            // qtGuestComboBox
            // 
            qtGuestComboBox.FormattingEnabled = true;
            qtGuestComboBox.ItemHeight = 15;
            qtGuestComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            qtGuestComboBox.Location = new System.Drawing.Point(18, 42);
            qtGuestComboBox.Margin = new Padding(4, 3, 4, 3);
            qtGuestComboBox.Name = "qtGuestComboBox";
            qtGuestComboBox.Size = new System.Drawing.Size(176, 23);
            qtGuestComboBox.TabIndex = 25;
            // 
            // finalizeButton
            // 
            finalizeButton.Location = new System.Drawing.Point(19, 389);
            finalizeButton.Margin = new Padding(4, 3, 4, 3);
            finalizeButton.Name = "finalizeButton";
            finalizeButton.Size = new System.Drawing.Size(366, 36);
            finalizeButton.TabIndex = 22;
            finalizeButton.Text = "Finalize bill";
            finalizeButton.Click += finalizeButton_Click;
            // 
            // metroLabel12
            // 
            metroLabel12.AutoSize = true;
            metroLabel12.BackColor = System.Drawing.Color.Transparent;
            metroLabel12.Location = new System.Drawing.Point(19, 195);
            metroLabel12.Margin = new Padding(4, 0, 4, 0);
            metroLabel12.Name = "metroLabel12";
            metroLabel12.Size = new System.Drawing.Size(93, 15);
            metroLabel12.TabIndex = 32;
            metroLabel12.Text = "Deperture [date]";
            // 
            // submitButton
            // 
            submitButton.Location = new System.Drawing.Point(19, 429);
            submitButton.Margin = new Padding(4, 3, 4, 3);
            submitButton.Name = "submitButton";
            submitButton.Size = new System.Drawing.Size(366, 42);
            submitButton.TabIndex = 17;
            submitButton.Text = "Submit";
            submitButton.Visible = false;
            submitButton.Click += submitButton_Click;
            // 
            // depDatePicker
            // 
            depDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            depDatePicker.CustomFormat = "dd-MM-yyyy";
            depDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            depDatePicker.Format = DateTimePickerFormat.Custom;
            depDatePicker.Location = new System.Drawing.Point(19, 220);
            depDatePicker.Margin = new Padding(4, 3, 4, 3);
            depDatePicker.MaxDate = new System.DateTime(2025, 6, 30, 0, 0, 0, 0);
            depDatePicker.MinDate = new System.DateTime(2014, 4, 27, 0, 0, 0, 0);
            depDatePicker.Name = "depDatePicker";
            depDatePicker.Size = new System.Drawing.Size(368, 26);
            depDatePicker.TabIndex = 31;
            depDatePicker.Value = new System.DateTime(2025, 2, 26, 0, 0, 0, 0);
            // 
            // roomNComboBox
            // 
            roomNComboBox.FormattingEnabled = true;
            roomNComboBox.ItemHeight = 15;
            roomNComboBox.Items.AddRange(new object[] { "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "301", "302", "303", "304", "305", "306", "307", "308", "309", "310", "401", "402", "403", "404", "405", "406", "407", "408", "409", "410", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510" });
            roomNComboBox.Location = new System.Drawing.Point(202, 96);
            roomNComboBox.Margin = new Padding(4, 3, 4, 3);
            roomNComboBox.Name = "roomNComboBox";
            roomNComboBox.Size = new System.Drawing.Size(185, 23);
            roomNComboBox.TabIndex = 24;
            // 
            // floorComboBox
            // 
            floorComboBox.FormattingEnabled = true;
            floorComboBox.ItemHeight = 15;
            floorComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            floorComboBox.Location = new System.Drawing.Point(19, 96);
            floorComboBox.Margin = new Padding(4, 3, 4, 3);
            floorComboBox.Name = "floorComboBox";
            floorComboBox.Size = new System.Drawing.Size(176, 23);
            floorComboBox.TabIndex = 23;
            // 
            // entryDatePicker
            // 
            entryDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            entryDatePicker.CustomFormat = "dd-MM-yyyy";
            entryDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            entryDatePicker.Format = DateTimePickerFormat.Custom;
            entryDatePicker.Location = new System.Drawing.Point(19, 162);
            entryDatePicker.Margin = new Padding(4, 3, 4, 3);
            entryDatePicker.MaxDate = new System.DateTime(2025, 6, 30, 0, 0, 0, 0);
            entryDatePicker.MinDate = new System.DateTime(2014, 5, 11, 0, 0, 0, 0);
            entryDatePicker.Name = "entryDatePicker";
            entryDatePicker.Size = new System.Drawing.Size(366, 26);
            entryDatePicker.TabIndex = 26;
            entryDatePicker.Value = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            // 
            // entryLabel
            // 
            entryLabel.AutoSize = true;
            entryLabel.BackColor = System.Drawing.Color.Transparent;
            entryLabel.Location = new System.Drawing.Point(19, 136);
            entryLabel.Margin = new Padding(4, 0, 4, 0);
            entryLabel.Name = "entryLabel";
            entryLabel.Size = new System.Drawing.Size(68, 15);
            entryLabel.TabIndex = 30;
            entryLabel.Text = "Entry [date]";
            // 
            // roomTypeComboBox
            // 
            roomTypeComboBox.FormattingEnabled = true;
            roomTypeComboBox.ItemHeight = 15;
            roomTypeComboBox.Items.AddRange(new object[] { "Single", "Double", "Twin", "Duplex", "Suite" });
            roomTypeComboBox.Location = new System.Drawing.Point(202, 42);
            roomTypeComboBox.Margin = new Padding(4, 3, 4, 3);
            roomTypeComboBox.Name = "roomTypeComboBox";
            roomTypeComboBox.Size = new System.Drawing.Size(185, 23);
            roomTypeComboBox.TabIndex = 22;
            roomTypeComboBox.SelectedIndexChanged += roomTypeComboBox_SelectedIndexChanged;
            // 
            // choiceLabel
            // 
            choiceLabel.AutoSize = true;
            choiceLabel.BackColor = System.Drawing.Color.Transparent;
            choiceLabel.Location = new System.Drawing.Point(19, 9);
            choiceLabel.Margin = new Padding(4, 0, 4, 0);
            choiceLabel.Name = "choiceLabel";
            choiceLabel.Size = new System.Drawing.Size(74, 15);
            choiceLabel.TabIndex = 21;
            choiceLabel.Text = "Your choices";
            // 
            // leftMPanel
            // 
            leftMPanel.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            leftMPanel.BackgroundImageLayout = ImageLayout.None;
            leftMPanel.Controls.Add(zipLabel);
            leftMPanel.Controls.Add(stateLabel);
            leftMPanel.Controls.Add(cityLabel);
            leftMPanel.Controls.Add(aptLabel);
            leftMPanel.Controls.Add(addLabel);
            leftMPanel.Controls.Add(emailLabel);
            leftMPanel.Controls.Add(nameLabel);
            leftMPanel.Controls.Add(emailTextBox);
            leftMPanel.Controls.Add(yearTextBox);
            leftMPanel.Controls.Add(monthComboBox);
            leftMPanel.Controls.Add(genderComboBox);
            leftMPanel.Controls.Add(birthdayLabel);
            leftMPanel.Controls.Add(dayComboBox);
            leftMPanel.Controls.Add(phoneNumberLabel);
            leftMPanel.Controls.Add(firstNameTextBox);
            leftMPanel.Controls.Add(genderLabel);
            leftMPanel.Controls.Add(zipComboBox);
            leftMPanel.Controls.Add(phoneNumberTextBox);
            leftMPanel.Controls.Add(stateComboBox);
            leftMPanel.Controls.Add(lastNameTextBox);
            leftMPanel.Controls.Add(cityTextBox);
            leftMPanel.Controls.Add(metroLabel6);
            leftMPanel.Controls.Add(aptTextBox);
            leftMPanel.Controls.Add(addTextBox);
            leftMPanel.Location = new System.Drawing.Point(4, 17);
            leftMPanel.Margin = new Padding(4, 3, 4, 3);
            leftMPanel.Name = "leftMPanel";
            leftMPanel.Size = new System.Drawing.Size(402, 486);
            leftMPanel.TabIndex = 4;
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new System.Drawing.Point(201, 418);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(55, 15);
            zipLabel.TabIndex = 25;
            zipLabel.Text = "ZIP Code";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(18, 418);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(33, 15);
            stateLabel.TabIndex = 24;
            stateLabel.Text = "State";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(200, 370);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(28, 15);
            cityLabel.TabIndex = 23;
            cityLabel.Text = "City";
            // 
            // aptLabel
            // 
            aptLabel.AutoSize = true;
            aptLabel.Location = new System.Drawing.Point(18, 369);
            aptLabel.Name = "aptLabel";
            aptLabel.Size = new System.Drawing.Size(64, 15);
            aptLabel.TabIndex = 22;
            aptLabel.Text = "Apartment";
            // 
            // addLabel
            // 
            addLabel.AutoSize = true;
            addLabel.Location = new System.Drawing.Point(18, 317);
            addLabel.Name = "addLabel";
            addLabel.Size = new System.Drawing.Size(82, 15);
            addLabel.TabIndex = 21;
            addLabel.Text = "Street Address";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Location = new System.Drawing.Point(18, 260);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(111, 15);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Your e-mail address";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.Transparent;
            nameLabel.Location = new System.Drawing.Point(16, 8);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(39, 15);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name";
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = System.Drawing.Color.White;
            emailTextBox.Location = new System.Drawing.Point(18, 285);
            emailTextBox.Margin = new Padding(4, 3, 4, 3);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new System.Drawing.Size(368, 23);
            emailTextBox.TabIndex = 14;
            // 
            // yearTextBox
            // 
            yearTextBox.BackColor = System.Drawing.Color.White;
            yearTextBox.Location = new System.Drawing.Point(268, 97);
            yearTextBox.Margin = new Padding(4, 3, 4, 3);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new System.Drawing.Size(117, 23);
            yearTextBox.TabIndex = 9;
            // 
            // monthComboBox
            // 
            monthComboBox.FormattingEnabled = true;
            monthComboBox.ItemHeight = 15;
            monthComboBox.Items.AddRange(new object[] { "January ", "February ", "March ", "April ", "May ", "June ", "July ", "August ", "September ", "October ", "November ", "December" });
            monthComboBox.Location = new System.Drawing.Point(18, 97);
            monthComboBox.Margin = new Padding(4, 3, 4, 3);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new System.Drawing.Size(139, 23);
            monthComboBox.TabIndex = 6;
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.ItemHeight = 15;
            genderComboBox.Items.AddRange(new object[] { "Female", "Male", "Other" });
            genderComboBox.Location = new System.Drawing.Point(18, 162);
            genderComboBox.Margin = new Padding(4, 3, 4, 3);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new System.Drawing.Size(367, 23);
            genderComboBox.TabIndex = 11;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.BackColor = System.Drawing.Color.Transparent;
            birthdayLabel.Location = new System.Drawing.Point(14, 73);
            birthdayLabel.Margin = new Padding(4, 0, 4, 0);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(51, 15);
            birthdayLabel.TabIndex = 5;
            birthdayLabel.Text = "Birthday";
            // 
            // dayComboBox
            // 
            dayComboBox.FormattingEnabled = true;
            dayComboBox.ItemHeight = 15;
            dayComboBox.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            dayComboBox.Location = new System.Drawing.Point(164, 97);
            dayComboBox.Margin = new Padding(4, 3, 4, 3);
            dayComboBox.Name = "dayComboBox";
            dayComboBox.Size = new System.Drawing.Size(96, 23);
            dayComboBox.TabIndex = 8;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            phoneNumberLabel.Location = new System.Drawing.Point(16, 197);
            phoneNumberLabel.Margin = new Padding(4, 0, 4, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(86, 15);
            phoneNumberLabel.TabIndex = 12;
            phoneNumberLabel.Text = "Phone number";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = System.Drawing.Color.White;
            firstNameTextBox.Location = new System.Drawing.Point(18, 31);
            firstNameTextBox.Margin = new Padding(4, 3, 4, 3);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new System.Drawing.Size(180, 23);
            firstNameTextBox.TabIndex = 2;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = System.Drawing.Color.Transparent;
            genderLabel.Location = new System.Drawing.Point(15, 136);
            genderLabel.Margin = new Padding(4, 0, 4, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 15);
            genderLabel.TabIndex = 10;
            genderLabel.Text = "Gender";
            // 
            // zipComboBox
            // 
            zipComboBox.BackColor = System.Drawing.Color.White;
            zipComboBox.Location = new System.Drawing.Point(201, 436);
            zipComboBox.Margin = new Padding(4, 3, 4, 3);
            zipComboBox.Name = "zipComboBox";
            zipComboBox.Size = new System.Drawing.Size(185, 23);
            zipComboBox.TabIndex = 20;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.BackColor = System.Drawing.Color.White;
            phoneNumberTextBox.Location = new System.Drawing.Point(16, 223);
            phoneNumberTextBox.Margin = new Padding(4, 3, 4, 3);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new System.Drawing.Size(368, 23);
            phoneNumberTextBox.TabIndex = 13;
            phoneNumberTextBox.Leave += phoneNumberTextBox_Leave;
            // 
            // stateComboBox
            // 
            stateComboBox.FormattingEnabled = true;
            stateComboBox.ItemHeight = 15;
            stateComboBox.Items.AddRange(new object[] { "Alexandria", "Aswan", "Asyut", "Beheira", "Beni Suef", "Cairo", "Dakahlia", "Damietta", "Faiyum", "Gharbia", "Giza", "Ismailia", "Kafr El Sheikh", "Luxor", "Matrouh", "Minya", "Monufia", "New Valley", "North Sinai", "Port Said", "Qalyubia", "Qena", "Red Sea", "Sharqia", "Sohag", "South Sinai", "Suez" });
            stateComboBox.Location = new System.Drawing.Point(18, 436);
            stateComboBox.Margin = new Padding(4, 3, 4, 3);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new System.Drawing.Size(174, 23);
            stateComboBox.TabIndex = 19;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = System.Drawing.Color.White;
            lastNameTextBox.Location = new System.Drawing.Point(205, 31);
            lastNameTextBox.Margin = new Padding(4, 3, 4, 3);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new System.Drawing.Size(180, 23);
            lastNameTextBox.TabIndex = 3;
            // 
            // cityTextBox
            // 
            cityTextBox.BackColor = System.Drawing.Color.White;
            cityTextBox.Location = new System.Drawing.Point(200, 388);
            cityTextBox.Margin = new Padding(4, 3, 4, 3);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new System.Drawing.Size(185, 23);
            cityTextBox.TabIndex = 18;
            // 
            // metroLabel6
            // 
            metroLabel6.AutoSize = true;
            metroLabel6.BackColor = System.Drawing.Color.Transparent;
            metroLabel6.Location = new System.Drawing.Point(16, 285);
            metroLabel6.Margin = new Padding(4, 0, 4, 0);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new System.Drawing.Size(74, 15);
            metroLabel6.TabIndex = 16;
            metroLabel6.Text = "Your address";
            // 
            // aptTextBox
            // 
            aptTextBox.BackColor = System.Drawing.Color.White;
            aptTextBox.Location = new System.Drawing.Point(16, 387);
            aptTextBox.Margin = new Padding(4, 3, 4, 3);
            aptTextBox.Name = "aptTextBox";
            aptTextBox.Size = new System.Drawing.Size(176, 23);
            aptTextBox.TabIndex = 17;
            // 
            // addTextBox
            // 
            addTextBox.BackColor = System.Drawing.Color.White;
            addTextBox.Location = new System.Drawing.Point(15, 335);
            addTextBox.Margin = new Padding(4, 3, 4, 3);
            addTextBox.Name = "addTextBox";
            addTextBox.Size = new System.Drawing.Size(368, 23);
            addTextBox.TabIndex = 15;
            // 
            // searchPage
            // 
            searchPage.Controls.Add(SearchError);
            searchPage.Controls.Add(searchDataGridView);
            searchPage.Controls.Add(searchButton);
            searchPage.Controls.Add(searchTextBox);
            searchPage.Location = new System.Drawing.Point(4, 24);
            searchPage.Margin = new Padding(4, 3, 4, 3);
            searchPage.Name = "searchPage";
            searchPage.Size = new System.Drawing.Size(1140, 528);
            searchPage.TabIndex = 4;
            searchPage.Text = "Universal Search";
            // 
            // SearchError
            // 
            SearchError.AutoSize = true;
            SearchError.Location = new System.Drawing.Point(315, 43);
            SearchError.Margin = new Padding(4, 0, 4, 0);
            SearchError.Name = "SearchError";
            SearchError.Size = new System.Drawing.Size(209, 75);
            SearchError.TabIndex = 19;
            SearchError.Text = "I ran out of entries :( SORRY DUDE.\r\n\r\nYou know, we can make another deal. \r\n\r\nI sure will find something.\r\n";
            SearchError.Visible = false;
            // 
            // searchDataGridView
            // 
            searchDataGridView.AllowUserToAddRows = false;
            searchDataGridView.AllowUserToDeleteRows = false;
            searchDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchDataGridView.Location = new System.Drawing.Point(79, 47);
            searchDataGridView.Margin = new Padding(4, 3, 4, 3);
            searchDataGridView.Name = "searchDataGridView";
            searchDataGridView.ReadOnly = true;
            searchDataGridView.Size = new System.Drawing.Size(852, 272);
            searchDataGridView.TabIndex = 18;
            searchDataGridView.Visible = false;
            // 
            // searchButton
            // 
            searchButton.BackColor = System.Drawing.Color.Transparent;
            searchButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("searchButton.BackgroundImage");
            searchButton.BackgroundImageLayout = ImageLayout.Zoom;
            searchButton.Location = new System.Drawing.Point(886, 227);
            searchButton.Margin = new Padding(4, 3, 4, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new System.Drawing.Size(54, 33);
            searchButton.TabIndex = 17;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = System.Drawing.Color.White;
            searchTextBox.Location = new System.Drawing.Point(88, 227);
            searchTextBox.Margin = new Padding(4, 3, 4, 3);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new System.Drawing.Size(831, 23);
            searchTextBox.TabIndex = 15;
            // 
            // metroTabPage2
            // 
            metroTabPage2.AutoScroll = true;
            metroTabPage2.Controls.Add(resTotalDataGridView);
            metroTabPage2.Location = new System.Drawing.Point(4, 24);
            metroTabPage2.Margin = new Padding(4, 3, 4, 3);
            metroTabPage2.Name = "metroTabPage2";
            metroTabPage2.Size = new System.Drawing.Size(1140, 528);
            metroTabPage2.TabIndex = 3;
            metroTabPage2.Text = "Reservation Adv. view";
            // 
            // resTotalDataGridView
            // 
            resTotalDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resTotalDataGridView.Location = new System.Drawing.Point(0, 3);
            resTotalDataGridView.Margin = new Padding(4, 3, 4, 3);
            resTotalDataGridView.Name = "resTotalDataGridView";
            resTotalDataGridView.Size = new System.Drawing.Size(1139, 501);
            resTotalDataGridView.TabIndex = 2;
            // 
            // roomPage
            // 
            roomPage.Controls.Add(metroLabel13);
            roomPage.Controls.Add(metroLabel11);
            roomPage.Controls.Add(reservedLabel);
            roomPage.Controls.Add(roomReservedListBox);
            roomPage.Controls.Add(roomOccupiedListBox);
            roomPage.Controls.Add(occupiedLabel);
            roomPage.Location = new System.Drawing.Point(4, 24);
            roomPage.Margin = new Padding(4, 3, 4, 3);
            roomPage.Name = "roomPage";
            roomPage.Size = new System.Drawing.Size(1140, 528);
            roomPage.TabIndex = 2;
            roomPage.Text = "Room availibility";
            // 
            // metroLabel13
            // 
            metroLabel13.AutoSize = true;
            metroLabel13.BackColor = System.Drawing.Color.Transparent;
            metroLabel13.Location = new System.Drawing.Point(536, 32);
            metroLabel13.Margin = new Padding(4, 0, 4, 0);
            metroLabel13.Name = "metroLabel13";
            metroLabel13.Size = new System.Drawing.Size(392, 15);
            metroLabel13.TabIndex = 10;
            metroLabel13.Text = "Room#| Type  |  ID#   |       Name      |      Phone #      |     Entry       |    Depart";
            // 
            // metroLabel11
            // 
            metroLabel11.AutoSize = true;
            metroLabel11.BackColor = System.Drawing.Color.Transparent;
            metroLabel11.Location = new System.Drawing.Point(-4, 32);
            metroLabel11.Margin = new Padding(4, 0, 4, 0);
            metroLabel11.Name = "metroLabel11";
            metroLabel11.Size = new System.Drawing.Size(258, 15);
            metroLabel11.TabIndex = 9;
            metroLabel11.Text = "Room#| Type  |  ID#   |       Name      |      Phone #";
            // 
            // reservedLabel
            // 
            reservedLabel.AutoSize = true;
            reservedLabel.BackColor = System.Drawing.Color.Transparent;
            reservedLabel.Location = new System.Drawing.Point(536, 5);
            reservedLabel.Margin = new Padding(4, 0, 4, 0);
            reservedLabel.Name = "reservedLabel";
            reservedLabel.Size = new System.Drawing.Size(54, 15);
            reservedLabel.TabIndex = 8;
            reservedLabel.Text = "Reserved";
            // 
            // roomReservedListBox
            // 
            roomReservedListBox.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            roomReservedListBox.BorderStyle = BorderStyle.None;
            roomReservedListBox.FormattingEnabled = true;
            roomReservedListBox.HorizontalScrollbar = true;
            roomReservedListBox.IntegralHeight = false;
            roomReservedListBox.Location = new System.Drawing.Point(537, 58);
            roomReservedListBox.Margin = new Padding(4, 3, 4, 3);
            roomReservedListBox.Name = "roomReservedListBox";
            roomReservedListBox.Size = new System.Drawing.Size(602, 447);
            roomReservedListBox.TabIndex = 7;
            // 
            // roomOccupiedListBox
            // 
            roomOccupiedListBox.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            roomOccupiedListBox.BorderStyle = BorderStyle.None;
            roomOccupiedListBox.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            roomOccupiedListBox.FormattingEnabled = true;
            roomOccupiedListBox.HorizontalScrollbar = true;
            roomOccupiedListBox.IntegralHeight = false;
            roomOccupiedListBox.Location = new System.Drawing.Point(0, 58);
            roomOccupiedListBox.Margin = new Padding(4, 3, 4, 3);
            roomOccupiedListBox.Name = "roomOccupiedListBox";
            roomOccupiedListBox.Size = new System.Drawing.Size(530, 447);
            roomOccupiedListBox.TabIndex = 6;
            // 
            // occupiedLabel
            // 
            occupiedLabel.AutoSize = true;
            occupiedLabel.BackColor = System.Drawing.Color.Transparent;
            occupiedLabel.Location = new System.Drawing.Point(-4, 5);
            occupiedLabel.Margin = new Padding(4, 0, 4, 0);
            occupiedLabel.Name = "occupiedLabel";
            occupiedLabel.Size = new System.Drawing.Size(58, 15);
            occupiedLabel.TabIndex = 5;
            occupiedLabel.Text = "Occupied";
            // 
            // qtGuestLabel
            // 
            qtGuestLabel.AutoSize = true;
            qtGuestLabel.Location = new System.Drawing.Point(19, 24);
            qtGuestLabel.Name = "qtGuestLabel";
            qtGuestLabel.Size = new System.Drawing.Size(42, 15);
            qtGuestLabel.TabIndex = 35;
            qtGuestLabel.Text = "Guests";
            // 
            // roomTypeLabel
            // 
            roomTypeLabel.AutoSize = true;
            roomTypeLabel.Location = new System.Drawing.Point(202, 24);
            roomTypeLabel.Name = "roomTypeLabel";
            roomTypeLabel.Size = new System.Drawing.Size(32, 15);
            roomTypeLabel.TabIndex = 36;
            roomTypeLabel.Text = "Type";
            // 
            // floorLabel
            // 
            floorLabel.AutoSize = true;
            floorLabel.Location = new System.Drawing.Point(19, 78);
            floorLabel.Name = "floorLabel";
            floorLabel.Size = new System.Drawing.Size(34, 15);
            floorLabel.TabIndex = 37;
            floorLabel.Text = "Floor";
            // 
            // roomNLabel
            // 
            roomNLabel.AutoSize = true;
            roomNLabel.Location = new System.Drawing.Point(202, 78);
            roomNLabel.Name = "roomNLabel";
            roomNLabel.Size = new System.Drawing.Size(86, 15);
            roomNLabel.TabIndex = 38;
            roomNLabel.Text = "Room Number";
            // 
            // Frontend
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(1164, 629);
            Controls.Add(resPanel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Frontend";
            StartPosition = FormStartPosition.Manual;
            Text = "Frontend";
            FormClosing += frontend_FormClosing;
            Load += MainTab_Load;
            resPanel.ResumeLayout(false);
            reservationPage.ResumeLayout(false);
            rightMPanel.ResumeLayout(false);
            middlePanel.ResumeLayout(false);
            middlePanel.PerformLayout();
            leftMPanel.ResumeLayout(false);
            leftMPanel.PerformLayout();
            searchPage.ResumeLayout(false);
            searchPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).EndInit();
            metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resTotalDataGridView).EndInit();
            roomPage.ResumeLayout(false);
            roomPage.PerformLayout();
            ResumeLayout(false);

        }

        #endregion



        private TabControl resPanel;
        private TabPage reservationPage;
        private Panel leftMPanel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Label birthdayLabel;
        private Label nameLabel;
        private ComboBox monthComboBox;
        private TextBox yearTextBox;
        private ComboBox dayComboBox;
        private TextBox phoneNumberTextBox;
        private Label genderLabel;
        private Label phoneNumberLabel;
        private ComboBox genderComboBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Panel middlePanel;
        private TextBox zipComboBox;
        private ComboBox stateComboBox;
        private TextBox cityTextBox;
        private TextBox aptTextBox;
        private Label metroLabel6;
        private TextBox addTextBox;
        private ComboBox roomTypeComboBox;
        private Label choiceLabel;
        private ComboBox roomNComboBox;
        private ComboBox floorComboBox;
        private Button submitButton;
        private Button updateButton;
        private Button editButton;
        private Button finalizeButton;
        private Button newButton;
        private System.Windows.Forms.DateTimePicker entryDatePicker;
        private Label metroLabel12;
        private System.Windows.Forms.DateTimePicker depDatePicker;
        private Label entryLabel;
        private Button foodMenuButton;
        private Button deleteButton;
        private CheckBox checkinCheckBox;
        private ComboBox resEditButton;
        private Panel rightMPanel;

        private TabPage roomPage;
        private TabPage metroTabPage2;
      
        private System.Windows.Forms.DataGridView resTotalDataGridView;
        private CheckBox foodSupplyCheckBox;
        private System.Windows.Forms.ListBox roomOccupiedListBox;
        private Label occupiedLabel;
        private Label reservedLabel;
        private System.Windows.Forms.ListBox roomReservedListBox;
        private TabPage searchPage;
        private TextBox searchTextBox;
        private ComboBox qtGuestComboBox;
        private Label metroLabel13;
        private Label metroLabel11;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private Button searchButton;
        private Label SearchError;
        private Label addLabel;
        private Label aptLabel;
        private Label zipLabel;
        private Label stateLabel;
        private Label cityLabel;
        private Label roomNLabel;
        private Label floorLabel;
        private Label roomTypeLabel;
        private Label qtGuestLabel;
    }
}