using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

public struct MotorControl
{
    public int rot1, rot2, rot3;
};

class EyeDataSequence
{
    public EyeDataSequence(float time, float LE, float RE, float LP, float RP)
    {
        this.time = time;
        this.LE = LE;
        this.RE = RE;
        this.LP = LP;
        this.RP = RP;
    }

    public float time, LE, RE, LP, RP;
};

namespace EyeMotorGUI
{
    public partial class Form1 : Form
    {
        MotorControl leftMotor, rightMotor, amphiMotor;

        String rotationSequence;

        List<EyeDataSequence> eyeRotVals = new List<EyeDataSequence>();

        public Form1()
        {
            InitializeComponent();

            //some spare stuff that wouldn't work when I tried to create the widget thing.

            //start up the serial port.
            try //or try to at least...
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    WriteToConsole("Connection successfully made!\n");
                }
                setBgColor(this.IsActiveConnection, Color.
                    Green);
                this.demoButton.Enabled = true;
                this.customButton.Enabled = true;
                this.StatusLabel.Text = "Connected!";
            }
            catch (Exception e1)
            {
                setBgColor(this.IsActiveConnection, Color.Red);
                this.demoButton.Enabled = false;
                this.customButton.Enabled = false;
                this.StatusLabel.Text = "Serial port not found!";
            }

            //set these to be hidden in the settings
            this.textBox1.Hide();
            this.textBox2.Hide();
            this.textBox3.Hide();
            this.textBoxr1.Hide();
            this.textBoxr2.Hide();
            this.textBoxr3.Hide();
            this.STB.Hide();
            this.label1.Hide();
            this.label2.Hide();
            this.label3.Hide();
            this.rMotorLabel.Hide();
            this.lMotorLabel.Hide();
            this.SVD.Hide();
            this.panel1.Hide();
            this.panel2.Hide();
            this.frl.Hide();
            this.srl.Hide();
            this.thrl.Hide();
            this.InstructionLabel.Hide();
            this.LeftBx.Hide();
            this.ManualSet.Hide();
            this.label7.Hide();
            this.InstructionLabel.Hide();
            //make the console read-only
            this.consoleOutput.ReadOnly = true;

            //For a timer
            System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();
            timer1.Interval = 50;   // milliseconds
            timer1.Tick += Timer1_Tick;  // set handler
            timer1.Start();

            this.Focus();
            this.KeyDown += Form_KeyDown;
        }

        public void WriteToConsole(string value)
        {
            consoleOutput.Text += value + "\r\n";
        }


        private void OnButton_Click(object sender, EventArgs e)
        {
            //write the following command to the Arduino
            serialPort1.Write("A");
        }

        private void OffButton_Click(object sender, EventArgs e)
        {
            //write the following command to the Arduino
            //serialPort1.Write("a");
            this.textBox1.Show();
            this.textBox2.Show();
            this.textBox3.Show();
            this.textBoxr1.Show();
            this.textBoxr2.Show();
            this.textBoxr3.Show();
            this.STB.Show();
            this.label1.Show();
            this.label2.Show();
            this.label3.Show();
            this.rMotorLabel.Show();
            this.lMotorLabel.Show();
            this.SVD.Show();
            this.panel1.Show();
            this.panel2.Show();
            this.frl.Show();
            this.srl.Show();
            this.thrl.Show();
            this.InstructionLabel.Show();

            this.LeftBx.Hide();
            this.ManualSet.Hide();
            this.label7.Hide();

            setBgColor(this.panel1, Color.Red);
            setBgColor(this.panel2, Color.Red);
        }

        public void setBgColor(Panel p, Color rgb)
        {
            p.BackColor = rgb;
        }

        private void ManBtn_Click(object sender, EventArgs e)
        {
            //show the stuff for the manual input
            this.LeftBx.Show();
            this.ManualSet.Show();
            this.label7.Show();
            this.InstructionLabel.Show();


            //hide the stuff for the automatic input.
            this.textBox1.Hide();
            this.textBox2.Hide();
            this.textBox3.Hide();
            this.textBoxr1.Hide();
            this.textBoxr2.Hide();
            this.textBoxr3.Hide();
            this.STB.Hide();
            this.label1.Hide();
            this.label2.Hide();
            this.label3.Hide();
            this.rMotorLabel.Hide();
            this.lMotorLabel.Hide();
            this.SVD.Hide();
            this.panel1.Hide();
            this.panel2.Hide();
            this.frl.Hide();
            this.srl.Hide();
            this.thrl.Hide();

            //write the signal
            serialPort1.Write("ChangeManual");
        }

        private void ManualSet_Click(object sender, EventArgs e)
        {
            //set the left and right motor values that will be modified from the parent program.
            //this will prepare them to be sent to the arduino.

            //set data
            amphiMotor.rot1 = Convert.ToInt32(LeftBx.Text);

            //creates the rotation sequence.
            rotationSequence = amphiMotor.rot1.ToString();

            //prints out to the program console.
            WriteToConsole("Values " + amphiMotor.rot1 + " has been sent to the board");
            WriteToConsole("Sequence sent: " + rotationSequence);

            WriteToConsole("Manual rotation sequence sent to the board.");
            serialPort1.Write(rotationSequence);
            this.Focus();
        }


        //sends the data to the arduino board.
        private void STB_Click(object sender, EventArgs e)
        {
            serialPort1.Write("RunCustom");
            WriteToConsole("Run Custom sent to board.");
            //Thread.Sleep(2000);
            serialPort1.Write(rotationSequence);
        }


        private void SVD_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                serialPort1.Write("BeginRead");
                WriteToConsole("Begin Read sent to board.");

                //set the left and right motor values that will be modified from the parent program.
                //this will prepare them to be sent to the arduino.

                //left side
                leftMotor.rot1 = Convert.ToInt32(textBox1.Text) + 90;
                leftMotor.rot2 = Convert.ToInt32(textBox2.Text) + 90;
                leftMotor.rot3 = Convert.ToInt32(textBox3.Text) + 90;

                //right side
                rightMotor.rot1 = Convert.ToInt32(textBoxr1.Text) + 90;
                rightMotor.rot2 = Convert.ToInt32(textBoxr2.Text) + 90;
                rightMotor.rot3 = Convert.ToInt32(textBoxr3.Text) + 90;

                //creates the rotation sequence.
                rotationSequence = ", " + leftMotor.rot1 + ", " + leftMotor.rot2 + ", " + leftMotor.rot3 + ", " + rightMotor.rot1 + ", " + rightMotor.rot2 + ", " + rightMotor.rot3;

                //prints out to the program console.
                WriteToConsole("Values " + leftMotor.rot1 + "," + leftMotor.rot2 + ", " + "and " + leftMotor.rot3 + " have been sent to the board");
                WriteToConsole("Sequence sent: " + rotationSequence);
                setBgColor(this.panel2, Color.Green);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }





        private void Timer1_Tick(object sender, EventArgs e)
        {
            //TODO: make the program able to detect serial port connections every second
            //and make it autoconnect.

            try //or try to at least...
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    setBgColor(this.IsActiveConnection, Color.
                    Yellow);
                    this.StatusLabel.Text = "Serial port found! Please restart the program!";
                    WriteToConsole("Connection was lost then found again. Program must be restarted.");
                }

            }
            catch (Exception e1)
            {
                setBgColor(this.IsActiveConnection, Color.
                    Red);
                this.StatusLabel.Text = "Serial port not found!";
                demoButton.Enabled = false;
                customButton.Enabled = false;
            }



        }


        private async void Form_KeyDown(object sender, KeyEventArgs e)
        {
            this.Focus();
            if (e.KeyCode == Keys.NumPad4)
            {
                serialPort1.Write("L");
                WriteToConsole("Left Turn Written");

                //await Task.Delay(1000);

                //serialPort1.Write("N");
                //WriteToConsole("Center Written");

            }

            if (e.KeyCode == Keys.NumPad6)
            {
                serialPort1.Write("R");
                WriteToConsole("Right Turn Written");

                //await Task.Delay(1000);

                //serialPort1.Write("N");
                //WriteToConsole("Center Written");
            }

            if (e.KeyCode == Keys.Up)
            {
                //move motors up

            }

            if (e.KeyCode == Keys.Down)
            {
                //move motors down

            }
            if (e.KeyCode == Keys.NumPad5)
            {
                //move motors center
                serialPort1.Write("N");
            }
        }
        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        //lefthand functions
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.textBox1.Text, "[^0-9]") && !System.Text.RegularExpressions.Regex.IsMatch(this.textBox1.Text, "-"))
            {
                MessageBox.Show("Please enter only numbers.");
                this.textBox1.Text = textBox1.Text.Remove(this.textBox1.Text.Length - 1);
            }
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBoxr1.Text.Length > 0 && textBoxr2.Text.Length > 0 && textBoxr3.Text.Length > 0)
            {
                setBgColor(this.panel1, Color.Green);
            }

            if (this.panel1.BackColor == Color.Green)
            {
                setBgColor(this.panel2, Color.Red);
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.textBox2.Text, "[^0-9]") && !System.Text.RegularExpressions.Regex.IsMatch(this.textBox2.Text, "-"))
            {
                MessageBox.Show("Please enter only numbers.");
                this.textBox2.Text = this.textBox2.Text.Remove(this.textBox2.Text.Length - 1);
            }
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBoxr1.Text.Length > 0 && textBoxr2.Text.Length > 0 && textBoxr3.Text.Length > 0)
            {
                setBgColor(this.panel1, Color.Green);
            }

            if (this.panel1.BackColor == Color.Green)
            {
                setBgColor(this.panel2, Color.Red);
            }
        }


        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.textBox3.Text, "[^0-9]") && !System.Text.RegularExpressions.Regex.IsMatch(this.textBox3.Text, "-"))
            {
                MessageBox.Show("Please enter only numbers.");
                this.textBox3.Text = this.textBox3.Text.Remove(this.textBox3.Text.Length - 1);
            }
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBoxr1.Text.Length > 0 && textBoxr2.Text.Length > 0 && textBoxr3.Text.Length > 0)
            {
                setBgColor(this.panel1, Color.Green);
            }

            if (this.panel1.BackColor == Color.Green)
            {
                setBgColor(this.panel2, Color.Red);
            }
        }

        //righthand functions
        private void TextBoxr1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.textBoxr1.Text, "[^0-9]") && !System.Text.RegularExpressions.Regex.IsMatch(this.textBoxr1.Text, "-"))
            {
                MessageBox.Show("Please enter only numbers.");
                this.textBoxr1.Text = textBoxr1.Text.Remove(this.textBoxr1.Text.Length - 1);
            }
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBoxr1.Text.Length > 0 && textBoxr2.Text.Length > 0 && textBoxr3.Text.Length > 0)
            {
                setBgColor(this.panel1, Color.Green);
            }

            if (this.panel1.BackColor == Color.Green)
            {
                setBgColor(this.panel2, Color.Red);
            }
        }

        private void TextBoxr2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.textBoxr2.Text, "[^0-9]") && !System.Text.RegularExpressions.Regex.IsMatch(this.textBoxr2.Text, "-"))
            {
                MessageBox.Show("Please enter only numbers.");
                this.textBoxr2.Text = this.textBoxr2.Text.Remove(this.textBoxr2.Text.Length - 1);
            }
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBoxr1.Text.Length > 0 && textBoxr2.Text.Length > 0 && textBoxr3.Text.Length > 0)
            {
                setBgColor(this.panel1, Color.Green);
            }

            if (this.panel1.BackColor == Color.Green)
            {
                setBgColor(this.panel2, Color.Red);
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            Stream st;
            OpenFileDialog d1 = new OpenFileDialog();

            int currentLine = 0;

            if(d1.ShowDialog() == DialogResult.OK)
            {
                if((st = d1.OpenFile()) != null)
                {
                    string file = d1.FileName;

                    foreach(String str in File.ReadAllLines(file))
                    {

                        if(currentLine != 0)
                        {
                            string[] split = str.Split(',');

                            EyeDataSequence lineSeq = new EyeDataSequence(float.Parse(split[0]), float.Parse(split[1]), float.Parse(split[2]), float.Parse(split[3]), float.Parse(split[4]));

                            eyeRotVals.Add(lineSeq);

                            WriteToConsole(lineSeq.LP.ToString());
                        }

                        currentLine++;
                    }

                }
            }

        }



        private void LeftBx_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.textBoxr3.Text, "[^0-9]") && !System.Text.RegularExpressions.Regex.IsMatch(this.textBoxr3.Text, "-"))
            {
                MessageBox.Show("Please enter only numbers.");
                this.textBoxr3.Text = this.textBoxr3.Text.Remove(this.textBoxr3.Text.Length - 1);
            }

        }



        private void TextBoxr3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.textBoxr3.Text, "[^0-9]") && !System.Text.RegularExpressions.Regex.IsMatch(this.textBoxr3.Text, "-"))
            {
                MessageBox.Show("Please enter only numbers.");
                this.textBoxr3.Text = this.textBoxr3.Text.Remove(this.textBoxr3.Text.Length - 1);
            }

            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBoxr1.Text.Length > 0 && textBoxr2.Text.Length > 0 && textBoxr3.Text.Length > 0)
            {
                setBgColor(this.panel1, Color.Green);
            }

            if (this.panel1.BackColor == Color.Green)
            {
                setBgColor(this.panel2, Color.Red);
            }

        }


    }
}