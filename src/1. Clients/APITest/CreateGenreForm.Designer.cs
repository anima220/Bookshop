namespace APITest
{
    partial class CreateGenreForm
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
            this.abortButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.isEditableCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // abortButton
            // 
            this.abortButton.Location = new System.Drawing.Point(15, 215);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(181, 63);
            this.abortButton.TabIndex = 1;
            this.abortButton.Text = "Abbrechen";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(319, 127);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(181, 63);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Erstellen";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // isEditableCheckBox
            // 
            this.isEditableCheckBox.AutoSize = true;
            this.isEditableCheckBox.Location = new System.Drawing.Point(15, 86);
            this.isEditableCheckBox.Name = "isEditableCheckBox";
            this.isEditableCheckBox.Size = new System.Drawing.Size(91, 21);
            this.isEditableCheckBox.TabIndex = 3;
            this.isEditableCheckBox.Text = "Editierbar";
            this.isEditableCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(64, 41);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(146, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // CreateGenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.isEditableCheckBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.abortButton);
            this.Name = "CreateGenreForm";
            this.Text = "Genre erstellen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.CheckBox isEditableCheckBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
    }
}