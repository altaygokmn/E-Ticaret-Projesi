namespace EntityFramework
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonUptade = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.textBoxStockAmount = new System.Windows.Forms.TextBox();
            this.textBoxStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.textBoxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.textboxNameUpdate = new System.Windows.Forms.TextBox();
            this.dgwPrd = new System.Windows.Forms.DataGridView();
            this.labelNameUpdate = new System.Windows.Forms.Label();
            this.labelUnitPriceUpdate = new System.Windows.Forms.Label();
            this.labelStockAmountUpdate = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.labelStockAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrd)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(970, 12);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(144, 34);
            this.buttonRemove.TabIndex = 0;
            this.buttonRemove.Text = "Sil";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonUptade
            // 
            this.buttonUptade.Location = new System.Drawing.Point(938, 539);
            this.buttonUptade.Name = "buttonUptade";
            this.buttonUptade.Size = new System.Drawing.Size(176, 43);
            this.buttonUptade.TabIndex = 1;
            this.buttonUptade.Text = "Güncelle";
            this.buttonUptade.UseVisualStyleBackColor = true;
            this.buttonUptade.Click += new System.EventHandler(this.buttonUptade_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(377, 539);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(176, 43);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Ekle";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(377, 372);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(176, 22);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(377, 419);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(176, 22);
            this.textBoxUnitPrice.TabIndex = 5;
            // 
            // textBoxStockAmount
            // 
            this.textBoxStockAmount.Location = new System.Drawing.Point(377, 468);
            this.textBoxStockAmount.Name = "textBoxStockAmount";
            this.textBoxStockAmount.Size = new System.Drawing.Size(176, 22);
            this.textBoxStockAmount.TabIndex = 6;
            // 
            // textBoxStockAmountUpdate
            // 
            this.textBoxStockAmountUpdate.Location = new System.Drawing.Point(938, 470);
            this.textBoxStockAmountUpdate.Name = "textBoxStockAmountUpdate";
            this.textBoxStockAmountUpdate.Size = new System.Drawing.Size(176, 22);
            this.textBoxStockAmountUpdate.TabIndex = 7;
            // 
            // textBoxUnitPriceUpdate
            // 
            this.textBoxUnitPriceUpdate.Location = new System.Drawing.Point(938, 421);
            this.textBoxUnitPriceUpdate.Name = "textBoxUnitPriceUpdate";
            this.textBoxUnitPriceUpdate.Size = new System.Drawing.Size(176, 22);
            this.textBoxUnitPriceUpdate.TabIndex = 8;
            // 
            // textboxNameUpdate
            // 
            this.textboxNameUpdate.Location = new System.Drawing.Point(938, 372);
            this.textboxNameUpdate.Name = "textboxNameUpdate";
            this.textboxNameUpdate.Size = new System.Drawing.Size(176, 22);
            this.textboxNameUpdate.TabIndex = 9;
            // 
            // dgwPrd
            // 
            this.dgwPrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPrd.Location = new System.Drawing.Point(26, 52);
            this.dgwPrd.Name = "dgwPrd";
            this.dgwPrd.RowHeadersWidth = 51;
            this.dgwPrd.RowTemplate.Height = 24;
            this.dgwPrd.Size = new System.Drawing.Size(1088, 267);
            this.dgwPrd.TabIndex = 10;
            this.dgwPrd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // labelNameUpdate
            // 
            this.labelNameUpdate.AutoSize = true;
            this.labelNameUpdate.Location = new System.Drawing.Point(864, 378);
            this.labelNameUpdate.Name = "labelNameUpdate";
            this.labelNameUpdate.Size = new System.Drawing.Size(31, 16);
            this.labelNameUpdate.TabIndex = 11;
            this.labelNameUpdate.Text = "İsim";
            // 
            // labelUnitPriceUpdate
            // 
            this.labelUnitPriceUpdate.AutoSize = true;
            this.labelUnitPriceUpdate.Location = new System.Drawing.Point(864, 427);
            this.labelUnitPriceUpdate.Name = "labelUnitPriceUpdate";
            this.labelUnitPriceUpdate.Size = new System.Drawing.Size(36, 16);
            this.labelUnitPriceUpdate.TabIndex = 12;
            this.labelUnitPriceUpdate.Text = "Fiyat";
            // 
            // labelStockAmountUpdate
            // 
            this.labelStockAmountUpdate.AutoSize = true;
            this.labelStockAmountUpdate.Location = new System.Drawing.Point(864, 473);
            this.labelStockAmountUpdate.Name = "labelStockAmountUpdate";
            this.labelStockAmountUpdate.Size = new System.Drawing.Size(73, 16);
            this.labelStockAmountUpdate.TabIndex = 13;
            this.labelStockAmountUpdate.Text = "Stok Adedi";
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Location = new System.Drawing.Point(254, 378);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(31, 16);
            this.labelAdd.TabIndex = 14;
            this.labelAdd.Text = "İsim";
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(263, 427);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(36, 16);
            this.labelUnitPrice.TabIndex = 15;
            this.labelUnitPrice.Text = "Fiyat";
            // 
            // labelStockAmount
            // 
            this.labelStockAmount.AutoSize = true;
            this.labelStockAmount.Location = new System.Drawing.Point(263, 476);
            this.labelStockAmount.Name = "labelStockAmount";
            this.labelStockAmount.Size = new System.Drawing.Size(73, 16);
            this.labelStockAmount.TabIndex = 16;
            this.labelStockAmount.Text = "Stok Adedi";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1195, 617);
            this.Controls.Add(this.labelStockAmount);
            this.Controls.Add(this.labelUnitPrice);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.labelStockAmountUpdate);
            this.Controls.Add(this.labelUnitPriceUpdate);
            this.Controls.Add(this.labelNameUpdate);
            this.Controls.Add(this.dgwPrd);
            this.Controls.Add(this.textboxNameUpdate);
            this.Controls.Add(this.textBoxUnitPriceUpdate);
            this.Controls.Add(this.textBoxStockAmountUpdate);
            this.Controls.Add(this.textBoxStockAmount);
            this.Controls.Add(this.textBoxUnitPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonUptade);
            this.Controls.Add(this.buttonRemove);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPrd;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonUptade;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.TextBox textBoxStockAmount;
        private System.Windows.Forms.TextBox textBoxStockAmountUpdate;
        private System.Windows.Forms.TextBox textBoxUnitPriceUpdate;
        private System.Windows.Forms.TextBox textboxNameUpdate;
        private System.Windows.Forms.Label labelNameUpdate;
        private System.Windows.Forms.Label labelUnitPriceUpdate;
        private System.Windows.Forms.Label labelStockAmountUpdate;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.Label labelStockAmount;
    }
}

