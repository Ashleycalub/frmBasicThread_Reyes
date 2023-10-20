using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBasicThread_Reyes
{
    public partial class frmBasicThread : Form
    {
        public frmBasicThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Thread ThreadA;
            Thread ThreadB;

            ThreadStart threadstart = new ThreadStart(MyThreadClass.Thread1);
            ThreadA = new Thread(threadstart);
            ThreadB = new Thread(threadstart);

            ThreadA.Name = "Thread A Process ";
            ThreadB.Name = "Thread B Process ";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            lblThread.Text = "          - End of Thread - ";
            Console.WriteLine(lblThread.Text);
        }
    }
}
