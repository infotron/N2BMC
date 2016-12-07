namespace N2ManagementConsole
{
    partial class frmLogin
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
            this.lblDevices = new System.Windows.Forms.Label();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.btnSocketOn = new System.Windows.Forms.Button();
            this.btnSocketOff = new System.Windows.Forms.Button();
            this.btnP1On = new System.Windows.Forms.Button();
            this.btnP2Off = new System.Windows.Forms.Button();
            this.DashBoardPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.btnP2On = new System.Windows.Forms.Button();
            this.btnP1Off = new System.Windows.Forms.Button();
            this.metroCteFlrPlanPanel = new System.Windows.Forms.Panel();
            this.socketsInMetroCtrPanel = new System.Windows.Forms.Panel();
            this.TenthFlrpanel = new System.Windows.Forms.Panel();
            this.SandBoxPanel = new System.Windows.Forms.Panel();
            this.gridSocketPanel = new System.Windows.Forms.Panel();
            this.filterPeoplePanel = new System.Windows.Forms.Panel();
            this.visitorPanel = new System.Windows.Forms.Panel();
            this.visitorPaulPanel = new System.Windows.Forms.Panel();
            this.studentVisitorPanel = new System.Windows.Forms.Panel();
            this.extinguisherPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDevices
            // 
            this.lblDevices.AutoSize = true;
            this.lblDevices.Location = new System.Drawing.Point(60, 15);
            this.lblDevices.Name = "lblDevices";
            this.lblDevices.Size = new System.Drawing.Size(106, 13);
            this.lblDevices.TabIndex = 0;
            this.lblDevices.Text = "Discovered Devices:";
            this.lblDevices.Visible = false;
            // 
            // cmbDevices
            // 
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(172, 12);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(121, 21);
            this.cmbDevices.TabIndex = 1;
            this.cmbDevices.Visible = false;
            // 
            // btnSocketOn
            // 
            this.btnSocketOn.Location = new System.Drawing.Point(81, 39);
            this.btnSocketOn.Name = "btnSocketOn";
            this.btnSocketOn.Size = new System.Drawing.Size(103, 23);
            this.btnSocketOn.TabIndex = 2;
            this.btnSocketOn.Text = "Main On";
            this.btnSocketOn.UseVisualStyleBackColor = true;
            this.btnSocketOn.Visible = false;
            this.btnSocketOn.Click += new System.EventHandler(this.btnSocketOn_Click);
            // 
            // btnSocketOff
            // 
            this.btnSocketOff.Location = new System.Drawing.Point(190, 39);
            this.btnSocketOff.Name = "btnSocketOff";
            this.btnSocketOff.Size = new System.Drawing.Size(103, 23);
            this.btnSocketOff.TabIndex = 3;
            this.btnSocketOff.Text = "Main Off";
            this.btnSocketOff.UseVisualStyleBackColor = true;
            this.btnSocketOff.Visible = false;
            this.btnSocketOff.Click += new System.EventHandler(this.btnSocketOff_Click);
            // 
            // btnP1On
            // 
            this.btnP1On.Location = new System.Drawing.Point(310, 39);
            this.btnP1On.Name = "btnP1On";
            this.btnP1On.Size = new System.Drawing.Size(103, 23);
            this.btnP1On.TabIndex = 4;
            this.btnP1On.Text = "P1 ON";
            this.btnP1On.UseVisualStyleBackColor = true;
            this.btnP1On.Visible = false;
            this.btnP1On.Click += new System.EventHandler(this.btnP1On_Click);
            // 
            // btnP2Off
            // 
            this.btnP2Off.Location = new System.Drawing.Point(659, 39);
            this.btnP2Off.Name = "btnP2Off";
            this.btnP2Off.Size = new System.Drawing.Size(103, 23);
            this.btnP2Off.TabIndex = 7;
            this.btnP2Off.Text = "P2 Off";
            this.btnP2Off.UseVisualStyleBackColor = true;
            this.btnP2Off.Visible = false;
            this.btnP2Off.Click += new System.EventHandler(this.btnP2Off_Click);
            // 
            // DashBoardPanel
            // 
            this.DashBoardPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DashBoardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashBoardPanel.Location = new System.Drawing.Point(0, 0);
            this.DashBoardPanel.Name = "DashBoardPanel";
            this.DashBoardPanel.Size = new System.Drawing.Size(1192, 882);
            this.DashBoardPanel.TabIndex = 9;
            this.DashBoardPanel.Visible = false;
            this.DashBoardPanel.Click += new System.EventHandler(this.DashBoardPanel_Click);
            this.DashBoardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DashBoardPanel_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(376, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Need help loggin in?";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLogin.Location = new System.Drawing.Point(158, 213);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(55, 213);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Remember me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(230, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Pasword:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(51, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Integrate, Analyze, Visualize and Control";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(154, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "N2 SuperGrid";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPanel
            // 
            this.LoginPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginPanel.Controls.Add(this.groupBox1);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1192, 882);
            this.LoginPanel.TabIndex = 8;
            this.LoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPanel_Paint);
            // 
            // btnP2On
            // 
            this.btnP2On.Location = new System.Drawing.Point(528, 39);
            this.btnP2On.Name = "btnP2On";
            this.btnP2On.Size = new System.Drawing.Size(103, 23);
            this.btnP2On.TabIndex = 12;
            this.btnP2On.Text = "P2 ON";
            this.btnP2On.UseVisualStyleBackColor = true;
            this.btnP2On.Visible = false;
            this.btnP2On.Click += new System.EventHandler(this.btnP2On_Click);
            // 
            // btnP1Off
            // 
            this.btnP1Off.Location = new System.Drawing.Point(419, 39);
            this.btnP1Off.Name = "btnP1Off";
            this.btnP1Off.Size = new System.Drawing.Size(103, 23);
            this.btnP1Off.TabIndex = 11;
            this.btnP1Off.Text = "P1 Off";
            this.btnP1Off.UseVisualStyleBackColor = true;
            this.btnP1Off.Visible = false;
            this.btnP1Off.Click += new System.EventHandler(this.btnP1Off_Click);
            // 
            // metroCteFlrPlanPanel
            // 
            this.metroCteFlrPlanPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroCteFlrPlanPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroCteFlrPlanPanel.Location = new System.Drawing.Point(0, 0);
            this.metroCteFlrPlanPanel.Name = "metroCteFlrPlanPanel";
            this.metroCteFlrPlanPanel.Size = new System.Drawing.Size(1192, 882);
            this.metroCteFlrPlanPanel.TabIndex = 1;
            this.metroCteFlrPlanPanel.Visible = false;
            this.metroCteFlrPlanPanel.Click += new System.EventHandler(this.metroCteFlrPlanPanel_Click);
            this.metroCteFlrPlanPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.metroCtrFlrPlanPanel_Paint);
            // 
            // socketsInMetroCtrPanel
            // 
            this.socketsInMetroCtrPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.socketsInMetroCtrPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.socketsInMetroCtrPanel.Location = new System.Drawing.Point(0, 0);
            this.socketsInMetroCtrPanel.Name = "socketsInMetroCtrPanel";
            this.socketsInMetroCtrPanel.Size = new System.Drawing.Size(1192, 882);
            this.socketsInMetroCtrPanel.TabIndex = 2;
            this.socketsInMetroCtrPanel.Visible = false;
            this.socketsInMetroCtrPanel.Click += new System.EventHandler(this.socketsInMetroCtrPanel_Click);
            this.socketsInMetroCtrPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.socketsInMetroCtrPanel_Paint);
            // 
            // TenthFlrpanel
            // 
            this.TenthFlrpanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TenthFlrpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TenthFlrpanel.Location = new System.Drawing.Point(0, 0);
            this.TenthFlrpanel.Name = "TenthFlrpanel";
            this.TenthFlrpanel.Size = new System.Drawing.Size(1192, 882);
            this.TenthFlrpanel.TabIndex = 2;
            this.TenthFlrpanel.Visible = false;
            this.TenthFlrpanel.Click += new System.EventHandler(this.TenthFlrpanel_Click);
            this.TenthFlrpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TenthFlrpanel_Paint);
            // 
            // SandBoxPanel
            // 
            this.SandBoxPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SandBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SandBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.SandBoxPanel.Name = "SandBoxPanel";
            this.SandBoxPanel.Size = new System.Drawing.Size(1192, 882);
            this.SandBoxPanel.TabIndex = 2;
            this.SandBoxPanel.Visible = false;
            this.SandBoxPanel.Click += new System.EventHandler(this.SandBoxPanel_Click);
            this.SandBoxPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SandBoxPanel_Paint);
            // 
            // gridSocketPanel
            // 
            this.gridSocketPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gridSocketPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSocketPanel.Location = new System.Drawing.Point(0, 0);
            this.gridSocketPanel.Name = "gridSocketPanel";
            this.gridSocketPanel.Size = new System.Drawing.Size(1192, 882);
            this.gridSocketPanel.TabIndex = 2;
            this.gridSocketPanel.Visible = false;
            this.gridSocketPanel.Click += new System.EventHandler(this.gridSocketPanel_Click);
            this.gridSocketPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gridSocketPanel_Paint);
            // 
            // filterPeoplePanel
            // 
            this.filterPeoplePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.filterPeoplePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterPeoplePanel.Location = new System.Drawing.Point(0, 0);
            this.filterPeoplePanel.Name = "filterPeoplePanel";
            this.filterPeoplePanel.Size = new System.Drawing.Size(1192, 882);
            this.filterPeoplePanel.TabIndex = 2;
            this.filterPeoplePanel.Visible = false;
            this.filterPeoplePanel.Click += new System.EventHandler(this.filterPeoplePanel_Click);
            this.filterPeoplePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.filterPeoplePanel_Paint);
            // 
            // visitorPanel
            // 
            this.visitorPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.visitorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visitorPanel.Location = new System.Drawing.Point(0, 0);
            this.visitorPanel.Name = "visitorPanel";
            this.visitorPanel.Size = new System.Drawing.Size(1192, 882);
            this.visitorPanel.TabIndex = 2;
            this.visitorPanel.Visible = false;
            this.visitorPanel.Click += new System.EventHandler(this.visitorPanel_Click);
            this.visitorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.visitorPanel_Paint);
            // 
            // visitorPaulPanel
            // 
            this.visitorPaulPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.visitorPaulPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visitorPaulPanel.Location = new System.Drawing.Point(0, 0);
            this.visitorPaulPanel.Name = "visitorPaulPanel";
            this.visitorPaulPanel.Size = new System.Drawing.Size(1192, 882);
            this.visitorPaulPanel.TabIndex = 2;
            this.visitorPaulPanel.Visible = false;
            this.visitorPaulPanel.Click += new System.EventHandler(this.visitorPaulPanel_Click);
            this.visitorPaulPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.visitorPaulPanel_Paint);
            // 
            // studentVisitorPanel
            // 
            this.studentVisitorPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.studentVisitorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentVisitorPanel.Location = new System.Drawing.Point(0, 0);
            this.studentVisitorPanel.Name = "studentVisitorPanel";
            this.studentVisitorPanel.Size = new System.Drawing.Size(1192, 882);
            this.studentVisitorPanel.TabIndex = 2;
            this.studentVisitorPanel.Visible = false;
            this.studentVisitorPanel.Click += new System.EventHandler(this.studentVisitorPanel_Click);
            this.studentVisitorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.studentVisitorPanel_Paint);
            // 
            // extinguisherPanel
            // 
            this.extinguisherPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.extinguisherPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extinguisherPanel.Location = new System.Drawing.Point(0, 0);
            this.extinguisherPanel.Name = "extinguisherPanel";
            this.extinguisherPanel.Size = new System.Drawing.Size(1192, 882);
            this.extinguisherPanel.TabIndex = 2;
            this.extinguisherPanel.Visible = false;
            this.extinguisherPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.extinguisherPanel_Paint);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1192, 882);
            this.Controls.Add(this.metroCteFlrPlanPanel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.btnP2On);
            this.Controls.Add(this.btnP2Off);
            this.Controls.Add(this.filterPeoplePanel);
            this.Controls.Add(this.btnP1Off);
            this.Controls.Add(this.gridSocketPanel);
            this.Controls.Add(this.btnSocketOn);
            this.Controls.Add(this.DashBoardPanel);
            this.Controls.Add(this.btnSocketOff);
            this.Controls.Add(this.socketsInMetroCtrPanel);
            this.Controls.Add(this.btnP1On);
            this.Controls.Add(this.visitorPaulPanel);
            this.Controls.Add(this.visitorPanel);
            this.Controls.Add(this.TenthFlrpanel);
            this.Controls.Add(this.cmbDevices);
            this.Controls.Add(this.lblDevices);
            this.Controls.Add(this.extinguisherPanel);
            this.Controls.Add(this.studentVisitorPanel);
            this.Controls.Add(this.SandBoxPanel);
            this.DoubleBuffered = true;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDevices;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.Button btnSocketOn;
        private System.Windows.Forms.Button btnSocketOff;
        private System.Windows.Forms.Button btnP1On;
        private System.Windows.Forms.Button btnP2Off;
        private System.Windows.Forms.Panel DashBoardPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button btnP2On;
        private System.Windows.Forms.Button btnP1Off;
        private System.Windows.Forms.Panel metroCteFlrPlanPanel;
        private System.Windows.Forms.Panel socketsInMetroCtrPanel;
        private System.Windows.Forms.Panel TenthFlrpanel;
        private System.Windows.Forms.Panel SandBoxPanel;
        private System.Windows.Forms.Panel gridSocketPanel;
        private System.Windows.Forms.Panel filterPeoplePanel;
        private System.Windows.Forms.Panel visitorPanel;
        private System.Windows.Forms.Panel visitorPaulPanel;
        private System.Windows.Forms.Panel studentVisitorPanel;
        private System.Windows.Forms.Panel extinguisherPanel;
    }
}

