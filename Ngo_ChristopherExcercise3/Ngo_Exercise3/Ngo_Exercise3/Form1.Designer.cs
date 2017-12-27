namespace Ngo_Exercise3
{
    partial class Form1
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
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblLongDate = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnUpper = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnAddDate = new System.Windows.Forms.Button();
            this.lblDateFuture = new System.Windows.Forms.Label();
            this.btnParseCredit = new System.Windows.Forms.Button();
            this.txtCreditCard = new System.Windows.Forms.TextBox();
            this.lblCCInfo = new System.Windows.Forms.Label();
            this.lblPart1 = new System.Windows.Forms.Label();
            this.btnDates = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblStartResult = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblEndResult = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResultLabel = new System.Windows.Forms.Label();
            this.btnDateCharacteristics = new System.Windows.Forms.Button();
            this.lblDaylightHeader = new System.Windows.Forms.Label();
            this.lblLeapHeader = new System.Windows.Forms.Label();
            this.lblDaylight = new System.Windows.Forms.Label();
            this.lblLeap = new System.Windows.Forms.Label();
            this.lblBirthdayResult = new System.Windows.Forms.Label();
            this.lblLongResult = new System.Windows.Forms.Label();
            this.lblFullNameResult = new System.Windows.Forms.Label();
            this.btnOneResult = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.lblPart2 = new System.Windows.Forms.Label();
            this.lblPart3 = new System.Windows.Forms.Label();
            this.lblPart4 = new System.Windows.Forms.Label();
            this.lblResultCaluc4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(17, 35);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(123, 13);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name(First Last)";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.Location = new System.Drawing.Point(17, 70);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(53, 13);
            this.lblBirthdate.TabIndex = 3;
            this.lblBirthdate.Text = "Birthday";
            // 
            // lblLongDate
            // 
            this.lblLongDate.AutoSize = true;
            this.lblLongDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongDate.Location = new System.Drawing.Point(17, 107);
            this.lblLongDate.Name = "lblLongDate";
            this.lblLongDate.Size = new System.Drawing.Size(107, 13);
            this.lblLongDate.TabIndex = 7;
            this.lblLongDate.Text = "Long Date String ";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(124, 207);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(168, 159);
            this.txtInput.TabIndex = 8;
            // 
            // btnUpper
            // 
            this.btnUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpper.Location = new System.Drawing.Point(20, 207);
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Size = new System.Drawing.Size(98, 53);
            this.btnUpper.TabIndex = 9;
            this.btnUpper.Text = "Upper Case";
            this.btnUpper.UseVisualStyleBackColor = true;
            this.btnUpper.Click += new System.EventHandler(this.btnUpperCase_Click);
            // 
            // btnLower
            // 
            this.btnLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLower.Location = new System.Drawing.Point(20, 266);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(98, 53);
            this.btnLower.TabIndex = 11;
            this.btnLower.Text = "Lower Case";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(20, 325);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(98, 41);
            this.btnClean.TabIndex = 12;
            this.btnClean.Text = "Clear End";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnAddDate
            // 
            this.btnAddDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDate.Location = new System.Drawing.Point(20, 435);
            this.btnAddDate.Name = "btnAddDate";
            this.btnAddDate.Size = new System.Drawing.Size(272, 42);
            this.btnAddDate.TabIndex = 13;
            this.btnAddDate.Text = "Generate Date";
            this.btnAddDate.UseVisualStyleBackColor = true;
            this.btnAddDate.Click += new System.EventHandler(this.btnAddDate_Click);
            // 
            // lblDateFuture
            // 
            this.lblDateFuture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFuture.Location = new System.Drawing.Point(133, 482);
            this.lblDateFuture.Name = "lblDateFuture";
            this.lblDateFuture.Size = new System.Drawing.Size(159, 26);
            this.lblDateFuture.TabIndex = 14;
            this.lblDateFuture.Text = "(Today\'s Date + 30 Days)";
            this.lblDateFuture.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnParseCredit
            // 
            this.btnParseCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParseCredit.Location = new System.Drawing.Point(369, 86);
            this.btnParseCredit.Name = "btnParseCredit";
            this.btnParseCredit.Size = new System.Drawing.Size(213, 55);
            this.btnParseCredit.TabIndex = 16;
            this.btnParseCredit.Text = "Parse Credit Card Number";
            this.btnParseCredit.UseVisualStyleBackColor = true;
            this.btnParseCredit.Click += new System.EventHandler(this.btnParseCredit_Click);
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.Location = new System.Drawing.Point(369, 60);
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Size = new System.Drawing.Size(213, 20);
            this.txtCreditCard.TabIndex = 17;
            this.txtCreditCard.Text = "1234-6549-3216-6549";
            this.txtCreditCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCCInfo
            // 
            this.lblCCInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCInfo.Location = new System.Drawing.Point(369, 28);
            this.lblCCInfo.Name = "lblCCInfo";
            this.lblCCInfo.Size = new System.Drawing.Size(213, 29);
            this.lblCCInfo.TabIndex = 18;
            this.lblCCInfo.Text = "Please enter credit card number: Format (XXXX-XXXX-XXXX-XXXX)";
            // 
            // lblPart1
            // 
            this.lblPart1.Location = new System.Drawing.Point(441, 145);
            this.lblPart1.Name = "lblPart1";
            this.lblPart1.Size = new System.Drawing.Size(141, 16);
            this.lblPart1.TabIndex = 19;
            this.lblPart1.Text = "Part 1";
            this.lblPart1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDates
            // 
            this.btnDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDates.Location = new System.Drawing.Point(372, 240);
            this.btnDates.Name = "btnDates";
            this.btnDates.Size = new System.Drawing.Size(213, 53);
            this.btnDates.TabIndex = 20;
            this.btnDates.Text = "Calculate Date Differences";
            this.btnDates.UseVisualStyleBackColor = true;
            this.btnDates.Click += new System.EventHandler(this.btnDates_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(395, 299);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(198, 15);
            this.lblStartDate.TabIndex = 21;
            this.lblStartDate.Text = "Today\'s Date and Time (Start)";
            // 
            // lblStartResult
            // 
            this.lblStartResult.AutoSize = true;
            this.lblStartResult.Location = new System.Drawing.Point(441, 314);
            this.lblStartResult.Name = "lblStartResult";
            this.lblStartResult.Size = new System.Drawing.Size(30, 13);
            this.lblStartResult.TabIndex = 22;
            this.lblStartResult.Text = "Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(395, 339);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(207, 15);
            this.lblEndDate.TabIndex = 23;
            this.lblEndDate.Text = "Preset Birthday and Time (End)";
            // 
            // lblEndResult
            // 
            this.lblEndResult.AutoSize = true;
            this.lblEndResult.Location = new System.Drawing.Point(441, 356);
            this.lblEndResult.Name = "lblEndResult";
            this.lblEndResult.Size = new System.Drawing.Size(30, 13);
            this.lblEndResult.TabIndex = 24;
            this.lblEndResult.Text = "Date";
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(347, 377);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(290, 22);
            this.lblResult.TabIndex = 25;
            this.lblResult.Text = "Result (Days, Hours, Minutes, and Seconds)";
            // 
            // lblResultLabel
            // 
            this.lblResultLabel.Location = new System.Drawing.Point(444, 399);
            this.lblResultLabel.Name = "lblResultLabel";
            this.lblResultLabel.Size = new System.Drawing.Size(193, 22);
            this.lblResultLabel.TabIndex = 26;
            this.lblResultLabel.Text = "Result Displayed in (D, H, M, S) ";
            // 
            // btnDateCharacteristics
            // 
            this.btnDateCharacteristics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateCharacteristics.Location = new System.Drawing.Point(369, 435);
            this.btnDateCharacteristics.Name = "btnDateCharacteristics";
            this.btnDateCharacteristics.Size = new System.Drawing.Size(213, 42);
            this.btnDateCharacteristics.TabIndex = 27;
            this.btnDateCharacteristics.Text = "Date Characteristics";
            this.btnDateCharacteristics.UseVisualStyleBackColor = true;
            this.btnDateCharacteristics.Click += new System.EventHandler(this.btnDateCharacteristics_Click);
            // 
            // lblDaylightHeader
            // 
            this.lblDaylightHeader.AutoSize = true;
            this.lblDaylightHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaylightHeader.Location = new System.Drawing.Point(369, 495);
            this.lblDaylightHeader.Name = "lblDaylightHeader";
            this.lblDaylightHeader.Size = new System.Drawing.Size(156, 13);
            this.lblDaylightHeader.TabIndex = 28;
            this.lblDaylightHeader.Text = "Daylight Savings Enabled:";
            // 
            // lblLeapHeader
            // 
            this.lblLeapHeader.AutoSize = true;
            this.lblLeapHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeapHeader.Location = new System.Drawing.Point(369, 525);
            this.lblLeapHeader.Name = "lblLeapHeader";
            this.lblLeapHeader.Size = new System.Drawing.Size(69, 13);
            this.lblLeapHeader.TabIndex = 29;
            this.lblLeapHeader.Text = "Leap Year:";
            // 
            // lblDaylight
            // 
            this.lblDaylight.AutoSize = true;
            this.lblDaylight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaylight.Location = new System.Drawing.Point(545, 497);
            this.lblDaylight.Name = "lblDaylight";
            this.lblDaylight.Size = new System.Drawing.Size(48, 15);
            this.lblDaylight.TabIndex = 30;
            this.lblDaylight.Text = "Result";
            // 
            // lblLeap
            // 
            this.lblLeap.AutoSize = true;
            this.lblLeap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeap.Location = new System.Drawing.Point(545, 527);
            this.lblLeap.Name = "lblLeap";
            this.lblLeap.Size = new System.Drawing.Size(48, 15);
            this.lblLeap.TabIndex = 31;
            this.lblLeap.Text = "Result";
            // 
            // lblBirthdayResult
            // 
            this.lblBirthdayResult.Location = new System.Drawing.Point(147, 60);
            this.lblBirthdayResult.Name = "lblBirthdayResult";
            this.lblBirthdayResult.Size = new System.Drawing.Size(145, 23);
            this.lblBirthdayResult.TabIndex = 33;
            this.lblBirthdayResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLongResult
            // 
            this.lblLongResult.Location = new System.Drawing.Point(130, 86);
            this.lblLongResult.Name = "lblLongResult";
            this.lblLongResult.Size = new System.Drawing.Size(162, 55);
            this.lblLongResult.TabIndex = 35;
            this.lblLongResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFullNameResult
            // 
            this.lblFullNameResult.Location = new System.Drawing.Point(147, 34);
            this.lblFullNameResult.Name = "lblFullNameResult";
            this.lblFullNameResult.Size = new System.Drawing.Size(145, 23);
            this.lblFullNameResult.TabIndex = 32;
            this.lblFullNameResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOneResult
            // 
            this.btnOneResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneResult.Location = new System.Drawing.Point(105, 145);
            this.btnOneResult.Name = "btnOneResult";
            this.btnOneResult.Size = new System.Drawing.Size(187, 23);
            this.btnOneResult.TabIndex = 36;
            this.btnOneResult.Text = "Display Question 1 Result";
            this.btnOneResult.UseVisualStyleBackColor = true;
            this.btnOneResult.Click += new System.EventHandler(this.btnOneResult_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.infoLabel.Location = new System.Drawing.Point(112, 366);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(180, 45);
            this.infoLabel.TabIndex = 37;
            this.infoLabel.Text = "Select all text is used to demonstrate if any spaces are in the text above. ";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPart2
            // 
            this.lblPart2.Location = new System.Drawing.Point(441, 158);
            this.lblPart2.Name = "lblPart2";
            this.lblPart2.Size = new System.Drawing.Size(141, 16);
            this.lblPart2.TabIndex = 38;
            this.lblPart2.Text = "Part 2";
            this.lblPart2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPart3
            // 
            this.lblPart3.Location = new System.Drawing.Point(441, 171);
            this.lblPart3.Name = "lblPart3";
            this.lblPart3.Size = new System.Drawing.Size(141, 16);
            this.lblPart3.TabIndex = 39;
            this.lblPart3.Text = "Part 3";
            this.lblPart3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPart4
            // 
            this.lblPart4.Location = new System.Drawing.Point(441, 184);
            this.lblPart4.Name = "lblPart4";
            this.lblPart4.Size = new System.Drawing.Size(141, 16);
            this.lblPart4.TabIndex = 40;
            this.lblPart4.Text = "Part 4";
            this.lblPart4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResultCaluc4
            // 
            this.lblResultCaluc4.AutoSize = true;
            this.lblResultCaluc4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultCaluc4.Location = new System.Drawing.Point(369, 158);
            this.lblResultCaluc4.Name = "lblResultCaluc4";
            this.lblResultCaluc4.Size = new System.Drawing.Size(142, 16);
            this.lblResultCaluc4.TabIndex = 41;
            this.lblResultCaluc4.Text = "CC Number Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 561);
            this.Controls.Add(this.lblResultCaluc4);
            this.Controls.Add(this.lblPart4);
            this.Controls.Add(this.lblPart3);
            this.Controls.Add(this.lblPart2);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.btnOneResult);
            this.Controls.Add(this.lblLongResult);
            this.Controls.Add(this.lblBirthdayResult);
            this.Controls.Add(this.lblFullNameResult);
            this.Controls.Add(this.lblLeap);
            this.Controls.Add(this.lblDaylight);
            this.Controls.Add(this.lblLeapHeader);
            this.Controls.Add(this.lblDaylightHeader);
            this.Controls.Add(this.btnDateCharacteristics);
            this.Controls.Add(this.lblResultLabel);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblEndResult);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartResult);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.btnDates);
            this.Controls.Add(this.lblPart1);
            this.Controls.Add(this.lblCCInfo);
            this.Controls.Add(this.txtCreditCard);
            this.Controls.Add(this.btnParseCredit);
            this.Controls.Add(this.lblDateFuture);
            this.Controls.Add(this.btnAddDate);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnUpper);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblLongDate);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblFullName);
            this.Name = "Form1";
            this.Text = "Exercise 3 - Chris Ngo - IS350";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblLongDate;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnUpper;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnAddDate;
        private System.Windows.Forms.Label lblDateFuture;
        private System.Windows.Forms.Button btnParseCredit;
        private System.Windows.Forms.TextBox txtCreditCard;
        private System.Windows.Forms.Label lblCCInfo;
        private System.Windows.Forms.Label lblPart1;
        private System.Windows.Forms.Button btnDates;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblStartResult;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblEndResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResultLabel;
        private System.Windows.Forms.Button btnDateCharacteristics;
        private System.Windows.Forms.Label lblDaylightHeader;
        private System.Windows.Forms.Label lblLeapHeader;
        private System.Windows.Forms.Label lblDaylight;
        private System.Windows.Forms.Label lblLeap;
        private System.Windows.Forms.Label lblBirthdayResult;
        private System.Windows.Forms.Label lblLongResult;
        private System.Windows.Forms.Label lblFullNameResult;
        private System.Windows.Forms.Button btnOneResult;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label lblPart2;
        private System.Windows.Forms.Label lblPart3;
        private System.Windows.Forms.Label lblPart4;
        private System.Windows.Forms.Label lblResultCaluc4;
    }
}

