using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SharpSynth.UserInterface.WindowsForms.Controls
{
    public partial class ucPianoKeyOctave : UserControl
    {
        public event PianoKeyDownHandler PianoKeyDown;
        public event PianoKeyUpHandler PianoKeyUp;

        public delegate void PianoKeyDownHandler(object sender, PianoKeyEventArgs e);
        public delegate void PianoKeyUpHandler(object sender, PianoKeyEventArgs e);

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Piano Key")]
        [Description("Represent the start octave of full scale of real piano.")]
        public byte Octave { get; set; }

        public ucPianoKeyOctave()
        {
            InitializeComponent();

            Octave = 0;
        }

        public ucPianoKeyOctave(byte octave)
            : this()
        {
            Octave = octave;
        }

        public void btnPiano_KeyDown(object sender, KeyEventArgs e)
        {
            if (PianoKeyDown != null)
            {
                PianoKeyDown(sender, new PianoKeyEventArgs(e.KeyData));
            }
        }

        public void btnPiano_KeyUp(object sender, KeyEventArgs e)
        {
            if (PianoKeyUp != null)
            {
                PianoKeyUp(sender, new PianoKeyEventArgs(e.KeyData));
            }
        }
    }
}
