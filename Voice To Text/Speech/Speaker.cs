using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Voice_To_Text.Speech
{
    class Speaker
    {
        private SpeechSynthesizer synth = new SpeechSynthesizer();
        public Speaker()
        {
            synth.SetOutputToDefaultAudioDevice();
            synth.SelectVoice("Microsoft Zira Desktop");
        }

        public async Task Speak(string msg)
        {
            await Task.Factory.StartNew(() => synth.Speak(msg));
        }
    }
}
