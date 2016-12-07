using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Reflection;

namespace N2ManagementConsole
{
    public partial class frmLogin : Form
    {
        clsMySQL oMySql = new clsMySQL();
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
            oMySql.OpenConnection();
            if (oMySql.mySqlCn != null)
            {
                //create command and assign the query and connection from the constructor
                string query = String.Format("insert into EquipToggleCommands (TargetDevice, relay, data) values ('dfy1GO','{0}','{1}');",relay, data);
                MySqlCommand cmd = new MySqlCommand(query, oMySql.mySqlCn);

                //Execute command
                cmd.ExecuteNonQuery();
            }
            oMySql.closeConnection();
        }

        private void btnSocketOn_Click(object sender, EventArgs e)
        {
            sendToggleCommand(10,1);
        }

        private void btnSocketOff_Click(object sender, EventArgs e)
        {
            sendToggleCommand(10, 0);
        }

        private void btnP1On_Click(object sender, EventArgs e)
        {
            sendToggleCommand(30, 1);
        }

        private void btnP2Off_Click(object sender, EventArgs e)
        {
            sendToggleCommand(31, 0);
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
            if (loginBitMap == null)
                loginBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.SuperGridMain.png"));

            setBackGroundImageBitMap(loginBitMap, e);
        }

        private void DashBoardPanel_Paint(object sender, PaintEventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            loginBitMap.Dispose();
            loginBitMap = null;
            if (DashboardBitMap == null)
                DashboardBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.SuperGridDashboard.png"));

            setBackGroundImageBitMap(DashboardBitMap, e);
        }

        private void btnPanelCtl_Click(object sender, EventArgs e)
        {
            if (DashBoardPanel.Visible == false)
            {
                DashBoardPanel.Visible = true;
                metroCteFlrPlanPanel.Visible = false;
            }
            else
            {
                DashBoardPanel.Visible = false;
                metroCteFlrPlanPanel.Visible = true;
            }

        }

        private void btnP1Off_Click(object sender, EventArgs e)
        {
            sendToggleCommand(30, 0);
        }

        private void btnP2On_Click(object sender, EventArgs e)
        {
            sendToggleCommand(31, 1);
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

            if (DashboardBitMap != null)
            {
                DashboardBitMap.Dispose();
                DashboardBitMap = null;
            }

            if (MetroCtrFlrPlanBitMap == null)
            {
                MetroCtrFlrPlanBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.MetroCtrFloorPlan.png"));
            }

            setBackGroundImageBitMap(MetroCtrFlrPlanBitMap, e);
        }

        private void socketsInMetroCtrPanel_Paint(object sender, PaintEventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            if (MetroCtrFlrPlanBitMap != null)
            {
                MetroCtrFlrPlanBitMap.Dispose();
                MetroCtrFlrPlanBitMap = null;
            }

            if (socketsInMetroCtrBitMap == null)
            {
                socketsInMetroCtrBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.socketsInMetroCtr.png"));
            }

            setBackGroundImageBitMap(socketsInMetroCtrBitMap, e);
            
        }

        private void metroCteFlrPlanPanel_Click(object sender, EventArgs e)
        {
            metroCteFlrPlanPanel.Visible = false;
            socketsInMetroCtrPanel.Visible = true;
        }

        private void TenthFlrpanel_Paint(object sender, PaintEventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            if (socketsInMetroCtrBitMap != null)
            {
                socketsInMetroCtrBitMap.Dispose();
                socketsInMetroCtrBitMap = null;
            }

            if (TenthFlrpanelBitMap == null)
            {
                TenthFlrpanelBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.metroCtrTenthFlr.png"));
            }

            setBackGroundImageBitMap(TenthFlrpanelBitMap, e);
            
        }

        private void socketsInMetroCtrPanel_Click(object sender, EventArgs e)
        {
            socketsInMetroCtrPanel.Visible = false;
            TenthFlrpanel.Visible = true;
        }

        private void TenthFlrpanel_Click(object sender, EventArgs e)
        {
            TenthFlrpanel.Visible = false;
            SandBoxPanel.Visible = true;
        }

        private void SandBoxPanel_Paint(object sender, PaintEventArgs e)
        {

            Assembly asm = Assembly.GetExecutingAssembly();

            if (TenthFlrpanelBitMap != null)
            {
                TenthFlrpanelBitMap.Dispose();
                TenthFlrpanelBitMap = null;
            }

            if (SandBoxPanelBitMap == null)
            {
                SandBoxPanelBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.SuperGridSandBox.png"));
            }

            setBackGroundImageBitMap(SandBoxPanelBitMap, e);
            
        }

        private void gridSocketPanel_Paint(object sender, PaintEventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            if (SandBoxPanelBitMap != null)
            {
                SandBoxPanelBitMap.Dispose();
                SandBoxPanelBitMap = null;
            }

            if (gridSocketPanelBitMap == null)
            {
                gridSocketPanelBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.SuperGridSocket.png"));
            }

            setBackGroundImageBitMap(gridSocketPanelBitMap, e);
        }

        private void SandBoxPanel_Click(object sender, EventArgs e)
        {
            SandBoxPanel.Visible = false;
            gridSocketPanel.Visible = true;
        }

        private void filterPeoplePanel_Paint(object sender, PaintEventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            if (gridSocketPanelBitMap != null)
            {
                gridSocketPanelBitMap.Dispose();
                gridSocketPanelBitMap = null;
            }

            if (filterPeopleBitMap == null)
            {
                filterPeopleBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.SuperGrid_filter peops.png"));
            }

            setBackGroundImageBitMap(filterPeopleBitMap, e);
        }

        private void gridSocketPanel_Click(object sender, EventArgs e)
        {
            gridSocketPanel.Visible = false;
            filterPeoplePanel.Visible = true;
        }

        private void visitorPanel_Paint(object sender, PaintEventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            if (filterPeopleBitMap != null)
            {
                filterPeopleBitMap.Dispose();
                filterPeopleBitMap = null;
            }

            if (visitorPanelBitMap == null)
            {
                visitorPanelBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.SuperGrid_visitor.png"));
            }

            setBackGroundImageBitMap(visitorPanelBitMap, e);

        }

        private void filterPeoplePanel_Click(object sender, EventArgs e)
        {
            filterPeoplePanel.Visible = false;
            visitorPanel.Visible = true;
        }

        private void visitorPaulPanel_Paint(object sender, PaintEventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            if (visitorPanelBitMap != null)
            {
                visitorPanelBitMap.Dispose();
                visitorPanelBitMap = null;
            }

            if (visitorPaulBitMap == null)
            {
                visitorPaulBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.SuperGridPaulVisit.png"));
            }

            setBackGroundImageBitMap(visitorPaulBitMap, e);
        }

        private void visitorPanel_Click(object sender, EventArgs e)
        {
            visitorPanel.Visible = false;
            visitorPaulPanel.Visible = true;
        }

        private void studentVisitorPanel_Paint(object sender, PaintEventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            if (visitorPaulBitMap != null)
            {
                visitorPaulBitMap.Dispose();
                visitorPaulBitMap = null;
            }

            if (studentVisitorBitMap == null)
            {
                studentVisitorBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.SuperGridStudentVisitor.png"));
            }

            setBackGroundImageBitMap(studentVisitorBitMap, e);

        }

        private void visitorPaulPanel_Click(object sender, EventArgs e)
        {
            visitorPaulPanel.Visible = false;
            studentVisitorPanel.Visible = true;

        }

        private void extinguisherPanel_Paint(object sender, PaintEventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            if (studentVisitorBitMap != null)
            {
                studentVisitorBitMap.Dispose();
                studentVisitorBitMap = null;
            }

            if (extinguisherBitMap == null)
            {
                extinguisherBitMap = new Bitmap(asm.GetManifestResourceStream("N2ManagementConsole.Resources.SuperGrid_Extinguisher.png"));
            }

            setBackGroundImageBitMap(extinguisherBitMap, e);

        }

        private void studentVisitorPanel_Click(object sender, EventArgs e)
        {
            studentVisitorPanel.Visible = false;
            extinguisherPanel.Visible = true;
        }



    }
}
