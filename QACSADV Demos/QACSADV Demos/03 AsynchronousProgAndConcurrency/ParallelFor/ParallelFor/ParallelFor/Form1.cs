using System.Windows.Forms;

namespace ParallelFor
{
    public partial class Form1 : Form
    {
        private PictureBox[] pictureBoxes;
        CancellationTokenSource cts = new();

        public Form1()
        {
            InitializeComponent();
            InitializePictureBoxes();
        }

        private void InitializePictureBoxes()
        {
            // Initialize PictureBoxes representing cars
            pictureBoxes = new PictureBox[]
            {
                pictureBox1,
                pictureBox2,
               
                // Add more PictureBoxes as needed
            };
            for(int i=0; i < pictureBoxes.Count(); i++)
            {
                pictureBoxes[i].Tag = i;
            }

        }

        private void StartRaceButton_Click(object sender, EventArgs e)
        {
            List<int> carColors = new List<int>();
            // Start the race using Parallel.For
            Parallel.For(0, pictureBoxes.Count(), i =>
            {
                const int raceTrackLength = 300; // Adjust according to form size

                //Can't use Invoke to use UI thread to update UI. Doing this makes the 
                //Parallel.For stick with it's current value So..
                //Run the race up front by adding car movement info to a list and then replay the movements.
                // Simulate car movement
                for (int j = 0; j < raceTrackLength; j++)
                {
                    // Move the car forward
                    //pictureBoxes[i].Invoke((MethodInvoker)(() =>
                    //{
                    //    pictureBoxes[i].Left += random.Next(5); // Adjust speed as needed
                    //}));
                    carColors.Add((int)(pictureBoxes[i].Tag));
                    // Simulate delay
                    //Thread.Sleep(50); // Adjust delay as needed
                }
            });
            foreach(int carNum in carColors)
            {
                Random random = new Random();
                pictureBoxes[carNum].Invoke((MethodInvoker)(() =>
                {
                    pictureBoxes[carNum].Left += random.Next(5); // Adjust speed as needed
                }));
                Thread.Sleep(50);
            }
        }

        private void MoveCar(PictureBox pictureBox)
        {

        }
    }
}
