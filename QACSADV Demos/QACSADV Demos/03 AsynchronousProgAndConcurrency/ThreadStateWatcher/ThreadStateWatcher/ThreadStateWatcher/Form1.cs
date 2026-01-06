namespace ThreadStateWatcher
{
    public partial class Form1 : Form
    {
        //
        // Private fields
        //
        Thread worker = null;
        bool sleepRequested = false;
        CancellationTokenSource cts = new CancellationTokenSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            // Start the worker thread running
            worker.Start();


            // Changing the button states - ignore
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            btnSuspend.Enabled = true;
            btnSleep.Enabled = true;
        }

        private void btnStop_Click(object sender, System.EventArgs e)
        {
            // Stop the worker thread
            worker.Abort();


            // Changing the button states - ignore
            btnResume.Enabled = false;
            btnSuspend.Enabled = false;
            btnStop.Enabled = false;
            btnSleep.Enabled = false;
            btnCreate.Enabled = true;
        }

        private void btnSuspend_Click(object sender, System.EventArgs e)
        {
            // Pause the worker thread
            worker.Suspend(); //Deprecated. Do Not Use

            // Changing the button states - ignore
            btnResume.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnResume_Click(object sender, System.EventArgs e)
        {
            // Resume the worker thread
            worker.Resume();

            // Changing the button states - ignore
            btnResume.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnSleep_Click(object sender, System.EventArgs e)
        {
            // Flip on the sleep requested flag, so that the 
            // worker thread will sleep next time round its loop
            sleepRequested = true;
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            //
            // Abort an existing workerAnalyser thread
            //
            if (workerAnalyser != null)
            {
                workerAnalyser.Abort();
                workerAnalyser.Join();
            }

            //
            // Abort an existing worker thread
            //
            if (worker != null)
            {
                worker.Abort();
                worker.Join();

            }

            //
            // Instantiate a new worker thread, and put it in the 
            // background. 
            //
            worker = new Thread(new ThreadStart(WorkerMethod));
            worker.IsBackground = true;

            //
            // Create and start the new analyser thread that continuously monitors
            // the worker thread's state.
            //	
            workerAnalyser = new Thread(new ThreadStart(AnalyseWorker));
            workerAnalyser.IsBackground = true;
            workerAnalyser.Start();

            // Changing the button states - ignore
            btnStart.Enabled = true;
            btnCreate.Enabled = false;
        }


        // 
        // Worker thread method. Very nasty loop that will
        // instantly set the processor to 100% utilisation
        //
        private void WorkerMethod()
        {

            // Loops forever - only an Abort() on the 
            // worker object will end this loop, or if the
            // application itself ends.
            for (; ; )
            {
                //
                // Goes to sleep if requested
                //
                if (sleepRequested)
                {
                    Thread.Sleep(2000);
                    sleepRequested = false;
                }
            }
        }





        //
        // Implementation for worker analyser thread
        //
        Thread workerAnalyser;
        void AnalyseWorker()
        {
            //
            // Again, a very nasty loop to continuously monitor
            // the worker thread's state
            //
            do
            {
                // Give up the time slice
                Thread.Sleep(0);

                // Get the state from the worker thread
                // This is more complex than it should be, as the value
                // for Running is 0. Consequently, to check that a background thread is 
                // actually running, you need to check to see if its value
                // is set to ThreadState.Background.
                //
                txtState.Invoke((Action)delegate
                {
                    txtState.Text = worker.ThreadState.ToString() +
                        ((worker.ThreadState == ThreadState.Background) ? ", Running" : "");
                });
            } while ((worker.ThreadState & ThreadState.Stopped) == 0);
            txtState.Invoke((Action)delegate
            {
                txtState.Text = worker.ThreadState.ToString();
            });
        }
    }
}

