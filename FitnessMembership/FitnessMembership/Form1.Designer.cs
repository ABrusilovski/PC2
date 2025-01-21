namespace FitnessMembership
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
            this.membershipType = new System.Windows.Forms.GroupBox();
            this.options = new System.Windows.Forms.GroupBox();
            this.membershipLength = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // membershipType
            // 
            this.membershipType.Location = new System.Drawing.Point(25, 31);
            this.membershipType.Name = "membershipType";
            this.membershipType.Size = new System.Drawing.Size(175, 163);
            this.membershipType.TabIndex = 0;
            this.membershipType.TabStop = false;
            this.membershipType.Text = "Type of Membership";
            this.membershipType.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // options
            // 
            this.options.Location = new System.Drawing.Point(269, 41);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(357, 152);
            this.options.TabIndex = 1;
            this.options.TabStop = false;
            this.options.Text = "Options";
            this.options.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // membershipLength
            // 
            this.membershipLength.Location = new System.Drawing.Point(25, 231);
            this.membershipLength.Name = "membershipLength";
            this.membershipLength.Size = new System.Drawing.Size(174, 177);
            this.membershipLength.TabIndex = 2;
            this.membershipLength.TabStop = false;
            this.membershipLength.Text = "Membership Length";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(274, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 170);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.membershipLength);
            this.Controls.Add(this.options);
            this.Controls.Add(this.membershipType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox membershipType;
        private System.Windows.Forms.GroupBox options;
        private System.Windows.Forms.GroupBox membershipLength;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

