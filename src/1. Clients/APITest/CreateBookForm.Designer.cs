namespace APITest
{
    partial class CreateBookForm
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
            this.AbortButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.EditionTextBox = new System.Windows.Forms.TextBox();
            this.publishingYearDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pageCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.availabilityStateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.coverTypeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.isEbookCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pageCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityStateNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverTypeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AbortButton
            // 
            this.AbortButton.Location = new System.Drawing.Point(12, 381);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(195, 57);
            this.AbortButton.TabIndex = 1;
            this.AbortButton.Text = "Abbrechen";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(593, 288);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(195, 57);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Speichern";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titel: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Erscheinungsjahr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Auflage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seitenanzahl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vorhanden:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Preis:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ebook:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Covertyp:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "ISBN:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(137, 6);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(651, 22);
            this.titleTextBox.TabIndex = 12;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(137, 233);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(651, 22);
            this.isbnTextBox.TabIndex = 14;
            // 
            // EditionTextBox
            // 
            this.EditionTextBox.Location = new System.Drawing.Point(137, 96);
            this.EditionTextBox.Name = "EditionTextBox";
            this.EditionTextBox.Size = new System.Drawing.Size(651, 22);
            this.EditionTextBox.TabIndex = 19;
            // 
            // publishingYearDateTimePicker
            // 
            this.publishingYearDateTimePicker.Location = new System.Drawing.Point(137, 34);
            this.publishingYearDateTimePicker.Name = "publishingYearDateTimePicker";
            this.publishingYearDateTimePicker.Size = new System.Drawing.Size(246, 22);
            this.publishingYearDateTimePicker.TabIndex = 21;
            // 
            // pageCountNumericUpDown
            // 
            this.pageCountNumericUpDown.Location = new System.Drawing.Point(137, 66);
            this.pageCountNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.pageCountNumericUpDown.Name = "pageCountNumericUpDown";
            this.pageCountNumericUpDown.Size = new System.Drawing.Size(246, 22);
            this.pageCountNumericUpDown.TabIndex = 22;
            this.pageCountNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.Location = new System.Drawing.Point(137, 125);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(246, 22);
            this.priceNumericUpDown.TabIndex = 23;
            // 
            // availabilityStateNumericUpDown
            // 
            this.availabilityStateNumericUpDown.Location = new System.Drawing.Point(137, 153);
            this.availabilityStateNumericUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.availabilityStateNumericUpDown.Name = "availabilityStateNumericUpDown";
            this.availabilityStateNumericUpDown.Size = new System.Drawing.Size(246, 22);
            this.availabilityStateNumericUpDown.TabIndex = 25;
            // 
            // coverTypeNumericUpDown
            // 
            this.coverTypeNumericUpDown.Location = new System.Drawing.Point(137, 180);
            this.coverTypeNumericUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.coverTypeNumericUpDown.Name = "coverTypeNumericUpDown";
            this.coverTypeNumericUpDown.Size = new System.Drawing.Size(246, 22);
            this.coverTypeNumericUpDown.TabIndex = 27;
            // 
            // isEbookCheckBox
            // 
            this.isEbookCheckBox.AutoSize = true;
            this.isEbookCheckBox.Location = new System.Drawing.Point(137, 209);
            this.isEbookCheckBox.Name = "isEbookCheckBox";
            this.isEbookCheckBox.Size = new System.Drawing.Size(18, 17);
            this.isEbookCheckBox.TabIndex = 28;
            this.isEbookCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreateBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.isEbookCheckBox);
            this.Controls.Add(this.coverTypeNumericUpDown);
            this.Controls.Add(this.availabilityStateNumericUpDown);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.pageCountNumericUpDown);
            this.Controls.Add(this.publishingYearDateTimePicker);
            this.Controls.Add(this.EditionTextBox);
            this.Controls.Add(this.isbnTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AbortButton);
            this.Name = "CreateBookForm";
            this.Text = "Buch erstellen";
            this.Load += new System.EventHandler(this.CreateBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pageCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityStateNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverTypeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.TextBox EditionTextBox;
        private System.Windows.Forms.DateTimePicker publishingYearDateTimePicker;
        private System.Windows.Forms.NumericUpDown pageCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.NumericUpDown availabilityStateNumericUpDown;
        private System.Windows.Forms.NumericUpDown coverTypeNumericUpDown;
        private System.Windows.Forms.CheckBox isEbookCheckBox;
    }
}