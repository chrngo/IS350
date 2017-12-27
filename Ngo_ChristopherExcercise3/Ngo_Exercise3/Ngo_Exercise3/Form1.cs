using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngo_Exercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Question 1 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //added on button click. was not stated in instructions but made it better to display results
        private void btnOneResult_Click(object sender, EventArgs e)
        {
            //Init Variables that are module level. 
            string MyName = "Chris" + " " + "Ngo";
            DateTime MyBirthDate = new DateTime(1985, 1, 1);
            DateTime TodayDate = DateTime.Today;

            //Do results 
            lblFullNameResult.Text = MyName;
            lblBirthdayResult.Text = MyBirthDate.ToString("MM/dd/yyyy");
            lblLongResult.Text = TodayDate.ToLongDateString();
        }

        //Question 2 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnUpperCase_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text.ToUpper();
            txtInput.Select();
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text.ToLower();
            txtInput.Select();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text.TrimEnd();
            txtInput.Select();
        }

        //Question 3 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnAddDate_Click(object sender, EventArgs e)
        {
            DateTime tempDateVar;

            tempDateVar = DateTime.Now;
            tempDateVar = tempDateVar.AddDays(30);
            lblDateFuture.Text = tempDateVar.ToString("MM/dd/yyyy");
        }

        //Question 4 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnParseCredit_Click(object sender, EventArgs e)
        {
            string Part1, Part2, Part3, Part4;

            //get all data types and set to parts as instructed
            Part1 = txtCreditCard.Text.Substring(0, 4);
            Part2 = txtCreditCard.Text.Substring(5, 4);
            Part3 = txtCreditCard.Text.Substring(10, 4);
            Part4 = txtCreditCard.Text.Substring(15, 4);

            //Set and print to screen 
            lblPart1.Text = Part1;
            lblPart2.Text = Part2;
            lblPart3.Text = Part3;
            lblPart4.Text = Part4;
        }

        //Question 5 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnDates_Click(object sender, EventArgs e)
        {
            //Init values
            DateTime StartingDate, EndingDate;
            TimeSpan StoringVar; 

            StartingDate = new DateTime(1995, 1, 1, 0, 0, 0);
            EndingDate = DateTime.Now;

            lblStartResult.Text = System.Convert.ToString(StartingDate);
            lblEndResult.Text = System.Convert.ToString(EndingDate);

            StoringVar = EndingDate.Subtract(StartingDate);

            lblResultLabel.Text = System.Convert.ToString(StoringVar);
        }

        //Question 6 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnDateCharacteristics_Click(object sender, EventArgs e)
        {
            bool DSTResult, LeapResult;

            DSTResult =  DateTime.Now.IsDaylightSavingTime();
            LeapResult = DateTime.IsLeapYear(DateTime.Now.Year);

            lblDaylight.Text = System.Convert.ToString(DSTResult);
            lblLeap.Text = System.Convert.ToString(LeapResult);
        }
    }
}



