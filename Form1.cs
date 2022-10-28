using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Basic_Threading
{
    public partial class frmBasicThread : Form
    {
        public frmBasicThread()
        {
            InitializeComponent();
        }

        public void MyThreads()
        {
            lblThread.Text = ("-Before Starting Thread-");
            Console.WriteLine("-Before Starting Thread-");

            MyThreadClass ThreadClass = new MyThreadClass();
            Thread threadA = new Thread(new ThreadStart(ThreadClass.thread1));
            Thread threadB = new Thread(new ThreadStart(ThreadClass.thread1));

            threadA.Priority = ThreadPriority.Highest;
            threadA.Name = "Thread A Process";
            threadB.Priority = ThreadPriority.Highest;
            threadB.Name = "Thread B Process";

            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            Console.WriteLine("-End Of Thread-");
            lblThread.Text = ("-End Of Thread-");

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyThreads();
        }
    }
}
