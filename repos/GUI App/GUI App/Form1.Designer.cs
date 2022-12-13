namespace GUI_App
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
            this.SgnIn = new System.Windows.Forms.Button();
            this.SgnInPanel = new System.Windows.Forms.Panel();
            this.BckBtn = new System.Windows.Forms.Button();
            this.WrongData = new System.Windows.Forms.Label();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.Pswd = new System.Windows.Forms.TextBox();
            this.Usnm = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.SgnUpPanel = new System.Windows.Forms.Panel();
            this.SgnUpButton = new System.Windows.Forms.Button();
            this.BckButton2 = new System.Windows.Forms.Button();
            this.SgUAG = new System.Windows.Forms.TextBox();
            this.SgUNM = new System.Windows.Forms.TextBox();
            this.SgUPW = new System.Windows.Forms.TextBox();
            this.SgUUN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.Button();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.EditPWPanel = new System.Windows.Forms.Panel();
            this.NewPWInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.OldPWInput = new System.Windows.Forms.TextBox();
            this.PWLabel = new System.Windows.Forms.Label();
            this.EditPWBtn = new System.Windows.Forms.Button();
            this.CancelPW = new System.Windows.Forms.Button();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.NewDatLabel = new System.Windows.Forms.Label();
            this.NewInfo = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.EditPW = new System.Windows.Forms.Button();
            this.EditUN = new System.Windows.Forms.Button();
            this.EditAge = new System.Windows.Forms.Button();
            this.EditName = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SgnInPanel.SuspendLayout();
            this.SgnUpPanel.SuspendLayout();
            this.DataPanel.SuspendLayout();
            this.EditPWPanel.SuspendLayout();
            this.EditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SgnIn
            // 
            this.SgnIn.Location = new System.Drawing.Point(156, 98);
            this.SgnIn.Name = "SgnIn";
            this.SgnIn.Size = new System.Drawing.Size(94, 29);
            this.SgnIn.TabIndex = 0;
            this.SgnIn.Text = "Sign In";
            this.SgnIn.UseVisualStyleBackColor = true;
            this.SgnIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SgnInPanel
            // 
            this.SgnInPanel.Controls.Add(this.BckBtn);
            this.SgnInPanel.Controls.Add(this.WrongData);
            this.SgnInPanel.Controls.Add(this.Pswd);
            this.SgnInPanel.Controls.Add(this.Usnm);
            this.SgnInPanel.Controls.Add(this.Password);
            this.SgnInPanel.Controls.Add(this.Username);
            this.SgnInPanel.Controls.Add(this.SignInBtn);
            this.SgnInPanel.Location = new System.Drawing.Point(131, 26);
            this.SgnInPanel.Name = "SgnInPanel";
            this.SgnInPanel.Size = new System.Drawing.Size(403, 197);
            this.SgnInPanel.TabIndex = 2;
            this.SgnInPanel.Visible = false;
            // 
            // BckBtn
            // 
            this.BckBtn.Location = new System.Drawing.Point(12, 152);
            this.BckBtn.Name = "BckBtn";
            this.BckBtn.Size = new System.Drawing.Size(94, 29);
            this.BckBtn.TabIndex = 6;
            this.BckBtn.Text = "Back";
            this.BckBtn.UseVisualStyleBackColor = true;
            this.BckBtn.Click += new System.EventHandler(this.BckBtn_Click);
            // 
            // WrongData
            // 
            this.WrongData.AutoSize = true;
            this.WrongData.Location = new System.Drawing.Point(106, 122);
            this.WrongData.Name = "WrongData";
            this.WrongData.Size = new System.Drawing.Size(0, 20);
            this.WrongData.TabIndex = 5;
            // 
            // SignInBtn
            // 
            this.SignInBtn.Location = new System.Drawing.Point(289, 152);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(94, 29);
            this.SignInBtn.TabIndex = 4;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // Pswd
            // 
            this.Pswd.Location = new System.Drawing.Point(152, 89);
            this.Pswd.Name = "Pswd";
            this.Pswd.Size = new System.Drawing.Size(125, 27);
            this.Pswd.TabIndex = 3;
            // 
            // Usnm
            // 
            this.Usnm.Location = new System.Drawing.Point(152, 42);
            this.Usnm.Name = "Usnm";
            this.Usnm.Size = new System.Drawing.Size(125, 27);
            this.Usnm.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(48, 89);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(70, 20);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(48, 49);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(75, 20);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // SgnUpPanel
            // 
            this.SgnUpPanel.Controls.Add(this.SgnUpButton);
            this.SgnUpPanel.Controls.Add(this.BckButton2);
            this.SgnUpPanel.Controls.Add(this.SgUAG);
            this.SgnUpPanel.Controls.Add(this.SgUNM);
            this.SgnUpPanel.Controls.Add(this.SgUPW);
            this.SgnUpPanel.Controls.Add(this.SgUUN);
            this.SgnUpPanel.Controls.Add(this.label5);
            this.SgnUpPanel.Controls.Add(this.label4);
            this.SgnUpPanel.Controls.Add(this.label3);
            this.SgnUpPanel.Controls.Add(this.label2);
            this.SgnUpPanel.Location = new System.Drawing.Point(74, 2);
            this.SgnUpPanel.Name = "SgnUpPanel";
            this.SgnUpPanel.Size = new System.Drawing.Size(544, 285);
            this.SgnUpPanel.TabIndex = 3;
            // 
            // SgnUpButton
            // 
            this.SgnUpButton.Location = new System.Drawing.Point(434, 236);
            this.SgnUpButton.Name = "SgnUpButton";
            this.SgnUpButton.Size = new System.Drawing.Size(94, 29);
            this.SgnUpButton.TabIndex = 3;
            this.SgnUpButton.Text = "Sign Up";
            this.SgnUpButton.UseVisualStyleBackColor = true;
            this.SgnUpButton.Click += new System.EventHandler(this.SgnUpButton_Click);
            // 
            // BckButton2
            // 
            this.BckButton2.Location = new System.Drawing.Point(17, 236);
            this.BckButton2.Name = "BckButton2";
            this.BckButton2.Size = new System.Drawing.Size(94, 29);
            this.BckButton2.TabIndex = 2;
            this.BckButton2.Text = "Back";
            this.BckButton2.UseVisualStyleBackColor = true;
            this.BckButton2.Click += new System.EventHandler(this.BckButton2_Click);
            // 
            // SgUAG
            // 
            this.SgUAG.Location = new System.Drawing.Point(284, 200);
            this.SgUAG.Name = "SgUAG";
            this.SgUAG.Size = new System.Drawing.Size(125, 27);
            this.SgUAG.TabIndex = 1;
            // 
            // SgUNM
            // 
            this.SgUNM.Location = new System.Drawing.Point(284, 145);
            this.SgUNM.Name = "SgUNM";
            this.SgUNM.Size = new System.Drawing.Size(125, 27);
            this.SgUNM.TabIndex = 1;
            // 
            // SgUPW
            // 
            this.SgUPW.Location = new System.Drawing.Point(284, 83);
            this.SgUPW.Name = "SgUPW";
            this.SgUPW.Size = new System.Drawing.Size(125, 27);
            this.SgUPW.TabIndex = 1;
            // 
            // SgUUN
            // 
            this.SgUUN.Location = new System.Drawing.Point(284, 22);
            this.SgUUN.Name = "SgUUN";
            this.SgUUN.Size = new System.Drawing.Size(125, 27);
            this.SgUUN.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(440, 98);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(94, 29);
            this.SignUp.TabIndex = 4;
            this.SignUp.Text = "Sign Up";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // DataPanel
            // 
            this.DataPanel.Controls.Add(this.EditPWPanel);
            this.DataPanel.Controls.Add(this.EditPanel);
            this.DataPanel.Controls.Add(this.EditPW);
            this.DataPanel.Controls.Add(this.EditUN);
            this.DataPanel.Controls.Add(this.EditAge);
            this.DataPanel.Controls.Add(this.EditName);
            this.DataPanel.Controls.Add(this.label13);
            this.DataPanel.Controls.Add(this.UsernameLabel);
            this.DataPanel.Controls.Add(this.AgeLabel);
            this.DataPanel.Controls.Add(this.NameLabel);
            this.DataPanel.Controls.Add(this.label9);
            this.DataPanel.Controls.Add(this.label8);
            this.DataPanel.Controls.Add(this.label7);
            this.DataPanel.Controls.Add(this.label6);
            this.DataPanel.Location = new System.Drawing.Point(131, 2);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(413, 285);
            this.DataPanel.TabIndex = 7;
            // 
            // EditPWPanel
            // 
            this.EditPWPanel.Controls.Add(this.NewPWInput);
            this.EditPWPanel.Controls.Add(this.label11);
            this.EditPWPanel.Controls.Add(this.OldPWInput);
            this.EditPWPanel.Controls.Add(this.PWLabel);
            this.EditPWPanel.Controls.Add(this.EditPWBtn);
            this.EditPWPanel.Controls.Add(this.CancelPW);
            this.EditPWPanel.Location = new System.Drawing.Point(58, 35);
            this.EditPWPanel.Name = "EditPWPanel";
            this.EditPWPanel.Size = new System.Drawing.Size(250, 217);
            this.EditPWPanel.TabIndex = 4;
            // 
            // NewPWInput
            // 
            this.NewPWInput.Location = new System.Drawing.Point(59, 119);
            this.NewPWInput.Name = "NewPWInput";
            this.NewPWInput.Size = new System.Drawing.Size(125, 27);
            this.NewPWInput.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Input your new password";
            // 
            // OldPWInput
            // 
            this.OldPWInput.Location = new System.Drawing.Point(59, 46);
            this.OldPWInput.Name = "OldPWInput";
            this.OldPWInput.Size = new System.Drawing.Size(125, 27);
            this.OldPWInput.TabIndex = 2;
            // 
            // PWLabel
            // 
            this.PWLabel.AutoSize = true;
            this.PWLabel.Location = new System.Drawing.Point(31, 17);
            this.PWLabel.Name = "PWLabel";
            this.PWLabel.Size = new System.Drawing.Size(169, 20);
            this.PWLabel.TabIndex = 1;
            this.PWLabel.Text = "Input your old password";
            // 
            // EditPWBtn
            // 
            this.EditPWBtn.Location = new System.Drawing.Point(136, 171);
            this.EditPWBtn.Name = "EditPWBtn";
            this.EditPWBtn.Size = new System.Drawing.Size(94, 29);
            this.EditPWBtn.TabIndex = 0;
            this.EditPWBtn.Text = "Confirm";
            this.EditPWBtn.UseVisualStyleBackColor = true;
            this.EditPWBtn.Click += new System.EventHandler(this.EditPWBtn_Click);
            // 
            // CancelPW
            // 
            this.CancelPW.Location = new System.Drawing.Point(12, 171);
            this.CancelPW.Name = "CancelPW";
            this.CancelPW.Size = new System.Drawing.Size(94, 29);
            this.CancelPW.TabIndex = 0;
            this.CancelPW.Text = "Cancel";
            this.CancelPW.UseVisualStyleBackColor = true;
            this.CancelPW.Click += new System.EventHandler(this.CancelPW_Click);
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.NewDatLabel);
            this.EditPanel.Controls.Add(this.NewInfo);
            this.EditPanel.Controls.Add(this.Cancel);
            this.EditPanel.Controls.Add(this.Confirm);
            this.EditPanel.Controls.Add(this.toolStrip1);
            this.EditPanel.Location = new System.Drawing.Point(69, 55);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(250, 161);
            this.EditPanel.TabIndex = 3;
            // 
            // NewDatLabel
            // 
            this.NewDatLabel.AutoSize = true;
            this.NewDatLabel.Location = new System.Drawing.Point(39, 31);
            this.NewDatLabel.Name = "NewDatLabel";
            this.NewDatLabel.Size = new System.Drawing.Size(58, 20);
            this.NewDatLabel.TabIndex = 3;
            this.NewDatLabel.Text = "label10";
            // 
            // NewInfo
            // 
            this.NewInfo.Location = new System.Drawing.Point(56, 67);
            this.NewInfo.Name = "NewInfo";
            this.NewInfo.Size = new System.Drawing.Size(125, 27);
            this.NewInfo.TabIndex = 2;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(16, 116);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(94, 29);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(134, 117);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(94, 29);
            this.Confirm.TabIndex = 1;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(250, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // EditPW
            // 
            this.EditPW.Location = new System.Drawing.Point(243, 214);
            this.EditPW.Name = "EditPW";
            this.EditPW.Size = new System.Drawing.Size(94, 29);
            this.EditPW.TabIndex = 2;
            this.EditPW.Text = "Edit";
            this.EditPW.UseVisualStyleBackColor = true;
            this.EditPW.Click += new System.EventHandler(this.EditPW_Click);
            // 
            // EditUN
            // 
            this.EditUN.Location = new System.Drawing.Point(243, 155);
            this.EditUN.Name = "EditUN";
            this.EditUN.Size = new System.Drawing.Size(94, 29);
            this.EditUN.TabIndex = 2;
            this.EditUN.Text = "Edit";
            this.EditUN.UseVisualStyleBackColor = true;
            this.EditUN.Click += new System.EventHandler(this.EditUN_Click);
            // 
            // EditAge
            // 
            this.EditAge.Location = new System.Drawing.Point(243, 86);
            this.EditAge.Name = "EditAge";
            this.EditAge.Size = new System.Drawing.Size(94, 29);
            this.EditAge.TabIndex = 2;
            this.EditAge.Text = "Edit";
            this.EditAge.UseVisualStyleBackColor = true;
            this.EditAge.Click += new System.EventHandler(this.EditAge_Click);
            // 
            // EditName
            // 
            this.EditName.Location = new System.Drawing.Point(243, 26);
            this.EditName.Name = "EditName";
            this.EditName.Size = new System.Drawing.Size(94, 29);
            this.EditName.TabIndex = 2;
            this.EditName.Text = "Edit";
            this.EditName.UseVisualStyleBackColor = true;
            this.EditName.Click += new System.EventHandler(this.EditName_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(160, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "********";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(162, 165);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(58, 20);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "label10";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(162, 96);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(58, 20);
            this.AgeLabel.TabIndex = 1;
            this.AgeLabel.Text = "label10";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(160, 37);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(58, 20);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(679, 289);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.SgnUpPanel);
            this.Controls.Add(this.SgnInPanel);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.SgnIn);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SgnInPanel.ResumeLayout(false);
            this.SgnInPanel.PerformLayout();
            this.SgnUpPanel.ResumeLayout(false);
            this.SgnUpPanel.PerformLayout();
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            this.EditPWPanel.ResumeLayout(false);
            this.EditPWPanel.PerformLayout();
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private Button SgnIn;
        private Panel SgnInPanel;
        private Label Username;
        private TextBox Pswd;
        private TextBox Usnm;
        private Label Password;
        private Label WrongData;
        private Button SignInBtn;
        private Button BckBtn;
        private Panel SgnUpPanel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox SgUAG;
        private TextBox SgUNM;
        private TextBox SgUPW;
        private TextBox SgUUN;
        private Button SgnUpButton;
        private Button BckButton2;
        private Button SignUp;
        private Panel DataPanel;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label13;
        private Label UsernameLabel;
        private Label AgeLabel;
        private Label NameLabel;
        private Button EditPW;
        private Button EditUN;
        private Button EditAge;
        private Button EditName;
        private Panel EditPanel;
        private Label NewDatLabel;
        private TextBox NewInfo;
        private Button Cancel;
        private Button Confirm;
        private ToolStrip toolStrip1;
        private Panel EditPWPanel;
        private Label PWLabel;
        private Button EditPWBtn;
        private Button CancelPW;
        private TextBox NewPWInput;
        private Label label11;
        private TextBox OldPWInput;
    }
}