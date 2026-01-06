namespace ThreadRacer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, System.EventArgs e)
        {
            //
            // Don't let them start another race if one is in progress
            //
            if (Racer.carsReady > 0)
            {
                MessageBox.Show("Sorry, a race is in progress");
                return;
            }

            lblResult.Text = "";

            //
            // Prepare for the race
            //
            Racer.Initialise();

            // Instantiate the five racer objects
            Racer r1 = new Racer(picBlue, 1, lblResult);
            Racer r2 = new Racer(picGreen, 2, lblResult);
            Racer r3 = new Racer(picRed, 3, lblResult);
            Racer r4 = new Racer(picPurple, 4, lblResult);
            Racer r5 = new Racer(picBlack, 5, lblResult);

            //
            // Create the five racing threads, set them to 
            // being background threads, and get them started
            //
            Thread t1 = new Thread(new ThreadStart(r1.Go));
            Thread t2 = new Thread(new ThreadStart(r2.Go));
            Thread t3 = new Thread(new ThreadStart(r3.Go));
            Thread t4 = new Thread(new ThreadStart(r4.Go));
            Thread t5 = new Thread(new ThreadStart(r5.Go));

            t1.IsBackground = true;
            t2.IsBackground = true;
            t3.IsBackground = true;
            t4.IsBackground = true;
            t5.IsBackground = true;

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();

            //
            // Wait for all five racers to be ready
            //
            while (Racer.carsReady < 5)
                Thread.Sleep(0);

            // Now signal the event so that all the threads start at the same time
            Racer.GoEvent.Set();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            picBlue.Location = new System.Drawing.Point(13, 62);
            picGreen.Location = new System.Drawing.Point(13, 117);
            picRed.Location = new System.Drawing.Point(13, 175);
            picPurple.Location = new System.Drawing.Point(13, 233);
            picBlack.Location = new System.Drawing.Point(13, 290);
            Racer.Initialise();
        }
    }
}
