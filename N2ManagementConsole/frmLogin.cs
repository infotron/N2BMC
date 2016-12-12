using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;

namespace N2ManagementConsole
{
    public partial class frmLogin : Form
    {
        clsMySQL oMySql = new clsMySQL();
        Boolean dbaseIsBusy = false;
        string monitoredSlug = String.Empty;

        Bitmap loginBitMap = null;
        Bitmap DashboardBitMap = null;
        Bitmap MetroCtrFlrPlanBitMap = null;
        Bitmap socketsInMetroCtrBitMap = null;
        Bitmap TenthFlrpanelBitMap = null;
        Bitmap SandBoxPanelBitMap = null;
        Bitmap gridSocketPanelBitMap = null;
        Bitmap filterPeopleBitMap = null;
        Bitmap visitorPanelBitMap = null;
        Bitmap visitorPaulBitMap = null;
        Bitmap studentVisitorBitMap = null;
        Bitmap extinguisherBitMap = null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void sendToggleCommand(int relay, int data)
        {
            if (dbaseIsBusy)
                return;

            dbaseIsBusy = true;

            try
            {
                oMySql.OpenConnection();
                if (oMySql.mySqlCn != null)
                {
                    //create command and assign the query and connection from the constructor
                    string query = String.Format("insert into EquipToggleCommands (TargetDevice, relay, data) values ('dfy1GO','{0}','{1}');", relay, data);
                    MySqlCommand cmd = new MySqlCommand(query, oMySql.mySqlCn);

                    //Execute command
                    cmd.ExecuteNonQuery();
                }
                oMySql.closeConnection();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            dbaseIsBusy = false;
        }


        private void setBackGroundImageBitMap(Bitmap newBitMap, PaintEventArgs e)
        {
            e.Graphics.DrawImage(
                newBitMap,
                this.ClientRectangle,
                new Rectangle(0, 0, newBitMap.Width, newBitMap.Height),
                GraphicsUnit.Pixel);
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            using (loginBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.SuperGridMain.png")))
            {
                setBackGroundImageBitMap(loginBitMap, e);
            }
        }

        private void DashBoardPanel_Paint(object sender, PaintEventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            using (DashboardBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.SuperGridDashboard.png")))
            {
                setBackGroundImageBitMap(DashboardBitMap, e);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DashBoardPanel.Visible = true;
            LoginPanel.Visible = false; 
        }

        private void DashBoardPanel_Click(object sender, EventArgs e)
        {
            DashBoardPanel.Visible = false;
            metroCteFlrPlanPanel.Visible = true;
        }

        private void metroCtrFlrPlanPanel_Paint(object sender, PaintEventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            using (MetroCtrFlrPlanBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.MetroCtrFloorPlan.png")))
            {
                setBackGroundImageBitMap(MetroCtrFlrPlanBitMap, e);
            }
        }

        private void socketsInMetroCtrPanel_Paint(object sender, PaintEventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            using (socketsInMetroCtrBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.socketsInMetroCtr.png")))
            {
                setBackGroundImageBitMap(socketsInMetroCtrBitMap, e);
            }

        }

        private void metroCteFlrPlanPanel_Click(object sender, EventArgs e)
        {
            metroCteFlrPlanPanel.Visible = false;
            socketsInMetroCtrPanel.Visible = true;
        }

        private void TenthFlrpanel_Paint(object sender, PaintEventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            using (TenthFlrpanelBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.metroCtrTenthFlr.png")))
            {
                setBackGroundImageBitMap(TenthFlrpanelBitMap, e);
            }
        }

        private void socketsInMetroCtrPanel_Click(object sender, EventArgs e)
        {
            socketsInMetroCtrPanel.Visible = false;
            TenthFlrpanel.Visible = true;
        }

        private void TenthFlrpanel_Click(object sender, EventArgs e)
        {
            controlPanel.Visible = true;
        }



        private void filterPeoplePanel_Paint(object sender, PaintEventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            using (filterPeopleBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.SuperGrid_filter peops.png")))
            {
                setBackGroundImageBitMap(filterPeopleBitMap, e);
            }
        }


        private void visitorPanel_Paint(object sender, PaintEventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            using (visitorPanelBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.SuperGrid_visitor.png")))
            {
                setBackGroundImageBitMap(visitorPanelBitMap, e);
            }
        }

        private void filterPeoplePanel_Click(object sender, EventArgs e)
        {
            filterPeoplePanel.Visible = false;
            visitorPanel.Visible = true;
        }

        private void visitorPaulPanel_Paint(object sender, PaintEventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            using (visitorPaulBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.SuperGridPaulVisit.png")))
            {
                setBackGroundImageBitMap(visitorPaulBitMap, e);
            }
        }

        private void visitorPanel_Click(object sender, EventArgs e)
        {
            visitorPanel.Visible = false;
            visitorPaulPanel.Visible = true;
        }

        private void studentVisitorPanel_Paint(object sender, PaintEventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            using (studentVisitorBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.SuperGridStudentVisitor.png")))
            {
                setBackGroundImageBitMap(studentVisitorBitMap, e);
            }
        }

        private void visitorPaulPanel_Click(object sender, EventArgs e)
        {
            visitorPaulPanel.Visible = false;
            studentVisitorPanel.Visible = true;

        }

        private void extinguisherPanel_Paint(object sender, PaintEventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            using (extinguisherBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.SuperGrid_Extinguisher.png")))
            {
                setBackGroundImageBitMap(extinguisherBitMap, e);
            }
        }

        private void studentVisitorPanel_Click(object sender, EventArgs e)
        {
            studentVisitorPanel.Visible = false;
            extinguisherPanel.Visible = true;
        }


        private void populate_Devices ()
        {
            if (dbaseIsBusy)
                return;

            dbaseIsBusy = true;
            cmbDevices.Items.Clear();

            try
            {
                oMySql.OpenConnection();
                if (oMySql.mySqlCn != null)
                {
                    //create command and assign the query and connection from the constructor
                    string query = String.Format("select Address from  Equip  where ActiveFlag = 'Y';");
                    MySqlCommand cmd = new MySqlCommand(query, oMySql.mySqlCn);

                    //Execute command
                    MySqlDataReader datareader = cmd.ExecuteReader();
                    while (datareader.Read())
                    {
                        cmbDevices.Items.Add(datareader["Address"]);
                    }

                    datareader.Close();

                }
                oMySql.closeConnection();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            dbaseIsBusy = false;
        }

        private void controlPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (controlPanel.Visible == true)
            {
                populate_Devices();

                cmbDevices.SelectedIndex = cmbDevices.Items.Count - 1;

                ctlPanelPictureBox.Image = Image.FromFile(@".\\Resources\\sandboxUser.png");
                ctlPanelPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                ctlPanelUsageChart.Image = Image.FromFile(@".\\Resources\\sandboxIntervalUsageChart.png");
                ctlPanelUsageChart.SizeMode = PictureBoxSizeMode.StretchImage;

                chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

                Axis axis = chart1.ChartAreas[0].Axes[0];   // your indices
                LabelStyle als = new LabelStyle();
                als.ForeColor = chart1.ChartAreas[0].BackColor;
                axis.LabelStyle = als;
                axis.MajorTickMark.TickMarkStyle = TickMarkStyle.None;
                hide_monitored_values();
            }
        }

        private void cmbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainSwitch.Enabled = true;
            plug1Switch.Enabled = true;
            plug2Switch.Enabled = true;

            if (dbaseIsBusy)
                return;

            dbaseIsBusy = true;

            try
            {
                oMySql.OpenConnection();
                if (oMySql.mySqlCn != null)
                {
                    //create command and assign the query and connection from the constructor
                    const string query = "update Equip set monitorSensors = 'N';";
                    MySqlCommand cmd = new MySqlCommand(query, oMySql.mySqlCn);

                    //Execute command
                    cmd.ExecuteNonQuery();
                }
                oMySql.closeConnection();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            dbaseIsBusy = false;

        }

        //private double timeValue = 0;
        private void sensorTmr_Tick(object sender, EventArgs e)
        {
            if (dbaseIsBusy)
                return;

            dbaseIsBusy = true;

            try
            {
                oMySql.OpenConnection();
                if (oMySql.mySqlCn != null)
                {
                    //create command and assign the query and connection from the constructif
                    string query = String.Format("select * from sensorData where slug = '{0}' order by id desc limit 1;", monitoredSlug);
                    MySqlCommand cmd = new MySqlCommand(query, oMySql.mySqlCn);

                    //Execute command
                    MySqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.Read())
                    {
                        //populate sensor controls with latest readings ...
                        lblVoltsValue.Text = datareader["volts"].ToString();
                        lblAmpsValue.Text = datareader["amps"].ToString();
                        lblWattsValue.Text = datareader["watts"].ToString();
                        lblTempVal.Text = datareader["temperature"].ToString();
                        lblHumidityVal.Text = datareader["humidity"].ToString();
                        //lblCOValue.Text = datareader["co"].ToString();
                        lblMethaneVal.Text = datareader["methane"].ToString();
                        lblStatusValue.Text = datareader["status"].ToString();

                        if (chart1.Series[0].Points.Count > 30)
                        {
                            chart1.Series[0].Points.RemoveAt(0);
                            chart1.ResetAutoValues();
                        }
                        else
                        {
                            chart1.Series[0].Points.AddXY(DateTime.Now.ToOADate(), Convert.ToDouble(lblWattsValue.Text));
                        }


                        //chart1.Series["Wattage"].Points.AddXY(timeValue, Convert.ToDouble(lblWattsValue.Text));
                        //timeValue += sensorTmr.Interval/1000;
                    }

                    datareader.Close();
                }
                oMySql.closeConnection();
                show_monitored_values();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            dbaseIsBusy = false;
        }

        private void mainSwitch_Toggled(object sender, EventArgs e)
        {
            if (mainSwitch.IsOn)
            {
                sendToggleCommand(10, 1);
                sensorMonitorSwitch.Enabled = true;
            }
            else
            {
                sendToggleCommand(10, 0);
                if (!mainSwitch.IsOn && !plug1Switch.IsOn && !plug2Switch.IsOn)
                    sensorMonitorSwitch.Enabled = false;
            }
        }

        private void plug1Switch_Toggled(object sender, EventArgs e)
        {
            if (plug1Switch.IsOn)
            {
                sendToggleCommand(30, 1);
                sensorMonitorSwitch.Enabled = true;
            }
            else
            {
                sendToggleCommand(30, 0);
                if (!mainSwitch.IsOn && !plug1Switch.IsOn && !plug2Switch.IsOn)
                    sensorMonitorSwitch.Enabled = false;
            }
        }

        private void plug2Switch_Toggled(object sender, EventArgs e)
        {
            if (plug2Switch.IsOn)
            {
                sendToggleCommand(31, 1);
                sensorMonitorSwitch.Enabled = true;
            }
            else
            {
                sendToggleCommand(31, 0);
                if (!mainSwitch.IsOn && !plug1Switch.IsOn && !plug2Switch.IsOn)
                    sensorMonitorSwitch.Enabled = false;
            }
        }

        private void sensorMonitorSwitch_Toggled(object sender, EventArgs e)
        {
            if (dbaseIsBusy || cmbDevices.Text.Length == 0)
                return;

            dbaseIsBusy = true;

            try
            {
                oMySql.OpenConnection();
                if (oMySql.mySqlCn != null)
                {
                    if (sensorMonitorSwitch.IsOn)
                    {
                        //create command and assign the query and connection from the constructor
                        string query = String.Format("update Equip set monitorSensors = 'Y' where Address  = '{0}'", cmbDevices.Text);
                        MySqlCommand cmd = new MySqlCommand(query, oMySql.mySqlCn);

                        //Execute command
                        cmd.ExecuteNonQuery();

                        query = String.Format("select Slug from Equip where Address  = '{0}'", cmbDevices.Text);
                        MySqlCommand cmd1 = new MySqlCommand(query, oMySql.mySqlCn);
                        MySqlDataReader datareader = cmd1.ExecuteReader();
                        if (datareader.Read())
                        {
                            monitoredSlug = datareader["Slug"].ToString();
                            sensorTmr.Enabled = true;
                        }

                        datareader.Close();
                        chart1.Visible = true;
                        ctlPanelUsageChart.Visible = true;
                        label10.Visible = true;

                    }
                    else
                    {
                        //create command and assign the query and connection from the constructor
                        string query = String.Format("update Equip set monitorSensors = 'N' where Address  = '{0}'", cmbDevices.Text);
                        MySqlCommand cmd = new MySqlCommand(query, oMySql.mySqlCn);

                        //Execute command
                        cmd.ExecuteNonQuery();
                        sensorTmr.Enabled = false;
                        chart1.Visible = false;
                        ctlPanelUsageChart.Visible = false;
                        label10.Visible = false;
                    }
                    oMySql.closeConnection();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            dbaseIsBusy = false;
        }

        private void radBtnSocket_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnSocket.Checked == true)
            {
                radBtnSandbox.Checked = false;
                ctlPanelPictureBox.Image = Image.FromFile(@".\\Resources\\socketUser.png");
                ctlPanelUsageChart.Image = Image.FromFile(@".\\Resources\\socketIntervalUsageChart.png");
                lblUnitType.Text = "Duplex outlet: ss 101";
            }
        }

        private void radBtnSandbox_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnSandbox.Checked == true)
            {
                radBtnSocket.Checked = false;
                ctlPanelPictureBox.Image = Image.FromFile(@".\\Resources\\sandboxUser.png");
                ctlPanelUsageChart.Image = Image.FromFile(@".\\Resources\\sandboxIntervalUsageChart.png");
                lblUnitType.Text = "SandBox: sb122";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            controlPanel.Visible = false;
            TenthFlrpanel.Visible = true;
        }

        private void btnBak_Click(object sender, EventArgs e)
        {
            DashBoardPanel.Visible = true;
            metroCteFlrPlanPanel.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            socketsInMetroCtrPanel.Visible = true;
            TenthFlrpanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            socketsInMetroCtrPanel.Visible = false;
            metroCteFlrPlanPanel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TenthFlrpanel.Visible = false;
            filterPeoplePanel.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TenthFlrpanel.Visible = true;
            filterPeoplePanel.Visible = false;            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            visitorPanel.Visible = false;
            filterPeoplePanel.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            visitorPaulPanel.Visible = false;
            visitorPanel.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            studentVisitorPanel.Visible = false;
            visitorPaulPanel.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            extinguisherPanel.Visible = false;
            studentVisitorPanel.Visible = true;
        }

        private void LoginPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (LoginPanel.Visible == true)
            {
                SuperGridPicBox.Image = Image.FromFile(@".\\Resources\\SuperGrid.png");
                SuperGridPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
                N2GlobalPicBox.Image = Image.FromFile(@".\\Resources\\N2Global.png");
                N2GlobalPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
                loggedInUserPicBox.Image = Image.FromFile(@".\\Resources\\paul_photo.jpg");
                loggedInUserPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void hide_monitored_values ()
        {
            lblTempVal.Visible = false;
            lblHumidityVal.Visible = false;
            lblMethaneVal.Visible = false;
            lblCOValue.Visible = false;
            lblVOCVal.Visible = false;
            lblCO2Val.Visible = false;
            lblStatusValue.Visible = false;
            lblWattsValue.Visible = false;
            lblAmpsValue.Visible = false;
            lblVoltsValue.Visible = false;
        }

        private void show_monitored_values()
        {
            if (lblTempVal.Visible == true)
                return;
            lblTempVal.Visible = true;
            lblHumidityVal.Visible = true;
            lblMethaneVal.Visible = true;
            lblCOValue.Visible = true;
            lblVOCVal.Visible = true;
            lblCO2Val.Visible = true;
            lblStatusValue.Visible = true;
            lblWattsValue.Visible = true;
            lblAmpsValue.Visible = true;
            lblVoltsValue.Visible = true;
        }

    }
}
