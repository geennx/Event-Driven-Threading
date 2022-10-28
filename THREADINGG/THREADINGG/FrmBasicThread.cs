using System.Threading;
using System.Windows.Forms;
using System;

namespace THREADINGG
{
    public partial class FrmBasicThread : Form
    {
        ThreadStart delThread = new ThreadStart(MyThreadClass.Thread1);
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Console.WriteLine("-Before Starting a Thread-");
            Thread ThreadA = new Thread(delThread);
            Thread ThreadB = new Thread(delThread);

            ThreadA.Name = "Thread A process";
            ThreadB.Name = "Thread B process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            if (!ThreadA.IsAlive && !ThreadB.IsAlive)
            {
                label1.Text = "-End of Thread-";
                Console.WriteLine("-End of thread");
                
            }
        }
    }
}
