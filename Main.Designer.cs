namespace EzCAD_Dev_Dome
{
    partial class Main_Form
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
            this.config_gBox = new System.Windows.Forms.GroupBox();
            this.redline_btn = new System.Windows.Forms.Button();
            this.mark_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.groupBox_客户 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.preview_btn = new System.Windows.Forms.Button();
            this.textBox_日期码 = new System.Windows.Forms.TextBox();
            this.textBox_日期码大小 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox_系列 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_电压值 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_电压 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_每单元距离 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_每单元颗数 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_光源总数 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_弯曲方向 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_产品型号 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_客户 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFilebtn = new System.Windows.Forms.Button();
            this.fileNametBox = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button_baocun = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.config_gBox.SuspendLayout();
            this.groupBox_客户.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // config_gBox
            // 
            this.config_gBox.Controls.Add(this.redline_btn);
            this.config_gBox.Controls.Add(this.mark_btn);
            this.config_gBox.Controls.Add(this.label2);
            this.config_gBox.Controls.Add(this.textBox);
            this.config_gBox.Controls.Add(this.cancel_btn);
            this.config_gBox.Location = new System.Drawing.Point(38, 512);
            this.config_gBox.Name = "config_gBox";
            this.config_gBox.Size = new System.Drawing.Size(946, 183);
            this.config_gBox.TabIndex = 220;
            this.config_gBox.TabStop = false;
            this.config_gBox.Text = "参数配置";
            // 
            // redline_btn
            // 
            this.redline_btn.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.redline_btn.Location = new System.Drawing.Point(506, 540);
            this.redline_btn.Name = "redline_btn";
            this.redline_btn.Size = new System.Drawing.Size(113, 35);
            this.redline_btn.TabIndex = 227;
            this.redline_btn.Tag = "0";
            this.redline_btn.Text = "红光对标";
            this.redline_btn.UseVisualStyleBackColor = true;
            this.redline_btn.Click += new System.EventHandler(this.redline_btn_Click);
            // 
            // mark_btn
            // 
            this.mark_btn.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mark_btn.Location = new System.Drawing.Point(506, 581);
            this.mark_btn.Name = "mark_btn";
            this.mark_btn.Size = new System.Drawing.Size(113, 35);
            this.mark_btn.TabIndex = 225;
            this.mark_btn.Tag = "0";
            this.mark_btn.Text = "启动雕刻";
            this.mark_btn.UseVisualStyleBackColor = true;
            this.mark_btn.Click += new System.EventHandler(this.mark_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 27);
            this.label2.TabIndex = 224;
            this.label2.Text = "要雕刻的数据:";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox.Location = new System.Drawing.Point(216, 569);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(255, 34);
            this.textBox.TabIndex = 223;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel_btn.Location = new System.Drawing.Point(506, 622);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(113, 35);
            this.cancel_btn.TabIndex = 222;
            this.cancel_btn.Tag = "0";
            this.cancel_btn.Text = "取消雕刻";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // groupBox_客户
            // 
            this.groupBox_客户.Controls.Add(this.groupBox6);
            this.groupBox_客户.Controls.Add(this.groupBox5);
            this.groupBox_客户.Controls.Add(this.groupBox4);
            this.groupBox_客户.Controls.Add(this.groupBox3);
            this.groupBox_客户.Controls.Add(this.groupBox2);
            this.groupBox_客户.Location = new System.Drawing.Point(4, 8);
            this.groupBox_客户.Name = "groupBox_客户";
            this.groupBox_客户.Size = new System.Drawing.Size(332, 286);
            this.groupBox_客户.TabIndex = 225;
            this.groupBox_客户.TabStop = false;
            this.groupBox_客户.Text = "配置参数";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.preview_btn);
            this.groupBox6.Controls.Add(this.textBox_日期码);
            this.groupBox6.Controls.Add(this.textBox_日期码大小);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Location = new System.Drawing.Point(7, 205);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(307, 78);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "日期码";
            // 
            // preview_btn
            // 
            this.preview_btn.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.preview_btn.Location = new System.Drawing.Point(232, 41);
            this.preview_btn.Name = "preview_btn";
            this.preview_btn.Size = new System.Drawing.Size(72, 34);
            this.preview_btn.TabIndex = 238;
            this.preview_btn.Tag = "0";
            this.preview_btn.Text = "生成";
            this.preview_btn.UseVisualStyleBackColor = true;
            this.preview_btn.Click += new System.EventHandler(this.preview_btn_Click_1);
            // 
            // textBox_日期码
            // 
            this.textBox_日期码.Location = new System.Drawing.Point(57, 12);
            this.textBox_日期码.Multiline = true;
            this.textBox_日期码.Name = "textBox_日期码";
            this.textBox_日期码.Size = new System.Drawing.Size(121, 59);
            this.textBox_日期码.TabIndex = 237;
            // 
            // textBox_日期码大小
            // 
            this.textBox_日期码大小.AllowDrop = true;
            this.textBox_日期码大小.Location = new System.Drawing.Point(225, 14);
            this.textBox_日期码大小.Name = "textBox_日期码大小";
            this.textBox_日期码大小.Size = new System.Drawing.Size(59, 21);
            this.textBox_日期码大小.TabIndex = 236;
            this.textBox_日期码大小.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(186, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 12);
            this.label13.TabIndex = 235;
            this.label13.Text = "大小:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 233;
            this.label12.Text = "日期码:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox_系列);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.comboBox_电压值);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.comboBox_电压);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(6, 152);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(313, 47);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "电压";
            // 
            // comboBox_系列
            // 
            this.comboBox_系列.FormattingEnabled = true;
            this.comboBox_系列.Location = new System.Drawing.Point(233, 18);
            this.comboBox_系列.Name = "comboBox_系列";
            this.comboBox_系列.Size = new System.Drawing.Size(75, 20);
            this.comboBox_系列.TabIndex = 237;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(201, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 236;
            this.label11.Text = "系列:";
            // 
            // comboBox_电压值
            // 
            this.comboBox_电压值.FormattingEnabled = true;
            this.comboBox_电压值.Location = new System.Drawing.Point(141, 17);
            this.comboBox_电压值.Name = "comboBox_电压值";
            this.comboBox_电压值.Size = new System.Drawing.Size(59, 20);
            this.comboBox_电压值.TabIndex = 235;
            this.comboBox_电压值.SelectedIndexChanged += new System.EventHandler(this.comboBox_电压值_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(95, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 234;
            this.label10.Text = "电压值:";
            // 
            // comboBox_电压
            // 
            this.comboBox_电压.FormattingEnabled = true;
            this.comboBox_电压.Items.AddRange(new object[] {
            "DC",
            "AC"});
            this.comboBox_电压.Location = new System.Drawing.Point(38, 16);
            this.comboBox_电压.Name = "comboBox_电压";
            this.comboBox_电压.Size = new System.Drawing.Size(52, 20);
            this.comboBox_电压.TabIndex = 233;
            this.comboBox_电压.SelectedIndexChanged += new System.EventHandler(this.comboBox_电压_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 232;
            this.label9.Text = "电压:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox_每单元距离);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBox_每单元颗数);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBox_光源总数);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(8, 104);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 47);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "剪切";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 233;
            this.label8.Text = "cm)";
            // 
            // textBox_每单元距离
            // 
            this.textBox_每单元距离.AllowDrop = true;
            this.textBox_每单元距离.Location = new System.Drawing.Point(245, 17);
            this.textBox_每单元距离.Name = "textBox_每单元距离";
            this.textBox_每单元距离.Size = new System.Drawing.Size(41, 21);
            this.textBox_每单元距离.TabIndex = 232;
            this.textBox_每单元距离.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 231;
            this.label7.Text = "灯/";
            // 
            // textBox_每单元颗数
            // 
            this.textBox_每单元颗数.AllowDrop = true;
            this.textBox_每单元颗数.Location = new System.Drawing.Point(189, 16);
            this.textBox_每单元颗数.Name = "textBox_每单元颗数";
            this.textBox_每单元颗数.Size = new System.Drawing.Size(29, 21);
            this.textBox_每单元颗数.TabIndex = 230;
            this.textBox_每单元颗数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 229;
            this.label6.Text = "单元信息;(";
            // 
            // textBox_光源总数
            // 
            this.textBox_光源总数.AllowDrop = true;
            this.textBox_光源总数.Location = new System.Drawing.Point(62, 17);
            this.textBox_光源总数.Name = "textBox_光源总数";
            this.textBox_光源总数.Size = new System.Drawing.Size(59, 21);
            this.textBox_光源总数.TabIndex = 228;
            this.textBox_光源总数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 227;
            this.label5.Text = "光源总数：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBox_弯曲方向);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboBox_产品型号);
            this.groupBox3.Location = new System.Drawing.Point(7, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 46);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "产品";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 228;
            this.label4.Text = "弯曲方向：";
            // 
            // comboBox_弯曲方向
            // 
            this.comboBox_弯曲方向.FormattingEnabled = true;
            this.comboBox_弯曲方向.Items.AddRange(new object[] {
            "正",
            "侧"});
            this.comboBox_弯曲方向.Location = new System.Drawing.Point(203, 16);
            this.comboBox_弯曲方向.Name = "comboBox_弯曲方向";
            this.comboBox_弯曲方向.Size = new System.Drawing.Size(64, 20);
            this.comboBox_弯曲方向.TabIndex = 227;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 226;
            this.label3.Text = "产品型号：";
            // 
            // comboBox_产品型号
            // 
            this.comboBox_产品型号.FormattingEnabled = true;
            this.comboBox_产品型号.Items.AddRange(new object[] {
            "F10",
            "F11",
            "F15",
            "F16",
            "F17",
            "F21",
            "F22",
            "F23"});
            this.comboBox_产品型号.Location = new System.Drawing.Point(78, 16);
            this.comboBox_产品型号.Name = "comboBox_产品型号";
            this.comboBox_产品型号.Size = new System.Drawing.Size(52, 20);
            this.comboBox_产品型号.TabIndex = 225;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_客户);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.openFilebtn);
            this.groupBox2.Controls.Add(this.fileNametBox);
            this.groupBox2.Location = new System.Drawing.Point(7, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 42);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "模板";
            // 
            // comboBox_客户
            // 
            this.comboBox_客户.FormattingEnabled = true;
            this.comboBox_客户.Items.AddRange(new object[] {
            "12056",
            "12058",
            "12090",
            "12115",
            "12120",
            "12130",
            "12141",
            "12251",
            "13013",
            "12582",
            "17021",
            "12585",
            "6666 CE ",
            "17100 "});
            this.comboBox_客户.Location = new System.Drawing.Point(215, 16);
            this.comboBox_客户.Name = "comboBox_客户";
            this.comboBox_客户.Size = new System.Drawing.Size(84, 20);
            this.comboBox_客户.TabIndex = 229;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(182, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 12);
            this.label15.TabIndex = 228;
            this.label15.Text = "客户:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "模板文件：";
            // 
            // openFilebtn
            // 
            this.openFilebtn.Font = new System.Drawing.Font("黑体", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openFilebtn.Location = new System.Drawing.Point(157, 15);
            this.openFilebtn.Name = "openFilebtn";
            this.openFilebtn.Size = new System.Drawing.Size(21, 21);
            this.openFilebtn.TabIndex = 34;
            this.openFilebtn.Text = "...";
            this.openFilebtn.UseVisualStyleBackColor = true;
            this.openFilebtn.Click += new System.EventHandler(this.openFilebtn_Click_1);
            // 
            // fileNametBox
            // 
            this.fileNametBox.Location = new System.Drawing.Point(72, 15);
            this.fileNametBox.Name = "fileNametBox";
            this.fileNametBox.Size = new System.Drawing.Size(84, 21);
            this.fileNametBox.TabIndex = 33;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.button_baocun);
            this.groupBox7.Controls.Add(this.pictureBox);
            this.groupBox7.Location = new System.Drawing.Point(342, 8);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(421, 286);
            this.groupBox7.TabIndex = 226;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "结果输出";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 21);
            this.textBox1.TabIndex = 232;
            this.textBox1.Text = "test123";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 231;
            this.label14.Text = "保存文件名：";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // button_baocun
            // 
            this.button_baocun.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_baocun.Location = new System.Drawing.Point(346, 15);
            this.button_baocun.Name = "button_baocun";
            this.button_baocun.Size = new System.Drawing.Size(66, 35);
            this.button_baocun.TabIndex = 229;
            this.button_baocun.Tag = "0";
            this.button_baocun.Text = "保存";
            this.button_baocun.UseVisualStyleBackColor = true;
            this.button_baocun.Click += new System.EventHandler(this.button_baocun_Click_1);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox.Location = new System.Drawing.Point(5, 13);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(410, 270);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 34;
            this.pictureBox.TabStop = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 295);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox_客户);
            this.Controls.Add(this.config_gBox);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "C#";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScinanLaserForm_FormClosed);
            this.Load += new System.EventHandler(this.Form_Load);
            this.config_gBox.ResumeLayout(false);
            this.config_gBox.PerformLayout();
            this.groupBox_客户.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox config_gBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button redline_btn;
        private System.Windows.Forms.Button mark_btn;
        private System.Windows.Forms.GroupBox groupBox_客户;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_弯曲方向;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_产品型号;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openFilebtn;
        private System.Windows.Forms.TextBox fileNametBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_光源总数;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button preview_btn;
        private System.Windows.Forms.TextBox textBox_日期码;
        private System.Windows.Forms.TextBox textBox_日期码大小;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox_系列;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_电压值;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_电压;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_每单元距离;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_每单元颗数;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button_baocun;
        public System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox comboBox_客户;
        private System.Windows.Forms.Label label15;
    }
}