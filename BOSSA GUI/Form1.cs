using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Reflection;

namespace BOSSA_GUI
{
    public partial class Form1 : Form
    {
        [DllImport("Kernel32")]
        public static extern void AllocConsole();

        [DllImport("Kernel32")]
        public static extern void FreeConsole();

        string strBossac = "bossac.exe";
        string argsBossac1 = "-u -e -w -b --port=";
        string argsBossac2 = " \"";
        string argsBossac3 = "\" -R";

        string[] currentPorts;

        public Form1()
        {
            using (var resource = Assembly.GetExecutingAssembly().GetManifestResourceStream("BOSSA_GUI.bossac.exe"))
            {
                using (var file = new FileStream("bossac.exe", FileMode.Create, FileAccess.Write))
                {
                    resource.CopyTo(file);
                }
            }
            InitializeComponent();
            textBox1.ScrollBars = ScrollBars.Vertical;
        }

        private void button_1_click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (fileBox.Text == null || fileBox.Text == "")
            {
                textBox1.Text = "No Firmware File Selected";
                return;
            }

            if (comPortBox.Text == null || comPortBox.Text == "" || comPortBox.Text == "Refresh Serial Ports")
            {
                textBox1.Text = "No Com Port Selected";
                return;
            }

            string lastPort = comPortBox.Text;
            string[] lastPorts = new string[lastPort.Count()];
            currentPorts.CopyTo(lastPorts, 0);

            SerialPort mySerialPort = new SerialPort(lastPort);
            mySerialPort.BaudRate = 1200;
            mySerialPort.Open();
            Thread.Sleep(500);
            mySerialPort.Close();
            Thread.Sleep(500);
            refreshPorts();
            Thread.Sleep(500);
            foreach (string port in currentPorts)
            {
                if (!lastPorts.Contains(port))
                {
                    comPortBox.Text = port;
                    break;
                }
            }

            mySerialPort = new SerialPort(comPortBox.Text);
            textBox1.AppendText(mySerialPort.BaudRate.ToString());

            Process process = new Process();
            var s = AppDomain.CurrentDomain.BaseDirectory + strBossac;
            
            process.StartInfo.FileName = s;
            process.StartInfo.Arguments = argsBossac1 + comPortBox.Text + argsBossac2 + fileBox.Text + argsBossac3;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.OutputDataReceived += new DataReceivedEventHandler((sender2, e2) =>
            {
                if (!String.IsNullOrEmpty(e2.Data))
                {
                    Invoke((MethodInvoker)delegate {
                        textBox1.AppendText(e2.Data + "\n");
                    });
                }
            });

            process.ErrorDataReceived += new DataReceivedEventHandler((sender2, e2) =>
            {
                if (!String.IsNullOrEmpty(e2.Data))
                {
                    Invoke((MethodInvoker)delegate {
                        textBox1.AppendText(e2.Data + "\n");
                    });
                }
            });

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.Close();
        }

        private void find_file_click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Browse For Firmware File";
            openFileDialog1.DefaultExt = "bin";
            openFileDialog1.Filter =
                "Binary (*.BIN)|*.BIN|" +
                "All files (*.*)|*.*";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.ShowDialog();

            fileBox.Text = openFileDialog1.FileName;
        }

        private void refreshSerialPorts(object sender, EventArgs e)
        {
            refreshPorts();
        }

        private void refreshPorts()
        {
            textBox1.Clear();
            textBox1.AppendText("cleared text Box");
            comPortBox.Items.Clear();

            textBox1.AppendText("cleared ComportBox");
            currentPorts = SerialPort.GetPortNames();

            foreach (string port in currentPorts)
            {
                comPortBox.Items.Add(port);
                comPortBox.Text = port;
            }
        }

    }
}
