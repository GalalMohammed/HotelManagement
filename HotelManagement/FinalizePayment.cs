using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace Hotel_Manager
{
    public partial class FinalizePayment : Form
    {
        public FinalizePayment()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public int totalAmountFromFrontend = 0;
        public int foodBill = 0;
        private double finalTotalFinalized = 0.0;
        private string? paymentType;


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double FinalTotalFinalized
        {
            get { return finalTotalFinalized; }
            set { finalTotalFinalized = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }
        private string? paymentCardNumber;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? PaymentCardNumber
        {
            get { return paymentCardNumber; }
            set { paymentCardNumber = value; }
        }
        private string? MM_YY_Of_Card;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? MMYYOfCard1
        {
            get { return MM_YY_Of_Card; }
            set { MM_YY_Of_Card = value; }
        }
        private string? CVC_Of_Card;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? CVCOfCard1
        {
            get { return CVC_Of_Card; }
            set { CVC_Of_Card = value; }
        }
        private string? CardType;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? CardType1
        {
            get { return CardType; }
            set { CardType = value; }
        }

        private void FinalizePayment_Load(object sender, EventArgs e)
        {
         
            double totalWithTax = Convert.ToDouble(totalAmountFromFrontend) * 0.07; 
            double FinalTotal = Convert.ToDouble(totalAmountFromFrontend) + totalWithTax + foodBill;
            currentBillAmount.Text = "$" + Convert.ToString(totalAmountFromFrontend)+" USD";
            foodBillAmount.Text = "$" + Convert.ToString(foodBill) + " USD";
            taxAmount.Text = "$" + Convert.ToString(totalWithTax)+" USD";
            totalAmount.Text = "$" + Convert.ToString(FinalTotal) + " USD";
            FinalTotalFinalized = FinalTotal;

        }

        private void nextButton_Click(object sender, EventArgs e)
        {   

            try
            {
                PaymentType = paymentComboBox.Text;
                PaymentCardNumber = phoneNComboBox.Text;
                MMYYOfCard1 = monthComboBox?.SelectedItem?.ToString() +"/"+ yearComboBox?.SelectedItem?.ToString();
                CVCOfCard1 = cvcComboBox.Text;
                CardType1 = cardTypeView.Text;
                
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error Closing the window", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (phoneNComboBox.Text[..1] == "3")
                cardTypeView.Text = "AmericanExpress";
            else if (phoneNComboBox.Text[..1] == "4")
                cardTypeView.Text = "Visa";
            else if (phoneNComboBox.Text[..1] == "5")
                cardTypeView.Text = "MasterCard";
            else if (phoneNComboBox.Text[..1] == "6")
                cardTypeView.Text = "Discover";
            else
                cardTypeView.Text = "Unknown";
        }

        private void phoneNComboBox_Leave(object sender, EventArgs e)
        {
            long getphn = Convert.ToInt64(phoneNComboBox.Text);
            string formatString = String.Format("{0:0000-0000-0000-0000}", getphn);
            phoneNComboBox.Text = formatString;
        }
       
    }
}
