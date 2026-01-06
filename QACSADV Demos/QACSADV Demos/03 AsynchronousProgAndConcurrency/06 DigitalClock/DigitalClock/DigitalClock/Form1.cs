namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            clockTimer = new System.Threading.Timer(new TimerCallback(ClockTick), null, 0, 1000);
        }

        private delegate void TickTock();

        //
        // Method called back by the Timer
        //
        private void ClockTick(object o)
        {
            if (InvokeRequired)
                Invoke(new TickTock(SetClockText));
            else
                SetClockText();
        }

       //[System.Runtime.Remoting.Messaging.OneWay]
        private void SetClockText()
        {
            lblClock.Text = String.Format("{0:T}", DateTime.Now);
        }


        //
        // Send the UI thread to sleep for five seconds
        // THIS IS ONLY HERE TO DEMONSTRATE THE DAMAGE THAT CALLING
        // Thread.Sleep() CAN DO TO A USER INTERFACE
        //
        private void btnSleep_Click(object sender, System.EventArgs e)
        {
            Thread.Sleep(5000);
        }

        //
        // This shows the perils of blocking with a Join()
        // Your application will deadlock itself, even though you
        // might be thinking that you're doing things correctly
        //
        private void btnThread_Click(object sender, System.EventArgs e)
        {
            // Start up the thread, put it in the background and then
            // wait for it to finish
            Thread t = new Thread(new ThreadStart(Deadlock));
            t.IsBackground = true;
            t.Start();
            t.Join();
        }

        //
        // You will never come out of here. Here's why.
        // This thread calls ClockTick(). Because it is not the UI thread
        // it will use the Invoke() mechanism to deliver the call to 
        // SetClockText(), which is what should happen. However, this
        // involves marshalling the call onto the UI thread, which is
        // sound asleep, waiting for this thread to finish its work.
        // Deadlock!
        //
        private void Deadlock()
        {
            Thread.Sleep(1000);
            ClockTick(null);
            Thread.Sleep(1000);
        }


        // Private fields
        System.Threading.Timer clockTimer = null;
    }
}
