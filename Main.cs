using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace EzCAD_Dev_Dome
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        string ezdFileName = ""; //用来存储模板文件的文件路径

        [DllImport(@"MarkEzd.dll", EntryPoint = "lmc1_Close", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 lmc1_Close();

        [DllImport("MarkEzd.dll", EntryPoint = "lmc1_Initial", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lmc1_Initial(string strEzCadPath, int bTestMode, IntPtr hOwenWnd);

        [DllImport("MarkEzd.dll", EntryPoint = "lmc1_LoadEzdFile", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lmc1_LoadEzdFile(string strFileName);

        [DllImport("MarkEzd.dll", EntryPoint = "lmc1_ChangeTextByName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lmc1_ChangeTextByName(string strTextName, string strTextNew);

        [DllImport("MarkEzd.dll", EntryPoint = "lmc1_DeleteEnt", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lmc1_DeleteEnt(string strEntName);

        [DllImport("MarkEzd.dll", EntryPoint = "lmc1_Mark", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lmc1_Mark(int bFlyMark);

        [DllImport("MarkEzd.dll", EntryPoint = "lmc1_RedLightMark", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 lmc1_RedLightMark(); //显示一次红光对标

        [DllImport("MyMarkEzd.dll", EntryPoint = "CsGetHBitmap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr CsGetHBitmap(IntPtr hOwenWnd, int width, int height);

        [DllImport("MyMarkEzd_xp.dll", EntryPoint = "CsGetHBitmap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr CsGetHBitmap_XP(IntPtr hOwenWnd, int width, int height);

        [DllImport("MarkEzd.dll", EntryPoint = "lmc1_MoveEnt", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lmc1_MoveEnt(string pEntName, double dMovex, double dMovey);

        [DllImport("MarkEzd.dll", EntryPoint = "lmc1_SaveEntLibToFile", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lmc1_SaveEntLibToFile(string strFileName);

        [DllImport("MarkEzd.dll", EntryPoint = "lmc1_CopyEnt", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lmc1_CopyEnt(string pEntName, string pEntNEWName);

        [DllImport("MarkEzd.dll", EntryPoint = "lmc1_AddFileToLib", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int  lmc1_AddFileToLib(string pFileName, string pEntName, double dPosX, double dPosY, double dPosZ, int nAlign, double dRatio, int nPenNo);

        private void Form_Load(object sender, EventArgs e)
        {
            int c = lmc1_Initial(Application.StartupPath, 0, Handle);  //初始化激光雕刻机

            if (c != 0)
            {
                // MessageBox.Show("初始化Lmc失败\r\n错误代码：" + c + "\r\n错误原因:" + EzCad_Error_Code.ErrorMessage[c]);
                //lmc1_Close();
            }
            ezdFileName = Application.StartupPath + "/test.ezd";
            fileNametBox.Text = "test.ezd";
        }

        //旧无用
        void debug_string(string s)
        {
            //log_tBox.AppendText(s);
            //log_tBox.CreateControl();
        }
        //旧打开文件
        private void openFilebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Application.StartupPath;
            dialog.Multiselect = false;//多个文件
            dialog.Title = "请选择丝印文件";
            dialog.Filter = "Ezd文件(*.Ezd)|*.ezd";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ezdFileName = dialog.FileName;
                fileNametBox.Text = dialog.SafeFileName;
                fileNametBox.BackColor = Color.LightGreen;
            }
        }
        //旧加载文件
        private void preview_btn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(ezdFileName))
            {
                fileNametBox.BackColor = Color.Red;
                MessageBox.Show("请先选择丝印文件!!!\r\n");
                return;
            }

            int c = 5;

            while (c-- > 0)
            {
                if (lmc1_LoadEzdFile(ezdFileName) == 0)         //加载模板丝印文件
                    break;
                lmc1_Close();
                Thread.Sleep(200);
                lmc1_Initial(Application.StartupPath, 0, Handle);
                Thread.Sleep(100);
            }

            if (c < 0)
            {
                lmc1_Close();
                MessageBox.Show("加载丝印文件出错，请重试！！！");
                return;
            }

            lmc1_ChangeTextByName("test_qr", textBox.Text); //修改二维码
            lmc1_ChangeTextByName("test_str", textBox.Text); //修改文本

            IntPtr intPtr = lmc1_MoveEnt("test_str",26,-46);   //调整位置

            lmc1_MoveEnt("F10 虚线", 0, 0);              //copy虚线
            //lmc1_CopyEnt("F10 虚线", "F10 虚线1");
            lmc1_CopyEnt("F10 虚线", "F10 虚线2");
            lmc1_CopyEnt("F10 虚线", "F10 虚线3");
            lmc1_CopyEnt("F10 虚线", "F10 虚线4");
            lmc1_CopyEnt("F10 虚线", "F10 虚线5");
            lmc1_CopyEnt("F10 虚线", "F10 虚线6");
            lmc1_CopyEnt("F10 虚线", "F10 虚线7");
            lmc1_MoveEnt("F10 虚线",0,-106.514);
            lmc1_MoveEnt("F10 虚线2", 50, -106.514);
            lmc1_MoveEnt("F10 虚线3", 100, -106.514);
            lmc1_MoveEnt("F10 虚线4", 150, -106.514);
            lmc1_MoveEnt("F10 虚线5", 200, -106.514);
            lmc1_MoveEnt("F10 虚线6",250, -106.514);
            lmc1_MoveEnt("F10 虚线7",300, -106.514);

            lmc1_MoveEnt("F10 剪刀", 300, -106.514);

            lmc1_MoveEnt("正单色 电压标", 275, -106.514); //电压标

            lmc1_MoveEnt("12056 LOGO", 225, -106.514); //LOGO

             lmc1_MoveEnt("侧弯曲标识", 175, -106.514); //弯曲标

            // lmc1_MoveEnt("日期码", 125, -200); //日期码
            //lmc1_AddFileToLib(Application.StartupPath + "/图标/F10/剪切线.ezd", "F10 虚线", 0, 0, 0, 8, 0, 0);
            //lmc1_AddFileToLib(Application.StartupPath + "/图标/F10/剪切线.ezd", "F10 虚线", 50, 0, 0, 8, 0, 0);
            //lmc1_AddFileToLib(Application.StartupPath + "/图标/F10/剪切线.ezd", "F10 虚线", 100, 0, 0, 8, 0, 0);
            //lmc1_AddFileToLib(Application.StartupPath + "/图标/F10/剪切线.ezd", "F10 虚线", 150, 0, 0, 8, 0, 0);
            //lmc1_AddFileToLib(Application.StartupPath + "/图标/F10/剪切线.ezd", "F10 虚线", 200, 0, 0, 8, 0, 0);
            //lmc1_AddFileToLib(Application.StartupPath + "/图标/正侧弯标/侧弯.ezd", "侧弯曲标识",0,0,0,8,0,0);
            //lmc1_AddFileToLib(Application.StartupPath + "/图标/正侧弯标/正弯.ezd", "正弯曲标识", 275, 200, 0, 0, 0, 1);


            Bitmap m = null;
            try
            {
                if (Environment.OSVersion.Version.Major > 5) //主版本号大于五为Vasta以上系统
                {
                    m = Image.FromHbitmap(CsGetHBitmap(Handle, 560, 320)); //获取预览图片，win7及以上
                }
                else
                {
                    m = Image.FromHbitmap(CsGetHBitmap_XP(Handle, 560, 320));//获取预览图片，XP系统
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取预览图时发生错误：" + ex.Message);
                return;
            }

            if (m == null)
            {
                MessageBox.Show("无法获取预览图！！！");
                lmc1_Close();
                return;
            }
            else
            {
                pictureBox.Image = m;
            }
        }

        private void redline_btn_Click(object sender, EventArgs e)
        {
            lmc1_RedLightMark();
            Thread.Sleep(10);
            lmc1_RedLightMark();
            Thread.Sleep(10);
            lmc1_RedLightMark();
            Thread.Sleep(10);
            lmc1_RedLightMark();
            Thread.Sleep(10);
        }

        private void mark_btn_Click(object sender, EventArgs e)
        {
            int c = lmc1_Mark(0); //执行镭雕

            if (c == 0)
            {
            }
            else
            {
                MessageBox.Show("雕刻时出错\r\n错误代码：" + c + "\r\n错误原因:" + EzCad_Error_Code.ErrorMessage[c]);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void ScinanLaserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            lmc1_Close();
        }

        private void button_baocun_Click(object sender, EventArgs e)
        {
            lmc1_SaveEntLibToFile(Application.StartupPath + "/test123.ezd");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void preview_btn_Click_1(object sender, EventArgs e)
        {
            if (!File.Exists(ezdFileName))
            {
                fileNametBox.BackColor = Color.Red;
                MessageBox.Show("请先选择丝印文件!!!\r\n");
                return;
            }

            int c = 5;

            while (c-- > 0)
            {
                if (lmc1_LoadEzdFile(ezdFileName) == 0)         //加载模板丝印文件
                    break;
                lmc1_Close();
                Thread.Sleep(200);
                lmc1_Initial(Application.StartupPath, 0, Handle);
                Thread.Sleep(100);
            }

            if (c < 0)
            {
                lmc1_Close();
                MessageBox.Show("加载丝印文件出错，请重试！！！");
                return;
            }

            //获取配置参数
            string ju_客户 = comboBox_客户.Text;
            string ju_产品型号= comboBox_产品型号.Text;
            string ju_弯曲方向 = comboBox_弯曲方向.Text;
            string ju_光源总数 = textBox_光源总数.Text;
            string ju_每单元颗数 = textBox_每单元颗数.Text;
            string ju_每单元距离 = textBox_每单元距离.Text;
            string ju_电压 = comboBox_电压.Text;
            string ju_电压值 = comboBox_电压值.Text;
            string ju_系列 = comboBox_系列.Text;
            string ju_日期码 = textBox_日期码.Text;
            string ju_日期码大小 = textBox_日期码大小.Text;
            Trace.WriteLine(ju_弯曲方向, ju_每单元距离);

            //计算值
            int ju_剪切线数量 = int.Parse(ju_光源总数) / int.Parse(ju_每单元颗数);
            double ju_每个剪切数距离 = double.Parse(ju_每单元距离)*10;
            Trace.WriteLine(ju_剪切线数量);

            //合并输出
            //虚线
            double  x2 = 0;
            for (int i = 0; i < ju_剪切线数量; i++)
            {
                lmc1_CopyEnt(ju_产品型号 + "虚线", ju_产品型号 + "虚线"+ Convert.ToString(i));
                if (i == 0)
                {
                    lmc1_MoveEnt(ju_产品型号 + "虚线" + Convert.ToString(i), x2, -106.514);

                }
                else
                {
                    x2 = x2 + ju_每个剪切数距离;
                    lmc1_MoveEnt(ju_产品型号 + "虚线" + Convert.ToString(i), x2, -106.514);
                }
                //lmc1_MoveEnt(ju_产品型号 + "虚线" + Convert.ToString(i), 0, -106.514);
            }

            lmc1_MoveEnt(ju_产品型号 + "虚线" + Convert.ToString(ju_剪切线数量 - 1), 0, -106.514);
            //剪刀
            lmc1_MoveEnt(ju_产品型号 + "剪刀", x2, -106.514);
            //电压
            double ju_最终距离 = x2 - ju_每个剪切数距离 / 2;
            lmc1_MoveEnt(ju_弯曲方向+ ju_电压+ ju_电压值+ ju_系列, ju_最终距离, -106.514);
            //logo
            ju_最终距离 = ju_最终距离 - ju_每个剪切数距离;
            lmc1_MoveEnt(ju_客户 + "LOGO", ju_最终距离, -106.514);
            //UL
            ju_最终距离 = ju_最终距离 - ju_每个剪切数距离;
            lmc1_MoveEnt("UL标", ju_最终距离, -106.514);
            //弯曲
            ju_最终距离 = ju_最终距离 - ju_每个剪切数距离;
            lmc1_MoveEnt(ju_弯曲方向+"弯", ju_最终距离, -106.514);
            //日期
            ju_最终距离 = ju_最终距离 - ju_每个剪切数距离;
            lmc1_MoveEnt("日期码", ju_最终距离, -106.514);
            lmc1_ChangeTextByName("日期码", textBox_日期码.Text );

            //lmc1_ChangeTextByName("test_qr", textBox.Text); //修改二维码
            //lmc1_ChangeTextByName("test_str", textBox.Text); //修改文本
            //lmc1_MoveEnt("test_str", 26, -46);   //调整位置
            //lmc1_MoveEnt("F10 虚线", 0, 0);              //copy虚线
            //lmc1_CopyEnt("F10 虚线", "F10 虚线1");
            //lmc1_CopyEnt("F10 虚线", "F10 虚线2");
            //lmc1_CopyEnt("F10 虚线", "F10 虚线3");
            //lmc1_CopyEnt("F10 虚线", "F10 虚线4");
            //lmc1_CopyEnt("F10 虚线", "F10 虚线5");
            //lmc1_CopyEnt("F10 虚线", "F10 虚线6");
            //lmc1_CopyEnt("F10 虚线", "F10 虚线7");
            //lmc1_MoveEnt("F10 虚线", 0, -106.514);
            //lmc1_MoveEnt("F10 虚线2", 50, -106.514);
            //lmc1_MoveEnt("F10 虚线3", 100, -106.514);
            //lmc1_MoveEnt("F10 虚线4", 150, -106.514);
            //lmc1_MoveEnt("F10 虚线5", 200, -106.514);
            //lmc1_MoveEnt("F10 虚线6", 250, -106.514);
            //lmc1_MoveEnt("F10 虚线7", 300, -106.514);
            //lmc1_MoveEnt("F10 剪刀", 300, -106.514);
            //lmc1_MoveEnt("正单色 电压标", 275, -106.514); //电压标
            //lmc1_MoveEnt("12056 LOGO", 225, -106.514); //LOGO
            //lmc1_MoveEnt("侧弯曲标识", 175, -106.514); //弯曲标



            //预览图片
            Bitmap m = null;
            try
            {
                if (Environment.OSVersion.Version.Major > 5) //主版本号大于五为Vasta以上系统
                {
                    m = Image.FromHbitmap(CsGetHBitmap(Handle, 410, 270)); //获取预览图片，win7及以上
                }
                else
                {
                    m = Image.FromHbitmap(CsGetHBitmap_XP(Handle, 410, 270));//获取预览图片，XP系统
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取预览图时发生错误：" + ex.Message);
                return;
            }
            //预览错误提示
            if (m == null)
            {
                MessageBox.Show("无法获取预览图！！！");
                lmc1_Close();
                return;
            }
            else
            {
                pictureBox.Image = m;
            }
        }

        //保存输出
        private void button_baocun_Click_1(object sender, EventArgs e)
        {
            lmc1_SaveEntLibToFile(Application.StartupPath + "/"+ textBox1.Text  + ".ezd");
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFilebtn_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Application.StartupPath;
            dialog.Multiselect = false;//多个文件
            dialog.Title = "请选择丝印文件";
            dialog.Filter = "Ezd文件(*.Ezd)|*.ezd";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ezdFileName = dialog.FileName;
                fileNametBox.Text = dialog.SafeFileName;
                fileNametBox.BackColor = Color.LightGreen;
            }
        }
        //电压被选择时
        private void comboBox_电压_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ju_电压 = comboBox_电压.Text;
            comboBox_电压值.ResetText();
            comboBox_电压值.Items.Clear();
            comboBox_系列.ResetText();
            comboBox_系列.Items.Clear();
            if (ju_电压 == "DC")
            {
                //MessageBox.Show("AC");
                string[] comValue = new string[] { "12V", "24V" };
                for (int i = 0; i < comValue.Length; i++)
                {
                    comboBox_电压值.Items.Add(comValue[i]);
                }

            }
            else
            {
                string[] comValue = new string[] { "12V", "24V", "220V" };
                for (int i = 0; i < comValue.Length; i++)
                {
                    comboBox_电压值.Items.Add(comValue[i]);
                }
            }

            

        }
        //电压值被选择时
        private void comboBox_电压值_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ju_电压值 = comboBox_电压值.Text;
            string ju_电压 = comboBox_电压.Text;
            comboBox_系列.ResetText();
            comboBox_系列.Items.Clear();
            if (ju_电压 == "DC")
            {
                if (ju_电压值 == "12V")
                {
                    string[] comValue = new string[] { "单色" };
                    for (int i = 0; i < comValue.Length; i++)
                    {
                        comboBox_系列.Items.Add(comValue[i]);
                    }
                }
                if (ju_电压值 == "24V")
                {
                    string[] comValue = new string[] { "单色", "E系列", "S系列", "D系列", "A系列", "DTW", "RGA", "DMX" };
                    for (int i = 0; i < comValue.Length; i++)
                    {
                        comboBox_系列.Items.Add(comValue[i]);
                    }
                }
            }
            else
            {
                if (ju_电压值 == "12V")
                {
                    string[] comValue = new string[] { "通用" };
                    for (int i = 0; i < comValue.Length; i++)
                    {
                        comboBox_系列.Items.Add(comValue[i]);
                    }
                }
                if (ju_电压值 == "24V")
                {
                    string[] comValue = new string[] { "单色", "E系列", "S系列", "D系列", "A系列", "DTW" };
                    for (int i = 0; i < comValue.Length; i++)
                    {
                        comboBox_系列.Items.Add(comValue[i]);
                    }
                }
                if (ju_电压值 == "220V")
                {
                    string[] comValue = new string[] { "通用" };
                    for (int i = 0; i < comValue.Length; i++)
                    {
                        comboBox_系列.Items.Add(comValue[i]);
                    }
                }

            }
                
        }
    }
}
