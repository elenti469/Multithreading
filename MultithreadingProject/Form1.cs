using System.Threading; // without this whole project will stop working
namespace MultithreadingProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_thread1_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(MakeRedSquares);
            t1.Name = "Red Thread";
            t1.Start();
        }

        void MakeRedSquares()
        {
            Random rnd1 = new Random();
            Graphics g1 = CreateGraphics();

            for(int i = 0; i < 100; i++)
            {
                int rnd1x = rnd1.Next(50, 201); // randomizes numbers for graphics location
                int rnd1y = rnd1.Next(100, 500);

                Thread.Sleep(200); // delayes next loop by 200 miliseconds
                g1.DrawRectangle(new Pen(Color.Red, 3), rnd1x, rnd1y, 12, 12);
            }

            // final message in new window
            MessageBox.Show(" " + Thread.CurrentThread.Name + " has finished working", "Thread info");
        }

        private void btn_thread2_Click(object sender, EventArgs e)
        {
            Thread t2 = new Thread(MakeBlueCircles);
            t2.Name = "Blue Thread";
            t2.Start();
        }

        void MakeBlueCircles()
        {
            Random rnd2 = new Random();
            Graphics g2 = CreateGraphics();

            for (int i = 0; i < 100; i++)
            {
                int rnd2x = rnd2.Next(290, 500);
                int rnd2y = rnd2.Next(100, 500);

                Thread.Sleep(200);
                g2.DrawEllipse(new Pen(Color.Blue, 3), rnd2x, rnd2y, 12, 12);
            }
            MessageBox.Show(" " + Thread.CurrentThread.Name + " has finished working", "Thread info");
        }

        private void btn_thread3_Click(object sender, EventArgs e)
        {
            Thread t3 = new Thread(numbersSquared);
            t3.Name = "Math Thread";
            t3.Start();
        }

        void numbersSquared()
        {
            for(int i = 1; i < 101;i++)
            {
                Thread.Sleep(200);
                //Invoke method !!!
                textBox1.Invoke((MethodInvoker)(() => textBox1.AppendText(" " + i + " squared is: " + i * i + "\r\n")));
                progressBar1.Invoke((MethodInvoker)(() => progressBar1.Value = i));
            }
            MessageBox.Show(" " + Thread.CurrentThread.Name + " has finished working", "Thread info");
        }
    }
}