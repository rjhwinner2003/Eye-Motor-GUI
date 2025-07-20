using System.Drawing;

namespace EyeMotorGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.demoButton = new System.Windows.Forms.Button();
            this.customButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.STB = new System.Windows.Forms.Button();
            this.SVD = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IsActiveConnection = new System.Windows.Forms.Panel();
            this.SPS = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.consoleOutput = new System.Windows.Forms.TextBox();
            this.ConsoleLabel = new System.Windows.Forms.Label();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.thrl = new System.Windows.Forms.Label();
            this.srl = new System.Windows.Forms.Label();
            this.frl = new System.Windows.Forms.Label();
            this.textBoxr3 = new System.Windows.Forms.TextBox();
            this.textBoxr2 = new System.Windows.Forms.TextBox();
            this.textBoxr1 = new System.Windows.Forms.TextBox();
            this.lMotorLabel = new System.Windows.Forms.Label();
            this.rMotorLabel = new System.Windows.Forms.Label();
            this.ManBtn = new System.Windows.Forms.Button();
            this.LeftBx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ManualSet = new System.Windows.Forms.Button();
            this.SeqFromFile = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.SendSeq = new System.Windows.Forms.Button();
            this.TestMessage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bpanel = new System.Windows.Forms.Panel();
            this.bpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 3000000;
            this.serialPort1.PortName = "COM3";
            // 
            // demoButton
            // 
            this.demoButton.Location = new System.Drawing.Point(528, 79);
            this.demoButton.Name = "demoButton";
            this.demoButton.Size = new System.Drawing.Size(573, 59);
            this.demoButton.TabIndex = 0;
            this.demoButton.Text = "Demo Rotation";
            this.demoButton.UseVisualStyleBackColor = true;
            this.demoButton.Click += new System.EventHandler(this.OnButton_Click);
            // 
            // customButton
            // 
            this.customButton.Location = new System.Drawing.Point(528, 154);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(573, 59);
            this.customButton.TabIndex = 1;
            this.customButton.Text = "Rotation Sequence";
            this.customButton.UseVisualStyleBackColor = true;
            this.customButton.Click += new System.EventHandler(this.OffButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(658, 526);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(658, 558);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(658, 590);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 26);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Second Rotation";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Rotation";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 593);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Third Rotation";
            // 
            // STB
            // 
            this.STB.Location = new System.Drawing.Point(839, 640);
            this.STB.Name = "STB";
            this.STB.Size = new System.Drawing.Size(262, 55);
            this.STB.TabIndex = 8;
            this.STB.Text = "Send To Board";
            this.STB.UseVisualStyleBackColor = true;
            this.STB.Click += new System.EventHandler(this.STB_Click);
            // 
            // SVD
            // 
            this.SVD.Location = new System.Drawing.Point(839, 575);
            this.SVD.Name = "SVD";
            this.SVD.Size = new System.Drawing.Size(262, 55);
            this.SVD.TabIndex = 9;
            this.SVD.Text = "Set Data";
            this.SVD.UseVisualStyleBackColor = true;
            this.SVD.Click += new System.EventHandler(this.SVD_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(1107, 653);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 30);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(1107, 587);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(33, 30);
            this.panel1.TabIndex = 12;
            // 
            // IsActiveConnection
            // 
            this.IsActiveConnection.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsActiveConnection.Location = new System.Drawing.Point(55, 305);
            this.IsActiveConnection.Name = "IsActiveConnection";
            this.IsActiveConnection.Size = new System.Drawing.Size(33, 30);
            this.IsActiveConnection.TabIndex = 13;
            // 
            // SPS
            // 
            this.SPS.AutoSize = true;
            this.SPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPS.Location = new System.Drawing.Point(48, 240);
            this.SPS.Name = "SPS";
            this.SPS.Size = new System.Drawing.Size(185, 40);
            this.SPS.TabIndex = 14;
            this.SPS.Text = "Serial Port";
            this.SPS.Click += new System.EventHandler(this.Label4_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(90, 310);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(130, 22);
            this.StatusLabel.TabIndex = 15;
            this.StatusLabel.Text = "Not Connected";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // consoleOutput
            // 
            this.consoleOutput.AcceptsReturn = true;
            this.consoleOutput.AcceptsTab = true;
            this.consoleOutput.AllowDrop = true;
            this.consoleOutput.Location = new System.Drawing.Point(55, 793);
            this.consoleOutput.Multiline = true;
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.ReadOnly = true;
            this.consoleOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleOutput.Size = new System.Drawing.Size(1524, 357);
            this.consoleOutput.TabIndex = 16;
            // 
            // ConsoleLabel
            // 
            this.ConsoleLabel.AutoSize = true;
            this.ConsoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleLabel.Location = new System.Drawing.Point(50, 761);
            this.ConsoleLabel.Name = "ConsoleLabel";
            this.ConsoleLabel.Size = new System.Drawing.Size(110, 29);
            this.ConsoleLabel.TabIndex = 17;
            this.ConsoleLabel.Text = "Console";
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel.Location = new System.Drawing.Point(527, 424);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(588, 30);
            this.InstructionLabel.TabIndex = 18;
            this.InstructionLabel.Text = "Note: Input degree positive is right. Negative is left.";
            // 
            // thrl
            // 
            this.thrl.AutoSize = true;
            this.thrl.Location = new System.Drawing.Point(529, 724);
            this.thrl.Name = "thrl";
            this.thrl.Size = new System.Drawing.Size(109, 20);
            this.thrl.TabIndex = 24;
            this.thrl.Text = "Third Rotation";
            // 
            // srl
            // 
            this.srl.AutoSize = true;
            this.srl.Location = new System.Drawing.Point(529, 692);
            this.srl.Name = "srl";
            this.srl.Size = new System.Drawing.Size(129, 20);
            this.srl.TabIndex = 23;
            this.srl.Text = "Second Rotation";
            // 
            // frl
            // 
            this.frl.AutoSize = true;
            this.frl.Location = new System.Drawing.Point(529, 662);
            this.frl.Name = "frl";
            this.frl.Size = new System.Drawing.Size(105, 20);
            this.frl.TabIndex = 22;
            this.frl.Text = "First Rotation";
            // 
            // textBoxr3
            // 
            this.textBoxr3.Location = new System.Drawing.Point(659, 721);
            this.textBoxr3.Name = "textBoxr3";
            this.textBoxr3.Size = new System.Drawing.Size(162, 26);
            this.textBoxr3.TabIndex = 21;
            this.textBoxr3.TextChanged += new System.EventHandler(this.TextBoxr3_TextChanged);
            // 
            // textBoxr2
            // 
            this.textBoxr2.Location = new System.Drawing.Point(659, 689);
            this.textBoxr2.Name = "textBoxr2";
            this.textBoxr2.Size = new System.Drawing.Size(162, 26);
            this.textBoxr2.TabIndex = 20;
            this.textBoxr2.TextChanged += new System.EventHandler(this.TextBoxr2_TextChanged);
            // 
            // textBoxr1
            // 
            this.textBoxr1.Location = new System.Drawing.Point(659, 657);
            this.textBoxr1.Name = "textBoxr1";
            this.textBoxr1.Size = new System.Drawing.Size(162, 26);
            this.textBoxr1.TabIndex = 19;
            this.textBoxr1.TextChanged += new System.EventHandler(this.TextBoxr1_TextChanged);
            // 
            // lMotorLabel
            // 
            this.lMotorLabel.AutoSize = true;
            this.lMotorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMotorLabel.Location = new System.Drawing.Point(346, 551);
            this.lMotorLabel.Name = "lMotorLabel";
            this.lMotorLabel.Size = new System.Drawing.Size(142, 32);
            this.lMotorLabel.TabIndex = 25;
            this.lMotorLabel.Text = "Left Motor";
            this.lMotorLabel.Click += new System.EventHandler(this.Label8_Click);
            // 
            // rMotorLabel
            // 
            this.rMotorLabel.AutoSize = true;
            this.rMotorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMotorLabel.Location = new System.Drawing.Point(346, 682);
            this.rMotorLabel.Name = "rMotorLabel";
            this.rMotorLabel.Size = new System.Drawing.Size(161, 32);
            this.rMotorLabel.TabIndex = 26;
            this.rMotorLabel.Text = "Right Motor";
            // 
            // ManBtn
            // 
            this.ManBtn.Location = new System.Drawing.Point(528, 227);
            this.ManBtn.Name = "ManBtn";
            this.ManBtn.Size = new System.Drawing.Size(573, 59);
            this.ManBtn.TabIndex = 27;
            this.ManBtn.Text = "Manual";
            this.ManBtn.UseVisualStyleBackColor = true;
            this.ManBtn.Click += new System.EventHandler(this.ManBtn_Click);
            // 
            // LeftBx
            // 
            this.LeftBx.Location = new System.Drawing.Point(809, 488);
            this.LeftBx.Name = "LeftBx";
            this.LeftBx.Size = new System.Drawing.Size(100, 26);
            this.LeftBx.TabIndex = 28;
            this.LeftBx.TextChanged += new System.EventHandler(this.LeftBx_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(676, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Rotation Degree";
            // 
            // ManualSet
            // 
            this.ManualSet.Location = new System.Drawing.Point(680, 537);
            this.ManualSet.Name = "ManualSet";
            this.ManualSet.Size = new System.Drawing.Size(262, 38);
            this.ManualSet.TabIndex = 37;
            this.ManualSet.Text = "Set Data";
            this.ManualSet.UseVisualStyleBackColor = true;
            this.ManualSet.Click += new System.EventHandler(this.ManualSet_Click);
            // 
            // SeqFromFile
            // 
            this.SeqFromFile.Location = new System.Drawing.Point(528, 302);
            this.SeqFromFile.Name = "SeqFromFile";
            this.SeqFromFile.Size = new System.Drawing.Size(573, 58);
            this.SeqFromFile.TabIndex = 38;
            this.SeqFromFile.Text = "Rotation Sequence From File";
            this.SeqFromFile.UseVisualStyleBackColor = true;
            this.SeqFromFile.Click += new System.EventHandler(this.SeqFromFile_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(54, 165);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(292, 50);
            this.OpenFile.TabIndex = 39;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SendSeq
            // 
            this.SendSeq.Location = new System.Drawing.Point(54, 237);
            this.SendSeq.Name = "SendSeq";
            this.SendSeq.Size = new System.Drawing.Size(292, 51);
            this.SendSeq.TabIndex = 40;
            this.SendSeq.Text = "Send Sequence";
            this.SendSeq.UseVisualStyleBackColor = true;
            this.SendSeq.Click += new System.EventHandler(this.SendSeq_Click);
            // 
            // TestMessage
            // 
            this.TestMessage.Location = new System.Drawing.Point(1600, 1136);
            this.TestMessage.Name = "TestMessage";
            this.TestMessage.Size = new System.Drawing.Size(120, 68);
            this.TestMessage.TabIndex = 41;
            this.TestMessage.Text = "TestMessage";
            this.TestMessage.UseVisualStyleBackColor = true;
            this.TestMessage.Visible = false;
            this.TestMessage.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 30);
            this.label4.TabIndex = 42;
            this.label4.Text = "File Sequence Manager";
            this.label4.Click += new System.EventHandler(this.Label4_Click_1);
            // 
            // bpanel
            // 
            this.bpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bpanel.Controls.Add(this.label4);
            this.bpanel.Controls.Add(this.SendSeq);
            this.bpanel.Controls.Add(this.OpenFile);
            this.bpanel.Location = new System.Drawing.Point(614, 380);
            this.bpanel.Name = "bpanel";
            this.bpanel.Size = new System.Drawing.Size(409, 390);
            this.bpanel.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 1216);
            this.Controls.Add(this.bpanel);
            this.Controls.Add(this.TestMessage);
            this.Controls.Add(this.SeqFromFile);
            this.Controls.Add(this.ManualSet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LeftBx);
            this.Controls.Add(this.ManBtn);
            this.Controls.Add(this.rMotorLabel);
            this.Controls.Add(this.lMotorLabel);
            this.Controls.Add(this.thrl);
            this.Controls.Add(this.srl);
            this.Controls.Add(this.frl);
            this.Controls.Add(this.textBoxr3);
            this.Controls.Add(this.textBoxr2);
            this.Controls.Add(this.textBoxr1);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.ConsoleLabel);
            this.Controls.Add(this.consoleOutput);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SPS);
            this.Controls.Add(this.IsActiveConnection);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SVD);
            this.Controls.Add(this.STB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.customButton);
            this.Controls.Add(this.demoButton);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SeriCommand";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bpanel.ResumeLayout(false);
            this.bpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button demoButton;
        private System.Windows.Forms.Button customButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button STB;
        private System.Windows.Forms.Button SVD;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel IsActiveConnection;
        private System.Windows.Forms.Label SPS;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox consoleOutput;
        private System.Windows.Forms.Label ConsoleLabel;
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.Label thrl;
        private System.Windows.Forms.Label srl;
        private System.Windows.Forms.Label frl;
        private System.Windows.Forms.TextBox textBoxr3;
        private System.Windows.Forms.TextBox textBoxr2;
        private System.Windows.Forms.TextBox textBoxr1;
        private System.Windows.Forms.Label lMotorLabel;
        private System.Windows.Forms.Label rMotorLabel;
        private System.Windows.Forms.Button ManBtn;
        private System.Windows.Forms.TextBox LeftBx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ManualSet;
        private System.Windows.Forms.Button SeqFromFile;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button SendSeq;
        private System.Windows.Forms.Button TestMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel bpanel;
    }
}