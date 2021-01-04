
namespace QUANLYBANHANG1
{
    partial class fQLSP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalesStatistics = new System.Windows.Forms.Button();
            this.btnManipulate = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pTop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxChoice = new System.Windows.Forms.ComboBox();
            this.lbChoice = new System.Windows.Forms.Label();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.lbKeyWord = new System.Windows.Forms.Label();
            this.lbDanhSachSP = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pTop.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalesStatistics);
            this.panel1.Controls.Add(this.btnManipulate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 358);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 52);
            this.panel1.TabIndex = 1;
            // 
            // btnSalesStatistics
            // 
            this.btnSalesStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesStatistics.Location = new System.Drawing.Point(11, 12);
            this.btnSalesStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalesStatistics.Name = "btnSalesStatistics";
            this.btnSalesStatistics.Size = new System.Drawing.Size(197, 38);
            this.btnSalesStatistics.TabIndex = 1;
            this.btnSalesStatistics.Text = "Thống kê bán hàng";
            this.btnSalesStatistics.UseVisualStyleBackColor = true;
            this.btnSalesStatistics.Click += new System.EventHandler(this.btnSalesStatistics_Click);
            // 
            // btnManipulate
            // 
            this.btnManipulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManipulate.Location = new System.Drawing.Point(731, 12);
            this.btnManipulate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManipulate.Name = "btnManipulate";
            this.btnManipulate.Size = new System.Drawing.Size(99, 38);
            this.btnManipulate.TabIndex = 0;
            this.btnManipulate.Text = "Chỉnh Sửa";
            this.btnManipulate.UseVisualStyleBackColor = true;
            this.btnManipulate.Click += new System.EventHandler(this.btnManipulate_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAll.Location = new System.Drawing.Point(757, 78);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 27);
            this.btnSelectAll.TabIndex = 0;
            this.btnSelectAll.Text = "Tất cả";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(669, 78);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pTop
            // 
            this.pTop.Controls.Add(this.btnSelectAll);
            this.pTop.Controls.Add(this.panel3);
            this.pTop.Controls.Add(this.btnSearch);
            this.pTop.Controls.Add(this.lbDanhSachSP);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(843, 110);
            this.pTop.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbxChoice);
            this.panel3.Controls.Add(this.lbChoice);
            this.panel3.Controls.Add(this.txtKeyWord);
            this.panel3.Controls.Add(this.lbKeyWord);
            this.panel3.Location = new System.Drawing.Point(11, 36);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(821, 31);
            this.panel3.TabIndex = 0;
            // 
            // cbxChoice
            // 
            this.cbxChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChoice.FormattingEnabled = true;
            this.cbxChoice.Items.AddRange(new object[] {
            "Mã Sản Phẩm",
            "Tên Sản Phẩm"});
            this.cbxChoice.Location = new System.Drawing.Point(95, 4);
            this.cbxChoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxChoice.Name = "cbxChoice";
            this.cbxChoice.Size = new System.Drawing.Size(182, 24);
            this.cbxChoice.TabIndex = 3;
            // 
            // lbChoice
            // 
            this.lbChoice.AutoSize = true;
            this.lbChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChoice.Location = new System.Drawing.Point(12, 6);
            this.lbChoice.Name = "lbChoice";
            this.lbChoice.Size = new System.Drawing.Size(75, 17);
            this.lbChoice.TabIndex = 2;
            this.lbChoice.Text = "Cách tìm:";
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Location = new System.Drawing.Point(363, 4);
            this.txtKeyWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(456, 22);
            this.txtKeyWord.TabIndex = 1;
            this.txtKeyWord.TextChanged += new System.EventHandler(this.txtKeyWord_TextChanged);
            // 
            // lbKeyWord
            // 
            this.lbKeyWord.AutoSize = true;
            this.lbKeyWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKeyWord.Location = new System.Drawing.Point(281, 6);
            this.lbKeyWord.Name = "lbKeyWord";
            this.lbKeyWord.Size = new System.Drawing.Size(74, 17);
            this.lbKeyWord.TabIndex = 1;
            this.lbKeyWord.Text = "Từ Khóa:";
            // 
            // lbDanhSachSP
            // 
            this.lbDanhSachSP.AutoSize = true;
            this.lbDanhSachSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachSP.Location = new System.Drawing.Point(284, 7);
            this.lbDanhSachSP.Name = "lbDanhSachSP";
            this.lbDanhSachSP.Size = new System.Drawing.Size(263, 29);
            this.lbDanhSachSP.TabIndex = 0;
            this.lbDanhSachSP.Text = "Danh Sách Sản Phẩm";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 110);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 62;
            this.dgvSanPham.RowTemplate.Height = 28;
            this.dgvSanPham.Size = new System.Drawing.Size(843, 248);
            this.dgvSanPham.TabIndex = 2;
            // 
            // fQLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 410);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fQLSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sản Phẩm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fQLSP_FormClosed);
            this.Load += new System.EventHandler(this.fQLSP_Load);
            this.panel1.ResumeLayout(false);
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnManipulate;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.Label lbKeyWord;
        private System.Windows.Forms.Label lbDanhSachSP;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.ComboBox cbxChoice;
        private System.Windows.Forms.Label lbChoice;
        private System.Windows.Forms.Button btnSalesStatistics;
    }
}

