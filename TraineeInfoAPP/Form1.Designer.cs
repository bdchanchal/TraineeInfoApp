namespace TraineeInfoAPP
{
    partial class TraineeInfoUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.entrySEIDTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.entryTraineeDetailsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchSEIDTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchTraineeDetailsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalTraineeTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BITM Trainee Info";
            // 
            // entrySEIDTextBox
            // 
            this.entrySEIDTextBox.Location = new System.Drawing.Point(137, 31);
            this.entrySEIDTextBox.Name = "entrySEIDTextBox";
            this.entrySEIDTextBox.Size = new System.Drawing.Size(230, 20);
            this.entrySEIDTextBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(287, 156);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 28);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SEID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trainee Details";
            // 
            // entryTraineeDetailsTextBox
            // 
            this.entryTraineeDetailsTextBox.Location = new System.Drawing.Point(137, 60);
            this.entryTraineeDetailsTextBox.Multiline = true;
            this.entryTraineeDetailsTextBox.Name = "entryTraineeDetailsTextBox";
            this.entryTraineeDetailsTextBox.Size = new System.Drawing.Size(230, 90);
            this.entryTraineeDetailsTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.entryTraineeDetailsTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.entrySEIDTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(73, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 193);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entry Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "SEID";
            // 
            // searchSEIDTextBox
            // 
            this.searchSEIDTextBox.Location = new System.Drawing.Point(137, 22);
            this.searchSEIDTextBox.Name = "searchSEIDTextBox";
            this.searchSEIDTextBox.Size = new System.Drawing.Size(230, 20);
            this.searchSEIDTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Trainee Details";
            // 
            // searchTraineeDetailsTextBox
            // 
            this.searchTraineeDetailsTextBox.Location = new System.Drawing.Point(137, 52);
            this.searchTraineeDetailsTextBox.Multiline = true;
            this.searchTraineeDetailsTextBox.Name = "searchTraineeDetailsTextBox";
            this.searchTraineeDetailsTextBox.Size = new System.Drawing.Size(230, 90);
            this.searchTraineeDetailsTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.searchTraineeDetailsTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.searchSEIDTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(73, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 196);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Trainee";
            // 
            // totalTraineeTextBox
            // 
            this.totalTraineeTextBox.Location = new System.Drawing.Point(289, 265);
            this.totalTraineeTextBox.Multiline = true;
            this.totalTraineeTextBox.Name = "totalTraineeTextBox";
            this.totalTraineeTextBox.Size = new System.Drawing.Size(147, 32);
            this.totalTraineeTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(280, 148);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(87, 29);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // TraineeInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalTraineeTextBox);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TraineeInfoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trainee Info UI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox entrySEIDTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox entryTraineeDetailsTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchSEIDTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchTraineeDetailsTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalTraineeTextBox;
    }
}

