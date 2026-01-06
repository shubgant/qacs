using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRacer
{
    public class Racer
    {
        internal static ManualResetEvent GoEvent = new ManualResetEvent(false);
        internal static int carsReady = 0;
        // Field used to tell when a race is over, and who won
        private static int winningCar = -1;

        private readonly PictureBox pictCar;
        Label lblResult;
        private const int RaceTrackLength = 665; // Adjust according to form size
        private readonly Random random;
        int car;

        //
        // Initialise ready to run a race
        //
        internal static void Initialise()
        {
            carsReady = 0;
            GoEvent.Reset();
            winningCar = -1;
        }

        public Racer(PictureBox pb, int carNo, Label lblRes)
        {
            pictCar = pb;
            pictCar.Left = 13;
            car = carNo;
            lblResult = lblRes;
            random = new Random();
        }

        public async Task StartRaceAsync()
        {
            // Start moving the car forward asynchronously
            await Task.Run(() => Move());
        }

        private void Move()
        {
            // One more car ready to go
            Interlocked.Increment(ref carsReady);

            // Wait until all cars are ready to race
            GoEvent.WaitOne();

            // Simulate car movement
            while (pictCar.Left < 665 && winningCar == -1)
            {
                pictCar.Invoke((Action)delegate
                {
                    // Move the car forward
                    pictCar.Left += random.Next(5); // Adjust speed as needed
                });
                // Simulate delay
                Task.Delay(25).Wait(); // Adjust delay as needed
            }

            lock (typeof(Racer))
            {
                if (winningCar == -1)
                {
                    winningCar = car;
                    lblResult.Invoke((Action)delegate
                    {
                        lblResult.Text = "Car " + winningCar + " is the winner ";
                    });
                }
            }
            // One more racer has finished
            Interlocked.Decrement(ref carsReady);
        }
    }
}
