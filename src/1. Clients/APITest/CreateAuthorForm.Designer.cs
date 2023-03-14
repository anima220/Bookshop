namespace APITest
{
    partial class CreateAuthorForm
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.isAliveCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AbortButton = new System.Windows.Forms.Button();
            this.CreateAuthorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(98, 16);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(306, 22);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(98, 50);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(306, 22);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // birthdateDateTimePicker
            // 
            this.birthdateDateTimePicker.Location = new System.Drawing.Point(98, 87);
            this.birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            this.birthdateDateTimePicker.Size = new System.Drawing.Size(306, 22);
            this.birthdateDateTimePicker.TabIndex = 2;
            // 
            // isAliveCheckBox
            // 
            this.isAliveCheckBox.AutoSize = true;
            this.isAliveCheckBox.Location = new System.Drawing.Point(64, 126);
            this.isAliveCheckBox.Name = "isAliveCheckBox";
            this.isAliveCheckBox.Size = new System.Drawing.Size(18, 17);
            this.isAliveCheckBox.TabIndex = 3;
            this.isAliveCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vorname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nachname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Geburtstag:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lebt?:";
            // 
            // AbortButton
            // 
            this.AbortButton.Location = new System.Drawing.Point(12, 223);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(150, 59);
            this.AbortButton.TabIndex = 8;
            this.AbortButton.Text = "Abbrechen";
            this.AbortButton.UseVisualStyleBackColor = true;
            // 
            // CreateAuthorButton
            // 
            this.CreateAuthorButton.Location = new System.Drawing.Point(254, 163);
            this.CreateAuthorButton.Name = "CreateAuthorButton";
            this.CreateAuthorButton.Size = new System.Drawing.Size(150, 59);
            this.CreateAuthorButton.TabIndex = 9;
            this.CreateAuthorButton.Text = "Erstellen";
            this.CreateAuthorButton.UseVisualStyleBackColor = true;
            this.CreateAuthorButton.Click += new System.EventHandler(this.CreateAuthorButton_Click);
            // 
            // CreateAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 294);
            this.Controls.Add(this.CreateAuthorButton);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isAliveCheckBox);
            this.Controls.Add(this.birthdateDateTimePicker);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "CreateAuthorForm";
            this.Text = "CreateAuthorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker;
        private System.Windows.Forms.CheckBox isAliveCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.Button CreateAuthorButton;
    }
}