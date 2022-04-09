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
using System.IO;
using Newtonsoft.Json;

namespace Voice_To_Text
{
    public partial class VoiceToTextWindow : Form
    {
        private SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        public VoiceToTextWindow()
        {
            recognizer.LoadGrammar(new DictationGrammar());
            recognizer.SetInputToDefaultAudioDevice();
            //LoadGrammars();
            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);
            InitializeComponent();
        }

        private void LoadGrammars()
        {
            string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\words.txt";
            List<string> WordList = new List<string>();
            using (StreamReader r = new StreamReader(dir))
            {
                string line = r.ReadLine().Replace("\r\n", "").Trim();
                if (!string.IsNullOrEmpty(line) && !string.IsNullOrWhiteSpace(line))
                {
                    WordList.Add(line);
                }
                
            }

        }

        private DialogResult ErrorMessage(string msg, string caption, MessageBoxButtons btns)
        {
            return System.Windows.Forms.MessageBox.Show(msg, caption, btns);
        }

        private void SetButtonState(bool speak, bool stop, bool read)
        {
            SpeakBtn.Enabled = speak;
            StopBtn.Enabled = stop;
            ReadBtn.Enabled = read;
        }

        private async void ReadBtn_Click(object sender, EventArgs e)
        {
            SetButtonState(false, false, false);
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
            SetButtonState(true, true, true);
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            recognizer.RecognizeAsyncCancel();
            SetButtonState(true, true, true);
        }

        private void SpeakBtn_Click_1(object sender, EventArgs e)
        {
            SetButtonState(false, true, false);
            MessageBox.Text = "";
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }
        private void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            MessageBox.Text += e.Result.Text;
        }

    }
}
