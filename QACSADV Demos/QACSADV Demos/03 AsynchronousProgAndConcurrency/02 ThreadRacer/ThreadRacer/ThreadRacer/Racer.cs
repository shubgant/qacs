using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadRacer
{
    internal class Racer
    {
        //
        // Accessible fields, including the event that is used to start the race
        //
        internal static ManualResetEvent GoEvent = new ManualResetEvent(false);
        internal static int carsReady = 0;

        // Field used to tell when a race is over, and who won
        private static int winningCar = -1;

        //
        // Private fields for the Racer object
        //
        PictureBox pictCar;
        Label lblResult;
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

        //
        // Standard constructor 
        //
        internal Racer(PictureBox pb, int carNo, Label lblRes)
        {
            pictCar = pb;
            pictCar.Left = 13;
            car = carNo;
            lblResult = lblRes;
        }

        internal void Go()
        {
            // One more car ready to go
            Interlocked.Increment(ref carsReady);

            // Wait until all cars are ready to race
            GoEvent.WaitOne();


            // Seed the delay generator 
            //Random r = new Random(AppDomain.GetCurrentThreadId());
            Random r = new Random(Thread.CurrentThread.ManagedThreadId);
            //
            // Move the car across the screen, while there is
            // no winner
            //
            while (pictCar.Left < 665 && winningCar == -1)
            {
                pictCar.Invoke((Action)delegate
                {
                    Thread.Sleep(r.Next(30));
                    pictCar.Left += 4;
                });
            }

            //
            // Now test to see if you were the winner in a synchronised
            // block of code using a Monitor.Lock()
            //
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
