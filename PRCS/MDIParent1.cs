using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRCS
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void prescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrescription prs = new PRCS.frmPrescription();
            prs.Show();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            //this.Width = 893;
            //this.Height = 439;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string vrsn = "19.225";
            ClsVar.GblTimeCardExportedTillDate = "20/12/2017";



            if (txtUId.Text == "")
            {
                MessageBox.Show("Please Insert Username.....!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Insert Password.....!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            ClsMain SvCls = new ClsMain();

            //SvCls.insertUpdate("update security set uid=usercode");


            string SelectQry = "select * from Loginuser  where UserName='" + txtUId.Text.Trim() + "' and Password= '" + txtPassword.Text.Trim() + "'";

            string userid = txtUId.Text;
            string password = txtPassword.Text;

            try
            {
                SvCls.toGetData(SelectQry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.GblUserId = SvCls.GblRdrToGetData["UserCode"].ToString();
                    ClsVar.GblUserName = SvCls.GblRdrToGetData["UserName"].ToString();
                    Pnl1.Visible = false;


                    if (txtUId.Text.Trim() == "Jomir")
                    {

                        menuStrip.Enabled = true;
                    }

                    ClsVar.GblFormWidth = 960;
                    ClsVar.GblFormHeight = 600;
                    this.ControlBox = Visible = true;
                    this.menuStrip.Visible = true;

                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                    this.WindowState = FormWindowState.Maximized;

                    Pnl1.Visible = false;

                    //SecurityAssign();

                    ClsVar.logDescription = "Log In to Virsion : " + vrsn;
                    SvCls.insertUpdate("insert into log (uid,pcname,comid,description) values ('" + ClsVar.GblUserId + "','" + ClsVar.GblPcName + "','" + ClsVar.GblComId + "','" + ClsVar.logDescription + "')");
                }
                else
                {

                    MessageBox.Show("Invalid Username Or Password.\r\n Make Sure about your server name:" + ClsVar.ServerName + " \r\n your database name : " + ClsVar.DataBaseName, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword.Select();
                    return;
                }

            }
            catch
            {

            }


            this.Text = "Doctor Prescription Software Licensed to " + ClsVar.GblComName + " (Connected to " + ClsVar.ServerName + ")  " + ClsVar.GblUserName + " Log In to Virsion: " + vrsn + " at " + DateTime.Now.ToString(("HH:MM:ss"));

            lblComName.Left = 30;
            lblComName.Top = this.Height - 60;

            lblLicens.Left = 30;
            lblLicens.Top = this.Height - 80;


        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            frmPrescription prs = new PRCS.frmPrescription();
            prs.Show();
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                btnLogin.Select();
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Leave(object sender, EventArgs e)
        {
            //this.MdiParent.Visible = true;
        }
    }
}