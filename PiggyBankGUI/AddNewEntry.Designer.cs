namespace PiggyBankGUI
{
    partial class AddNewEntry
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
            this.AmountMtb = new System.Windows.Forms.MaskedTextBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.ActualRbtn1 = new System.Windows.Forms.RadioButton();
            this.PlannedRbtn2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.NotesRtb = new System.Windows.Forms.RichTextBox();
            this.CategoryCmb = new System.Windows.Forms.ComboBox();
            this.MemberCmb = new System.Windows.Forms.ComboBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AmountMtb
            // 
            this.AmountMtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountMtb.Location = new System.Drawing.Point(29, 30);
            this.AmountMtb.Name = "AmountMtb";
            this.AmountMtb.Size = new System.Drawing.Size(118, 20);
            this.AmountMtb.TabIndex = 0;
            this.AmountMtb.Text = "Enter Amount";
            this.AmountMtb.Click += new System.EventHandler(this.AmountMtb_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(207, 30);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 20);
            this.DatePicker.TabIndex = 1;
            // 
            // ActualRbtn1
            // 
            this.ActualRbtn1.AutoSize = true;
            this.ActualRbtn1.Location = new System.Drawing.Point(29, 102);
            this.ActualRbtn1.Name = "ActualRbtn1";
            this.ActualRbtn1.Size = new System.Drawing.Size(55, 17);
            this.ActualRbtn1.TabIndex = 2;
            this.ActualRbtn1.TabStop = true;
            this.ActualRbtn1.Text = "Actual";
            this.ActualRbtn1.UseVisualStyleBackColor = true;
            // 
            // PlannedRbtn2
            // 
            this.PlannedRbtn2.AutoSize = true;
            this.PlannedRbtn2.Location = new System.Drawing.Point(29, 126);
            this.PlannedRbtn2.Name = "PlannedRbtn2";
            this.PlannedRbtn2.Size = new System.Drawing.Size(64, 17);
            this.PlannedRbtn2.TabIndex = 3;
            this.PlannedRbtn2.TabStop = true;
            this.PlannedRbtn2.Text = "Planned";
            this.PlannedRbtn2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Operation status:";
            // 
            // NotesRtb
            // 
            this.NotesRtb.Location = new System.Drawing.Point(207, 83);
            this.NotesRtb.Name = "NotesRtb";
            this.NotesRtb.Size = new System.Drawing.Size(200, 69);
            this.NotesRtb.TabIndex = 5;
            this.NotesRtb.Text = "Notes";
            this.NotesRtb.Click += new System.EventHandler(this.NotesRtb_Click);
            // 
            // CategoryCmb
            // 
            this.CategoryCmb.FormattingEnabled = true;
            this.CategoryCmb.Location = new System.Drawing.Point(29, 196);
            this.CategoryCmb.Name = "CategoryCmb";
            this.CategoryCmb.Size = new System.Drawing.Size(121, 21);
            this.CategoryCmb.TabIndex = 6;
            this.CategoryCmb.Text = "Choose Category";
            // 
            // MemberCmb
            // 
            this.MemberCmb.FormattingEnabled = true;
            this.MemberCmb.Location = new System.Drawing.Point(207, 195);
            this.MemberCmb.Name = "MemberCmb";
            this.MemberCmb.Size = new System.Drawing.Size(121, 21);
            this.MemberCmb.TabIndex = 7;
            this.MemberCmb.Text = "Choose Member";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(284, 250);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(365, 250);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddNewEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 297);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.MemberCmb);
            this.Controls.Add(this.CategoryCmb);
            this.Controls.Add(this.NotesRtb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlannedRbtn2);
            this.Controls.Add(this.ActualRbtn1);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.AmountMtb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddNewEntry";
            this.Text = "Add New Entry";
            this.Load += new System.EventHandler(this.AddNewEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox AmountMtb;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.RadioButton ActualRbtn1;
        private System.Windows.Forms.RadioButton PlannedRbtn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox NotesRtb;
        private System.Windows.Forms.ComboBox CategoryCmb;
        private System.Windows.Forms.ComboBox MemberCmb;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}

