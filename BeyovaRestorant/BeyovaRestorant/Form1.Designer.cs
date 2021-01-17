namespace BeyovaRestorant
{
    partial class Form1
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
            this.navpageUrunler = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navpUrunler = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.flowUrunler = new System.Windows.Forms.FlowLayoutPanel();
            this.navpMasalar = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.flowMasalar = new System.Windows.Forms.FlowLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnOde = new DevExpress.XtraEditors.SimpleButton();
            this.toplamTxt = new DevExpress.XtraEditors.CalcEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUrunKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.navpageUrunler)).BeginInit();
            this.navpageUrunler.SuspendLayout();
            this.navpUrunler.SuspendLayout();
            this.navpMasalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toplamTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navpageUrunler
            // 
            this.navpageUrunler.Controls.Add(this.navpUrunler);
            this.navpageUrunler.Controls.Add(this.navpMasalar);
            this.navpageUrunler.Dock = System.Windows.Forms.DockStyle.Right;
            this.navpageUrunler.Location = new System.Drawing.Point(528, 0);
            this.navpageUrunler.Name = "navpageUrunler";
            this.navpageUrunler.PageProperties.ShowCollapseButton = false;
            this.navpageUrunler.PageProperties.ShowExpandButton = false;
            this.navpageUrunler.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navpUrunler,
            this.navpMasalar});
            this.navpageUrunler.RegularSize = new System.Drawing.Size(294, 536);
            this.navpageUrunler.SelectedPage = this.navpMasalar;
            this.navpageUrunler.Size = new System.Drawing.Size(294, 536);
            this.navpageUrunler.TabIndex = 0;
            this.navpageUrunler.Text = "Urunler";
            // 
            // navpUrunler
            // 
            this.navpUrunler.Caption = "Urunler";
            this.navpUrunler.Controls.Add(this.flowUrunler);
            this.navpUrunler.Name = "navpUrunler";
            this.navpUrunler.Size = new System.Drawing.Size(229, 490);
            // 
            // flowUrunler
            // 
            this.flowUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowUrunler.Location = new System.Drawing.Point(0, 0);
            this.flowUrunler.Name = "flowUrunler";
            this.flowUrunler.Size = new System.Drawing.Size(229, 490);
            this.flowUrunler.TabIndex = 0;
            // 
            // navpMasalar
            // 
            this.navpMasalar.Caption = "Masalar";
            this.navpMasalar.Controls.Add(this.flowMasalar);
            this.navpMasalar.Controls.Add(this.groupControl1);
            this.navpMasalar.Name = "navpMasalar";
            this.navpMasalar.Size = new System.Drawing.Size(223, 490);
            // 
            // flowMasalar
            // 
            this.flowMasalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMasalar.Location = new System.Drawing.Point(0, 0);
            this.flowMasalar.Name = "flowMasalar";
            this.flowMasalar.Size = new System.Drawing.Size(223, 397);
            this.flowMasalar.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnOde);
            this.groupControl1.Controls.Add(this.toplamTxt);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 397);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(223, 93);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Hesap";
            // 
            // btnOde
            // 
            this.btnOde.Location = new System.Drawing.Point(72, 63);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(75, 23);
            this.btnOde.TabIndex = 1;
            this.btnOde.Text = "Hesabı Öde";
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // toplamTxt
            // 
            this.toplamTxt.Location = new System.Drawing.Point(23, 37);
            this.toplamTxt.Name = "toplamTxt";
            this.toplamTxt.Size = new System.Drawing.Size(178, 20);
            this.toplamTxt.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(528, 536);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUrunKodu,
            this.colUrunAdi,
            this.colUrunBirim,
            this.colUrunMiktar,
            this.colUrunFiyat,
            this.colToplam});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colUrunKodu
            // 
            this.colUrunKodu.Caption = "Ürün Kodu";
            this.colUrunKodu.FieldName = "urunKodu";
            this.colUrunKodu.Name = "colUrunKodu";
            this.colUrunKodu.OptionsColumn.AllowEdit = false;
            this.colUrunKodu.Visible = true;
            this.colUrunKodu.VisibleIndex = 0;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "urunAd";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.OptionsColumn.AllowEdit = false;
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 1;
            // 
            // colUrunBirim
            // 
            this.colUrunBirim.Caption = "Birimi";
            this.colUrunBirim.FieldName = "urunBirim";
            this.colUrunBirim.Name = "colUrunBirim";
            this.colUrunBirim.OptionsColumn.AllowEdit = false;
            this.colUrunBirim.Visible = true;
            this.colUrunBirim.VisibleIndex = 2;
            // 
            // colUrunMiktar
            // 
            this.colUrunMiktar.Caption = "Miktar";
            this.colUrunMiktar.FieldName = "miktar";
            this.colUrunMiktar.Name = "colUrunMiktar";
            this.colUrunMiktar.Visible = true;
            this.colUrunMiktar.VisibleIndex = 3;
            // 
            // colUrunFiyat
            // 
            this.colUrunFiyat.Caption = "Fiyat";
            this.colUrunFiyat.FieldName = "fiyat";
            this.colUrunFiyat.Name = "colUrunFiyat";
            this.colUrunFiyat.OptionsColumn.AllowEdit = false;
            this.colUrunFiyat.Visible = true;
            this.colUrunFiyat.VisibleIndex = 4;
            // 
            // colToplam
            // 
            this.colToplam.Caption = "Toplam Tutar";
            this.colToplam.DisplayFormat.FormatString = "C2";
            this.colToplam.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplam.FieldName = "colToplam";
            this.colToplam.Name = "colToplam";
            this.colToplam.OptionsColumn.AllowEdit = false;
            this.colToplam.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colToplam", "SUM={0:C2}")});
            this.colToplam.UnboundExpression = "[miktar] * [fiyat]";
            this.colToplam.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colToplam.Visible = true;
            this.colToplam.VisibleIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 536);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.navpageUrunler);
            this.Name = "Form1";
            this.Text = "Beyova Restorant Otomasyonu";
            ((System.ComponentModel.ISupportInitialize)(this.navpageUrunler)).EndInit();
            this.navpageUrunler.ResumeLayout(false);
            this.navpUrunler.ResumeLayout(false);
            this.navpMasalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toplamTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navpageUrunler;
        private DevExpress.XtraBars.Navigation.NavigationPage navpUrunler;
        private System.Windows.Forms.FlowLayoutPanel flowUrunler;
        private DevExpress.XtraBars.Navigation.NavigationPage navpMasalar;
        private System.Windows.Forms.FlowLayoutPanel flowMasalar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunBirim;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colToplam;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CalcEdit toplamTxt;
        private DevExpress.XtraEditors.SimpleButton btnOde;
    }
}

