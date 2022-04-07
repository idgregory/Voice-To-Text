using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace Voice_To_Text.Speech
{
    class Listener
    {
        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        public Listener()
        {
            recognizer.LoadGrammar(new DictationGrammar());
            recognizer.SetInputToDefaultAudioDevice();
        }
        public async Task<string> Recognize()
        {
            return await Task<string>.Factory.StartNew(() => recognizer.Recognize().Text);
        }
    }
}
