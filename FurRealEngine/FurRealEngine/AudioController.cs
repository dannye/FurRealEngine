using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace FurRealEngine
{
    static class AudioController {

        static private SoundPlayer acquisition = new SoundPlayer(Properties.Resources.Acquisition);
        static private SoundPlayer moratorium = new SoundPlayer(Properties.Resources.Moratorium);
        static private SoundPlayer ferocity = new SoundPlayer(Properties.Resources.Ferocity);

        static public void playAcquisition()
        {
            moratorium.Stop();
            ferocity.Stop();
            acquisition.PlayLooping();
        }

        static public void playMoratorium()
        {
            acquisition.Stop();
            ferocity.Stop();
            moratorium.PlayLooping();
        }

        static public void playFerocity()
        {
            acquisition.Stop();
            moratorium.Stop();
            ferocity.PlayLooping();
        }
    }
}
