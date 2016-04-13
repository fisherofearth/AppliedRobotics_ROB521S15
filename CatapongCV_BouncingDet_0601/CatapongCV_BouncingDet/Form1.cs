using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System.Linq;

namespace CatapongCV_BouncingDet
{
    public partial class Form1 : Form
    {

        Capture capWebcam = null;
        bool blnCapturingInProcess = false;
        Image<Bgr, Byte>  imgOriginal; //save the original image
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@".\beep.wav");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PauseVideo();
        }

        private void PauseVideo()
        {
            if (blnCapturingInProcess == true)      //if we are currently processing an image, user just choose pause, so ...
            {
                Application.Idle -= processFrameAndUpdateGUI;   // remove the process image function from the application's list of task
                blnCapturingInProcess = false;                  // update flag variable
                button1.Text = "resume";
                button1.BackColor = Color.Red;
            }
            else    // else if we are not currently processing an image, user just choose resume, so...
            {
                Application.Idle += processFrameAndUpdateGUI;   // and the process image function to the application's list of tasks
                blnCapturingInProcess = true;                   // update flag variable
                button1.Text = "pause";
                button1.BackColor = Color.Green;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                capWebcam = new Capture(); //associate capture object to the default webcom
            }
            catch (NullReferenceException except)
            {
                //txb1.Text = except.Message;
                return;
            }
            player.Load();
            player.Play();
            // once we have a good capture object...
            Application.Idle += processFrameAndUpdateGUI;   //add process image function to the application's list of task
            blnCapturingInProcess = true;                   //update member flag variable

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (capWebcam != null)
            {
                capWebcam.Dispose();
            }
        }


        Rectangle rectROI = new Rectangle((640 - 200) / 2, (480 - 240), 200, 240); //rectangle: width = 150, height = 100, center of image
       
        void processFrameAndUpdateGUI(object sender, EventArgs arg)
        {
            //read original image from webcom
            imgOriginal = capWebcam.QueryFrame();   //get the next fram from the webcam
            if (imgOriginal == null) return;        //if we did not get a fram, bail

            imageBox3.Image = imgOriginal.Resize(imageBox3.Width, imageBox3.Height, INTER.CV_INTER_LINEAR);

            imgOriginal.ROI = rectROI;
            imageBox1.Image = imgOriginal.Convert<Gray, byte>().Resize(imageBox1.Width, imageBox1.Height, INTER.CV_INTER_LINEAR);
            if (DetectBouncing(imgOriginal.Convert<Gray, byte>(), Convert.ToInt16( textBox2.Text)) == true)
            {
               //PauseVideo();

                player.Play();
            }
        }
        Image<Gray, byte> imgFormal;
        Image<Gray, byte> imgDiff;
        
        Image<Gray, byte> imgHist = new Image<Gray, byte>(200, 100);
        private bool DetectBouncing(Image<Gray, byte> imgORI, int thresh)
        {


            if (imgFormal == null) imgDiff = imgORI.CopyBlank();
            else imgDiff = imgORI - imgFormal;
            imgFormal = imgORI;

            int[] hist = new int[200];
            double[] histNorm = new double[200];
            for (int x = 0; x < imgDiff.Width; x++)
            {
                hist[x] = 0;
                for (int y = 0; y < imgDiff.Height; y++)
                {
                    if (imgDiff.Data[y, x, 0] > 20)     // a thresh. for ignoring small change
                        hist[x] += imgDiff.Data[y, x, 0];
                }
            }

            hist = SmoothVector(hist, 10);
            // normalization
            double sumHist = hist.Sum();
            if (sumHist == 0) sumHist = 1;
            for (int x = 0; x < imgDiff.Width; x++)
            {
                histNorm[x] = hist[x] / sumHist;
            }


            // show normalized histogram
            imgHist.SetZero();
            double p = 99 / histNorm.Max();
            if (histNorm.Max() == 0) p = 0;
            for (int x = 0; x < imgDiff.Width; x++)
            {
                imgHist.Data[99 - Convert.ToInt16(histNorm[x] * p), x, 0] = 0xFF;
            }
            ibHist.Image = imgHist;


            imageBox2.Image = imgDiff.Resize(imageBox2.Width, imageBox2.Height, INTER.CV_INTER_LINEAR);



            int count;
            count = 0;
            for (int x = 0; x < imgDiff.Width; x++)
            {
                if (histNorm[x] * p > 50) count++;
            }
            if (count > 30) return false;


            count = 0;
            for (int x = 1; x < imgDiff.Width - 1; x++)
            {
                if (histNorm[x]*p > 50)
                {
                    count++;

                }
                else
                {
                    if (count > 10 && count < 22) return true;
                    else count = 0;
                }
            }
            return false;

            /*
            sum = sum / 100;
            textBox1.Text = sum.ToString();
            if (sum > (thresh )) return true;
            else return false;
            */

        }

        private int[] SmoothVector(int[] data, int times)
        {
            
            for (int t = 0; t < times; t++)
            {
                int[] tmpData = data;
                data[0] = (tmpData[0] + tmpData[1] + tmpData[ 2]) / 3;
                for (int i = 1; i < tmpData.Length - 1; i++)
                {
                    data[i] = (tmpData[i - 1] + tmpData[i] + tmpData[i + 1]) / 3;
                }
                data[tmpData.Length - 1] = (tmpData[tmpData.Length - 1] + tmpData[tmpData.Length - 2] + tmpData[tmpData.Length - 3]) / 3;
            }
            return data;
        }
    }
}



