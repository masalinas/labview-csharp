using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Include LabVIEW namespace from the COM Interface
using LabVIEW;

namespace TresaVisualPOC
{
    public partial class frmMainView : Form
    {
        private string labViewFile;
        private _Application labViewApp;
        private VirtualInstrument viApp;

        private void InitLabviewApplication()
        {
            try
            {
                this.labViewApp = new LabVIEW.Application();

                if (this.labViewApp == null)
                {
                    Console.WriteLine("TresaPOC : An error occurred getting labVIEWApp.");
                    return;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        private void StartViApplication()
        {
            //Create VI object
            //this.viApp = labViewApp.GetVIReference(this.labViewFile, "", true, 0);
            this.viApp = labViewApp.GetVIReference(this.labViewFile);

            if (this.viApp == null)
            {
                Console.WriteLine("TresaPOC : An error occurred getting the VI reference.  Make sure the VI path you entered is correct.");
                return;
            }

            //Create input parameter names object to pass to the VI
            /*object paramNames = new object[]
            {
                    "Serial Port",             //input Arduino serial port configuiration
                    "Digital Output Channel",  //input Arduino digital pin
                    "LED Value",               //input Arduino Switch ON/OFF Button
                    "Stop Button"              //input Arduino Stop Button
            };

            //Create input parameter values to pass to the VI
            object paramValues = new object[]
            {
                    "COM3", //input Arduino serial port configuiration
                    13,     //input Arduino digital pin
                    0,      //input Arduino Switch ON/OFF Button
                    0       //input Arduino Stop Button
            };

            // Call the VI with the "Call2" method. "Call2" is very similar to "Call" except "Call2"
            // has a few more common input parameters. Both are like calling a subVI or a function call
            // while the "Run" method is more like hitting the run button on a VI. Also, parameters
            // are passed in and out by way of the first two parameters in the call method.

            //Call VI and provide input parameters
            this.viApp.Call2(ref paramNames, ref paramValues, true, false, false, true);*/

            this.viApp.FPWinOpen = true;

            this.viApp.SetControlValue("Serial Port", "COM3");
            this.viApp.SetControlValue("Digital Output Channel", 13);
            this.viApp.SetControlValue("LED Value", 0);
            this.viApp.SetControlValue("Stop Button", 0);

            //Run the VI with default input values, you will see the values on the front panel update if it is open
            this.viApp.Run(true);
        }

        public frmMainView()
        {
            InitializeComponent();

            // Initialize Labview Application
            InitLabviewApplication();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdLabbiewFile = new OpenFileDialog
            {
                InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), "labview"),
                Title = "Browse Labview Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "vi",
                Filter = "Labview files (*.vi)|*.vi",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (ofdLabbiewFile.ShowDialog() == DialogResult.OK)
            {
                // show vi file selected
                this.labViewFile = ofdLabbiewFile.FileName;

                // set vi file selected
                txtLabviewFile.Text = Path.GetFileName(this.labViewFile);

                // enable switch button
                btnSwitch.Enabled = true;

                // start vi labview application
                StartViApplication();
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (btnSwitch.Text == "OFF")
            {
                btnSwitch.Text = "ON";
                btnSwitch.BackColor = Color.Green;

                this.viApp.SetControlValue("LED Value", 1);
            } else
            {
                btnSwitch.Text = "OFF";
                btnSwitch.BackColor = Color.Gray;

                this.viApp.SetControlValue("LED Value", 0);
            }

            txtLoopRate.Text = this.viApp.GetControlValue("Loop Rate (Hz)").ToString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.viApp.SetControlValue("Stop Button", 1);
        }

        private void frmMainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            // stop vi labview application
            this.viApp.SetControlValue("Stop Button", 1);

            // close labview runtime
            this.labViewApp.Quit();
        }
    }
}
