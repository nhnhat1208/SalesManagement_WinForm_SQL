
namespace QUANLYBANHANG1
{
    partial class SP_Manipulate
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pBot = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.pContainer = new System.Windows.Forms.Panel();
            this.lbManipulate = new System.Windows.Forms.Label();
            this.pMaLoai = new System.Windows.Forms.Panel();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.lbMaLoai = new System.Windows.Forms.Label();
            this.pChatLieu = new System.Windows.Forms.Panel();
            this.txtChatLieu = new System.Windows.Forms.TextBox();
            this.lbChatLieu = new System.Windows.Forms.Label();
            this.pMauSac = new System.Windows.Forms.Panel();
            this.txtMauSac = new System.Windows.Forms.TextBox();
            this.lbMauSac = new System.Windows.Forms.Label();
            this.pMaSP = new System.Windows.Forms.Panel();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lbMaSP = new System.Windows.Forms.Label();
            this.pHangSX = new System.Windows.Forms.Panel();
            this.txtHangSX = new System.Windows.Forms.TextBox();
            this.lbHangSX = new System.Windows.Forms.Label();
            this.pTenSP = new System.Windows.Forms.Panel();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.dgv1SanPham = new System.Windows.Forms.DataGridView();
            this.pBot.SuspendLayout();
            this.pContainer.SuspendLayout();
            this.pMaLoai.SuspendLayout();
            this.pChatLieu.SuspendLayout();
            this.pMauSac.SuspendLayout();
            this.pMaSP.SuspendLayout();
            this.pHangSX.SuspendLayout();
            this.pTenSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(185, 9);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(102, 41);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(785, 9);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 41);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Trở Lại";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pBot
            // 
            this.pBot.Controls.Add(this.btnSave);
            this.pBot.Controls.Add(this.btnDelete);
            this.pBot.Controls.Add(this.btnUpdate);
            this.pBot.Controls.Add(this.btnSkip);
            this.pBot.Controls.Add(this.btnInsert);
            this.pBot.Controls.Add(this.btnReturn);
            this.pBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBot.Location = new System.Drawing.Point(0, 490);
            this.pBot.Name = "pBot";
            this.pBot.Size = new System.Drawing.Size(915, 53);
            this.pBot.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(492, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 41);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(337, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 41);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(35, 9);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 41);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(635, 9);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(102, 41);
            this.btnSkip.TabIndex = 2;
            this.btnSkip.Text = "Bỏ Qua";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // pContainer
            // 
            this.pContainer.Controls.Add(this.lbManipulate);
            this.pContainer.Controls.Add(this.pMaLoai);
            this.pContainer.Controls.Add(this.pChatLieu);
            this.pContainer.Controls.Add(this.pMauSac);
            this.pContainer.Controls.Add(this.pMaSP);
            this.pContainer.Controls.Add(this.pHangSX);
            this.pContainer.Controls.Add(this.pTenSP);
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pContainer.Location = new System.Drawing.Point(0, 0);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(915, 212);
            this.pContainer.TabIndex = 0;
            // 
            // lbManipulate
            // 
            this.lbManipulate.AutoSize = true;
            this.lbManipulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManipulate.Location = new System.Drawing.Point(218, 9);
            this.lbManipulate.Name = "lbManipulate";
            this.lbManipulate.Size = new System.Drawing.Size(432, 32);
            this.lbManipulate.TabIndex = 14;
            this.lbManipulate.Text = "FORM CHỈNH SỬA SẢN PHẨM";
            // 
            // pMaLoai
            // 
            this.pMaLoai.Controls.Add(this.txtMaLoai);
            this.pMaLoai.Controls.Add(this.lbMaLoai);
            this.pMaLoai.Location = new System.Drawing.Point(26, 160);
            this.pMaLoai.Name = "pMaLoai";
            this.pMaLoai.Size = new System.Drawing.Size(362, 44);
            this.pMaLoai.TabIndex = 4;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(136, 6);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(223, 26);
            this.txtMaLoai.TabIndex = 0;
            // 
            // lbMaLoai
            // 
            this.lbMaLoai.AutoSize = true;
            this.lbMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLoai.Location = new System.Drawing.Point(5, 12);
            this.lbMaLoai.Name = "lbMaLoai";
            this.lbMaLoai.Size = new System.Drawing.Size(77, 20);
            this.lbMaLoai.TabIndex = 0;
            this.lbMaLoai.Text = "Mã Loại:";
            // 
            // pChatLieu
            // 
            this.pChatLieu.Controls.Add(this.txtChatLieu);
            this.pChatLieu.Controls.Add(this.lbChatLieu);
            this.pChatLieu.Location = new System.Drawing.Point(431, 160);
            this.pChatLieu.Name = "pChatLieu";
            this.pChatLieu.Size = new System.Drawing.Size(421, 44);
            this.pChatLieu.TabIndex = 5;
            // 
            // txtChatLieu
            // 
            this.txtChatLieu.Location = new System.Drawing.Point(136, 9);
            this.txtChatLieu.Name = "txtChatLieu";
            this.txtChatLieu.Size = new System.Drawing.Size(282, 26);
            this.txtChatLieu.TabIndex = 0;
            // 
            // lbChatLieu
            // 
            this.lbChatLieu.AutoSize = true;
            this.lbChatLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChatLieu.Location = new System.Drawing.Point(5, 12);
            this.lbChatLieu.Name = "lbChatLieu";
            this.lbChatLieu.Size = new System.Drawing.Size(91, 20);
            this.lbChatLieu.TabIndex = 0;
            this.lbChatLieu.Text = "Chất Liệu:";
            // 
            // pMauSac
            // 
            this.pMauSac.Controls.Add(this.txtMauSac);
            this.pMauSac.Controls.Add(this.lbMauSac);
            this.pMauSac.Location = new System.Drawing.Point(26, 110);
            this.pMauSac.Name = "pMauSac";
            this.pMauSac.Size = new System.Drawing.Size(362, 44);
            this.pMauSac.TabIndex = 2;
            // 
            // txtMauSac
            // 
            this.txtMauSac.Location = new System.Drawing.Point(136, 9);
            this.txtMauSac.Name = "txtMauSac";
            this.txtMauSac.Size = new System.Drawing.Size(223, 26);
            this.txtMauSac.TabIndex = 0;
            // 
            // lbMauSac
            // 
            this.lbMauSac.AutoSize = true;
            this.lbMauSac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMauSac.Location = new System.Drawing.Point(5, 12);
            this.lbMauSac.Name = "lbMauSac";
            this.lbMauSac.Size = new System.Drawing.Size(84, 20);
            this.lbMauSac.TabIndex = 0;
            this.lbMauSac.Text = "Màu Sắc:";
            // 
            // pMaSP
            // 
            this.pMaSP.Controls.Add(this.txtMaSP);
            this.pMaSP.Controls.Add(this.lbMaSP);
            this.pMaSP.Location = new System.Drawing.Point(26, 60);
            this.pMaSP.Name = "pMaSP";
            this.pMaSP.Size = new System.Drawing.Size(362, 44);
            this.pMaSP.TabIndex = 0;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(136, 9);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(223, 26);
            this.txtMaSP.TabIndex = 0;
            // 
            // lbMaSP
            // 
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSP.Location = new System.Drawing.Point(5, 12);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(125, 20);
            this.lbMaSP.TabIndex = 1;
            this.lbMaSP.Text = "Mã Sản Phẩm:";
            // 
            // pHangSX
            // 
            this.pHangSX.Controls.Add(this.txtHangSX);
            this.pHangSX.Controls.Add(this.lbHangSX);
            this.pHangSX.Location = new System.Drawing.Point(431, 110);
            this.pHangSX.Name = "pHangSX";
            this.pHangSX.Size = new System.Drawing.Size(421, 44);
            this.pHangSX.TabIndex = 3;
            // 
            // txtHangSX
            // 
            this.txtHangSX.Location = new System.Drawing.Point(136, 9);
            this.txtHangSX.Name = "txtHangSX";
            this.txtHangSX.Size = new System.Drawing.Size(282, 26);
            this.txtHangSX.TabIndex = 0;
            // 
            // lbHangSX
            // 
            this.lbHangSX.AutoSize = true;
            this.lbHangSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHangSX.Location = new System.Drawing.Point(5, 12);
            this.lbHangSX.Name = "lbHangSX";
            this.lbHangSX.Size = new System.Drawing.Size(137, 20);
            this.lbHangSX.TabIndex = 0;
            this.lbHangSX.Text = "Hãng Sản Xuất:";
            // 
            // pTenSP
            // 
            this.pTenSP.Controls.Add(this.txtTenSP);
            this.pTenSP.Controls.Add(this.lbTenSP);
            this.pTenSP.Location = new System.Drawing.Point(431, 60);
            this.pTenSP.Name = "pTenSP";
            this.pTenSP.Size = new System.Drawing.Size(421, 44);
            this.pTenSP.TabIndex = 1;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(136, 9);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(282, 26);
            this.txtTenSP.TabIndex = 0;
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSP.Location = new System.Drawing.Point(5, 12);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(131, 20);
            this.lbTenSP.TabIndex = 0;
            this.lbTenSP.Text = "Tên Sản Phẩm:";
            // 
            // dgv1SanPham
            // 
            this.dgv1SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1SanPham.Location = new System.Drawing.Point(0, 212);
            this.dgv1SanPham.Name = "dgv1SanPham";
            this.dgv1SanPham.RowHeadersWidth = 62;
            this.dgv1SanPham.RowTemplate.Height = 28;
            this.dgv1SanPham.Size = new System.Drawing.Size(915, 278);
            this.dgv1SanPham.TabIndex = 6;
            this.dgv1SanPham.Click += new System.EventHandler(this.dgv1SanPham_Click);
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 543);
            this.Controls.Add(this.dgv1SanPham);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.pBot);
            this.Name = "InsertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh Sửa Sản Phẩm";
            this.Load += new System.EventHandler(this.InsertForm_Load);
            this.pBot.ResumeLayout(false);
            this.pContainer.ResumeLayout(false);
            this.pContainer.PerformLayout();
            this.pMaLoai.ResumeLayout(false);
            this.pMaLoai.PerformLayout();
            this.pChatLieu.ResumeLayout(false);
            this.pChatLieu.PerformLayout();
            this.pMauSac.ResumeLayout(false);
            this.pMauSac.PerformLayout();
            this.pMaSP.ResumeLayout(false);
            this.pMaSP.PerformLayout();
            this.pHangSX.ResumeLayout(false);
            this.pHangSX.PerformLayout();
            this.pTenSP.ResumeLayout(false);
            this.pTenSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1SanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pBot;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Label lbManipulate;
        private System.Windows.Forms.Panel pMaLoai;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label lbMaLoai;
        private System.Windows.Forms.Panel pChatLieu;
        private System.Windows.Forms.TextBox txtChatLieu;
        private System.Windows.Forms.Label lbChatLieu;
        private System.Windows.Forms.Panel pMauSac;
        private System.Windows.Forms.TextBox txtMauSac;
        private System.Windows.Forms.Label lbMauSac;
        private System.Windows.Forms.Panel pMaSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.Panel pHangSX;
        private System.Windows.Forms.TextBox txtHangSX;
        private System.Windows.Forms.Label lbHangSX;
        private System.Windows.Forms.Panel pTenSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.DataGridView dgv1SanPham;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSave;
    }
}