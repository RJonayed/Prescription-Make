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
    public partial class frmPrescription : Form
    {
        ClsMain SvCls = new ClsMain();
        ClsVar SvClsVar = new ClsVar();
        public frmPrescription()
        {
            InitializeComponent();
            //this.Width = ClsVar.GblFormWidth;
            //this.Height = ClsVar.GblFormHeight;
            //this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdPresAddNew_Click(object sender, EventArgs e)
        {
            SvCls.toGetData("select isnull(Max(PresNo)+1,1001) As Max from PInfo");

            if (SvCls.GblRdrToGetData.Read())
            {
                cboPresNo.Text = SvCls.GblRdrToGetData["Max"].ToString();
                SvCls.GblCon.Close();
            }
                         
            txtPNum.Text = "";
            CboGender.Text = "";
            txtMobile.Text = "";
            txtAge.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            CboProb.Text = "";
            txtHst.Text = "";
            txtPhyFind.Text = "";
            txtAdc.Text = "";
            txtFees.Text = "";
            CboAuTime.Text = "";

            CboMSl.Text = "";
            CboMcNum.Text = "";
            txtQty.Text = "";
            CboMTime.Text = "";
            txtAge.Text = "";
            txtAdc.Text = "";
            CboInvgSl.Text = "";
            CboTstNum.Text = "";
            txtIngRmk.Text = "";

            GridHead_Mdc();
            GridHead_Invg();



            txtPNum.Focus();             
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmPrescription_Load(object sender, EventArgs e)
        {
            CmdPresAddNew.Select();
            txtFees.Text = "0";

            string Qry = "Select PresNo from PInfo order by PresNo asc";
            cboPresNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboPresNo.DisplayMember = "PresNo";
            cboPresNo.Text = "";

            Qry = "Select SCase from MdStp";
            CboProb.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            CboProb.DisplayMember = "SCase";
            CboProb.Text = "";

            Qry = "Select SlNo from Mdc order by SlNo asc";
            CboMSl.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            CboMSl.DisplayMember = "SlNo";
            CboMSl.Text = "";

            Qry = "select MName from Mdc order by MName asc";
            CboMcNum.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            CboMcNum.DisplayMember = "MName";
            CboMcNum.Text = "";

            Qry = "   Select MTime from Mdc Order by MTime asc";
            CboMTime.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            CboMTime.DisplayMember = "MTime";
            CboMTime.Text = "";

            Qry = "   Select Autime from Mdc Order by Autime asc";
            CboAuTime.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            CboAuTime.DisplayMember = "Autime";
            CboAuTime.Text = "";

           
            // Qry = "Select SlNo from Medicine";
            //CboMSl.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            //CboMSl.DisplayMember = "SlNo";
            //CboMSl.Text = "";

            Qry = "Select SlNo from Test order by SlNo asc";
            CboInvgSl.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            CboInvgSl.DisplayMember = "SlNo";
            CboInvgSl.Text = "";

            Qry = "select TstName from Test order by TstName asc";
            CboTstNum.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            CboTstNum.DisplayMember = "TstName";
            CboTstNum.Text = "";
                 
        }

        private void GridPack_Name()
        {
            GridPackName.DataSource = SvCls.GblDataTable("Select SCase as [Service type] from MdStp");
            GridPackName.Refresh();
        }

        private void GridHead_Mdc()
        {           
            GridMdc.DataSource = SvCls.GblDataTable("Select SlNo as [SL No], MName as[Medicine], Qty as[Qty], MTime as[Time], AuTime as[After Meal] from Mdc where PresNo = '" + cboPresNo.Text.Trim() + "'");
            GridMdc.Refresh();
        }

        private void GridHead_Invg()
        {
            GridInvst.DataSource = SvCls.GblDataTable("Select SlNo as[SL No], TstName as[Test Name], Rmk as[Remarks] from Test where PresNo='" + cboPresNo.Text.Trim() + "'");
            GridInvst.Refresh();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
                    
            
        }

        private void cmdPAddNew_Click(object sender, EventArgs e)       
        {

          
        }

        private void CmdPSave_Click(object sender, EventArgs e)
        {
            {
                
                if (txtPNum.Text.Trim() == "")
                {
                    MessageBox.Show("Patients Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtPNum.Select();
                    return;                   
                }


                string SaveQry;
                string SelectQry;
                string EdtQry;


                SaveQry = "Insert Into PInfo (PDate,PresNo,PName,Gender,PAge,Mobile,PAddress,Email,PProb,PHist,PhyFnd,PAdc,ReAppDate,Fees) values(Convert(datetime,'" + DtPDate.Text.Trim() + "',103),'" + cboPresNo.Text.Trim() +"', (N'" + txtPNum.Text.Trim() + "'), (N'" + CboGender.Text.Trim() + "'), (N'" + txtAge.Text.Trim() + "'), (N'" + txtMobile.Text.Trim() + "'), (N'" + txtAddress.Text.Trim() + "'), (N'" + txtEmail.Text.Trim() + "'),(N'" + CboProb.Text.Trim() + "') ,(N'" + txtHst.Text.Trim() + "'),(N'" + txtPhyFind.Text.Trim() + "'),(N'" + txtAdc.Text.Trim() + "'),Convert(datetime,'" + DtReAppDate.Text.Trim() + "',103),'" + txtFees.Text.Trim() + "')";
                SelectQry = "Select PName,Gender,PAge,Mobile,PAddress,Email,PhyFnd,PProb,PHist,PAdc,Fees from PInfo where PresNo='" + cboPresNo.Text.Trim() + "'";
                EdtQry = "Update PInfo set PName=(N'" + txtPNum.Text.Trim() +"'),Gender=(N'" + CboGender.Text.Trim() + "'),PAge=(N'" + txtAge.Text.Trim() + "'),Mobile=(N'" + txtMobile.Text.Trim() + "'),PAddress=(N'" + txtAddress.Text.Trim() + "'),Email=(N'" + txtEmail.Text.Trim() + "'),PhyFnd=(N'" + txtPhyFind.Text.Trim() + "'),PProb=(N'" + CboProb.Text.Trim()+ "'),PHist=(N'" + txtHst.Text.Trim() + "'),PAdc='" + txtAdc.Text.ToLower() + "',Fees=" + txtFees.Text.Trim() + " where PresNo='" + cboPresNo.Text.Trim() + "'";

                if (SvCls.DataExist(SelectQry).ToString() == "0")
                {


                    cmdSave_Click(null,null);

                    SvCls.insertUpdate(SaveQry);

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                    PicSave.Visible = true;

                    CmdMdcAddNew.Focus();
                  
                }

                else

                {
                    SvCls.insertUpdate(EdtQry);


                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                    PicSave.Visible = true;

                    CmdMdcAddNew.Focus();

                    // GridHead();
                }


                // Grid();
            }
        }

        private void cmdPDel_Click(object sender, EventArgs e)
        {
            if (cboPresNo.Text.Trim() == "")
            {
                MessageBox.Show("Not Saved....!! \rPlease Insert Party Prescription NO...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cmdDelete_Click(null,null);

                SvCls.insertUpdate("Delete from PInfo where PresNo = '" + cboPresNo.Text.Trim() + "'");
                lblMgs.ForeColor = System.Drawing.Color.Red;
                lblMgs.Visible = true;
                lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                PicSave.Visible = true;

                // GridHead();

                cmdPAddNew.Focus();

            }
        }

        private void CboPid_Leave(object sender, EventArgs e)
        {
           
        }

        private void cboPresNo_Leave(object sender, EventArgs e)
        {
            GridHead_Mdc();
            GridHead_Invg();

            SvCls.toGetData("Select PName,Gender,PAge,Mobile,PAddress,Email,PhyFnd,PProb,PHist,PAdc,cast(Fees as decimal) as Fees from PInfo where PresNo='" + cboPresNo.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                //CboPid.Text = SvCls.GblRdrToGetData["Pid"].ToString();
                txtPNum.Text = SvCls.GblRdrToGetData["PName"].ToString();
                CboGender.Text = SvCls.GblRdrToGetData["Gender"].ToString();
                txtMobile.Text = SvCls.GblRdrToGetData["Mobile"].ToString();
                txtAge.Text = SvCls.GblRdrToGetData["PAge"].ToString();
                txtEmail.Text = SvCls.GblRdrToGetData["Email"].ToString();

                txtAddress.Text = SvCls.GblRdrToGetData["PAddress"].ToString();
                txtPhyFind.Text = SvCls.GblRdrToGetData["PhyFnd"].ToString();
                CboProb.Text = SvCls.GblRdrToGetData["PProb"].ToString();
                txtHst.Text = SvCls.GblRdrToGetData["PHist"].ToString();
                txtAdc.Text = SvCls.GblRdrToGetData["PAdc"].ToString();
                txtFees.Text = SvCls.GblRdrToGetData["Fees"].ToString();


            }

            else
            {
                cmdPAddNew.Focus();
            }
        }

        private void CmdMdcAddNew_Click(object sender, EventArgs e)
        {

           
            SvCls.toGetData("select isnull(Max(SlNo)+1,1) As Max from Mdc where PresNo='" + cboPresNo.Text.Trim() + "'");

            if (SvCls.GblRdrToGetData.Read())
            {
                CboMSl.Text = SvCls.GblRdrToGetData["Max"].ToString();
                SvCls.GblCon.Close();
            }

            CboMcNum.Text = "";
            txtQty.Text = "";
            CboMTime.Text = "";
            txtAge.Text = "";
            txtAdc.Text = "";

            GridHead_Mdc();          

            CboMcNum.Focus();
        }

        private void CmdMSave_Click(object sender, EventArgs e)
        {
                                          
                if (CboMcNum.Text.Trim() == "")
                {
                    MessageBox.Show("Medicine Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CboTstNum.Focus();
                    return;

                }

                string SaveQry;
                string SelectQry;
                string EdtQry;


                SaveQry = "Insert into Mdc(PresNo,SlNo,MName,Qty,MTime,AuTime)values ('" + cboPresNo.Text.Trim() + "','" + CboMSl.Text.Trim() + "',(N'" + CboMcNum.Text.Trim() + "'),(N'" + txtQty.Text.Trim() + "'),(N'" + CboMTime.Text.Trim() + "'),(N'" + CboAuTime.Text.Trim() + "'))";
                SelectQry = "Select MName,Qty,MTime,AuTime from Mdc where SlNo='" + CboMSl.Text.Trim() + "' and PresNo='" + cboPresNo.Text.Trim() + "'";
                EdtQry = "Update Mdc set MName=(N'" + CboMcNum.Text.Trim() + "'),Qty=(N'" + txtQty.Text.Trim() + "'),MTime=(N'" + CboMTime.Text.Trim() + "'),AuTime=(N'" + CboAuTime.Text.Trim()  + "') where SlNo='" + CboMSl.Text.Trim() + "' and PresNo='" + cboPresNo.Text.Trim() + "'";

                if (SvCls.DataExist(SelectQry).ToString() == "0")
                {
                    SvCls.insertUpdate(SaveQry);


                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                    PicSave.Visible = true;

                    GridHead_Mdc();

                    CmdMdcAddNew.Focus();
                }
                else
                {
                    SvCls.insertUpdate(EdtQry);


                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                    PicSave.Visible = true;

                    GridHead_Mdc();
                }


                // Grid();

              //  CmdIngAddNew.Focus();
            
        }
        private void CboMSl_Leave(object sender, EventArgs e)
        {
            SvCls.toGetData("Select MName,Qty,MTime,AuTime from Mdc where SlNo='" + CboMSl.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                CboMcNum.Text = SvCls.GblRdrToGetData["MName"].ToString();
                txtQty.Text = SvCls.GblRdrToGetData["Qty"].ToString();
                CboMTime.Text = SvCls.GblRdrToGetData["MTime"].ToString();
                CboAuTime.Text = SvCls.GblRdrToGetData["AuTime"].ToString();
                
            }

            else
            {

            }
        }

        private void CmdIngAddNew_Click(object sender, EventArgs e)
        {
            if (cboPresNo.Text.Trim() == "")
            {
                MessageBox.Show("Prescrition NO Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cmdPAddNew.Focus();

                return;
            }


            SvCls.toGetData("select isnull(Max(SlNo)+1,1) As Max from Test where PresNo='" + cboPresNo.Text.Trim() + "'");

            if (SvCls.GblRdrToGetData.Read())
            {
                CboInvgSl.Text = SvCls.GblRdrToGetData["Max"].ToString();
                SvCls.GblCon.Close();
            }

            CboTstNum.Text = "";
            txtIngRmk.Text = "";

            GridHead_Invg();

            CboTstNum.Focus();
        }

        private void CmdIngSave_Click(object sender, EventArgs e)
        {
            {

                if (CboInvgSl.Text.Trim() == "")
                {
                    MessageBox.Show("Investigation Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);                    
                    CmdIngAddNew.Focus();
                    return;

                                              
                }


                if (CboTstNum.Text.Trim() == "")
                {
                    MessageBox.Show("Investigation Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CboTstNum.Focus();
                    return;

                }

                string SaveQry;
                string SelectQry;
                string EdtQry;


                SaveQry = "Insert into Test(PresNo,SlNo,TstName,Rmk)values('" + cboPresNo.Text.Trim() + "','" + CboInvgSl.Text.Trim() + "',(N'" + CboTstNum.Text.Trim() + "'),(N'" + txtIngRmk.Text.Trim() + "')) ";
                SelectQry = "Select TstName,Rmk from Test where SlNo='" + CboInvgSl.Text.Trim() + "' and PresNo='" + cboPresNo.Text.Trim() + "'";
                EdtQry = "Update Test set TstName=(N'" + CboTstNum.Text.Trim() + "'),Rmk=(N'" + txtIngRmk.Text.Trim() + "') where SlNo='" + CboInvgSl.Text.Trim() + "' and PresNo='" + cboPresNo.Text.Trim() + "'";

                if (SvCls.DataExist(SelectQry).ToString() == "0")
                {
                    SvCls.insertUpdate(SaveQry);


                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                    PicSave.Visible = true;

                    CmdIngAddNew.Focus();


                    GridHead_Invg();
                }
                else
                {
                    SvCls.insertUpdate(EdtQry);


                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                    PicSave.Visible = true;

                    GridHead_Invg();
                }


                // Grid();

                CmdIngAddNew.Focus();
            }
        }

        private void CboInvgSl_Leave(object sender, EventArgs e)
        {
            SvCls.toGetData("Select TstName,Rmk from Test where SlNo='" + CboInvgSl.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                CboTstNum.Text = SvCls.GblRdrToGetData["TstName"].ToString();
                txtIngRmk.Text = SvCls.GblRdrToGetData["Rmk"].ToString();
            }

            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void CmdMDelete_Click(object sender, EventArgs e)
        {
            if (CboMSl.Text.Trim() == "")
            {
                MessageBox.Show("Not Saved....!! \rPlease Insert Medicine Serial...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SvCls.insertUpdate("Delete from Mdc where SlNo='" + CboMSl.Text.Trim() + "'");
                lblMgs.ForeColor = System.Drawing.Color.Red;
                lblMgs.Visible = true;
                lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                PicSave.Visible = true;

                GridHead_Mdc();

                CmdMdcAddNew.Focus();

            }
        }

        private void CmdInvDelete_Click(object sender, EventArgs e)
        {
            if (CboMSl.Text.Trim() == "")
            {
                MessageBox.Show("Not Saved....!! \rPlease Insert Investigation No...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SvCls.insertUpdate("Delete from Test where SlNo='" + CboInvgSl.Text.Trim() + "'");
                lblMgs.ForeColor = System.Drawing.Color.Red;
                lblMgs.Visible = true;
                lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                PicSave.Visible = true;

                GridHead_Invg();

                CmdIngAddNew.Focus();

            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {

            if (CboMSl.Text.Trim() == "")
            {
                MessageBox.Show("Not Saved....!! \rPlease Insert Party Employee ID...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SvCls.insertUpdate("Delete from Pres where PresNo='" + cboPresNo.Text.Trim() + "'");
                lblMgs.ForeColor = System.Drawing.Color.Red;
                lblMgs.Visible = true;
                lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                PicSave.Visible = true;

                //GridHead_Invg();

                CmdPresAddNew.Focus();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMgs.Visible = false;
            PicSave.Visible = false;

        }

        private void GridMdc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = GridMdc.SelectedCells[0].RowIndex;

            CboMSl.Text = GridMdc.Rows[i].Cells[0].Value.ToString();
            CboMcNum.Text = GridMdc.Rows[i].Cells[1].Value.ToString();
            txtQty.Text = GridMdc.Rows[i].Cells[2].Value.ToString();
            CboMTime.Text = GridMdc.Rows[i].Cells[3].Value.ToString();
            txtAdc.Text = GridMdc.Rows[i].Cells[4].Value.ToString();
        }

        private void GridInvst_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = GridInvst.SelectedCells[0].RowIndex;

            CboInvgSl.Text = GridInvst.Rows[i].Cells[0].Value.ToString();
            CboTstNum.Text = GridInvst.Rows[i].Cells[1].Value.ToString();
            txtIngRmk.Text = GridInvst.Rows[i].Cells[2].Value.ToString();
        }

        private void CmdPresAddNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cboPresNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void CmdPresAddNew_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void DtPDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void CmdPresAddNew_KeyUp(object sender, KeyEventArgs e)
        {

            //if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            //{
            //    DtPDate.Select();
            //}
        }

        private void cboPresNo_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void DtPDate_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void CboPid_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void cmdPAddNew_KeyUp(object sender, KeyEventArgs e)
        {

           
        }

        private void txtPNum_KeyUp(object sender, KeyEventArgs e)
        {

            //if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            //{
            //    CboGender.Select();
            //}
        }

        private void CboGender_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                txtMobile.Select();
            }
        }

        private void txtMobile_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                txtAge.Select();
            }
        }

        private void txtAge_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                txtEmail.Select();
            }
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                txtAddress.Select();
            }
        }

        private void txtAddress_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                CboProb.Select();
            }
        }

        private void txtProb_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                txtHst.Select();
            }
        }

        private void txtHst_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                txtPhyFind.Select();
            }
        }

        private void txtPRmk_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                CmdPSave.Select();
            }
        }

        private void CmdPSave_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                CboMSl.Select();
            }
        }

        private void cmdPDel_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void CboMSl_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void CmdMdcAddNew_KeyUp(object sender, KeyEventArgs e)
        {
         
        }

        private void CboMcNum_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                txtQty.Select();
            }
        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                CboMTime.Select();
            }
        }

        private void txtMdcTime_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                txtAdc.Select();
            }
        }

        private void txtMRmk_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                CmdMSave.Select();
            }
        }

        private void CboInvgSl_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void CmdIngAddNew_KeyUp(object sender, KeyEventArgs e)
        {

            //if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            //{
            //    CboTstNum.Select();
            //}
        }

        private void txtTestNum_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                txtIngRmk.Select();
            }
        }

        private void txtIngRmk_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                CmdIngSave.Select();

                CmdIngSave_Click(null,null);
            }
        }

        private void DtReAppDate_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                cmdSave.Select();
            }
        }

        private void CmdMSave_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                CboInvgSl.Focus();
            }
        }

        private void CmdIngSave_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                DtReAppDate.Select();
            }
        }

        private void CmdMSave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                CboInvgSl.Select();
            }
        }

        private void DtPDate_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CboMTime_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                CboAuTime.Select();
            }
        }

        private void CboAuTime_KeyUp(object sender, KeyEventArgs e)
        {
          
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                txtAdc.Select();
                CmdMSave_Click(null,null);
            }
        }

        private void CboTstNum_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
               txtIngRmk.Select();
            }
        }

        private void cmdPAddNew_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnItemFind_Click(object sender, EventArgs e)
        {
            
            CmdPSave_Click(null, null);

        }

        private void GridMdc_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = GridMdc.SelectedCells[0].RowIndex;

            CboMSl.Text = GridMdc.Rows[i].Cells[0].Value.ToString();
            CboMcNum.Text = GridMdc.Rows[i].Cells[1].Value.ToString();
            txtQty.Text = GridMdc.Rows[i].Cells[2].Value.ToString();
            CboMTime.Text = GridMdc.Rows[i].Cells[3].Value.ToString();
            CboAuTime.Text = GridMdc.Rows[i].Cells[4].Value.ToString();
        }

        private void CboAuTime_Leave(object sender, EventArgs e)
        {
            CmdPSave_Click(null, null);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Close();
            frmMdcStp Mdc = new PRCS. frmMdcStp();
            Mdc.Show();

            //frmPrescription visiable = false;
        }

        private void txtIngRmk_Leave(object sender, EventArgs e)
        {
            CmdIngSave_Click(null,null);
        }

        private void txtPhyFind_Leave(object sender, EventArgs e)
        {
          //CmdPSave_Click(null,null);
        }

        private void CboProb_Leave(object sender, EventArgs e)
        {
           
            //GridHead_Mdc();
            //GridHead_Invg();

                      
        }

        private void btnInpt_Click(object sender, EventArgs e)
        {
            PnlInpt.Visible = true;

            GridPack_Name();
        }
    }
    }

