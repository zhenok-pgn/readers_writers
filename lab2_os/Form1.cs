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
        private string innitialCatalog = Environment.CurrentDirectory;
        private Mutex mutex = new Mutex();
        private int readersCount = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Text = innitialCatalog;
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
                lock (thredsLog)
                {
                    thredsLog.WriteLine($"{threaad.Name} has been created");
                }
                threaad.Start();
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
                mutex.WaitOne();
                readersCount++;
                if(readersCount == 1)
                    lock (thredsLog)
                    {
                        mutex.ReleaseMutex();
                        Invoke(new Action<string>((name) =>
                            richTextBox1.Text += name + " " + i), Thread.CurrentThread.Name);
                        thredsLog.WriteLine(Thread.CurrentThread.Name + " : iteration " + i);
                        mutex.WaitOne();
                        readersCount--;

                    }
                mutex.ReleaseMutex();
                Thread.Sleep(500);
            }
        }

        private void FormCloseHandle(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
            thredsLog.Close();
        }

        private void OpenFolderBrowserDialog(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = innitialCatalog;
            folderBrowserDialog1.ShowDialog();
            innitialCatalog = folderBrowserDialog1.SelectedPath;
            label1.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
