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
    public partial class frmMdcStp : Form
    {
        ClsMain SvCls = new ClsMain();
        ClsVar SvClsVar = new ClsVar();
        public frmMdcStp()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdAddNew_Click(object sender, EventArgs e)
        {
            if (CboCase.Text.Trim() == "")
            {
                MessageBox.Show("Patients Problem Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                CboCase.Select();
                return;
            }

            SvCls.toGetData("Select isnull(Max(SlNO)+1,1) As Code from MdStp where SCase='" + CboCase.Text.Trim() + "'");

            if (SvCls.GblRdrToGetData.Read())
            {
                cboSl.Text = SvCls.GblRdrToGetData["Code"].ToString();
                SvCls.GblCon.Close();

                //CboCase.Text = "";
                txtMStp.Text = "";
                txtRmk.Text = "";

                GridHead_MST();

                txtMStp.Focus();

            }
            else
            {
                
            }
        }

        private void CmdMSave_Click(object sender, EventArgs e)
        {

            if (txtMStp.Text.Trim() == "")
            {
                MessageBox.Show("Patients Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtMStp.Select();
                return;
            }


            string SaveQry;
            string SelectQry;
            string EdtQry;


            SaveQry = "Insert into MdStp (SlNO,SCase,Stp1,Rmk)values('" + cboSl.Text.Trim() + "','" + CboCase.Text.Trim() + "','" + txtMStp.Text.Trim() + "','" + txtRmk.Text.Trim() + "')";
            SelectQry = "select Stp1,Rmk from MdStp where SlNO='" + cboSl.Text.Trim() + "' and SCase='" + CboCase.Text.Trim() + "' ";
            EdtQry = "Update MdStp set Stp1='" + txtMStp.Text.Trim() + "',Rmk='" + txtRmk.Text.Trim() + "' where SCase='" + CboCase.Text.Trim() + "' and SlNO='" + cboSl.Text.Trim() + "'";

            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {       

                SvCls.insertUpdate(SaveQry);

                lblMgs.ForeColor = System.Drawing.Color.Blue;
                lblMgs.Visible = true;
                lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                PicSave.Visible = true;

                GridHead_MST();


                CmdAddNew.Focus();

            }

            else

            {
                SvCls.insertUpdate(EdtQry);


                lblMgs.ForeColor = System.Drawing.Color.Blue;
                lblMgs.Visible = true;
                lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                PicSave.Visible = true;

                CmdAddNew.Focus();

                GridHead_MST();
            }


            // Grid();
        }

        private void frmMdcStp_Load(object sender, EventArgs e)
        {
            string Qry = "Select SLNo from MdStp order by SlNO asc";
            cboSl.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboSl.DisplayMember = "SLNo";
            cboSl.Text = "";

            Qry = "Select SCase from MdStp ";
            CboCase.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            CboCase.DisplayMember = "SCase";
            CboCase.Text = "";

            Qry = "Select SlNO from TestStp order by SlNO asc";
            CboTSl.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            CboTSl.DisplayMember = "SlNO";
            CboTSl.Text = "";

            Qry = "Select SCase from TestStp ";
            CboProb.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            CboProb.DisplayMember = "SCase";
            CboProb.Text = "";

            CboCase.Select();
        }

        private void GridHead_MST()
        {
            GridMStp.DataSource = SvCls.GblDataTable("Select SlNO as[SL NO],SCase as[Case],Stp1 as[Service Type] from MdStp where SCase='" + CboCase.Text.Trim() + "'");
            GridMStp.Refresh();
        }
        private void cboSl_Leave(object sender, EventArgs e)
        {
            
        }

        private void CmdMDelete_Click(object sender, EventArgs e)
        {
            if (cboSl.Text.Trim() == "")
            {
                MessageBox.Show("Not Saved....!! \rPlease Insert Party SL NO...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
                SvCls.insertUpdate("Delete from MdStp where SlNO='" + cboSl.Text.Trim() + "'");
                lblMgs.ForeColor = System.Drawing.Color.Red;
                lblMgs.Visible = true;
                lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                PicSave.Visible = true;

                GridHead_MST();

                CmdAddNew.Focus();

            }
        }

        private void btnPres_Click(object sender, EventArgs e)
        {
            

        }

        private void btnPrs_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrescription PRC = new PRCS.frmPrescription();
            PRC.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMgs.Visible = false;
            PicSave.Visible = false;
        }

        private void GridMStp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = GridMStp.SelectedCells[0].RowIndex;

            cboSl.Text = GridMStp.Rows[i].Cells[0].Value.ToString();
            CboCase.Text = GridMStp.Rows[i].Cells[1].Value.ToString();
            txtMStp.Text = GridMStp.Rows[i].Cells[2].Value.ToString();
            txtRmk.Text = GridMStp.Rows[i].Cells[3].Value.ToString();
            //CboAuTime.Text = GridMdc.Rows[i].Cells[4].Value.ToString();
        }

        private void PicSave_Click(object sender, EventArgs e)
        {

        }

        private void CmdPrs_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrescription PRC = new PRCS.frmPrescription();
            PRC.Show();
        }

        private void lblMgs_Click(object sender, EventArgs e)
        {

        }

        private void CboCase_Leave(object sender, EventArgs e)
        {
            SvCls.toGetData("Select SlNo,Stp1,Rmk from MdStp where SCase='" + CboCase.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {

                cboSl.Text = SvCls.GblRdrToGetData["SlNo"].ToString();
                txtMStp.Text = SvCls.GblRdrToGetData["Stp1"].ToString();
                txtRmk.Text = SvCls.GblRdrToGetData["Rmk"].ToString();

                GridHead_MST();

            }

            else
            {

            }
        }

        private void GridTest_Tst()
        {
            GridTest.DataSource = SvCls.GblDataTable("Select SlNO as[SL NO],SCase as[Case],TestS as[Test Setup] from TestStp where SCase='" + CboProb.Text.Trim() + "'");
            GridTest.Refresh();
        }
        private void CmdTAdd_Click(object sender, EventArgs e)
        {
            if (CboProb.Text.Trim() == "")
            {
                MessageBox.Show("Patients Problem Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                CboProb.Select();
                return;
            }

            SvCls.toGetData("Select isnull(Max(SlNO)+1,1) As Code from TestStp where SCase='" + CboProb.Text.Trim() + "'");

            if (SvCls.GblRdrToGetData.Read())
            {
                CboTSl.Text = SvCls.GblRdrToGetData["Code"].ToString();
                SvCls.GblCon.Close();

                //CboCase.Text = "";
                txtTstame.Text = "";
                txtTRmk.Text = "";

                GridTest_Tst();

                txtTstame.Focus();

            }
            else
            {

            }
        }

        private void CmdTDel_Click(object sender, EventArgs e)
        {
            if (cboSl.Text.Trim() == "")
            {
                MessageBox.Show("Not Saved....!! \rPlease Insert Party SL NO...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                SvCls.insertUpdate("Delete from TestStp where SlNO='" + cboSl.Text.Trim() + "'");
                lblMgs.ForeColor = System.Drawing.Color.Red;
                lblMgs.Visible = true;
                lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                PicSave.Visible = true;

                GridTest_Tst();

                CmdTAdd.Focus();

            }
        }

        private void CmdTSave_Click(object sender, EventArgs e)
        {
            if (txtTstame.Text.Trim() == "")
            {
                MessageBox.Show("Patients Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtTstame.Select();
                return;
            }


            string SaveQry;
            string SelectQry;
            string EdtQry;


            SaveQry = "Insert into TestStp (SlNO,SCase,TestS,Rmk)values('" + CboTSl.Text.Trim() + "','" + CboProb.Text.Trim() + "','" + txtTstame.Text.Trim() + "','" + txtTRmk.Text.Trim() + "')";
            SelectQry = "select TestS,Rmk from TestStp where SlNO='" + CboTSl.Text.Trim() + "' and SCase='" + CboProb.Text.Trim() + "' ";
            EdtQry = "Update TestStp set TestS='" + txtTstame.Text.Trim() + "',Rmk='" + txtTRmk.Text.Trim() + "' where SCase='" + CboProb.Text.Trim() + "' and SlNO='" + CboTSl.Text.Trim() + "'";

            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {

                SvCls.insertUpdate(SaveQry);

                lblMgs.ForeColor = System.Drawing.Color.Blue;
                lblMgs.Visible = true;
                lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                PicSave.Visible = true;

                GridTest_Tst();


                CmdTAdd.Focus();

            }

            else

            {
                SvCls.insertUpdate(EdtQry);


                lblMgs.ForeColor = System.Drawing.Color.Blue;
                lblMgs.Visible = true;
                lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                PicSave.Visible = true;

                CmdTAdd.Focus();

                GridTest_Tst();
            }
        }

        private void CboProb_Leave(object sender, EventArgs e)
        {
            SvCls.toGetData("Select SlNo,TestS,Rmk from TestStp where SCase='" + CboProb.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {

                CboTSl.Text = SvCls.GblRdrToGetData["SlNo"].ToString();
                txtTstame.Text = SvCls.GblRdrToGetData["TestS"].ToString();
                txtTRmk.Text = SvCls.GblRdrToGetData["Rmk"].ToString();

                GridTest_Tst();

            }

            else
            {

            }
        }

        private void GridTest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = GridTest.SelectedCells[0].RowIndex;

            CboProb.Text = GridTest.Rows[i].Cells[0].Value.ToString();
            CboTSl.Text = GridTest.Rows[i].Cells[1].Value.ToString();
            txtTstame.Text = GridTest.Rows[i].Cells[2].Value.ToString();
           // txtTRmk.Text = GridTest.Rows[i].Cells[3].Value.ToString();
        }
    }
    }

