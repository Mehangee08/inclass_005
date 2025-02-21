namespace inclass_005
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
            grpBox = new GroupBox();
            btnAdd = new Button();
            btnGetnewid = new Button();
            dtp = new DateTimePicker();
            txtBoxPassword = new TextBox();
            txtBoxUsername = new TextBox();
            txtBoxId = new TextBox();
            lblDate = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            lblId = new Label();
            lblError = new Label();
            grpBox.SuspendLayout();
            SuspendLayout();
            // 
            // grpBox
            // 
            grpBox.Controls.Add(btnAdd);
            grpBox.Controls.Add(btnGetnewid);
            grpBox.Controls.Add(dtp);
            grpBox.Controls.Add(txtBoxPassword);
            grpBox.Controls.Add(txtBoxUsername);
            grpBox.Controls.Add(txtBoxId);
            grpBox.Controls.Add(lblDate);
            grpBox.Controls.Add(lblPassword);
            grpBox.Controls.Add(lblUsername);
            grpBox.Controls.Add(lblId);
            grpBox.Location = new Point(160, 70);
            grpBox.Name = "grpBox";
            grpBox.Size = new Size(458, 313);
            grpBox.TabIndex = 0;
            grpBox.TabStop = false;
            grpBox.Text = "New user:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(41, 265);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(148, 34);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add new user";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnGetnewid
            // 
            btnGetnewid.Location = new Point(319, 58);
            btnGetnewid.Name = "btnGetnewid";
            btnGetnewid.Size = new Size(112, 34);
            btnGetnewid.TabIndex = 8;
            btnGetnewid.Text = "Get new ID";
            btnGetnewid.UseVisualStyleBackColor = true;
            btnGetnewid.Click += btnGetnewid_Click;
            // 
            // dtp
            // 
            dtp.Location = new Point(141, 201);
            dtp.Name = "dtp";
            dtp.Size = new Size(300, 31);
            dtp.TabIndex = 7;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(141, 156);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(150, 31);
            txtBoxPassword.TabIndex = 6;
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Location = new Point(141, 106);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(150, 31);
            txtBoxUsername.TabIndex = 5;
            // 
            // txtBoxId
            // 
            txtBoxId.Location = new Point(141, 61);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.Size = new Size(150, 31);
            txtBoxId.TabIndex = 4;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(20, 206);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(116, 25);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date created:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(17, 156);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(17, 106);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(95, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 61);
            lblId.Name = "lblId";
            lblId.Size = new Size(34, 25);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(170, 406);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 25);
            lblError.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 610);
            Controls.Add(lblError);
            Controls.Add(grpBox);
            Name = "Form1";
            Text = "Form1";
            grpBox.ResumeLayout(false);
            grpBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpBox;
        private Button btnAdd;
        private Button btnGetnewid;
        private DateTimePicker dtp;
        private TextBox txtBoxPassword;
        private TextBox txtBoxUsername;
        private TextBox txtBoxId;
        private Label lblDate;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblId;
        private Label lblError;
    }
}
