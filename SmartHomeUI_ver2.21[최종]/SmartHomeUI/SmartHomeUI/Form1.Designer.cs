namespace SmartHomeUI
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connection_status = new System.Windows.Forms.Label();
            this.disconnect = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.COM_port = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btn_CreateWater = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.DB_Clear = new System.Windows.Forms.Button();
            this.DB_Water = new System.Windows.Forms.Button();
            this.DataBase_Water = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LED_Bar = new System.Windows.Forms.TrackBar();
            this.btn_Auto = new System.Windows.Forms.RadioButton();
            this.btn_Menual = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Disconnect_AVR = new System.Windows.Forms.Button();
            this.Connect_AVR = new System.Windows.Forms.Button();
            this.COM_port2 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Disconnect_ARM = new System.Windows.Forms.Button();
            this.Connect_ARM = new System.Windows.Forms.Button();
            this.COM_port3 = new System.Windows.Forms.ComboBox();
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pb_Emo = new System.Windows.Forms.PictureBox();
            this.lbl_AirCon = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_Hix = new System.Windows.Forms.Label();
            this.lbl_Hum = new System.Windows.Forms.Label();
            this.lbl_Temp = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbl_CDS_Con = new System.Windows.Forms.Label();
            this.lbl_CDS = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.chart_GasFlame = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lbl_Dis = new System.Windows.Forms.Label();
            this.U9_button = new System.Windows.Forms.Button();
            this.Ultra_Distance = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_gas = new System.Windows.Forms.Label();
            this.lbl_gasCon = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lbl_WaterStatus = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.lbl_Water = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.lbl_Flame = new System.Windows.Forms.Label();
            this.lbl_FlameCon = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_Bar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Emo)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_GasFlame)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connection_status);
            this.groupBox1.Controls.Add(this.disconnect);
            this.groupBox1.Controls.Add(this.connect);
            this.groupBox1.Controls.Add(this.COM_port);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(38, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM 포트 아두이노";
            // 
            // connection_status
            // 
            this.connection_status.AutoSize = true;
            this.connection_status.ForeColor = System.Drawing.Color.Red;
            this.connection_status.Location = new System.Drawing.Point(19, 147);
            this.connection_status.Name = "connection_status";
            this.connection_status.Size = new System.Drawing.Size(83, 15);
            this.connection_status.TabIndex = 3;
            this.connection_status.Text = "연결되지 않음";
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(112, 92);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(84, 32);
            this.disconnect.TabIndex = 2;
            this.disconnect.Text = "끊기";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(6, 92);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(84, 32);
            this.connect.TabIndex = 1;
            this.connect.Text = "연결";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // COM_port
            // 
            this.COM_port.FormattingEnabled = true;
            this.COM_port.Location = new System.Drawing.Point(6, 27);
            this.COM_port.Name = "COM_port";
            this.COM_port.Size = new System.Drawing.Size(121, 23);
            this.COM_port.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btn_CreateWater);
            this.groupBox11.Controls.Add(this.label28);
            this.groupBox11.Controls.Add(this.label29);
            this.groupBox11.Controls.Add(this.textBox2);
            this.groupBox11.Controls.Add(this.label30);
            this.groupBox11.Controls.Add(this.label31);
            this.groupBox11.Controls.Add(this.label32);
            this.groupBox11.Controls.Add(this.btn_delete);
            this.groupBox11.Controls.Add(this.textBox1);
            this.groupBox11.Controls.Add(this.label33);
            this.groupBox11.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox11.Location = new System.Drawing.Point(779, 471);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(455, 205);
            this.groupBox11.TabIndex = 33;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "수위 데이터 삭제";
            // 
            // btn_CreateWater
            // 
            this.btn_CreateWater.Location = new System.Drawing.Point(345, 101);
            this.btn_CreateWater.Name = "btn_CreateWater";
            this.btn_CreateWater.Size = new System.Drawing.Size(88, 23);
            this.btn_CreateWater.TabIndex = 9;
            this.btn_CreateWater.Text = "생성버튼";
            this.btn_CreateWater.UseVisualStyleBackColor = true;
            this.btn_CreateWater.Click += new System.EventHandler(this.btn_CreateWater_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(81, 137);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(12, 15);
            this.label28.TabIndex = 8;
            this.label28.Text = "-";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(21, 140);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(34, 15);
            this.label29.TabIndex = 7;
            this.label29.Text = "경로:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 23);
            this.textBox2.TabIndex = 6;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(10, 104);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(148, 15);
            this.label30.TabIndex = 5;
            this.label30.Text = "log파일 생성 디렉토리 명:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(83, 176);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(12, 15);
            this.label31.TabIndex = 4;
            this.label31.Text = "-";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(21, 176);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(56, 15);
            this.label32.TabIndex = 3;
            this.label32.Text = "log 파일:";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(345, 37);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(88, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "데이터 삭제";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(14, 37);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(119, 15);
            this.label33.TabIndex = 0;
            this.label33.Text = "데이터 삭제 조건: ID";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.DB_Clear);
            this.groupBox7.Controls.Add(this.DB_Water);
            this.groupBox7.Controls.Add(this.DataBase_Water);
            this.groupBox7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox7.Location = new System.Drawing.Point(779, 261);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(455, 206);
            this.groupBox7.TabIndex = 34;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "수위 데이터 수집";
            // 
            // DB_Clear
            // 
            this.DB_Clear.Location = new System.Drawing.Point(245, 173);
            this.DB_Clear.Name = "DB_Clear";
            this.DB_Clear.Size = new System.Drawing.Size(100, 23);
            this.DB_Clear.TabIndex = 30;
            this.DB_Clear.Text = "화면 지우기";
            this.DB_Clear.UseVisualStyleBackColor = true;
            this.DB_Clear.Click += new System.EventHandler(this.DB_Clear_Click);
            // 
            // DB_Water
            // 
            this.DB_Water.Location = new System.Drawing.Point(109, 173);
            this.DB_Water.Name = "DB_Water";
            this.DB_Water.Size = new System.Drawing.Size(100, 23);
            this.DB_Water.TabIndex = 29;
            this.DB_Water.Text = "DB 불러오기";
            this.DB_Water.UseVisualStyleBackColor = true;
            this.DB_Water.Click += new System.EventHandler(this.DB_Water_Click);
            // 
            // DataBase_Water
            // 
            this.DataBase_Water.ItemHeight = 15;
            this.DataBase_Water.Location = new System.Drawing.Point(0, 26);
            this.DataBase_Water.Name = "DataBase_Water";
            this.DataBase_Water.Size = new System.Drawing.Size(455, 139);
            this.DataBase_Water.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.LED_Bar);
            this.groupBox2.Controls.Add(this.btn_Auto);
            this.groupBox2.Controls.Add(this.btn_Menual);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(779, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 112);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED Bar - PWM제어";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::SmartHomeUI.Properties.Resources.LightOFF;
            this.pictureBox1.Location = new System.Drawing.Point(32, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(419, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "최대";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(93, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "최소";
            // 
            // LED_Bar
            // 
            this.LED_Bar.AutoSize = false;
            this.LED_Bar.LargeChange = 9;
            this.LED_Bar.Location = new System.Drawing.Point(96, 49);
            this.LED_Bar.Maximum = 9;
            this.LED_Bar.Name = "LED_Bar";
            this.LED_Bar.Size = new System.Drawing.Size(356, 45);
            this.LED_Bar.TabIndex = 0;
            this.LED_Bar.Scroll += new System.EventHandler(this.LED_Bar_Scroll);
            // 
            // btn_Auto
            // 
            this.btn_Auto.AutoSize = true;
            this.btn_Auto.Location = new System.Drawing.Point(255, 24);
            this.btn_Auto.Name = "btn_Auto";
            this.btn_Auto.Size = new System.Drawing.Size(73, 19);
            this.btn_Auto.TabIndex = 2;
            this.btn_Auto.TabStop = true;
            this.btn_Auto.Text = "자동모드";
            this.btn_Auto.UseVisualStyleBackColor = true;
            this.btn_Auto.CheckedChanged += new System.EventHandler(this.btn_Auto_CheckedChanged);
            // 
            // btn_Menual
            // 
            this.btn_Menual.AutoSize = true;
            this.btn_Menual.Location = new System.Drawing.Point(171, 24);
            this.btn_Menual.Name = "btn_Menual";
            this.btn_Menual.Size = new System.Drawing.Size(73, 19);
            this.btn_Menual.TabIndex = 1;
            this.btn_Menual.TabStop = true;
            this.btn_Menual.Text = "수동모드";
            this.btn_Menual.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "밝기조절";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.Disconnect_AVR);
            this.groupBox3.Controls.Add(this.Connect_AVR);
            this.groupBox3.Controls.Add(this.COM_port2);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(38, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 168);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "COM 포트 AVR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(19, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "연결되지 않음";
            // 
            // Disconnect_AVR
            // 
            this.Disconnect_AVR.Location = new System.Drawing.Point(112, 92);
            this.Disconnect_AVR.Name = "Disconnect_AVR";
            this.Disconnect_AVR.Size = new System.Drawing.Size(84, 32);
            this.Disconnect_AVR.TabIndex = 2;
            this.Disconnect_AVR.Text = "끊기";
            this.Disconnect_AVR.UseVisualStyleBackColor = true;
            this.Disconnect_AVR.Click += new System.EventHandler(this.Disconnect_AVR_Click);
            // 
            // Connect_AVR
            // 
            this.Connect_AVR.Location = new System.Drawing.Point(6, 92);
            this.Connect_AVR.Name = "Connect_AVR";
            this.Connect_AVR.Size = new System.Drawing.Size(84, 32);
            this.Connect_AVR.TabIndex = 1;
            this.Connect_AVR.Text = "연결";
            this.Connect_AVR.UseVisualStyleBackColor = true;
            this.Connect_AVR.Click += new System.EventHandler(this.Connect_AVR_Click);
            // 
            // COM_port2
            // 
            this.COM_port2.FormattingEnabled = true;
            this.COM_port2.Location = new System.Drawing.Point(6, 27);
            this.COM_port2.Name = "COM_port2";
            this.COM_port2.Size = new System.Drawing.Size(121, 23);
            this.COM_port2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.Disconnect_ARM);
            this.groupBox4.Controls.Add(this.Connect_ARM);
            this.groupBox4.Controls.Add(this.COM_port3);
            this.groupBox4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(38, 484);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 168);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "COM 포트 ARM-Cortex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(19, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "연결되지 않음";
            // 
            // Disconnect_ARM
            // 
            this.Disconnect_ARM.Location = new System.Drawing.Point(112, 92);
            this.Disconnect_ARM.Name = "Disconnect_ARM";
            this.Disconnect_ARM.Size = new System.Drawing.Size(84, 32);
            this.Disconnect_ARM.TabIndex = 2;
            this.Disconnect_ARM.Text = "끊기";
            this.Disconnect_ARM.UseVisualStyleBackColor = true;
            this.Disconnect_ARM.Click += new System.EventHandler(this.Disconnect_ARM_Click);
            // 
            // Connect_ARM
            // 
            this.Connect_ARM.Location = new System.Drawing.Point(6, 92);
            this.Connect_ARM.Name = "Connect_ARM";
            this.Connect_ARM.Size = new System.Drawing.Size(84, 32);
            this.Connect_ARM.TabIndex = 1;
            this.Connect_ARM.Text = "연결";
            this.Connect_ARM.UseVisualStyleBackColor = true;
            this.Connect_ARM.Click += new System.EventHandler(this.Connect_ARM_Click);
            // 
            // COM_port3
            // 
            this.COM_port3.FormattingEnabled = true;
            this.COM_port3.Location = new System.Drawing.Point(6, 27);
            this.COM_port3.Name = "COM_port3";
            this.COM_port3.Size = new System.Drawing.Size(121, 23);
            this.COM_port3.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pb_Emo);
            this.groupBox5.Controls.Add(this.lbl_AirCon);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.lbl_Hix);
            this.groupBox5.Controls.Add(this.lbl_Hum);
            this.groupBox5.Controls.Add(this.lbl_Temp);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.Location = new System.Drawing.Point(291, 362);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(439, 101);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "온습도 모니터링";
            // 
            // pb_Emo
            // 
            this.pb_Emo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Emo.Image = global::SmartHomeUI.Properties.Resources.Good;
            this.pb_Emo.Location = new System.Drawing.Point(372, 30);
            this.pb_Emo.Name = "pb_Emo";
            this.pb_Emo.Size = new System.Drawing.Size(57, 56);
            this.pb_Emo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Emo.TabIndex = 42;
            this.pb_Emo.TabStop = false;
            // 
            // lbl_AirCon
            // 
            this.lbl_AirCon.AutoSize = true;
            this.lbl_AirCon.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_AirCon.Location = new System.Drawing.Point(283, 67);
            this.lbl_AirCon.Name = "lbl_AirCon";
            this.lbl_AirCon.Size = new System.Drawing.Size(38, 21);
            this.lbl_AirCon.TabIndex = 41;
            this.lbl_AirCon.Text = "OFF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(184, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 21);
            this.label9.TabIndex = 40;
            this.label9.Text = "에어컨:";
            // 
            // lbl_Hix
            // 
            this.lbl_Hix.AutoSize = true;
            this.lbl_Hix.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Hix.Location = new System.Drawing.Point(283, 36);
            this.lbl_Hix.Name = "lbl_Hix";
            this.lbl_Hix.Size = new System.Drawing.Size(17, 21);
            this.lbl_Hix.TabIndex = 39;
            this.lbl_Hix.Text = "-";
            // 
            // lbl_Hum
            // 
            this.lbl_Hum.AutoSize = true;
            this.lbl_Hum.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Hum.Location = new System.Drawing.Point(104, 67);
            this.lbl_Hum.Name = "lbl_Hum";
            this.lbl_Hum.Size = new System.Drawing.Size(17, 21);
            this.lbl_Hum.TabIndex = 39;
            this.lbl_Hum.Text = "-";
            // 
            // lbl_Temp
            // 
            this.lbl_Temp.AutoSize = true;
            this.lbl_Temp.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Temp.Location = new System.Drawing.Point(104, 37);
            this.lbl_Temp.Name = "lbl_Temp";
            this.lbl_Temp.Size = new System.Drawing.Size(17, 21);
            this.lbl_Temp.TabIndex = 25;
            this.lbl_Temp.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(330, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 21);
            this.label13.TabIndex = 24;
            this.label13.Text = "°C";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(155, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 21);
            this.label12.TabIndex = 23;
            this.label12.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(152, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "°C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(184, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "체감온도:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(6, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "습도 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(6, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "온도 :";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbl_CDS_Con);
            this.groupBox6.Controls.Add(this.lbl_CDS);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox6.Location = new System.Drawing.Point(530, 469);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 81);
            this.groupBox6.TabIndex = 39;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "외부조도 모니터링";
            // 
            // lbl_CDS_Con
            // 
            this.lbl_CDS_Con.AutoSize = true;
            this.lbl_CDS_Con.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_CDS_Con.Location = new System.Drawing.Point(90, 47);
            this.lbl_CDS_Con.Name = "lbl_CDS_Con";
            this.lbl_CDS_Con.Size = new System.Drawing.Size(17, 21);
            this.lbl_CDS_Con.TabIndex = 43;
            this.lbl_CDS_Con.Text = "-";
            // 
            // lbl_CDS
            // 
            this.lbl_CDS.AutoSize = true;
            this.lbl_CDS.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_CDS.Location = new System.Drawing.Point(90, 19);
            this.lbl_CDS.Name = "lbl_CDS";
            this.lbl_CDS.Size = new System.Drawing.Size(17, 21);
            this.lbl_CDS.TabIndex = 44;
            this.lbl_CDS.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(11, 47);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 21);
            this.label21.TabIndex = 42;
            this.label21.Text = "상태 :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(11, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 21);
            this.label22.TabIndex = 41;
            this.label22.Text = "조도 :";
            // 
            // chart_GasFlame
            // 
            this.chart_GasFlame.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart_GasFlame.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_GasFlame.Legends.Add(legend1);
            this.chart_GasFlame.Location = new System.Drawing.Point(289, 130);
            this.chart_GasFlame.Name = "chart_GasFlame";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Gas";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Flame";
            this.chart_GasFlame.Series.Add(series1);
            this.chart_GasFlame.Series.Add(series2);
            this.chart_GasFlame.Size = new System.Drawing.Size(441, 211);
            this.chart_GasFlame.TabIndex = 40;
            this.chart_GasFlame.Text = "Gas Chart";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lbl_Dis);
            this.groupBox9.Controls.Add(this.U9_button);
            this.groupBox9.Controls.Add(this.Ultra_Distance);
            this.groupBox9.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox9.Location = new System.Drawing.Point(291, 651);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(275, 67);
            this.groupBox9.TabIndex = 41;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "초음파 센서 모니터링";
            // 
            // lbl_Dis
            // 
            this.lbl_Dis.AutoSize = true;
            this.lbl_Dis.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Dis.Location = new System.Drawing.Point(103, 34);
            this.lbl_Dis.Name = "lbl_Dis";
            this.lbl_Dis.Size = new System.Drawing.Size(12, 15);
            this.lbl_Dis.TabIndex = 26;
            this.lbl_Dis.Text = "-";
            // 
            // U9_button
            // 
            this.U9_button.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.U9_button.Location = new System.Drawing.Point(166, 29);
            this.U9_button.Name = "U9_button";
            this.U9_button.Size = new System.Drawing.Size(100, 23);
            this.U9_button.TabIndex = 25;
            this.U9_button.Text = "거리 측정 버튼";
            this.U9_button.UseVisualStyleBackColor = true;
            this.U9_button.Click += new System.EventHandler(this.U9_button_Click);
            // 
            // Ultra_Distance
            // 
            this.Ultra_Distance.AutoSize = true;
            this.Ultra_Distance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Ultra_Distance.Location = new System.Drawing.Point(16, 29);
            this.Ultra_Distance.Name = "Ultra_Distance";
            this.Ultra_Distance.Size = new System.Drawing.Size(82, 21);
            this.Ultra_Distance.TabIndex = 0;
            this.Ultra_Distance.Text = "Distance :";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label10);
            this.groupBox12.Controls.Add(this.lbl_gas);
            this.groupBox12.Controls.Add(this.lbl_gasCon);
            this.groupBox12.Controls.Add(this.label23);
            this.groupBox12.Controls.Add(this.label24);
            this.groupBox12.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox12.Location = new System.Drawing.Point(289, 563);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(200, 74);
            this.groupBox12.TabIndex = 42;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "가스 센서 모니터링";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(93, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "PPM";
            // 
            // lbl_gas
            // 
            this.lbl_gas.AutoSize = true;
            this.lbl_gas.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_gas.Location = new System.Drawing.Point(63, 20);
            this.lbl_gas.Name = "lbl_gas";
            this.lbl_gas.Size = new System.Drawing.Size(15, 20);
            this.lbl_gas.TabIndex = 23;
            this.lbl_gas.Text = "-";
            // 
            // lbl_gasCon
            // 
            this.lbl_gasCon.AutoSize = true;
            this.lbl_gasCon.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_gasCon.Location = new System.Drawing.Point(63, 46);
            this.lbl_gasCon.Name = "lbl_gasCon";
            this.lbl_gasCon.Size = new System.Drawing.Size(15, 20);
            this.lbl_gasCon.TabIndex = 22;
            this.lbl_gasCon.Text = "-";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(6, 46);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(47, 20);
            this.label23.TabIndex = 2;
            this.label23.Text = "상태 :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.Location = new System.Drawing.Point(6, 20);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 20);
            this.label24.TabIndex = 1;
            this.label24.Text = "GAS :";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lbl_WaterStatus);
            this.groupBox8.Controls.Add(this.label99);
            this.groupBox8.Controls.Add(this.lbl_Water);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox8.Location = new System.Drawing.Point(291, 478);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(233, 72);
            this.groupBox8.TabIndex = 43;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "수위 센서";
            // 
            // lbl_WaterStatus
            // 
            this.lbl_WaterStatus.AutoSize = true;
            this.lbl_WaterStatus.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WaterStatus.Location = new System.Drawing.Point(70, 48);
            this.lbl_WaterStatus.Name = "lbl_WaterStatus";
            this.lbl_WaterStatus.Size = new System.Drawing.Size(15, 20);
            this.lbl_WaterStatus.TabIndex = 28;
            this.lbl_WaterStatus.Text = "-";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(11, 48);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(47, 20);
            this.label99.TabIndex = 27;
            this.label99.Text = "상태 :";
            // 
            // lbl_Water
            // 
            this.lbl_Water.AutoSize = true;
            this.lbl_Water.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Water.Location = new System.Drawing.Point(136, 22);
            this.lbl_Water.Name = "lbl_Water";
            this.lbl_Water.Size = new System.Drawing.Size(15, 20);
            this.lbl_Water.TabIndex = 26;
            this.lbl_Water.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(184, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "ELM";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Water Level :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(304, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(655, 36);
            this.label17.TabIndex = 44;
            this.label17.Text = "IoT 스마트 홈 / 임베디드SW 통합제어 프로그램";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("한컴 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(91, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 22);
            this.label18.TabIndex = 45;
            this.label18.Text = "통신 기능";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("한컴 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(391, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(242, 22);
            this.label19.TabIndex = 46;
            this.label19.Text = "센서 모니터링(Data 수집/ADC)";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("한컴 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.ForeColor = System.Drawing.Color.Blue;
            this.label25.Location = new System.Drawing.Point(775, 236);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(327, 22);
            this.label25.TabIndex = 48;
            this.label25.Text = "수집된 Data 데이터베이스(DB)연결 및 관리";
            // 
            // lbl_Time
            // 
            this.lbl_Time.BackColor = System.Drawing.Color.White;
            this.lbl_Time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Time.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Time.Location = new System.Drawing.Point(74, 28);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(168, 21);
            this.lbl_Time.TabIndex = 53;
            this.lbl_Time.Text = "-";
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(289, 115);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 15);
            this.label20.TabIndex = 54;
            this.label20.Text = "가스 센서 모니터링";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("한컴 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label26.ForeColor = System.Drawing.Color.Blue;
            this.label26.Location = new System.Drawing.Point(777, 71);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(110, 22);
            this.label26.TabIndex = 55;
            this.label26.Text = "디바이스 제어";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label27.Location = new System.Drawing.Point(12, 30);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(63, 17);
            this.label27.TabIndex = 56;
            this.label27.Text = "현재시간:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label34);
            this.groupBox10.Controls.Add(this.lbl_Flame);
            this.groupBox10.Controls.Add(this.lbl_FlameCon);
            this.groupBox10.Controls.Add(this.label37);
            this.groupBox10.Controls.Add(this.label38);
            this.groupBox10.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox10.Location = new System.Drawing.Point(530, 563);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 74);
            this.groupBox10.TabIndex = 57;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "플레임 센서 모니터링";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label34.Location = new System.Drawing.Point(123, 20);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(34, 20);
            this.label34.TabIndex = 24;
            this.label34.Text = "NM";
            // 
            // lbl_Flame
            // 
            this.lbl_Flame.AutoSize = true;
            this.lbl_Flame.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Flame.Location = new System.Drawing.Point(86, 20);
            this.lbl_Flame.Name = "lbl_Flame";
            this.lbl_Flame.Size = new System.Drawing.Size(15, 20);
            this.lbl_Flame.TabIndex = 23;
            this.lbl_Flame.Text = "-";
            // 
            // lbl_FlameCon
            // 
            this.lbl_FlameCon.AutoSize = true;
            this.lbl_FlameCon.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_FlameCon.Location = new System.Drawing.Point(66, 46);
            this.lbl_FlameCon.Name = "lbl_FlameCon";
            this.lbl_FlameCon.Size = new System.Drawing.Size(15, 20);
            this.lbl_FlameCon.TabIndex = 22;
            this.lbl_FlameCon.Text = "-";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label37.Location = new System.Drawing.Point(6, 46);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(47, 20);
            this.label37.TabIndex = 2;
            this.label37.Text = "상태 :";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label38.Location = new System.Drawing.Point(6, 20);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(63, 20);
            this.label38.TabIndex = 1;
            this.label38.Text = "FLAME :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 737);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.chart_GasFlame);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "IoT Device 스마트 홈 통합 제어 장치 - 2조";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_Bar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Emo)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_GasFlame)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label connection_status;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.ComboBox COM_port;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button btn_CreateWater;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button DB_Clear;
        private System.Windows.Forms.Button DB_Water;
        private System.Windows.Forms.ListBox DataBase_Water;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar LED_Bar;
        private System.Windows.Forms.RadioButton btn_Auto;
        private System.Windows.Forms.RadioButton btn_Menual;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Disconnect_AVR;
        private System.Windows.Forms.Button Connect_AVR;
        private System.Windows.Forms.ComboBox COM_port2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Disconnect_ARM;
        private System.Windows.Forms.Button Connect_ARM;
        private System.Windows.Forms.ComboBox COM_port3;
        private System.IO.Ports.SerialPort serialPort3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_AirCon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_Hix;
        private System.Windows.Forms.Label lbl_Hum;
        private System.Windows.Forms.Label lbl_Temp;
        private System.Windows.Forms.PictureBox pb_Emo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbl_CDS_Con;
        private System.Windows.Forms.Label lbl_CDS;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_GasFlame;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lbl_Dis;
        private System.Windows.Forms.Button U9_button;
        private System.Windows.Forms.Label Ultra_Distance;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label lbl_gas;
        private System.Windows.Forms.Label lbl_gasCon;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lbl_WaterStatus;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label lbl_Water;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lbl_Flame;
        private System.Windows.Forms.Label lbl_FlameCon;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
    }
}

