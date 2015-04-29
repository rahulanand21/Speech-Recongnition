using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Threading;
using System.Globalization;

namespace Speech_Recongnition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void speech_Click(object sender, EventArgs e)
        {
            CultureInfo India = new CultureInfo("en-IN");
            SpeechSynthesizer speak = new SpeechSynthesizer();
            speak.SelectVoiceByHints(VoiceGender.Male, VoiceAge.NotSet,0,India);
            speak.Rate = Convert.ToInt32(speed.Text);
            speak.Volume = Convert.ToInt32(volume.Text);
            speak.Speak(richTextBox.Text);
        }

        private void richTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox.Text = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            speed.Text = "1";
            volume.Text = "50";
        }
    }
}
