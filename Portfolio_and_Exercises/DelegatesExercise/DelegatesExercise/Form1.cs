using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DelegatesExercise//A.K.A. Super Color Flasher SCF6001.5f
{
    public partial class Form1 : Form
    {
        #region variables

        //delegate to hold the color changing method
        delegate void myDelegate();

        //delegate to reference which color changing method to call
        myDelegate FlashSelectedColor;

        //color randomiser
        Random myRandom;

        //worker variables
        int min, max, variableColor, direction = 10;

        #endregion
        /// <summary>
        /// initialisation
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            //set to flash default color
            FlashSelectedColor = new myDelegate(Default);

            //values
            min = scb_Minimum.Value;
            max = scb_Maximum.Value;
            tmr_Main.Interval = scb_Interval.Value;

            myRandom = new Random();

            //let's get this party started!
            tmr_Main.Start();
        }

        /// <summary>
        /// flashes at set intervals
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmr_Main_Tick(object sender, EventArgs e)
        {
            AdjustSelectedColor();

            FlashSelectedColor();
        }

        #region Delegated Worker Methods

        /// <summary>
        /// Default Color for startup
        /// </summary>
        void Default()
        {
            this.BackColor = DefaultBackColor;
        }

        /// <summary>
        /// Random Red Color
        /// </summary>
        void Red()
        {
            this.BackColor = Color.FromArgb(variableColor, 0, 0);
        }

        /// <summary>
        /// Random Green Color
        /// </summary>
        void Green()
        {
            this.BackColor = Color.FromArgb(0, variableColor, 0);
        }

        /// <summary>
        /// Random Blue Color
        /// </summary>
        void Blue()
        {
            this.BackColor = Color.FromArgb(0, 0, variableColor);
        }

        /// <summary>
        /// Random Color
        /// </summary>
        void Random()
        {
            this.BackColor = Color.FromArgb(myRandom.Next(min, max), myRandom.Next(min, max), myRandom.Next(min, max));
        }

        #endregion

        #region Setting the delegate



        private void btn_Red_Click(object sender, EventArgs e)
        {
            FlashSelectedColor = new myDelegate(Red);
        }

        private void btn_Green_Click(object sender, EventArgs e)
        {
            FlashSelectedColor = new myDelegate(Green);
        }

        private void btn_Blue_Click(object sender, EventArgs e)
        {
            FlashSelectedColor = new myDelegate(Blue);
        }


        private void btn_Random_Click(object sender, EventArgs e)
        {
            FlashSelectedColor = new myDelegate(Random);
        }

        #endregion

        #region More Worker Methods

        void AdjustSelectedColor()
        {
            //check for minimums and maximums
            int newColor = variableColor + direction;

            if (newColor < min || newColor > max)
                direction = -direction;

            //adjust the color
            variableColor += direction;
        }

        /// <summary>
        /// change color flash interval
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scb_Interval_ValueChanged(object sender, EventArgs e)
        {
            tmr_Main.Interval = scb_Interval.Value;
        }

        /// <summary>
        /// change minimum color value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scb_Minimum_ValueChanged(object sender, EventArgs e)
        {
            min = scb_Minimum.Value;
        }

        /// <summary>
        /// change maximum color value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scb_Maximum_Scroll(object sender, ScrollEventArgs e)
        {
            max = scb_Maximum.Value;
        }

        #endregion
    }
}
