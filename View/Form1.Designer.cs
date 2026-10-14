namespace View
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnRefresh = new Button();
            button5 = new Button();
            label1 = new Label();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            dgvPerson = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPerson).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(141, 23);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(266, 23);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(424, 23);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(562, 23);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // button5
            // 
            button5.Location = new Point(689, 23);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AccessibleName = "lblFirstName";
            label1.AutoSize = true;
            label1.Location = new Point(34, 72);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 5;
            label1.Text = "FirstName :";
            label1.Click += label1_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(34, 113);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "LastName :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(108, 69);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(564, 23);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(108, 110);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(564, 23);
            txtLastName.TabIndex = 8;
            // 
            // dgvPerson
            // 
            dgvPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerson.Location = new Point(34, 162);
            dgvPerson.Name = "dgvPerson";
            dgvPerson.Size = new Size(730, 202);
            dgvPerson.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPerson);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(btnRefresh);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnRefresh;
        private Button button5;
        private Label label1;
        private Label lblLastName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private DataGridView dgvPerson;
    }
}
