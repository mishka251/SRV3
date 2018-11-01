using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;

namespace SRVLab3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        Process cmd;
        private void btnPush_Click(object sender, EventArgs e)
        {
            Run();
        }

        void Send()
        {
            try
            {
                var pWriter = cmd.StandardInput;

                if (pWriter.BaseStream.CanWrite)
                {
                    pWriter.WriteLine(tbToConsole.Text );
                }
                else
                    MessageBox.Show("Cant Write");
                pWriter.Flush();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void Run()
        {
            if (cmd != null && !cmd.HasExited)
                cmd.Kill();
            try
            {
                cmd = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = tbCommand.Text,
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        StandardOutputEncoding = Encoding.GetEncoding(866),
                    }
                };
                cmd.OutputDataReceived += new DataReceivedEventHandler(Cmd_OutputDataReceived);

                cmd.Start();
                cmd.BeginOutputReadLine();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Cmd_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
                lbFromImage.Invoke(new Action(() => lbFromImage.Items.Add(e.Data)));

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cmd.HasExited)
                cmd.Kill();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
        }
    }
}
