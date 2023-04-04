using SmartHomeUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmartHomeUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_Menual.Checked = true; //PWM 수동 모드 버튼 활성화
            COM_port.DataSource = SerialPort.GetPortNames();// 콤보 박스에 연결할 포트이름 기입
        }
        const int TURNONAIRCON = 27; // 에어컨 on 상태값
        const int TURNOFFAIRCON = 23; // 에어컨 off 상태값
        const int HOT = 30; //hot 이미지 변경 조건 변수
        const int WARM = 28; //warm 이미지 변경 조건 변수
        const int COOL = 21; //cool 이미지 변경 조건 변수
        const int COLD = 18; //cold 이미지 변경 조건 변수
        const int LIGHTCON = 1000; // 조도에 따른 led on에 대한 상태 값
        const int GASCON = 400; //감스가 검출됫는지를 보기위한 변수
        const int WARNING = 500; // 수위가 위험 수준이 되었는지를 확인 변수
        const int ESCAPE = 650; //수위가 탈출을 해야할 정도의 수위인지 확인하는 변수
        const int FIRE = 980; //불꽃이 감지되었는지 확인하기 위한 변수
        const int FLAMESENSOR = 1023; // 플레임 센서의 기본값

        bool TurnON = true;//전구 아이콘을 이용해서 led bar에 대해서 on/off상태를 보는 변수
        bool CDS_Con = true; //조도 값에 따른 led바 Auto모드에서 led on/off상태를 보는 변수
        bool Condition = true; //온습도에 따른 에어컨의 상태를 보는 변수

        int transData = 0; // 전구 아이콘으로 on/off를 사용할시 기존의 led 밝기로 on하기 위한 변수
        int max_x = 10; // gas,flame에 대한 차트의 최대 x값
        double max = 0; //y축 valus
        int temp_x=0; //x축에대한 카운터 값을 늘리기 위한 변수

        int CDS=0; // 조도값을 담기 위한 변수
        int FlameData = 0; // 불꽃센서의 값을 담기 위한변수
        double valuesGas = 0; // 가스센서의 값을 담기 위한변수
        
        List<int> Waterlist = new List<int>(); // 수위값을 담아 평균을 내기이한 list

        string Dis = ""; //초음파의 거리값을 담는 변수
        string currentDirectory = Environment.CurrentDirectory;  // 저장되는 디렉토리 경로 설정

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.LightON;
            timer1.Start();//현재시간과 gas,flame차트를 움직이는 타이머
            timer1.Interval = 1000; //타이머 1초로 변경
        }

        #region >> Serial Connection
        private void connect_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = COM_port.Text;                                                       //Designate to Chosen ComName of ComboBox for SerialName                                                      
                serialPort1.BaudRate = 9600;                                                                //9600[bps]
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.None;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);   // Msut Do

                serialPort1.Open();  // SerialPort Open

                connection_status.Text = "포트가 열렸습니다.";
                connection_status.ForeColor = Color.Green;
                //listBox1.Items.Add(connection_status.Text);

            }
            else  //If Opened SerialPort
            {
                connection_status.Text = "포트가 열려 있습니다.";
            }
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)                                                                         //If Opened SerialPort
            {
                serialPort1.Close();                                                                        //SerialPort Close
                connection_status.Text = "포트가 닫혔습니다.";
                connection_status.ForeColor = Color.Red;
            }
            else  //If Closed SerialPort
            {
                connection_status.Text = "포트가 닫혀 있습니다.";
            }
        }
        private void Connect_AVR_Click(object sender, EventArgs e)
        {
            if (!serialPort2.IsOpen)
            {
                serialPort2.PortName = COM_port2.Text;                                                       //Designate to Chosen ComName of ComboBox for SerialName                                                      
                serialPort2.BaudRate = 9600;                                                                //9600[bps]
                serialPort2.DataBits = 8;
                serialPort2.StopBits = StopBits.One;
                serialPort2.Parity = Parity.None;
                serialPort2.DataReceived += new SerialDataReceivedEventHandler(serialPort2_DataReceived);   // Msut Do

                serialPort2.Open();  // SerialPort Open

                label4.Text = "포트가 열렸습니다.";
                label4.ForeColor = Color.Green;
                //listBox1.Items.Add(connection_status.Text);

            }
            else  //If Opened SerialPort
            {
                label4.Text = "포트가 열려 있습니다.";
            }
        }

        private void Disconnect_AVR_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)                                                                         //If Opened SerialPort
            {
                serialPort2.Close();                                                                        //SerialPort Close
                label4.Text = "포트가 닫혔습니다.";
                label4.ForeColor = Color.Red;
            }
            else  //If Closed SerialPort
            {
                label4.Text = "포트가 닫혀 있습니다.";
            }
        }

        private void Connect_ARM_Click(object sender, EventArgs e)
        {
            if (!serialPort3.IsOpen)
            {
                serialPort3.PortName = COM_port3.Text;                                                       //Designate to Chosen ComName of ComboBox for SerialName                                                      
                serialPort3.BaudRate = 9600;                                                                //9600[bps]
                serialPort3.DataBits = 8;
                serialPort3.StopBits = StopBits.One;
                serialPort3.Parity = Parity.None;
                serialPort3.DataReceived += new SerialDataReceivedEventHandler(serialPort3_DataReceived);   // Msut Do

                serialPort3.Open();  // SerialPort Open

                label5.Text = "포트가 열렸습니다.";
                label5.ForeColor = Color.Green;
                //listBox1.Items.Add(connection_status.Text);

            }
            else  //If Opened SerialPort
            {
                label5.Text = "포트가 열려 있습니다.";
            }
        }

        private void Disconnect_ARM_Click(object sender, EventArgs e)
        {
            if (serialPort3.IsOpen)                                                                         //If Opened SerialPort
            {
                serialPort3.Close();                                                                        //SerialPort Close
                label5.Text = "포트가 닫혔습니다.";
                label5.ForeColor = Color.Red;
            }
            else  //If Closed SerialPort
            {
                label5.Text = "포트가 닫혀 있습니다.";
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(MySerialReceived));
        }
        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(MySerialReceived));
        }
        private void serialPort3_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(MySerialReceived));
        }
        #endregion //포트연결 설정 부분

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("yyyy-MM-dd  tt hh:mm:ss"); // 실시간 시간 표시
            if(serialPort1.IsOpen)
            {
                //Gas
                chart_GasFlame.Series[0].Points.AddXY(temp_x, valuesGas);
                //데이터 셋의 갯수가 윈도우 사이즈를 초과하면
                if (chart_GasFlame.Series[0].Points.Count > max_x)  // 보여줄 갯 수보다 크면 첫 번째 데이터를 삭제
                {
                    chart_GasFlame.Series[0].Points.RemoveAt(0);   // 첫번째 데이터를 삭제한다.
                }
                chart_GasFlame.ChartAreas[0].AxisX.Maximum = temp_x;  // X축 최대값 표시 
                chart_GasFlame.ChartAreas[0].AxisX.Minimum = chart_GasFlame.Series[0].Points[0].XValue; // X축 최소값 표시, 최대값 기준 증가 순으로 설정 

                for (int i = 0; i < chart_GasFlame.Series[0].Points.Count; i++)  //Y축 값 표시 조건 
                {
                    if (max < chart_GasFlame.Series[0].Points[i].YValues[0])
                    {
                        max = chart_GasFlame.Series[0].Points[i].YValues[0];
                    }
                }
                chart_GasFlame.ChartAreas[0].AxisY.Maximum = max + 200;  // 기본 출력값에서 오버값 범위 +200

                //Flame
                chart_GasFlame.Series[1].Points.AddXY(temp_x, FlameData);
                //If, DataSetting Exceeds The Window Size
                if (chart_GasFlame.Series[1].Points.Count > max_x)  // If, Over the Window Size, Delete First Data
                {
                    chart_GasFlame.Series[1].Points.RemoveAt(0);   // Delete First Data
                }
                chart_GasFlame.ChartAreas[0].AxisX.Maximum = temp_x;  // Show Max X-Axis
                chart_GasFlame.ChartAreas[0].AxisX.Minimum = chart_GasFlame.Series[1].Points[0].XValue; // Show Min X-Axis, Set in Increasing Order Based on the Maximum Value

                for (int i = 0; i < chart_GasFlame.Series[1].Points.Count; i++)  // Y-axis value display condition 
                {
                    if (max < chart_GasFlame.Series[1].Points[i].YValues[0])
                    {
                        max = chart_GasFlame.Series[1].Points[i].YValues[0];
                    }
                }
                chart_GasFlame.ChartAreas[0].AxisY.Maximum = max + 200;  // Defualt Value + OverValue(+200)
                temp_x++;  // Increase the Number of X-axis Counter values
            }
        }
        private void MySerialReceived(object s, EventArgs e)
        {
            //Receive Data
            string ReceiveData = serialPort1.ReadLine();// T: Valsu, W: Valsu ..
            ReceiveData = ReceiveData.Replace("\n", "").Replace("\r", ""); //줄바꿈 커서 맨처음 이동 삭제
            //DataBase에 연결을하기 위한 프로토콜
            string connectionStr = string.Format("Data Source=192.168.0.237; Initial Catalog = SMARTHOME;User Id=sa;Password=1234");
            
            string[] dataArr = new string[] { };
            string[] splitData = ReceiveData.Split(':');// T: <- 이부분 삭제
           
            string DataType = splitData[0]; // Initial Word

            switch (DataType)
            {
                case "T":
                    try 
                    {
                        dataArr = splitData[1].Split(',');
                        lbl_Temp.Text = dataArr[0]; // 온도
                        lbl_Hum.Text = dataArr[1]; // 습도
                        lbl_Hix.Text = dataArr[2]; //체감온도

                        double TMP = Convert.ToDouble(dataArr[2]); //string - > double

                        //Each Temp Emotion
                        if (TMP >= HOT) // Over 30°C -> Hot
                            pb_Emo.Image = Resources.Hot;
                        else if (TMP < HOT && TMP >= WARM) // Over 28°C & Under 30°C -> Warm
                            pb_Emo.Image = Resources.Warm;
                        else if (TMP < WARM && TMP >= COOL) // Over 21°C & Under 28°C -> Good
                            pb_Emo.Image = Resources.Good;
                        else if (TMP < COOL && TMP >= COLD) // Over 18°C & Under 21°C -> Cool
                            pb_Emo.Image = Resources.Cool;
                        else // Under 18°C -> Cold
                            pb_Emo.Image = Resources.Cold;

                        //AirConditioner Standard
                        if (TMP > TURNONAIRCON && Condition == true) //Fan이 작동되고 있음
                        {
                            lbl_AirCon.Text = "ON";
                            Condition = false;
                        }
                        if (TMP < TURNOFFAIRCON && Condition == false)//Fan이 작동되고 있지 않음
                        {
                            lbl_AirCon.Text = "OFF";
                            Condition = true;
                        }
                    }
                    catch { }
                    break;

                case "C":
                    try
                    {
                        dataArr = splitData[1].Split(',');
                        lbl_CDS.Text = dataArr[0];
                        CDS = Convert.ToInt32(dataArr[0]);

                        //Auto Mode
                        if (btn_Auto.Checked)
                        {
                            LED_Bar.Enabled = false;
                            pictureBox1.Enabled = false;
                            if (CDS >= LIGHTCON && CDS_Con == true) // LED ON
                            {
                                lbl_CDS_Con.Text = "LED ON";
                                serialPort1.WriteLine("9");
                                CDS_Con = false;
                            }
                            else if (CDS < LIGHTCON - 50 && CDS_Con == false) // LED OFF
                            {
                                lbl_CDS_Con.Text = "LED OFF";
                                serialPort1.WriteLine("0");
                                if (CDS < LIGHTCON)
                                    CDS_Con = true;
                            }
                        }
                        else
                        {
                            LED_Bar.Enabled = true;
                            pictureBox1.Enabled = true;
                        }
                    }
                    catch { }
                    break;

                case "F":
                    try 
                    {
                        dataArr = splitData[1].Split(',');
                        FlameData = FLAMESENSOR - (Convert.ToInt32(dataArr[0]));
                        lbl_Flame.Text = Convert.ToString(FlameData);

                        if (FlameData < (FLAMESENSOR - FIRE)) // FlameData < 43
                        {
                            lbl_FlameCon.Text = "안전 이상 무";
                            lbl_FlameCon.ForeColor = Color.Green;
                        }
                        else
                        {
                            lbl_FlameCon.Text = "화염 경보 (스프링쿨러 가동)";
                            lbl_FlameCon.ForeColor = Color.Red;
                        }
                    }
                    catch { }
                    break;

                case "G":
                    try
                    {
                        dataArr = splitData[1].Split(',');
                        lbl_gas.Text = dataArr[0];
                        valuesGas = double.Parse(dataArr[0]);
                        int Gs = Convert.ToInt32(dataArr[0]);
                        if (Gs > GASCON)
                        {
                            lbl_gasCon.Text = "가스 누출 (환기 중)";
                            lbl_gasCon.ForeColor = Color.Red;
                        }
                        else
                        {
                            lbl_gasCon.Text = "안전 이상 무";
                            lbl_gasCon.ForeColor = Color.Green;
                        }
                    }
                    catch { }
                    break;

                case "W":
                    try
                    {
                        dataArr = splitData[1].Split(',');
                        lbl_Water.Text = dataArr[0];
                        int EachWater = Convert.ToInt32(dataArr[0]);
                        string water = lbl_Water.Text;

                        // Water Level
                        if (EachWater >= ESCAPE)
                        {
                            lbl_WaterStatus.Text = "위험! 집에서 나오세요!!";
                            lbl_WaterStatus.ForeColor = Color.Red;
                        }
                        else if (EachWater < ESCAPE && EachWater > WARNING)
                        {
                            lbl_WaterStatus.Text = "주의! 배수가 필요합니다!!";
                            lbl_WaterStatus.ForeColor = Color.Yellow;
                        }
                        else
                        {
                            lbl_WaterStatus.Text = "안전 이상 무";
                            lbl_WaterStatus.ForeColor = Color.Green;
                        }

                        //AVG Water
                        Waterlist.Add(EachWater);
                        if (Waterlist.Count == 100) // Data List;100
                        {
                            float avg = (float)Waterlist.Average();
                            Debug.WriteLine("average");

                            string avgCon="";

                            if (avg >= ESCAPE) avgCon = "위험! 집에서 나오세요!!";
                            else if (avg < ESCAPE && avg >= WARNING) avgCon = "주의! 배수가 필요합니다!!";
                            else avgCon = "안전 이상 무";

                            //DataBase_Water
                            string insertSQL = string.Format("INSERT INTO WATER_table2(date,WATER_data, status)VALUES('{0}','{1}','{2}')", DateTime.Now.ToString(), avg, avgCon);
                            using (SqlConnection connection = new SqlConnection(connectionStr))  // 데이테베이스 연결 객체(connection)생성
                            {
                                try
                                {
                                    connection.Open();  // 데이터베이스 연결 요청
                                    using (SqlCommand command = new SqlCommand(insertSQL, connection)) // 데이터베이스 명령어 객체(command)생성
                                    {
                                        command.ExecuteNonQuery();   // 데이터 추가 요청 함수 실행
                                    }
                                    connection.Close();  // 데이터베이스 연결 해제
                                    Debug.WriteLine("DB connection succeeded");
                                }
                                catch
                                {
                                    Debug.WriteLine("DB connection failed");
                                }
                            }

                            Waterlist.Clear();
                        }
                    }
                    catch { }
                    break;

                case "D":
                    try
                    {
                        dataArr = splitData[1].Split(',');
                        Dis = dataArr[0];
                    }
                    catch { };
                    break;
            }
        }

        private void LED_Bar_Scroll(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("포트가 열려있지 않습니다.");
                return;
            }
            else
            {
                if (btn_Menual.Checked)
                {
                    lbl_CDS_Con.Text = "밝기: " + LED_Bar.Value.ToString();
                    serialPort1.WriteLine(LED_Bar.Value.ToString());
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("포트가 열려있지 않습니다.");
                return;
            }
            else
            {
                if (btn_Menual.Checked)
                {
                    pictureBox1.Enabled = true;
                    if (TurnON == true) // LightON -> LightOFF Case
                    {
                        TurnON = false;
                        pictureBox1.Image = Resources.LightOFF;
                        transData = LED_Bar.Value;
                        LED_Bar.Value = 0;
                        LED_Bar.Enabled = false;
                        serialPort1.WriteLine(LED_Bar.Value.ToString());
                    }
                    else // LightOFF  -> LightON Case
                    {
                        TurnON = true;
                        LED_Bar.Value = transData;
                        pictureBox1.Image = Resources.LightON;
                        LED_Bar.Enabled = true;
                        serialPort1.WriteLine(LED_Bar.Value.ToString()); // 중복이라 아쉽;
                    }
                }  
            }
        }

        private void U9_button_Click(object sender, EventArgs e)
        {
            lbl_Dis.Text = Dis+"cm";
        }

        private void DB_Water_Click(object sender, EventArgs e)
        {
            //string selcetSQL = "SELECT ID, DATE, WATER_data, status FROM WATER_table2";
            string selcetSQL = "SELECT * FROM WATER_table2";
            string strconn = string.Format("Data Source ={0},{1};Initial Catalog={2};User ID ={3}; Password={4}", "192.168.0.237", 1433, "SMARTHOME", "sa", "1234");
            DataBase_Water.Items.Clear();
            using (SqlConnection connection = new SqlConnection(strconn))  // DB연결 객체 생성
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selcetSQL, connection)) // DB명령어 객체 생성
                {
                    SqlDataReader reader = command.ExecuteReader(); // ExecuteReader()함수를 이용해서 reader객체  생성
                    while (reader.Read())  // Read() 함수을 이용한 칼럼 정보 읽어 오기 
                    {
                        if (Convert.ToInt32(reader[2]) >= WARNING) // Read Data Except Safety
                            DataBase_Water.Items.Add(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3]);
                    }
                } 
                connection.Close();  // 데이터베이스 연결 해제
            }
        }

        private void DB_Clear_Click(object sender, EventArgs e)
        {
            DataBase_Water.Items.Clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text;
            string connectionStr = string.Format("Data Source = 192.168.0.237; Initial Catalog=SMARTHOME; User ID=sa; Password=1234");
            string deleteSQL = string.Format("DELETE FROM WATER_table2 WHERE ID= '{0}'", ID);
            string fileName = string.Format(@"\" + textBox2.Text + @"\db{0}.log", DateTime.Now.ToString("yyyy_MMdd_HHmm_ss"));
            using (SqlConnection connection = new SqlConnection(connectionStr)) //데이터베이스 연결 객체(connection) 생성
            {
                connection.Open(); // 데이터베이스 연결 요청
                using (SqlCommand cmd = new SqlCommand(deleteSQL, connection)) //데이터베이스 명령어 객체(cmd)생성
                {
                    cmd.ExecuteNonQuery(); // 데이터베이스 명령어 수행함수
                    using (StreamWriter sw = new StreamWriter(currentDirectory + @"\" + fileName, true))
                    {
                        sw.WriteLine("[{0}] [{1}]번째 Index CDS ON/OFF 정보 삭제됨...", DateTime.Now, ID);
                    }
                    FileInfo fileInfo = new FileInfo(currentDirectory + @"\" + fileName);
                    label31.Text = fileInfo.Name; // 파일명 정보 출력
                }
                MessageBox.Show("log파일 생성 및 데이터가 삭제 되었습니다.");
                connection.Close(); // 데이터베이스 연결해제
            }
        }

        private void btn_CreateWater_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory + @"\" + textBox2.Text);
            // 디렉토리 생성위한 객체 생성
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();   // 디렉토리 생성 
                MessageBox.Show("디렉토리가 생성 되었습니다!");
            }
            else
            {
                MessageBox.Show("디렉토리가 이미 생성 되었습니다!", name);
            }

            label28.Text = directoryInfo.FullName; // 디렉토리 경로 정보 출력
        }

        private void btn_Auto_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_Auto.Checked)
            {
                if(CDS>LIGHTCON)
                {
                    lbl_CDS_Con.Text = "LED ON";
                    serialPort1.WriteLine("9");
                }
                else
                {
                    lbl_CDS_Con.Text = "LED OFF";
                    serialPort1.WriteLine("0");
                }
            }
        }
    }
}
