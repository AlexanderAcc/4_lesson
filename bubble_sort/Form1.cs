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

namespace bubble_sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void mass(int n)
        {
            List<int> list10 = new List<int>();
            List<int> list1000 = new List<int>();

            Random rnd = new Random();

            if (n == 10)
            {
                for (int i = 0; i < n; i++)
                {
                    list10.Add(rnd.Next(0, 100));

                    if (list10[i] % 2 == 0)
                    {
                        listBox1.Items.Add(list10[i]);
                    }
                    else
                    {

                    }
                }
                mass_sort(listBox1);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    list1000.Add(rnd.Next(0, 100));

                    if (list1000[i] % 2 == 0)
                    {
                        listBox2.Items.Add(list1000[i]);
                    }
                    else
                    {

                    }
                }
                mass_sort(listBox2);
            }
        }
        public void mass_sort(ListBox list)
        {
            int temp;
            for (int i = 0; i < list.Items.Count; i++)
            {
                for (int j = i + 1; j < list.Items.Count; j++)
                {
                    if (Convert.ToInt32(list.Items[i]) > Convert.ToInt32(list.Items[j]))
                    {
                        temp = Convert.ToInt32(list.Items[i]);
                        list.Items[i] = list.Items[j];
                        list.Items[j] = temp;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            mass(10);

            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            label1.Text = elapsedTime;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> a = new List<int>();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            mass(1000);

            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            label2.Text = elapsedTime;
        }
    }
}
