namespace Lab6;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.tabControl1 = new System.Windows.Forms.TabControl();
        this.tabPage1 = new System.Windows.Forms.TabPage();
        this.tabPage2 = new System.Windows.Forms.TabPage();
        this.tabPage3 = new System.Windows.Forms.TabPage();
        this.tabPage4 = new System.Windows.Forms.TabPage();

        // Tab 1: Hiển thị danh sách
        this.lsvDanhSach = new System.Windows.Forms.ListView();
        this.colMaXB = new System.Windows.Forms.ColumnHeader();
        this.colTenXB = new System.Windows.Forms.ColumnHeader();
        this.colDiaChi = new System.Windows.Forms.ColumnHeader();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.txtMaXB_View = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.txtDiaChi_View = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.txtTenXB_View = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();

        // Tab 2: Thêm dữ liệu
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.btnThemDL = new System.Windows.Forms.Button();
        this.txtMaXB_Add = new System.Windows.Forms.TextBox();
        this.label5 = new System.Windows.Forms.Label();
        this.txtDiaChi_Add = new System.Windows.Forms.TextBox();
        this.label6 = new System.Windows.Forms.Label();
        this.txtTenXB_Add = new System.Windows.Forms.TextBox();
        this.label7 = new System.Windows.Forms.Label();
        this.label8 = new System.Windows.Forms.Label();

        // Tab 3: Sửa dữ liệu
        this.groupBox3 = new System.Windows.Forms.GroupBox();
        this.btnSuaDL = new System.Windows.Forms.Button();
        this.txtMaXB_Edit = new System.Windows.Forms.TextBox();
        this.label9 = new System.Windows.Forms.Label();
        this.txtDiaChi_Edit = new System.Windows.Forms.TextBox();
        this.label10 = new System.Windows.Forms.Label();
        this.txtTenXB_Edit = new System.Windows.Forms.TextBox();
        this.label11 = new System.Windows.Forms.Label();
        this.label12 = new System.Windows.Forms.Label();

        // Tab 4: Xóa dữ liệu
        this.groupBox4 = new System.Windows.Forms.GroupBox();
        this.btnXoaDL = new System.Windows.Forms.Button();
        this.txtMaXB_Del = new System.Windows.Forms.TextBox();
        this.label13 = new System.Windows.Forms.Label();
        this.label14 = new System.Windows.Forms.Label();

        // tabControl1
        this.tabControl1.Controls.Add(this.tabPage1);
        this.tabControl1.Controls.Add(this.tabPage2);
        this.tabControl1.Controls.Add(this.tabPage3);
        this.tabControl1.Controls.Add(this.tabPage4);
        this.tabControl1.Location = new System.Drawing.Point(12, 12);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new System.Drawing.Size(760, 537);
        this.tabControl1.TabIndex = 0;

        // tabPage1
        this.tabPage1.Controls.Add(this.lsvDanhSach);
        this.tabPage1.Controls.Add(this.groupBox1);
        this.tabPage1.Location = new System.Drawing.Point(4, 24);
        this.tabPage1.Name = "tabPage1";
        this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage1.Size = new System.Drawing.Size(752, 509);
        this.tabPage1.TabIndex = 0;
        this.tabPage1.Text = "Hiển thị danh sách";
        this.tabPage1.UseVisualStyleBackColor = true;

        // lsvDanhSach
        this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaXB,
            this.colTenXB,
            this.colDiaChi});
        this.lsvDanhSach.FullRowSelect = true;
        this.lsvDanhSach.GridLines = true;
        this.lsvDanhSach.Location = new System.Drawing.Point(6, 6);
        this.lsvDanhSach.Name = "lsvDanhSach";
        this.lsvDanhSach.Size = new System.Drawing.Size(740, 250);
        this.lsvDanhSach.TabIndex = 0;
        this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
        this.lsvDanhSach.View = System.Windows.Forms.View.Details;
        this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);

        // colMaXB
        this.colMaXB.Text = "Mã nhà xuất bản";
        this.colMaXB.Width = 150;

        // colTenXB
        this.colTenXB.Text = "Tên nhà xuất bản";
        this.colTenXB.Width = 200;

        // colDiaChi
        this.colDiaChi.Text = "Địa chỉ";
        this.colDiaChi.Width = 350;

        // groupBox1
        this.groupBox1.Controls.Add(this.label1);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Controls.Add(this.txtTenXB_View);
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Controls.Add(this.txtDiaChi_View);
        this.groupBox1.Controls.Add(this.label4);
        this.groupBox1.Controls.Add(this.txtMaXB_View);
        this.groupBox1.Location = new System.Drawing.Point(6, 262);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(740, 241);
        this.groupBox1.TabIndex = 1;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Thông tin chi tiết";

        // label1
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(16, 30);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(93, 15);
        this.label1.TabIndex = 0;
        this.label1.Text = "Mã nhà xuất bản:";

        // label2
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(16, 70);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(98, 15);
        this.label2.TabIndex = 1;
        this.label2.Text = "Tên nhà xuất bản:";

        // label3
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(16, 110);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(50, 15);
        this.label3.TabIndex = 2;
        this.label3.Text = "Địa chỉ:";

        // label4
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(16, 150);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(0, 15);
        this.label4.TabIndex = 3;

        // txtMaXB_View
        this.txtMaXB_View.Location = new System.Drawing.Point(138, 27);
        this.txtMaXB_View.Name = "txtMaXB_View";
        this.txtMaXB_View.ReadOnly = true;
        this.txtMaXB_View.Size = new System.Drawing.Size(596, 23);
        this.txtMaXB_View.TabIndex = 4;

        // txtTenXB_View
        this.txtTenXB_View.Location = new System.Drawing.Point(138, 67);
        this.txtTenXB_View.Name = "txtTenXB_View";
        this.txtTenXB_View.ReadOnly = true;
        this.txtTenXB_View.Size = new System.Drawing.Size(596, 23);
        this.txtTenXB_View.TabIndex = 5;

        // txtDiaChi_View
        this.txtDiaChi_View.Location = new System.Drawing.Point(138, 107);
        this.txtDiaChi_View.Multiline = true;
        this.txtDiaChi_View.Name = "txtDiaChi_View";
        this.txtDiaChi_View.ReadOnly = true;
        this.txtDiaChi_View.Size = new System.Drawing.Size(596, 120);
        this.txtDiaChi_View.TabIndex = 6;

        // tabPage2 - Thêm dữ liệu
        this.tabPage2.Controls.Add(this.groupBox2);
        this.tabPage2.Location = new System.Drawing.Point(4, 24);
        this.tabPage2.Name = "tabPage2";
        this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage2.Size = new System.Drawing.Size(752, 509);
        this.tabPage2.TabIndex = 1;
        this.tabPage2.Text = "Thêm dữ liệu";
        this.tabPage2.UseVisualStyleBackColor = true;

        // groupBox2
        this.groupBox2.Controls.Add(this.label8);
        this.groupBox2.Controls.Add(this.label7);
        this.groupBox2.Controls.Add(this.txtTenXB_Add);
        this.groupBox2.Controls.Add(this.label6);
        this.groupBox2.Controls.Add(this.txtDiaChi_Add);
        this.groupBox2.Controls.Add(this.label5);
        this.groupBox2.Controls.Add(this.txtMaXB_Add);
        this.groupBox2.Controls.Add(this.btnThemDL);
        this.groupBox2.Location = new System.Drawing.Point(6, 6);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(740, 497);
        this.groupBox2.TabIndex = 0;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Nhập thông tin nhà xuất bản";

        // label8
        this.label8.AutoSize = true;
        this.label8.Location = new System.Drawing.Point(16, 30);
        this.label8.Name = "label8";
        this.label8.Size = new System.Drawing.Size(93, 15);
        this.label8.TabIndex = 0;
        this.label8.Text = "Mã nhà xuất bản:";

        // label7
        this.label7.AutoSize = true;
        this.label7.Location = new System.Drawing.Point(16, 70);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(98, 15);
        this.label7.TabIndex = 1;
        this.label7.Text = "Tên nhà xuất bản:";

        // label6
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(16, 110);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(50, 15);
        this.label6.TabIndex = 2;
        this.label6.Text = "Địa chỉ:";

        // label5
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(16, 150);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(0, 15);
        this.label5.TabIndex = 3;

        // txtMaXB_Add
        this.txtMaXB_Add.Location = new System.Drawing.Point(138, 27);
        this.txtMaXB_Add.Name = "txtMaXB_Add";
        this.txtMaXB_Add.Size = new System.Drawing.Size(596, 23);
        this.txtMaXB_Add.TabIndex = 4;

        // txtTenXB_Add
        this.txtTenXB_Add.Location = new System.Drawing.Point(138, 67);
        this.txtTenXB_Add.Name = "txtTenXB_Add";
        this.txtTenXB_Add.Size = new System.Drawing.Size(596, 23);
        this.txtTenXB_Add.TabIndex = 5;

        // txtDiaChi_Add
        this.txtDiaChi_Add.Location = new System.Drawing.Point(138, 107);
        this.txtDiaChi_Add.Multiline = true;
        this.txtDiaChi_Add.Name = "txtDiaChi_Add";
        this.txtDiaChi_Add.Size = new System.Drawing.Size(596, 120);
        this.txtDiaChi_Add.TabIndex = 6;

        // btnThemDL
        this.btnThemDL.Location = new System.Drawing.Point(138, 240);
        this.btnThemDL.Name = "btnThemDL";
        this.btnThemDL.Size = new System.Drawing.Size(150, 40);
        this.btnThemDL.TabIndex = 7;
        this.btnThemDL.Text = "Thêm dữ liệu";
        this.btnThemDL.UseVisualStyleBackColor = true;
        this.btnThemDL.Click += new System.EventHandler(this.btnThemDL_Click);

        // tabPage3 - Sửa dữ liệu
        this.tabPage3.Controls.Add(this.groupBox3);
        this.tabPage3.Location = new System.Drawing.Point(4, 24);
        this.tabPage3.Name = "tabPage3";
        this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage3.Size = new System.Drawing.Size(752, 509);
        this.tabPage3.TabIndex = 2;
        this.tabPage3.Text = "Sửa dữ liệu";
        this.tabPage3.UseVisualStyleBackColor = true;

        // groupBox3
        this.groupBox3.Controls.Add(this.label12);
        this.groupBox3.Controls.Add(this.label11);
        this.groupBox3.Controls.Add(this.txtTenXB_Edit);
        this.groupBox3.Controls.Add(this.label10);
        this.groupBox3.Controls.Add(this.txtDiaChi_Edit);
        this.groupBox3.Controls.Add(this.label9);
        this.groupBox3.Controls.Add(this.txtMaXB_Edit);
        this.groupBox3.Controls.Add(this.btnSuaDL);
        this.groupBox3.Location = new System.Drawing.Point(6, 6);
        this.groupBox3.Name = "groupBox3";
        this.groupBox3.Size = new System.Drawing.Size(740, 497);
        this.groupBox3.TabIndex = 0;
        this.groupBox3.TabStop = false;
        this.groupBox3.Text = "Sửa thông tin nhà xuất bản";

        // label12
        this.label12.AutoSize = true;
        this.label12.Location = new System.Drawing.Point(16, 30);
        this.label12.Name = "label12";
        this.label12.Size = new System.Drawing.Size(93, 15);
        this.label12.TabIndex = 0;
        this.label12.Text = "Mã nhà xuất bản:";

        // label11
        this.label11.AutoSize = true;
        this.label11.Location = new System.Drawing.Point(16, 70);
        this.label11.Name = "label11";
        this.label11.Size = new System.Drawing.Size(98, 15);
        this.label11.TabIndex = 1;
        this.label11.Text = "Tên nhà xuất bản:";

        // label10
        this.label10.AutoSize = true;
        this.label10.Location = new System.Drawing.Point(16, 110);
        this.label10.Name = "label10";
        this.label10.Size = new System.Drawing.Size(50, 15);
        this.label10.TabIndex = 2;
        this.label10.Text = "Địa chỉ:";

        // label9
        this.label9.AutoSize = true;
        this.label9.Location = new System.Drawing.Point(16, 150);
        this.label9.Name = "label9";
        this.label9.Size = new System.Drawing.Size(0, 15);
        this.label9.TabIndex = 3;

        // txtMaXB_Edit
        this.txtMaXB_Edit.Location = new System.Drawing.Point(138, 27);
        this.txtMaXB_Edit.Name = "txtMaXB_Edit";
        this.txtMaXB_Edit.Size = new System.Drawing.Size(596, 23);
        this.txtMaXB_Edit.TabIndex = 4;

        // txtTenXB_Edit
        this.txtTenXB_Edit.Location = new System.Drawing.Point(138, 67);
        this.txtTenXB_Edit.Name = "txtTenXB_Edit";
        this.txtTenXB_Edit.Size = new System.Drawing.Size(596, 23);
        this.txtTenXB_Edit.TabIndex = 5;

        // txtDiaChi_Edit
        this.txtDiaChi_Edit.Location = new System.Drawing.Point(138, 107);
        this.txtDiaChi_Edit.Multiline = true;
        this.txtDiaChi_Edit.Name = "txtDiaChi_Edit";
        this.txtDiaChi_Edit.Size = new System.Drawing.Size(596, 120);
        this.txtDiaChi_Edit.TabIndex = 6;

        // btnSuaDL
        this.btnSuaDL.Location = new System.Drawing.Point(138, 240);
        this.btnSuaDL.Name = "btnSuaDL";
        this.btnSuaDL.Size = new System.Drawing.Size(150, 40);
        this.btnSuaDL.TabIndex = 7;
        this.btnSuaDL.Text = "Sửa dữ liệu";
        this.btnSuaDL.UseVisualStyleBackColor = true;
        this.btnSuaDL.Click += new System.EventHandler(this.btnSuaDL_Click);

        // tabPage4 - Xóa dữ liệu
        this.tabPage4.Controls.Add(this.groupBox4);
        this.tabPage4.Location = new System.Drawing.Point(4, 24);
        this.tabPage4.Name = "tabPage4";
        this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage4.Size = new System.Drawing.Size(752, 509);
        this.tabPage4.TabIndex = 3;
        this.tabPage4.Text = "Xóa dữ liệu";
        this.tabPage4.UseVisualStyleBackColor = true;

        // groupBox4
        this.groupBox4.Controls.Add(this.label14);
        this.groupBox4.Controls.Add(this.label13);
        this.groupBox4.Controls.Add(this.txtMaXB_Del);
        this.groupBox4.Controls.Add(this.btnXoaDL);
        this.groupBox4.Location = new System.Drawing.Point(6, 6);
        this.groupBox4.Name = "groupBox4";
        this.groupBox4.Size = new System.Drawing.Size(740, 497);
        this.groupBox4.TabIndex = 0;
        this.groupBox4.TabStop = false;
        this.groupBox4.Text = "Xóa thông tin nhà xuất bản";

        // label14
        this.label14.AutoSize = true;
        this.label14.Location = new System.Drawing.Point(16, 30);
        this.label14.Name = "label14";
        this.label14.Size = new System.Drawing.Size(93, 15);
        this.label14.TabIndex = 0;
        this.label14.Text = "Mã nhà xuất bản:";

        // label13
        this.label13.AutoSize = true;
        this.label13.Location = new System.Drawing.Point(16, 70);
        this.label13.Name = "label13";
        this.label13.Size = new System.Drawing.Size(0, 15);
        this.label13.TabIndex = 1;

        // txtMaXB_Del
        this.txtMaXB_Del.Location = new System.Drawing.Point(138, 27);
        this.txtMaXB_Del.Name = "txtMaXB_Del";
        this.txtMaXB_Del.Size = new System.Drawing.Size(596, 23);
        this.txtMaXB_Del.TabIndex = 2;

        // btnXoaDL
        this.btnXoaDL.Location = new System.Drawing.Point(138, 70);
        this.btnXoaDL.Name = "btnXoaDL";
        this.btnXoaDL.Size = new System.Drawing.Size(150, 40);
        this.btnXoaDL.TabIndex = 3;
        this.btnXoaDL.Text = "Xóa dữ liệu";
        this.btnXoaDL.UseVisualStyleBackColor = true;
        this.btnXoaDL.Click += new System.EventHandler(this.btnXoaDL_Click);

        // Form1
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(784, 561);
        this.Controls.Add(this.tabControl1);
        this.Name = "Form1";
        this.Text = "Quản lý nhà xuất bản sách - Lab 6";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.tabControl1.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.TabPage tabPage4;
    private System.Windows.Forms.ListView lsvDanhSach;
    private System.Windows.Forms.ColumnHeader colMaXB;
    private System.Windows.Forms.ColumnHeader colTenXB;
    private System.Windows.Forms.ColumnHeader colDiaChi;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtMaXB_View;
    private System.Windows.Forms.TextBox txtTenXB_View;
    private System.Windows.Forms.TextBox txtDiaChi_View;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtMaXB_Add;
    private System.Windows.Forms.TextBox txtTenXB_Add;
    private System.Windows.Forms.TextBox txtDiaChi_Add;
    private System.Windows.Forms.Button btnThemDL;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TextBox txtMaXB_Edit;
    private System.Windows.Forms.TextBox txtTenXB_Edit;
    private System.Windows.Forms.TextBox txtDiaChi_Edit;
    private System.Windows.Forms.Button btnSuaDL;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.TextBox txtMaXB_Del;
    private System.Windows.Forms.Button btnXoaDL;
}
