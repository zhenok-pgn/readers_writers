using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_os
{
    public partial class Form1 : Form
    {
        private readonly StreamWriter thredsLog;
        public Form1()
        {
            InitializeComponent();
            thredsLog = new StreamWriter("log.txt");
        }

        private void StartProcess(object sender, EventArgs e)
        {
            richTextBox1.Text = "started\n";
            CreateThreads("Writer", WriterWork, (int)writersAmount.Value);
            CreateThreads("Reader", ReaderWork, (int)readersAmount.Value);
        }

        private void CreateThreads(string threadName, ThreadStart start, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var threaad = new Thread(start) { Name = $"{threadName} {i}" };
                thredsLog.WriteLine($"{threaad.Name} has been created");
                threaad.Start();
            }
        }

        private void CreateReaders(int count)
        {
            for(int i = 0; i < count; i++)
            {

            }
        }

        private void WriterWork()
        { 
            for (int i = 0;; i++)
            {
                lock (thredsLog)
                {
                    Invoke(new Action<string>((name) =>
                        richTextBox1.Text += name + " " + i), Thread.CurrentThread.Name);
                    thredsLog.WriteLine(Thread.CurrentThread.Name + " : iteration " + i);
                }
            }
        }

        private void ReaderWork()
        {
            for (int i = 0; ; i++)
            {
                lock (thredsLog)
                {
                    Invoke(new Action<string>((name) =>
                        richTextBox1.Text += name + " " + i), Thread.CurrentThread.Name);
                    thredsLog.WriteLine(Thread.CurrentThread.Name + " : iteration " + i);
                }
            }
        }

        private void FormCloseHandle(object sender, FormClosingEventArgs e)
        {
            thredsLog.Close();
        }
    }
}
