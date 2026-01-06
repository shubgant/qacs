using System.Windows.Forms;

namespace TPLRacer
{
    public partial class Form1 : Form
    {
        private List<Racer> cars;
        public Form1()
        {
            InitializeComponent();
            InitializeCars();
        }

        private void InitializeCars()
        {
            // Initialize cars
            cars =
            [
                new Racer(picBlue, 1, this.lblResult),
                new Racer(picGreen, 2, this.lblResult),
                new Racer(picRed, 3, this.lblResult),
                new Racer(picPurple, 4, this.lblResult),
                new Racer(picBlack, 5, this.lblResult),
            ];

        }
        private async void btnGo_Click(object sender, System.EventArgs e)
        {
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

            // Start the race asynchronously
             RaceCarsUsingParallelFor();
        }

        private void RaceCarsUsingParallelFor()
        {
            // Start moving each car asynchronously
            //Task[] tasks = new Task[cars.Count];
            //for (int i = 0; i < cars.Count; i++)
            //{
            //    tasks[i] = cars[i].StartRaceAsync();
            //}
            //
            // Wait for all five racers to be ready
            //
            List<int> carMovementTracker = new List<int>();

            Parallel.For(0, cars.Count, i =>
            {
                const int raceTrackLength = 140;
                for (int j = 0; j < raceTrackLength; j++)
                {
                    Monitor.Enter(typeof(Form1));
                    carMovementTracker.Add(i);
                    Monitor.Exit(typeof(Form1));
                    Thread.Sleep(0);//Give another thread a look in
                }
                
                //if (Racer.carsReady == 5)
                //{
                //    Racer.GoEvent.Set();
                //}
            });
            foreach (int carNum in carMovementTracker)
            {
                //Random random = new Random();
                //pictureBoxes[carNum].Invoke((MethodInvoker)(() =>
                //{
                cars[carNum].Move(); // Adjust speed as needed
                //}));

            }
            //while (Racer.carsReady < 5)
            //    Thread.Sleep(0);
            //// Now signal the event so that all the threads start at the same time
            //Racer.GoEvent.Set();

            // Wait for all cars to finish the race
            //await Task.WhenAll(tasks);
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
