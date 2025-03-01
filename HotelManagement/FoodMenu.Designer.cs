using System.Windows.Forms;

namespace Hotel_Manager
{
    partial class FoodMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodMenu));
            this.foodPanel = new Panel();
            this.dinnerQTY = new TextBox();
            this.lunchQTY = new TextBox();
            this.breakfastQTY = new TextBox();
            this.dinnerPicture = new System.Windows.Forms.PictureBox();
            this.lunchPicture = new System.Windows.Forms.PictureBox();
            this.breakfastPicture = new System.Windows.Forms.PictureBox();
            this.dinnerCheckBox = new CheckBox();
            this.lunchCheckBox = new CheckBox();
            this.breakfastCheckBox = new CheckBox();
            this.metroLabel1 = new Label();
            this.needPanel = new Panel();
            this.surpriseCheckBox = new CheckBox();
            this.towelsCheckBox = new CheckBox();
            this.cleaningCheckBox = new CheckBox();
            this.metroLabel2 = new Label();
            this.nextButton = new Button();
            this.foodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastPicture)).BeginInit();
            this.needPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodPanel
            // 
            this.foodPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.foodPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.foodPanel.Controls.Add(this.dinnerQTY);
            this.foodPanel.Controls.Add(this.lunchQTY);
            this.foodPanel.Controls.Add(this.breakfastQTY);
            this.foodPanel.Controls.Add(this.dinnerPicture);
            this.foodPanel.Controls.Add(this.lunchPicture);
            this.foodPanel.Controls.Add(this.breakfastPicture);
            this.foodPanel.Controls.Add(this.dinnerCheckBox);
            this.foodPanel.Controls.Add(this.lunchCheckBox);
            this.foodPanel.Controls.Add(this.breakfastCheckBox);
            this.foodPanel.Controls.Add(this.metroLabel1);
            this.foodPanel.Location = new System.Drawing.Point(14, 63);
            this.foodPanel.Name = "foodPanel";
            this.foodPanel.Size = new System.Drawing.Size(332, 367);
            this.foodPanel.TabIndex = 5;
            // 
            // dinnerQTY
            // 
            this.dinnerQTY.BackColor = System.Drawing.Color.White;
            this.dinnerQTY.Enabled = false;
            this.dinnerQTY.Lines = new string[0];
            this.dinnerQTY.Location = new System.Drawing.Point(14, 327);
            this.dinnerQTY.MaxLength = 32767;
            this.dinnerQTY.Name = "dinnerQTY";
            this.dinnerQTY.PasswordChar = '\0';
            this.dinnerQTY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dinnerQTY.SelectedText = "";
            this.dinnerQTY.Size = new System.Drawing.Size(129, 29);
            this.dinnerQTY.TabIndex = 40;
            // 
            // lunchQTY
            // 
            this.lunchQTY.BackColor = System.Drawing.Color.White;
            this.lunchQTY.Enabled = false;
            this.lunchQTY.Lines = new string[0];
            this.lunchQTY.Location = new System.Drawing.Point(172, 181);
            this.lunchQTY.MaxLength = 32767;
            this.lunchQTY.Name = "lunchQTY";
            this.lunchQTY.PasswordChar = '\0';
            this.lunchQTY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lunchQTY.SelectedText = "";
            this.lunchQTY.Size = new System.Drawing.Size(144, 29);
            this.lunchQTY.TabIndex = 39;
            // 
            // breakfastQTY
            // 
            this.breakfastQTY.BackColor = System.Drawing.Color.White;
            this.breakfastQTY.Enabled = false;
            this.breakfastQTY.Lines = new string[0];
            this.breakfastQTY.Location = new System.Drawing.Point(14, 181);
            this.breakfastQTY.MaxLength = 32767;
            this.breakfastQTY.Name = "breakfastQTY";
            this.breakfastQTY.PasswordChar = '\0';
            this.breakfastQTY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.breakfastQTY.SelectedText = "";
            this.breakfastQTY.Size = new System.Drawing.Size(129, 29);
            this.breakfastQTY.TabIndex = 38;
            // 
            // dinnerPicture
            // 
            this.dinnerPicture.Image = ((System.Drawing.Image)(resources.GetObject("dinnerPicture.Image")));
            this.dinnerPicture.Location = new System.Drawing.Point(14, 226);
            this.dinnerPicture.Name = "dinnerPicture";
            this.dinnerPicture.Size = new System.Drawing.Size(129, 75);
            this.dinnerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dinnerPicture.TabIndex = 8;
            this.dinnerPicture.TabStop = false;
            // 
            // lunchPicture
            // 
            this.lunchPicture.Image = ((System.Drawing.Image)(resources.GetObject("lunchPicture.Image")));
            this.lunchPicture.Location = new System.Drawing.Point(172, 55);
            this.lunchPicture.Name = "lunchPicture";
            this.lunchPicture.Size = new System.Drawing.Size(144, 92);
            this.lunchPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lunchPicture.TabIndex = 7;
            this.lunchPicture.TabStop = false;
            // 
            // breakfastPicture
            // 
            this.breakfastPicture.Image = ((System.Drawing.Image)(resources.GetObject("breakfastPicture.Image")));
            this.breakfastPicture.Location = new System.Drawing.Point(14, 55);
            this.breakfastPicture.Name = "breakfastPicture";
            this.breakfastPicture.Size = new System.Drawing.Size(129, 92);
            this.breakfastPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.breakfastPicture.TabIndex = 6;
            this.breakfastPicture.TabStop = false;
            // 
            // dinnerCheckBox
            // 
            this.dinnerCheckBox.AutoSize = true;
            this.dinnerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.dinnerCheckBox.Location = new System.Drawing.Point(14, 307);
            this.dinnerCheckBox.Name = "dinnerCheckBox";
            this.dinnerCheckBox.Size = new System.Drawing.Size(110, 19);
            this.dinnerCheckBox.TabIndex = 5;
            this.dinnerCheckBox.Text = "Dinner   ($15)";
            this.dinnerCheckBox.CheckedChanged += new System.EventHandler(this.dinnerCheckBox_CheckedChanged);
            // 
            // lunchCheckBox
            // 
            this.lunchCheckBox.AutoSize = true;
            this.lunchCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.lunchCheckBox.Location = new System.Drawing.Point(172, 156);
            this.lunchCheckBox.Name = "lunchCheckBox";
            this.lunchCheckBox.Size = new System.Drawing.Size(106, 19);
            this.lunchCheckBox.TabIndex = 4;
            this.lunchCheckBox.Text = "Lunch   ($15)";
            this.lunchCheckBox.CheckedChanged += new System.EventHandler(this.lunchCheckBox_CheckedChanged);
            // 
            // breakfastCheckBox
            // 
            this.breakfastCheckBox.AutoSize = true;
            this.breakfastCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.breakfastCheckBox.Location = new System.Drawing.Point(14, 156);
            this.breakfastCheckBox.Name = "breakfastCheckBox";
            this.breakfastCheckBox.Size = new System.Drawing.Size(120, 19);
            this.breakfastCheckBox.TabIndex = 3;
            this.breakfastCheckBox.Text = "Break Fast  ($7)";
            this.breakfastCheckBox.CheckedChanged += new System.EventHandler(this.breakfastCheckBox_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(3, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(173, 28);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Food Selection";
            // 
            // needPanel
            // 
            this.needPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.needPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.needPanel.Controls.Add(this.surpriseCheckBox);
            this.needPanel.Controls.Add(this.towelsCheckBox);
            this.needPanel.Controls.Add(this.cleaningCheckBox);
            this.needPanel.Controls.Add(this.metroLabel2);
            this.needPanel.Location = new System.Drawing.Point(355, 63);
            this.needPanel.Name = "needPanel";
            this.needPanel.Size = new System.Drawing.Size(164, 326);
            this.needPanel.TabIndex = 6;
            // 
            // surpriseCheckBox
            // 
            this.surpriseCheckBox.AutoSize = true;
            this.surpriseCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.surpriseCheckBox.Location = new System.Drawing.Point(18, 128);
            this.surpriseCheckBox.Name = "surpriseCheckBox";
            this.surpriseCheckBox.Size = new System.Drawing.Size(131, 19);
            this.surpriseCheckBox.TabIndex = 44;
            this.surpriseCheckBox.Text = "Sweetest surprise";
            // 
            // towelsCheckBox
            // 
            this.towelsCheckBox.AutoSize = true;
            this.towelsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.towelsCheckBox.Location = new System.Drawing.Point(18, 91);
            this.towelsCheckBox.Name = "towelsCheckBox";
            this.towelsCheckBox.Size = new System.Drawing.Size(66, 19);
            this.towelsCheckBox.TabIndex = 42;
            this.towelsCheckBox.Text = "Towels";
            // 
            // cleaningCheckBox
            // 
            this.cleaningCheckBox.AutoSize = true;
            this.cleaningCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.cleaningCheckBox.Location = new System.Drawing.Point(18, 55);
            this.cleaningCheckBox.Name = "cleaningCheckBox";
            this.cleaningCheckBox.Size = new System.Drawing.Size(78, 19);
            this.cleaningCheckBox.TabIndex = 41;
            this.cleaningCheckBox.Text = "Cleaning";
            // 
            // metroLabel2
            // 
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.Location = new System.Drawing.Point(3, 10);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(121, 28);
            this.metroLabel2.TabIndex = 41;
            this.metroLabel2.Text = "Special needs";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(355, 396);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(164, 34);
            this.nextButton.TabIndex = 45;
            this.nextButton.Text = "Next";
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // FoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 442);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.needPanel);
            this.Controls.Add(this.foodPanel);
            this.MaximizeBox = false;
            this.Name = "FoodMenu";
            this.ShowInTaskbar = false;
            this.Text = "Food and Menu";
            this.foodPanel.ResumeLayout(false);
            this.foodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastPicture)).EndInit();
            this.needPanel.ResumeLayout(false);
            this.needPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel foodPanel;
        private Label metroLabel1;
        private System.Windows.Forms.PictureBox dinnerPicture;
        private System.Windows.Forms.PictureBox lunchPicture;
        private System.Windows.Forms.PictureBox breakfastPicture;
        public TextBox breakfastQTY;
        public TextBox dinnerQTY;
        public TextBox lunchQTY;
        private Label metroLabel2;
        public CheckBox dinnerCheckBox;
        public CheckBox lunchCheckBox;
        public CheckBox breakfastCheckBox;
        public CheckBox surpriseCheckBox;
        public CheckBox towelsCheckBox;
        public CheckBox cleaningCheckBox;
        public Panel needPanel;
        public Button nextButton;
    }
}