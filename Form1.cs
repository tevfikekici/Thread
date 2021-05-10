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

namespace Threads2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            Thread channel1 = new Thread(new ThreadStart(counter1));
            Thread channel2 = new Thread(new ThreadStart(counter2));
            CheckForIllegalCrossThreadCalls = false;

            channel1.Start();
            channel2.Start();

        }

        private void counter1()
        {
            for (int i = 0; i <= 30; i++)
            {
                Thread.Sleep(200);
                label1.Text = i + " ";
            }
        }

        private void counter2()
        {
            for (int i = 0; i <= 30; i++)
            {
                Thread.Sleep(300);
                label2.Text = i + " ";
            }
            MessageBox.Show("Finished");
        }













        int j, k = 0;

        Thread t1;
        Thread t2;
        private void button_StartWithDelegate_Click(object sender, EventArgs e)
        {
            t1 = new Thread(new ThreadStart(counter3));
            t2 = new Thread(new ThreadStart(counter4));


            t1.Start();
            t2.Start();
        }

        private delegate void counter3_delegate();
        private void new_Counter3()
        {
            j++;
            label3.Text = j + " ";
        }
        private void counter3()
        {
            for (int i = 1; i <= 30; i++)
            {
                Thread.Sleep(200);
                label1.Invoke(new counter3_delegate(new_Counter3));

            }
        }

        private delegate void counter4_delegate();
        private void new_Counter4()
        {
            k++;
            label4.Text = k + " ";
        }

        private void counter4()
        {
            for (int i = 1; i <= 30; i++)
            {
                Thread.Sleep(300);
                label1.Invoke(new counter3_delegate(new_Counter4));

            }
        }      

        private void button_Pause_Click(object sender, EventArgs e)
        {
            
            if (button_Suspend.Text == "Pause")
            {
                t1.Suspend();
                t2.Suspend();
                button_Suspend.Text = "Resume";
            }
            else
            {
                t1.Resume();
                t2.Resume();
                button_Suspend.Text = "Pause";
            }
        }










        Thread th1, th2;

        private void button_Start2_Click(object sender, EventArgs e)
        {
            th1 = new Thread(new ThreadStart(counter5));
            th2 = new Thread(new ThreadStart(counter6));
            CheckForIllegalCrossThreadCalls = false;

            th1.Start();
            th2.Start();
        }

        private void button_Pause2_Click(object sender, EventArgs e)
        {
            if (button_Pause2.Text == "Pause")
            {
                if (th1.IsAlive)
                {
                    th1.Suspend();
                }
                if (th2.IsAlive)
                {
                    th2.Suspend();
                }
               
                button_Pause2.Text = "Resume";
            }
            else
            {
                if (th1.IsAlive)
                {
                    th1.Resume();
                }
                if (th2.IsAlive)
                {
                    th2.Resume();
                }
               
                button_Pause2.Text = "Pause";
            }
        }

        private void button_Finish_Click(object sender, EventArgs e)
        {
            try
            {
                th1.Abort();
                th2.Abort();
            }
            catch (ThreadAbortException ex)
            {

                MessageBox.Show(ex.ToString(), "Error !");
            }
        }

        private void counter5()
        {
            for (int i = 0; i <= 30; i++)
            {
                Thread.Sleep(200);
                label5.Text = i + " ";
            }
        }

        private void counter6()
        {
            th1.Join();
            for (int i = 0; i <= 30; i++)
            {
                Thread.Sleep(300);
                label6.Text = i + " ";
            }
          
        }

    }
}
