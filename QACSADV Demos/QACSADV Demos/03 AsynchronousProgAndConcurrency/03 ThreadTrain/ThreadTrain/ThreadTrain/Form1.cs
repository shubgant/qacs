namespace ThreadTrain
{
    public partial class Form1 : Form
    {
        Thread t1;
        Thread t2;
        Thread t3;
        Thread t4;
        Thread t5;
        Thread t6;
        public Form1()
        {
            InitializeComponent();
        }
        CancellationTokenSource cts;
        //
        // Note. For clarity, we're not using arrays here, but you could
        //       certainly do so
        //
        private void btnGo_Click(object sender, System.EventArgs e)
        {
            //
            // Prepare for the race
            //
            cts = new CancellationTokenSource();
            Train.Initialise(lblSingleLeft.Left, lblSingleRight.Right);

            // Instantiate the five Train objects
            Train train1 = new Train(picRT1);
            Train train2 = new Train(picRT2);
            Train train3 = new Train(picRT3);
            Train train4 = new Train(picLT1);
            Train train5 = new Train(picLT2);
            Train train6 = new Train(picLT3);

            picRT1.Left = 7;
            picRT2.Left = 7;
            picRT3.Left = 7;
            picLT1.Left = 660;
            picLT2.Left = 660;
            picLT3.Left = 660;

            //
            // Create the threads to move the trains
            //
            ThreadPool.QueueUserWorkItem(new WaitCallback(train1.RTGo), cts.Token);
            ThreadPool.QueueUserWorkItem(new WaitCallback(train2.RTGo), cts.Token);
            ThreadPool.QueueUserWorkItem(new WaitCallback(train3.RTGo), cts.Token);
            ThreadPool.QueueUserWorkItem(new WaitCallback(train4.LTGo), cts.Token);
            ThreadPool.QueueUserWorkItem(new WaitCallback(train5.LTGo), cts.Token);
            ThreadPool.QueueUserWorkItem(new WaitCallback(train6.LTGo), cts.Token);
            //t1 = new Thread(()=> train1.RTGo(cts.Token));
            //t2 = new Thread(() => train2.RTGo(cts.Token));
            //t3 = new Thread(() => train3.RTGo(cts.Token));
            //t4 = new Thread(() => train4.LTGo(cts.Token));
            //t5 = new Thread(() => train5.LTGo(cts.Token));
            //t6 = new Thread(() => train6.LTGo(cts.Token));


            //t1.IsBackground = true;
            //t2.IsBackground = true;
            //t3.IsBackground = true;
            //t4.IsBackground = true;
            //t5.IsBackground = true;
            //t6.IsBackground = true;

            //t1.Start();
            //t2.Start();
            //t3.Start();
            //t4.Start();
            //t5.Start();
            //t6.Start();

            btnStop.Enabled = true;
            btnGo.Enabled = false;
        }

        private void btnStop_Click(object sender, System.EventArgs e)
        {
            //Abort is not supported anymore
            //t1.Abort();
            //t2.Abort();
            //t3.Abort();
            //t4.Abort();
            //t5.Abort();
            //t6.Abort();
            cts.Cancel();
            btnGo.Enabled = true;
            btnStop.Enabled = false;
        }

    }
}
