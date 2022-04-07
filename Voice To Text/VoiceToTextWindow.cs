using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Voice_To_Text.Speech;
using System.Speech.Recognition;

namespace Voice_To_Text
{
    public partial class VoiceToTextWindow : Form
    {
        private SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        public VoiceToTextWindow()
        {
            InitializeComponent();
            recognizer.LoadGrammar(new DictationGrammar());
            recognizer.SetInputToDefaultAudioDevice();
            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);
        }

        private DialogResult ErrorMessage(string msg, string caption, MessageBoxButtons btns)
        {
            return System.Windows.Forms.MessageBox.Show(msg, caption, btns);
        }

        private async void ReadBtn_Click(object sender, EventArgs e)
        {
            String BoxText = MessageBox.Text.Replace("\r\n", "").Trim();
            Speaker speak = new Speaker();
            if (!string.IsNullOrEmpty(BoxText) && !string.IsNullOrWhiteSpace(BoxText))
            {
                await speak.Speak(BoxText);
            }
            else
            {
                DialogResult result = ErrorMessage("Please Enter Text", "No Input!", MessageBoxButtons.OK);
            }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            recognizer.RecognizeAsyncCancel();
        }

        private void SpeakBtn_Click_1(object sender, EventArgs e)
        {
            MessageBox.Text = "";
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }
        private void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            MessageBox.Text += e.Result.Text;
        }
    }
}
