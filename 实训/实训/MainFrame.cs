using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实训
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length > 0)
            {
                comboBox1.Items.AddRange(ports);
                comboBox1.SelectedIndex = 0;
            }
        }
        private void InitSerialPort()
        {
            serialPort1.BaudRate = 115200;
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.ReceivedBytesThreshold = 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                button1.Text = "打开";
                return;
            }
            //否则打开串口
            else
            {
                serialPort1.PortName = comboBox1.Text;

                try
                {
                    serialPort1.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                button1.Text = "关闭";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                this.toolStripStatusLabel1.Text = "请先打开串口";
                return;
            }

            this.toolStripStatusLabel1.Text = "未找到有效的卡";

            // '666'填充为'00000666'
            string stuffId = this.tb_EmployeeId.Text.PadLeft(8, '0');
            // '00000666'转变成'66060000'
            stuffId = ISO15693CardHandler.CovertEndian(stuffId);

            // 检查输入数据的错误
            // ISO15693为32位，4字节，8字符
            if (stuffId.Length != 8)
            {
                MessageBox.Show("请输入4字节的16进制数据！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 检查16进制字符错误
            if (!ISO15693CardHandler.CheckValidHexBytes(stuffId))
            {
                MessageBox.Show("写入数据的16进制格式错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
