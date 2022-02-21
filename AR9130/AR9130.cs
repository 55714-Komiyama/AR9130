using Aero.Cosi.Applications;
using Aero.Cosi.ODP;
using FarPoint.Win.Spread;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace AR9130
{
    public partial class AR9130 : Aero.Cosi.Forms.BaseForm
    {
        protected const string s_FormName = "作業部門検索(AR9130)";
        protected Client _db;
        protected DataRow _resultRow;

        public  DataRow GetDepartmentInfo() 
        {
            return _resultRow;
        }


        public AR9130()
        {
            InitializeComponent();
        }

        private void AR9130_Load(object sender, EventArgs e)
        {
            try
            {
                //画面タイトル設定
                _db = Client.GetInstance();
                _db.Connect();
                using (ControlSetting ctrl = new ControlSetting()){
                    this.Text = ctrl.CreateFormTitle(s_FormName, _db.GetServerSysDate());
                }

                //画面初期化処理を実行する
                ClearContents();

                //SpreadSheet設定
                InitSheet();

                mtxShopCodeStart.Focus();
            }
            catch (Exception ex)
            {
                BaseForm_Error(ex);
            }
            finally
            {
            }

        }

        private void AR9130_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F2:
                    btnClear.PerformClick();
                    break;
                case Keys.F3:
                    btnClose.PerformClick();
                    break;
                case Keys.F11:
                    btnSearch.PerformClick();
                    break;
                case Keys.F12:
                    btnSelect.PerformClick();
                    break;
            }

        }
   

        private void InitSheet()
        {
            try
            {
                using (ControlSetting ctrl = new ControlSetting())
                {
                    ctrl.SpreadSheetColumnHeadersHeight = 22;

                    // ヘッダー見出しと、その幅を格納する
                    ctrl.SetSpreadSheetColumnsValue("作業部門コード", 110, CellHorizontalAlignment.Center);
                    ctrl.SetSpreadSheetColumnsValue("作業部門名", 253, CellHorizontalAlignment.Left);
                    ctrl.SetSpreadSheetColumnsValue("ID", 50, CellHorizontalAlignment.Left,false);

                    //表示列数、行数、表示モードを設定する
                    ctrl.SpreadSheetMaxColumns = 3;
                    ctrl.SpreadSheetMaxRows = 0;
                    ctrl.SpreadSheetOperationMode = OperationMode.SingleSelect;
                    ctrl.SpreadSheetEditModePermanent = false;

                    //ElTabelleを初期化する
                    ctrl.SpreadSheetInitialization(shtShopDetail);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        private void ClearContents()
        {
            try
            {
                using (ControlSetting ctrl = new ControlSetting())
                {
                    this.Cursor = Cursors.WaitCursor;
                    ctrl.ClearControlsContents(this.Controls);
                    mtxShopCodeStart.Focus();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //作業部門コード開始＞作業部門コード終了の場合はエラーメッセージを表示
                if (mtxShopCodeStart.Text.Length != 0 && mtxShopCodeStart.Text.Length != 0)
                {
                    if (int.Parse(mtxShopCodeStart.Text) > int.Parse(mtxShopCodeEnd.Text))
                    {
                        using (CodeInfoSetting objMsg = new CodeInfoSetting())
                        {
                            slbMsgValue.Text = objMsg.GetAppMessage("E0111");
                        }
                        using (ManagedMessage objMsg = new ManagedMessage())
                        {
                            objMsg.ShowMessage("E0024");
                        }
                        mtxShopCodeStart.Focus();
                        return;
                    }
                }
                //検索処理を実行する
                GetDepartmentData();
            }
            catch (Exception ex)
            {
                BaseForm_Error(ex);
            }
            finally
            {
            }
        
        }

        private void GetDepartmentData()
        {
            StringBuilder stbSQL = new StringBuilder();
            CodeInfoSetting objMSG = new CodeInfoSetting();
            try
            {
                stbSQL.AppendLine("SELECT DEPARTMENT_CODE");
                stbSQL.AppendLine("      ,DEPARTMENT_NAME");
                stbSQL.AppendLine("      ,DEPARTMENT_ID");
                stbSQL.AppendLine("FROM   MST_DEPARTMENT ");
                stbSQL.AppendLine("WHERE  IS_ACTIVE = 1 ");
                stbSQL.AppendLine("AND    IS_JOBSHOP = 1 ");

                if (mtxShopCodeStart.Text.Length != 0)
                {
                    stbSQL.AppendLine("AND DEPARTMENT_CODE >= " + mtxShopCodeStart.Text);
                }
                if (mtxShopCodeEnd.Text.Length != 0)
                {
                    stbSQL.AppendLine("AND DEPARTMENT_CODE <= " + mtxShopCodeEnd.Text);
                }
                if (mtxShopName.Text.Length != 0)
                {
                    stbSQL.AppendLine("AND DEPARTMENT_NAME LIKE " + OracleDBUtil.Escape(mtxShopName.Text)); 
                }
                stbSQL.AppendLine(" ORDER BY DEPARTMENT_CODE");

                using (DataBoundControlSetting objCTRL = new DataBoundControlSetting())
                {
                    objCTRL.SheetDataBinding(shtShopDetail, stbSQL.ToString());
                }

                if (shtShopDetail.Rows.Count > 0)
                {
                    slbRecCntValue.Text =shtShopDetail.Rows.Count.ToString();
                    slbMsgValue.Text = objMSG.GetAppMessage("I0009");
                }
                else
                {
                    slbRecCntValue.Text = string.Empty;
                    slbMsgValue.Text = string.Empty;
                    using (ManagedMessage objMsg = new ManagedMessage())
                    {
                        objMsg.ShowMessage("E0024");
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (stbSQL != null)
                {
                    stbSQL = null;
                }
                if (objMSG != null)
                {
                    objMSG.Dispose();
                    objMSG = null;
                }
            }
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                
                //一覧で選択されたデータを親画面に渡す
                using (DataBoundControlSetting ctrl = new DataBoundControlSetting())
                {
                    ctrl.GetSelectedRowRecord(shtShopDetail, ref this._resultRow);
                }
                if(this._resultRow == null)
                {
                    return;
                }
                this.Close();
            }
            catch (Exception ex)
            {
                BaseForm_Error(ex);
            }
            finally
            {
            }
            
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            //画面初期化処理を実行する
            ClearContents();
        }
    }
}
