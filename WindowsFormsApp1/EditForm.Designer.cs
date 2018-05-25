namespace WindowsFormsApp1
{
    partial class EditForm
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
            this.fioLabel = new System.Windows.Forms.Label();
            this.markLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.ticketLabel = new System.Windows.Forms.Label();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.markTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.ticketTextBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fioLabel
            // 
            this.fioLabel.AutoSize = true;
            this.fioLabel.Location = new System.Drawing.Point(22, 48);
            this.fioLabel.Name = "fioLabel";
            this.fioLabel.Size = new System.Drawing.Size(24, 13);
            this.fioLabel.TabIndex = 0;
            this.fioLabel.Text = "FIO";
            // 
            // markLabel
            // 
            this.markLabel.AutoSize = true;
            this.markLabel.Location = new System.Drawing.Point(22, 81);
            this.markLabel.Name = "markLabel";
            this.markLabel.Size = new System.Drawing.Size(31, 13);
            this.markLabel.TabIndex = 1;
            this.markLabel.Text = "Mark";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(22, 117);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date";
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.Location = new System.Drawing.Point(22, 153);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(37, 13);
            this.ticketLabel.TabIndex = 3;
            this.ticketLabel.Text = "Ticket";
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(159, 45);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(100, 20);
            this.fioTextBox.TabIndex = 4;
            // 
            // markTextBox
            // 
            this.markTextBox.Location = new System.Drawing.Point(159, 78);
            this.markTextBox.Name = "markTextBox";
            this.markTextBox.Size = new System.Drawing.Size(100, 20);
            this.markTextBox.TabIndex = 5;
            this.markTextBox.Leave += new System.EventHandler(this.markTextBox_Leave);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(159, 114);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateTextBox.TabIndex = 6;
            // 
            // ticketTextBox
            // 
            this.ticketTextBox.Location = new System.Drawing.Point(159, 150);
            this.ticketTextBox.Name = "ticketTextBox";
            this.ticketTextBox.Size = new System.Drawing.Size(100, 20);
            this.ticketTextBox.TabIndex = 7;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.Window;
            this.saveBtn.Location = new System.Drawing.Point(104, 205);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.ticketTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.markTextBox);
            this.Controls.Add(this.fioTextBox);
            this.Controls.Add(this.ticketLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.markLabel);
            this.Controls.Add(this.fioLabel);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fioLabel;
        private System.Windows.Forms.Label markLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label ticketLabel;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.TextBox markTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox ticketTextBox;
        private System.Windows.Forms.Button saveBtn;
    }
}