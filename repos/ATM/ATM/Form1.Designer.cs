namespace ATM
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
            this.label1 = new System.Windows.Forms.Label();
            this.LoginCard = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.DPOK = new System.Windows.Forms.Button();
            this.DPBox = new System.Windows.Forms.NumericUpDown();
            this.DPBtn = new System.Windows.Forms.Button();
            this.WDInput = new System.Windows.Forms.NumericUpDown();
            this.WDOK = new System.Windows.Forms.Button();
            this.WD100 = new System.Windows.Forms.Button();
            this.WD50 = new System.Windows.Forms.Button();
            this.WD20 = new System.Windows.Forms.Button();
            this.LTTable = new System.Windows.Forms.TableLayoutPanel();
            this.TN5 = new System.Windows.Forms.Label();
            this.TN4 = new System.Windows.Forms.Label();
            this.TN3 = new System.Windows.Forms.Label();
            this.TN2 = new System.Windows.Forms.Label();
            this.TN1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.WithdrawBtn = new System.Windows.Forms.Button();
            this.BalanceLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PinPanel = new System.Windows.Forms.Panel();
            this.DBL = new System.Windows.Forms.Label();
            this.WrongPin = new System.Windows.Forms.Label();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.InpPin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WDInput)).BeginInit();
            this.LTTable.SuspendLayout();
            this.PinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(239, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert your card";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginCard
            // 
            this.LoginCard.Location = new System.Drawing.Point(267, 207);
            this.LoginCard.Name = "LoginCard";
            this.LoginCard.Size = new System.Drawing.Size(125, 27);
            this.LoginCard.TabIndex = 1;
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(418, 206);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(94, 29);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "Proceed";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.button2);
            this.MainPanel.Controls.Add(this.DPOK);
            this.MainPanel.Controls.Add(this.DPBox);
            this.MainPanel.Controls.Add(this.DPBtn);
            this.MainPanel.Controls.Add(this.WDInput);
            this.MainPanel.Controls.Add(this.WDOK);
            this.MainPanel.Controls.Add(this.WD100);
            this.MainPanel.Controls.Add(this.WD50);
            this.MainPanel.Controls.Add(this.WD20);
            this.MainPanel.Controls.Add(this.LTTable);
            this.MainPanel.Controls.Add(this.WithdrawBtn);
            this.MainPanel.Controls.Add(this.BalanceLbl);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Location = new System.Drawing.Point(38, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(695, 435);
            this.MainPanel.TabIndex = 6;
            this.MainPanel.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DPOK
            // 
            this.DPOK.Location = new System.Drawing.Point(328, 235);
            this.DPOK.Name = "DPOK";
            this.DPOK.Size = new System.Drawing.Size(50, 29);
            this.DPOK.TabIndex = 12;
            this.DPOK.Text = "OK";
            this.DPOK.UseVisualStyleBackColor = true;
            this.DPOK.Visible = false;
            this.DPOK.Click += new System.EventHandler(this.DPOK_Click);
            // 
            // DPBox
            // 
            this.DPBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DPBox.Location = new System.Drawing.Point(163, 237);
            this.DPBox.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.DPBox.Name = "DPBox";
            this.DPBox.Size = new System.Drawing.Size(150, 27);
            this.DPBox.TabIndex = 11;
            this.DPBox.Visible = false;
            // 
            // DPBtn
            // 
            this.DPBtn.Location = new System.Drawing.Point(57, 237);
            this.DPBtn.Name = "DPBtn";
            this.DPBtn.Size = new System.Drawing.Size(94, 29);
            this.DPBtn.TabIndex = 10;
            this.DPBtn.Text = "Deposit";
            this.DPBtn.UseVisualStyleBackColor = true;
            this.DPBtn.Click += new System.EventHandler(this.DPBtn_Click);
            // 
            // WDInput
            // 
            this.WDInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.WDInput.Location = new System.Drawing.Point(163, 158);
            this.WDInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WDInput.Name = "WDInput";
            this.WDInput.Size = new System.Drawing.Size(150, 27);
            this.WDInput.TabIndex = 9;
            this.WDInput.Visible = false;
            // 
            // WDOK
            // 
            this.WDOK.Location = new System.Drawing.Point(328, 156);
            this.WDOK.Name = "WDOK";
            this.WDOK.Size = new System.Drawing.Size(50, 29);
            this.WDOK.TabIndex = 8;
            this.WDOK.Text = "OK";
            this.WDOK.UseVisualStyleBackColor = true;
            this.WDOK.Visible = false;
            this.WDOK.Click += new System.EventHandler(this.WDOK_Click);
            // 
            // WD100
            // 
            this.WD100.Location = new System.Drawing.Point(603, 156);
            this.WD100.Name = "WD100";
            this.WD100.Size = new System.Drawing.Size(50, 29);
            this.WD100.TabIndex = 7;
            this.WD100.Text = "100$";
            this.WD100.UseVisualStyleBackColor = true;
            this.WD100.Visible = false;
            this.WD100.Click += new System.EventHandler(this.WD100_Click);
            // 
            // WD50
            // 
            this.WD50.Location = new System.Drawing.Point(528, 156);
            this.WD50.Name = "WD50";
            this.WD50.Size = new System.Drawing.Size(50, 29);
            this.WD50.TabIndex = 6;
            this.WD50.Text = "50$";
            this.WD50.UseVisualStyleBackColor = true;
            this.WD50.Visible = false;
            this.WD50.Click += new System.EventHandler(this.WD50_Click);
            // 
            // WD20
            // 
            this.WD20.Location = new System.Drawing.Point(452, 156);
            this.WD20.Name = "WD20";
            this.WD20.Size = new System.Drawing.Size(50, 29);
            this.WD20.TabIndex = 5;
            this.WD20.Text = "20$";
            this.WD20.UseVisualStyleBackColor = true;
            this.WD20.Visible = false;
            this.WD20.Click += new System.EventHandler(this.WD20_Click);
            // 
            // LTTable
            // 
            this.LTTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.LTTable.ColumnCount = 5;
            this.LTTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LTTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LTTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LTTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LTTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LTTable.Controls.Add(this.TN5, 4, 1);
            this.LTTable.Controls.Add(this.TN4, 3, 1);
            this.LTTable.Controls.Add(this.TN3, 2, 1);
            this.LTTable.Controls.Add(this.TN2, 1, 1);
            this.LTTable.Controls.Add(this.TN1, 0, 1);
            this.LTTable.Controls.Add(this.label11, 4, 0);
            this.LTTable.Controls.Add(this.label10, 3, 0);
            this.LTTable.Controls.Add(this.label9, 2, 0);
            this.LTTable.Controls.Add(this.label7, 0, 0);
            this.LTTable.Controls.Add(this.label8, 1, 0);
            this.LTTable.Location = new System.Drawing.Point(11, 348);
            this.LTTable.Name = "LTTable";
            this.LTTable.RowCount = 2;
            this.LTTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.LTTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LTTable.Size = new System.Drawing.Size(667, 52);
            this.LTTable.TabIndex = 3;
            // 
            // TN5
            // 
            this.TN5.AutoSize = true;
            this.TN5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TN5.Location = new System.Drawing.Point(536, 31);
            this.TN5.Name = "TN5";
            this.TN5.Size = new System.Drawing.Size(127, 20);
            this.TN5.TabIndex = 8;
            this.TN5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TN4
            // 
            this.TN4.AutoSize = true;
            this.TN4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TN4.Location = new System.Drawing.Point(403, 31);
            this.TN4.Name = "TN4";
            this.TN4.Size = new System.Drawing.Size(126, 20);
            this.TN4.TabIndex = 7;
            this.TN4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TN3
            // 
            this.TN3.AutoSize = true;
            this.TN3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TN3.Location = new System.Drawing.Point(270, 31);
            this.TN3.Name = "TN3";
            this.TN3.Size = new System.Drawing.Size(126, 20);
            this.TN3.TabIndex = 6;
            this.TN3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TN2
            // 
            this.TN2.AutoSize = true;
            this.TN2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TN2.Location = new System.Drawing.Point(137, 31);
            this.TN2.Name = "TN2";
            this.TN2.Size = new System.Drawing.Size(126, 20);
            this.TN2.TabIndex = 5;
            this.TN2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TN1
            // 
            this.TN1.AutoSize = true;
            this.TN1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TN1.Location = new System.Drawing.Point(4, 31);
            this.TN1.Name = "TN1";
            this.TN1.Size = new System.Drawing.Size(126, 20);
            this.TN1.TabIndex = 4;
            this.TN1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.Location = new System.Drawing.Point(536, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Transaction # 5";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Location = new System.Drawing.Point(403, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Transaction # 4";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Location = new System.Drawing.Point(270, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Transaction # 3";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(4, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Transaction # 1";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Location = new System.Drawing.Point(137, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Transaction # 2";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WithdrawBtn
            // 
            this.WithdrawBtn.Location = new System.Drawing.Point(57, 158);
            this.WithdrawBtn.Name = "WithdrawBtn";
            this.WithdrawBtn.Size = new System.Drawing.Size(94, 29);
            this.WithdrawBtn.TabIndex = 2;
            this.WithdrawBtn.Text = "Withdraw";
            this.WithdrawBtn.UseVisualStyleBackColor = true;
            this.WithdrawBtn.Click += new System.EventHandler(this.WithdrawBtn_Click);
            // 
            // BalanceLbl
            // 
            this.BalanceLbl.AutoSize = true;
            this.BalanceLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BalanceLbl.Location = new System.Drawing.Point(35, 99);
            this.BalanceLbl.Name = "BalanceLbl";
            this.BalanceLbl.Size = new System.Drawing.Size(132, 45);
            this.BalanceLbl.TabIndex = 1;
            this.BalanceLbl.Text = "Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(257, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 54);
            this.label6.TabIndex = 0;
            this.label6.Text = "Welcome";
            // 
            // PinPanel
            // 
            this.PinPanel.Controls.Add(this.DBL);
            this.PinPanel.Controls.Add(this.WrongPin);
            this.PinPanel.Controls.Add(this.LogInBtn);
            this.PinPanel.Controls.Add(this.InpPin);
            this.PinPanel.Controls.Add(this.label13);
            this.PinPanel.Location = new System.Drawing.Point(229, 64);
            this.PinPanel.Name = "PinPanel";
            this.PinPanel.Size = new System.Drawing.Size(330, 200);
            this.PinPanel.TabIndex = 0;
            this.PinPanel.Visible = false;
            // 
            // DBL
            // 
            this.DBL.AutoSize = true;
            this.DBL.Location = new System.Drawing.Point(50, 104);
            this.DBL.Name = "DBL";
            this.DBL.Size = new System.Drawing.Size(50, 20);
            this.DBL.TabIndex = 4;
            this.DBL.Text = "label5";
            // 
            // WrongPin
            // 
            this.WrongPin.AutoSize = true;
            this.WrongPin.ForeColor = System.Drawing.Color.Crimson;
            this.WrongPin.Location = new System.Drawing.Point(117, 129);
            this.WrongPin.Name = "WrongPin";
            this.WrongPin.Size = new System.Drawing.Size(81, 20);
            this.WrongPin.TabIndex = 3;
            this.WrongPin.Text = "Wrong PIN";
            this.WrongPin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WrongPin.Visible = false;
            // 
            // LogInBtn
            // 
            this.LogInBtn.Location = new System.Drawing.Point(114, 157);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(94, 29);
            this.LogInBtn.TabIndex = 2;
            this.LogInBtn.Text = "Enter";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click_1);
            // 
            // InpPin
            // 
            this.InpPin.Location = new System.Drawing.Point(121, 88);
            this.InpPin.Name = "InpPin";
            this.InpPin.Size = new System.Drawing.Size(74, 27);
            this.InpPin.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(66, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(192, 54);
            this.label13.TabIndex = 0;
            this.label13.Text = "Input PIN";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(721, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 451);
            this.Controls.Add(this.PinPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.LoginCard);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WDInput)).EndInit();
            this.LTTable.ResumeLayout(false);
            this.LTTable.PerformLayout();
            this.PinPanel.ResumeLayout(false);
            this.PinPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox LoginCard;
        private Button EnterButton;
        private Panel MainPanel;
        private Button WithdrawBtn;
        private Label BalanceLbl;
        private Label label6;
        private TableLayoutPanel LTTable;
        private Label label7;
        private Label TN5;
        private Label TN4;
        private Label TN3;
        private Label TN2;
        private Label TN1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button WDOK;
        private Button WD100;
        private Button WD50;
        private Button WD20;
        private NumericUpDown WDInput;
        private Button DPOK;
        private NumericUpDown DPBox;
        private Button DPBtn;
        private Button button1;
        private Panel PinPanel;
        private Label WrongPin;
        private Button LogInBtn;
        private TextBox InpPin;
        private Label label13;
        private Label DBL;
        private Button button2;
    }
}