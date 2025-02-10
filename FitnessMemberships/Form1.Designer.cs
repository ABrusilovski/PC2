namespace My_First_Program
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
            this.typeGroupBox = new System.Windows.Forms.GroupBox();
            this.seniorRadioButton = new System.Windows.Forms.RadioButton();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.childRadioButton = new System.Windows.Forms.RadioButton();
            this.adultRadioButton = new System.Windows.Forms.RadioButton();
            this.optionsGroup = new System.Windows.Forms.GroupBox();
            this.trainerCheckBox = new System.Windows.Forms.CheckBox();
            this.karateCheckBox = new System.Windows.Forms.CheckBox();
            this.yogaCheckBox = new System.Windows.Forms.CheckBox();
            this.lengthGroup = new System.Windows.Forms.GroupBox();
            this.monthsTextBox = new System.Windows.Forms.TextBox();
            this.lengthPromptLabel = new System.Windows.Forms.Label();
            this.feesGroup = new System.Windows.Forms.GroupBox();
            this.totalFeeDisplay = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.monthlyFeeDisplay = new System.Windows.Forms.Label();
            this.monthlyLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.client_name = new System.Windows.Forms.GroupBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.first_name = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.typeGroupBox.SuspendLayout();
            this.optionsGroup.SuspendLayout();
            this.lengthGroup.SuspendLayout();
            this.feesGroup.SuspendLayout();
            this.client_name.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Controls.Add(this.seniorRadioButton);
            this.typeGroupBox.Controls.Add(this.studentRadioButton);
            this.typeGroupBox.Controls.Add(this.childRadioButton);
            this.typeGroupBox.Controls.Add(this.adultRadioButton);
            this.typeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeGroupBox.Location = new System.Drawing.Point(41, 137);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Size = new System.Drawing.Size(214, 150);
            this.typeGroupBox.TabIndex = 0;
            this.typeGroupBox.TabStop = false;
            this.typeGroupBox.Text = "Type of Membership";
            // 
            // seniorRadioButton
            // 
            this.seniorRadioButton.AutoSize = true;
            this.seniorRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seniorRadioButton.Location = new System.Drawing.Point(11, 98);
            this.seniorRadioButton.Name = "seniorRadioButton";
            this.seniorRadioButton.Size = new System.Drawing.Size(89, 17);
            this.seniorRadioButton.TabIndex = 3;
            this.seniorRadioButton.TabStop = true;
            this.seniorRadioButton.Text = "S&enior Citizen";
            this.seniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRadioButton.Location = new System.Drawing.Point(11, 75);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(62, 17);
            this.studentRadioButton.TabIndex = 2;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "&Student";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            // 
            // childRadioButton
            // 
            this.childRadioButton.AutoSize = true;
            this.childRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childRadioButton.Location = new System.Drawing.Point(11, 52);
            this.childRadioButton.Name = "childRadioButton";
            this.childRadioButton.Size = new System.Drawing.Size(108, 17);
            this.childRadioButton.TabIndex = 1;
            this.childRadioButton.TabStop = true;
            this.childRadioButton.Text = "Chil&d (12 && under)";
            this.childRadioButton.UseVisualStyleBackColor = true;
            // 
            // adultRadioButton
            // 
            this.adultRadioButton.AutoSize = true;
            this.adultRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultRadioButton.Location = new System.Drawing.Point(11, 29);
            this.adultRadioButton.Name = "adultRadioButton";
            this.adultRadioButton.Size = new System.Drawing.Size(95, 17);
            this.adultRadioButton.TabIndex = 0;
            this.adultRadioButton.TabStop = true;
            this.adultRadioButton.Text = "Standard &Adult";
            this.adultRadioButton.UseVisualStyleBackColor = true;
            // 
            // optionsGroup
            // 
            this.optionsGroup.Controls.Add(this.trainerCheckBox);
            this.optionsGroup.Controls.Add(this.karateCheckBox);
            this.optionsGroup.Controls.Add(this.yogaCheckBox);
            this.optionsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsGroup.Location = new System.Drawing.Point(292, 137);
            this.optionsGroup.Name = "optionsGroup";
            this.optionsGroup.Size = new System.Drawing.Size(242, 150);
            this.optionsGroup.TabIndex = 1;
            this.optionsGroup.TabStop = false;
            this.optionsGroup.Text = "Options";
            // 
            // trainerCheckBox
            // 
            this.trainerCheckBox.AutoSize = true;
            this.trainerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainerCheckBox.Location = new System.Drawing.Point(37, 99);
            this.trainerCheckBox.Name = "trainerCheckBox";
            this.trainerCheckBox.Size = new System.Drawing.Size(103, 17);
            this.trainerCheckBox.TabIndex = 2;
            this.trainerCheckBox.Text = "&Personal Trainer";
            this.trainerCheckBox.UseVisualStyleBackColor = true;
            // 
            // karateCheckBox
            // 
            this.karateCheckBox.AutoSize = true;
            this.karateCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.karateCheckBox.Location = new System.Drawing.Point(37, 63);
            this.karateCheckBox.Name = "karateCheckBox";
            this.karateCheckBox.Size = new System.Drawing.Size(57, 17);
            this.karateCheckBox.TabIndex = 1;
            this.karateCheckBox.Text = "&Karate";
            this.karateCheckBox.UseVisualStyleBackColor = true;
            // 
            // yogaCheckBox
            // 
            this.yogaCheckBox.AutoSize = true;
            this.yogaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yogaCheckBox.Location = new System.Drawing.Point(37, 29);
            this.yogaCheckBox.Name = "yogaCheckBox";
            this.yogaCheckBox.Size = new System.Drawing.Size(51, 17);
            this.yogaCheckBox.TabIndex = 0;
            this.yogaCheckBox.Text = "&Yoga";
            this.yogaCheckBox.UseVisualStyleBackColor = true;
            // 
            // lengthGroup
            // 
            this.lengthGroup.Controls.Add(this.monthsTextBox);
            this.lengthGroup.Controls.Add(this.lengthPromptLabel);
            this.lengthGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthGroup.Location = new System.Drawing.Point(41, 295);
            this.lengthGroup.Name = "lengthGroup";
            this.lengthGroup.Size = new System.Drawing.Size(214, 144);
            this.lengthGroup.TabIndex = 2;
            this.lengthGroup.TabStop = false;
            this.lengthGroup.Text = "Membership Length";
            // 
            // monthsTextBox
            // 
            this.monthsTextBox.Location = new System.Drawing.Point(18, 76);
            this.monthsTextBox.Name = "monthsTextBox";
            this.monthsTextBox.Size = new System.Drawing.Size(113, 20);
            this.monthsTextBox.TabIndex = 1;
            // 
            // lengthPromptLabel
            // 
            this.lengthPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthPromptLabel.Location = new System.Drawing.Point(8, 29);
            this.lengthPromptLabel.Name = "lengthPromptLabel";
            this.lengthPromptLabel.Size = new System.Drawing.Size(123, 44);
            this.lengthPromptLabel.TabIndex = 0;
            this.lengthPromptLabel.Text = "Enter the Number of Months:";
            // 
            // feesGroup
            // 
            this.feesGroup.Controls.Add(this.totalFeeDisplay);
            this.feesGroup.Controls.Add(this.totalLabel);
            this.feesGroup.Controls.Add(this.monthlyFeeDisplay);
            this.feesGroup.Controls.Add(this.monthlyLabel);
            this.feesGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesGroup.Location = new System.Drawing.Point(292, 295);
            this.feesGroup.Name = "feesGroup";
            this.feesGroup.Size = new System.Drawing.Size(242, 144);
            this.feesGroup.TabIndex = 3;
            this.feesGroup.TabStop = false;
            this.feesGroup.Text = "Membership Fees";
            // 
            // totalFeeDisplay
            // 
            this.totalFeeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalFeeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFeeDisplay.Location = new System.Drawing.Point(116, 77);
            this.totalFeeDisplay.Name = "totalFeeDisplay";
            this.totalFeeDisplay.Size = new System.Drawing.Size(74, 25);
            this.totalFeeDisplay.TabIndex = 3;
            this.totalFeeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(53, 85);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Total:";
            // 
            // monthlyFeeDisplay
            // 
            this.monthlyFeeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.monthlyFeeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyFeeDisplay.Location = new System.Drawing.Point(116, 23);
            this.monthlyFeeDisplay.Name = "monthlyFeeDisplay";
            this.monthlyFeeDisplay.Size = new System.Drawing.Size(74, 25);
            this.monthlyFeeDisplay.TabIndex = 1;
            this.monthlyFeeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthlyLabel
            // 
            this.monthlyLabel.AutoSize = true;
            this.monthlyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyLabel.Location = new System.Drawing.Point(23, 29);
            this.monthlyLabel.Name = "monthlyLabel";
            this.monthlyLabel.Size = new System.Drawing.Size(68, 13);
            this.monthlyLabel.TabIndex = 0;
            this.monthlyLabel.Text = "Monthly Fee:";
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(118, 474);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 35);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "&Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(338, 474);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 35);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(338, 569);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 35);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // client_name
            // 
            this.client_name.Controls.Add(this.last_name);
            this.client_name.Controls.Add(this.first_name);
            this.client_name.Location = new System.Drawing.Point(52, 34);
            this.client_name.Name = "client_name";
            this.client_name.Size = new System.Drawing.Size(426, 84);
            this.client_name.TabIndex = 7;
            this.client_name.TabStop = false;
            this.client_name.Text = "Client Name";
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(16, 53);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(393, 20);
            this.last_name.TabIndex = 1;
            this.last_name.Text = "last_name";
            this.last_name.Enter += new System.EventHandler(this.last_name_Enter);
            this.last_name.Leave += new System.EventHandler(this.last_name_Leave);
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(16, 24);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(394, 20);
            this.first_name.TabIndex = 0;
            this.first_name.Text = "first_name";
            this.first_name.Enter += new System.EventHandler(this.first_name_Enter);
            this.first_name.Leave += new System.EventHandler(this.first_name_Leave);
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.Location = new System.Drawing.Point(118, 569);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 35);
            this.register.TabIndex = 8;
            this.register.Text = "&Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(585, 649);
            this.Controls.Add(this.register);
            this.Controls.Add(this.client_name);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.feesGroup);
            this.Controls.Add(this.lengthGroup);
            this.Controls.Add(this.optionsGroup);
            this.Controls.Add(this.typeGroupBox);
            this.Name = "Form1";
            this.Text = "Fitness Membership Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.typeGroupBox.ResumeLayout(false);
            this.typeGroupBox.PerformLayout();
            this.optionsGroup.ResumeLayout(false);
            this.optionsGroup.PerformLayout();
            this.lengthGroup.ResumeLayout(false);
            this.lengthGroup.PerformLayout();
            this.feesGroup.ResumeLayout(false);
            this.feesGroup.PerformLayout();
            this.client_name.ResumeLayout(false);
            this.client_name.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox typeGroupBox;
        private System.Windows.Forms.RadioButton seniorRadioButton;
        private System.Windows.Forms.RadioButton studentRadioButton;
        private System.Windows.Forms.RadioButton childRadioButton;
        private System.Windows.Forms.RadioButton adultRadioButton;
        private System.Windows.Forms.GroupBox optionsGroup;
        private System.Windows.Forms.CheckBox trainerCheckBox;
        private System.Windows.Forms.CheckBox karateCheckBox;
        private System.Windows.Forms.CheckBox yogaCheckBox;
        private System.Windows.Forms.GroupBox lengthGroup;
        private System.Windows.Forms.TextBox monthsTextBox;
        private System.Windows.Forms.Label lengthPromptLabel;
        private System.Windows.Forms.GroupBox feesGroup;
        private System.Windows.Forms.Label totalFeeDisplay;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label monthlyFeeDisplay;
        private System.Windows.Forms.Label monthlyLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox client_name;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.Button register;
    }
}

