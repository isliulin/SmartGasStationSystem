﻿namespace DIT_Server
{
    partial class FormServer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSendAuto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textLicense = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboNozzleStatus = new System.Windows.Forms.ComboBox();
            this.comboNozzle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timerSend = new System.Windows.Forms.Timer(this.components);
            this.textInterval = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboCarColor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboCarBrand = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboPlateColor = new System.Windows.Forms.ComboBox();
            this.comboMode = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboInOut = new System.Windows.Forms.ComboBox();
            this.btnSendSingle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSendAuto
            // 
            this.btnSendAuto.Location = new System.Drawing.Point(204, 183);
            this.btnSendAuto.Name = "btnSendAuto";
            this.btnSendAuto.Size = new System.Drawing.Size(75, 23);
            this.btnSendAuto.TabIndex = 0;
            this.btnSendAuto.Text = "循环发送";
            this.btnSendAuto.UseVisualStyleBackColor = true;
            this.btnSendAuto.Click += new System.EventHandler(this.btnSendAuto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "当前车牌：";
            // 
            // textLicense
            // 
            this.textLicense.Location = new System.Drawing.Point(98, 47);
            this.textLicense.Name = "textLicense";
            this.textLicense.Size = new System.Drawing.Size(100, 21);
            this.textLicense.TabIndex = 2;
            this.textLicense.Text = "京A12345";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "油枪号：";
            // 
            // comboNozzleStatus
            // 
            this.comboNozzleStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "不生效",
            "提枪",
            "加油",
            "挂枪"});
            this.comboNozzleStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNozzleStatus.FormattingEnabled = true;
            this.comboNozzleStatus.Items.AddRange(new object[] {
            "无效",
            "提枪",
            "加油",
            "挂枪"});
            this.comboNozzleStatus.Location = new System.Drawing.Point(279, 79);
            this.comboNozzleStatus.Name = "comboNozzleStatus";
            this.comboNozzleStatus.Size = new System.Drawing.Size(92, 20);
            this.comboNozzleStatus.TabIndex = 4;
            // 
            // comboNozzle
            // 
            this.comboNozzle.AutoCompleteCustomSource.AddRange(new string[] {
            "不生效",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboNozzle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNozzle.FormattingEnabled = true;
            this.comboNozzle.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboNozzle.Location = new System.Drawing.Point(98, 77);
            this.comboNozzle.Name = "comboNozzle";
            this.comboNozzle.Size = new System.Drawing.Size(92, 20);
            this.comboNozzle.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "油枪状态：";
            // 
            // timerSend
            // 
            this.timerSend.Interval = 1000;
            this.timerSend.Tick += new System.EventHandler(this.timerSend_Tick);
            // 
            // textInterval
            // 
            this.textInterval.Location = new System.Drawing.Point(100, 185);
            this.textInterval.Name = "textInterval";
            this.textInterval.Size = new System.Drawing.Size(57, 21);
            this.textInterval.TabIndex = 13;
            this.textInterval.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "发送间隔：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "秒";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "车辆颜色：";
            // 
            // comboCarColor
            // 
            this.comboCarColor.AutoCompleteCustomSource.AddRange(new string[] {
            "白色",
            "银色",
            "黄色",
            "粉色",
            "红色",
            "绿色",
            "蓝色",
            "棕色",
            "黑色"});
            this.comboCarColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCarColor.FormattingEnabled = true;
            this.comboCarColor.Items.AddRange(new object[] {
            "白色",
            "银色",
            "黄色",
            "粉色",
            "红色",
            "绿色",
            "蓝色",
            "棕色",
            "黑色"});
            this.comboCarColor.Location = new System.Drawing.Point(98, 109);
            this.comboCarColor.Name = "comboCarColor";
            this.comboCarColor.Size = new System.Drawing.Size(92, 20);
            this.comboCarColor.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "车辆品牌：";
            // 
            // comboCarBrand
            // 
            this.comboCarBrand.AutoCompleteCustomSource.AddRange(new string[] {
            "不生效",
            "提枪",
            "加油",
            "挂枪"});
            this.comboCarBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCarBrand.FormattingEnabled = true;
            this.comboCarBrand.Items.AddRange(new object[] {
            "未知",
            "奥迪",
            "宝马",
            "奔驰",
            "本田",
            "标致",
            "别克",
            "大众",
            "丰田",
            "福特"});
            this.comboCarBrand.Location = new System.Drawing.Point(279, 108);
            this.comboCarBrand.Name = "comboCarBrand";
            this.comboCarBrand.Size = new System.Drawing.Size(92, 20);
            this.comboCarBrand.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "车牌颜色：";
            // 
            // comboPlateColor
            // 
            this.comboPlateColor.AutoCompleteCustomSource.AddRange(new string[] {
            "未知",
            "蓝色",
            "黄色",
            "白色",
            "黑色",
            "绿色"});
            this.comboPlateColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlateColor.FormattingEnabled = true;
            this.comboPlateColor.Items.AddRange(new object[] {
            "未知",
            "蓝色",
            "黄色",
            "白色",
            "黑色",
            "绿色"});
            this.comboPlateColor.Location = new System.Drawing.Point(279, 49);
            this.comboPlateColor.Name = "comboPlateColor";
            this.comboPlateColor.Size = new System.Drawing.Size(92, 20);
            this.comboPlateColor.TabIndex = 20;
            // 
            // comboMode
            // 
            this.comboMode.AutoCompleteCustomSource.AddRange(new string[] {
            "不生效",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMode.FormattingEnabled = true;
            this.comboMode.Items.AddRange(new object[] {
            "随机",
            "固定"});
            this.comboMode.Location = new System.Drawing.Point(99, 12);
            this.comboMode.Name = "comboMode";
            this.comboMode.Size = new System.Drawing.Size(92, 20);
            this.comboMode.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "车辆模式：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 25;
            this.label11.Text = "进出站状态：";
            // 
            // comboInOut
            // 
            this.comboInOut.AutoCompleteCustomSource.AddRange(new string[] {
            "白色",
            "银色",
            "黄色",
            "粉色",
            "红色",
            "绿色",
            "蓝色",
            "棕色",
            "黑色"});
            this.comboInOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInOut.FormattingEnabled = true;
            this.comboInOut.Items.AddRange(new object[] {
            "进站",
            "出站"});
            this.comboInOut.Location = new System.Drawing.Point(98, 139);
            this.comboInOut.Name = "comboInOut";
            this.comboInOut.Size = new System.Drawing.Size(92, 20);
            this.comboInOut.TabIndex = 24;
            // 
            // btnSendSingle
            // 
            this.btnSendSingle.Location = new System.Drawing.Point(285, 183);
            this.btnSendSingle.Name = "btnSendSingle";
            this.btnSendSingle.Size = new System.Drawing.Size(75, 23);
            this.btnSendSingle.TabIndex = 26;
            this.btnSendSingle.Text = "发送单车";
            this.btnSendSingle.UseVisualStyleBackColor = true;
            this.btnSendSingle.Click += new System.EventHandler(this.btnSendSingle_Click);
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 251);
            this.Controls.Add(this.btnSendSingle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboInOut);
            this.Controls.Add(this.comboMode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboPlateColor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboCarBrand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboCarColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textInterval);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboNozzle);
            this.Controls.Add(this.comboNozzleStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textLicense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendAuto);
            this.Name = "FormServer";
            this.Text = "DIT测试服务端";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLicense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboNozzleStatus;
        private System.Windows.Forms.ComboBox comboNozzle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerSend;
        private System.Windows.Forms.TextBox textInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboCarColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboCarBrand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboPlateColor;
        private System.Windows.Forms.ComboBox comboMode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboInOut;
        private System.Windows.Forms.Button btnSendSingle;
    }
}

