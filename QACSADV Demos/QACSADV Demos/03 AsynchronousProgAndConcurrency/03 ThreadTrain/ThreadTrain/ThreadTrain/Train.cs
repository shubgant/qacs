using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadTrain
{
    internal class Train
    {
        //
        // Private static fields, including the mutex
        //
        private static Mutex singleTrack;
        private static int leftEdge, rightEdge;

        //
        // Private fields for the Train object
        //
        PictureBox pictTrain;

        //
        // Method to set the positions to be used for the
        // edges of the "single track" section
        //
        static internal void Initialise(int left, int right)
        {
            leftEdge = left;
            rightEdge = right;
            singleTrack = new Mutex(false, "QASingleTrackMutex");
        }

        //
        // Standard constructor 
        //
        internal Train(PictureBox pb)
        {
            pictTrain = pb;
        }

        //
        // Method to move trains to the right. 
        // Note that we are using a mutex in much the same way that
        // you might use an AutoResetEvent, in that we use it to
        // signal when you can go onto the single track
        // A more typical use might be 
        // mutex.WaitOne()
        //   do something critical
        // mutex.ReleaseMutex()
        //		
        internal void RTGo(object? obj)
        {
            if (obj is null)
                return;

            CancellationToken token = (CancellationToken)obj;

            bool bOwnsMutex = false;
            int speed = 2;

            for (; ; )
            {
                if (token.IsCancellationRequested)
                {
                    if (bOwnsMutex)
                    {
                        singleTrack.ReleaseMutex();
                    }
                    break;
                }
                Thread.Sleep(30);
                pictTrain.Invoke((Action)delegate
                {
                    pictTrain.Left += speed;
                });
                // Obtain the mutex if the train is about to enter the
                // single track portion
                if (pictTrain.Right >= leftEdge && pictTrain.Left <= rightEdge && !bOwnsMutex)
                {
                    singleTrack.WaitOne();
                    bOwnsMutex = true;
                    speed += 2;
                }

                // Release the mutex if the train has left the single
                // track portion 
                //
                else if (pictTrain.Left >= rightEdge && bOwnsMutex)
                {
                    singleTrack.ReleaseMutex();
                    bOwnsMutex = false;
                    speed -= 2;
                }

                //
                // Wrap the image
                //
                pictTrain.Invoke((Action)delegate
                {
                    if (pictTrain.Left >= 775)
                        pictTrain.Left = -(pictTrain.Width + 3);
                });
            }
        }

        internal void LTGo(object? obj)
        {
            if (obj is null)
                return;

            CancellationToken token = (CancellationToken)obj;

            bool bOwnsMutex = false;
            int speed = 2;

            for (; ; )
            {
                if (token.IsCancellationRequested)
                {
                    if (bOwnsMutex)
                    {
                        singleTrack.ReleaseMutex();
                    }
                    break;
                }
                Thread.Sleep(30);
                pictTrain.Invoke((Action)delegate
                {
                    pictTrain.Left -= speed;
                });
                //
                // Obtain the mutex if we want to enter the single
                // track portion
                //
                if (pictTrain.Left <= rightEdge && pictTrain.Right >= leftEdge && !bOwnsMutex)
                {
                    singleTrack.WaitOne();
                    bOwnsMutex = true;
                    speed += 2;
                }

                //
                // Release the mutex once we have left the 
                // single track portion
                //
                else if (pictTrain.Right <= leftEdge && bOwnsMutex)
                {
                    singleTrack.ReleaseMutex();
                    bOwnsMutex = false;
                    speed -= 2;
                }

                //
                // Wrap the image if it falls off the left
                //	
                //	
                pictTrain.Invoke((Action)delegate
                {
                    if (pictTrain.Right <= 0)
                        pictTrain.Left = 778;
                });
            }
        }
    }
}
