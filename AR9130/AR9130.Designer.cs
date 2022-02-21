namespace AR9130
{
    partial class AR9130
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
            this.components = new System.ComponentModel.Container();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.mtxShopName = new Aero.Cosi.Forms.LimitEditBox(this.components);
            this.mtxShopCodeEnd = new Aero.Cosi.Forms.LimitEditBox(this.components);
            this.mtxShopCodeStart = new Aero.Cosi.Forms.LimitEditBox(this.components);
            this.lblcapProcessName = new System.Windows.Forms.Label();
            this.lblcapLabel1 = new System.Windows.Forms.Label();
            this.lblcapShopCode = new System.Windows.Forms.Label();
            this.stsDisplayCount = new System.Windows.Forms.StatusStrip();
            this.slbRecCntCaption = new System.Windows.Forms.ToolStripStatusLabel();
            this.slbRecCntValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.slbMsgValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.sprShopDetail = new FarPoint.Win.Spread.FpSpread();
            this.shtShopDetail = new FarPoint.Win.Spread.SheetView();
            this.grpSearch.SuspendLayout();
            this.stsDisplayCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprShopDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shtShopDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(216, 3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 30);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.TabStop = false;
            this.btnSelect.Text = "F12:選択";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(322, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "F3:終了";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(110, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "F11:検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 0;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "F2:クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.mtxShopName);
            this.grpSearch.Controls.Add(this.mtxShopCodeEnd);
            this.grpSearch.Controls.Add(this.mtxShopCodeStart);
            this.grpSearch.Controls.Add(this.lblcapProcessName);
            this.grpSearch.Controls.Add(this.lblcapLabel1);
            this.grpSearch.Controls.Add(this.lblcapShopCode);
            this.grpSearch.ForeColor = System.Drawing.Color.Blue;
            this.grpSearch.Location = new System.Drawing.Point(4, 39);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(439, 102);
            this.grpSearch.TabIndex = 4;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "検索条件";
            // 
            // mtxShopName
            // 
            this.mtxShopName.AsciiOnly = false;
            this.mtxShopName.CommaFormat = false;
            this.mtxShopName.DecimalPlace = 0;
            this.mtxShopName.Location = new System.Drawing.Point(116, 60);
            this.mtxShopName.MaximumValue = 0D;
            this.mtxShopName.MaxLenB = 20;
            this.mtxShopName.MaxLength = 0;
            this.mtxShopName.MinimumValue = 0D;
            this.mtxShopName.Name = "mtxShopName";
            this.mtxShopName.NumberOnly = false;
            this.mtxShopName.Size = new System.Drawing.Size(296, 27);
            this.mtxShopName.TabIndex = 5;
            this.mtxShopName.Value = "";
            // 
            // mtxShopCodeEnd
            // 
            this.mtxShopCodeEnd.AsciiOnly = false;
            this.mtxShopCodeEnd.CommaFormat = false;
            this.mtxShopCodeEnd.DecimalPlace = 0;
            this.mtxShopCodeEnd.Location = new System.Drawing.Point(221, 28);
            this.mtxShopCodeEnd.MaximumValue = 9999D;
            this.mtxShopCodeEnd.MaxLenB = 4;
            this.mtxShopCodeEnd.MaxLength = 0;
            this.mtxShopCodeEnd.MinimumValue = 0D;
            this.mtxShopCodeEnd.Name = "mtxShopCodeEnd";
            this.mtxShopCodeEnd.NumberOnly = true;
            this.mtxShopCodeEnd.Size = new System.Drawing.Size(69, 27);
            this.mtxShopCodeEnd.TabIndex = 3;
            this.mtxShopCodeEnd.Value = "";
            // 
            // mtxShopCodeStart
            // 
            this.mtxShopCodeStart.AsciiOnly = false;
            this.mtxShopCodeStart.CommaFormat = false;
            this.mtxShopCodeStart.DecimalPlace = 0;
            this.mtxShopCodeStart.Location = new System.Drawing.Point(116, 28);
            this.mtxShopCodeStart.MaximumValue = 9999D;
            this.mtxShopCodeStart.MaxLenB = 4;
            this.mtxShopCodeStart.MaxLength = 0;
            this.mtxShopCodeStart.MinimumValue = 0D;
            this.mtxShopCodeStart.Name = "mtxShopCodeStart";
            this.mtxShopCodeStart.NumberOnly = true;
            this.mtxShopCodeStart.Size = new System.Drawing.Size(69, 27);
            this.mtxShopCodeStart.TabIndex = 1;
            this.mtxShopCodeStart.Value = "";
            // 
            // lblcapProcessName
            // 
            this.lblcapProcessName.AutoSize = true;
            this.lblcapProcessName.ForeColor = System.Drawing.Color.Black;
            this.lblcapProcessName.Location = new System.Drawing.Point(10, 60);
            this.lblcapProcessName.Name = "lblcapProcessName";
            this.lblcapProcessName.Size = new System.Drawing.Size(84, 20);
            this.lblcapProcessName.TabIndex = 4;
            this.lblcapProcessName.Text = "作業部門名";
            // 
            // lblcapLabel1
            // 
            this.lblcapLabel1.AutoSize = true;
            this.lblcapLabel1.ForeColor = System.Drawing.Color.Black;
            this.lblcapLabel1.Location = new System.Drawing.Point(191, 31);
            this.lblcapLabel1.Name = "lblcapLabel1";
            this.lblcapLabel1.Size = new System.Drawing.Size(24, 20);
            this.lblcapLabel1.TabIndex = 2;
            this.lblcapLabel1.Text = "～";
            // 
            // lblcapShopCode
            // 
            this.lblcapShopCode.AutoSize = true;
            this.lblcapShopCode.ForeColor = System.Drawing.Color.Black;
            this.lblcapShopCode.Location = new System.Drawing.Point(10, 31);
            this.lblcapShopCode.Name = "lblcapShopCode";
            this.lblcapShopCode.Size = new System.Drawing.Size(100, 20);
            this.lblcapShopCode.TabIndex = 0;
            this.lblcapShopCode.Text = "作業部門コード";
            // 
            // stsDisplayCount
            // 
            this.stsDisplayCount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slbRecCntCaption,
            this.slbRecCntValue,
            this.slbMsgValue});
            this.stsDisplayCount.Location = new System.Drawing.Point(0, 506);
            this.stsDisplayCount.Name = "stsDisplayCount";
            this.stsDisplayCount.Size = new System.Drawing.Size(456, 22);
            this.stsDisplayCount.TabIndex = 6;
            this.stsDisplayCount.Text = "statusStrip1";
            // 
            // slbRecCntCaption
            // 
            this.slbRecCntCaption.AutoSize = false;
            this.slbRecCntCaption.Name = "slbRecCntCaption";
            this.slbRecCntCaption.Size = new System.Drawing.Size(70, 17);
            this.slbRecCntCaption.Text = "表示件数：";
            this.slbRecCntCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // slbRecCntValue
            // 
            this.slbRecCntValue.AutoSize = false;
            this.slbRecCntValue.Name = "slbRecCntValue";
            this.slbRecCntValue.Size = new System.Drawing.Size(80, 17);
            this.slbRecCntValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // slbMsgValue
            // 
            this.slbMsgValue.Name = "slbMsgValue";
            this.slbMsgValue.Size = new System.Drawing.Size(0, 17);
            // 
            // sprShopDetail
            // 
            this.sprShopDetail.AccessibleDescription = "";
            this.sprShopDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sprShopDetail.Location = new System.Drawing.Point(4, 147);
            this.sprShopDetail.Name = "sprShopDetail";
            this.sprShopDetail.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.shtShopDetail});
            this.sprShopDetail.Size = new System.Drawing.Size(439, 356);
            this.sprShopDetail.TabIndex = 5;
            // 
            // shtShopDetail
            // 
            this.shtShopDetail.Reset();
            this.shtShopDetail.SheetName = "Sheet1";
            // 
            // AR9130
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 528);
            this.Controls.Add(this.sprShopDetail);
            this.Controls.Add(this.stsDisplayCount);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.KeyPreview = true;
            this.Name = "AR9130";
            this.Text = "AR9130";
            this.Load += new System.EventHandler(this.AR9130_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AR9130_KeyDown);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.stsDisplayCount.ResumeLayout(false);
            this.stsDisplayCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprShopDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shtShopDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSelect;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.GroupBox grpSearch;
        internal System.Windows.Forms.Label lblcapProcessName;
        internal System.Windows.Forms.Label lblcapLabel1;
        internal System.Windows.Forms.Label lblcapShopCode;
        private System.Windows.Forms.StatusStrip stsDisplayCount;
        private FarPoint.Win.Spread.FpSpread sprShopDetail;
        private FarPoint.Win.Spread.SheetView shtShopDetail;
        private Aero.Cosi.Forms.LimitEditBox mtxShopName;
        private Aero.Cosi.Forms.LimitEditBox mtxShopCodeEnd;
        private Aero.Cosi.Forms.LimitEditBox mtxShopCodeStart;
        private System.Windows.Forms.ToolStripStatusLabel slbRecCntCaption;
        private System.Windows.Forms.ToolStripStatusLabel slbRecCntValue;
        private System.Windows.Forms.ToolStripStatusLabel slbMsgValue;
    }
}