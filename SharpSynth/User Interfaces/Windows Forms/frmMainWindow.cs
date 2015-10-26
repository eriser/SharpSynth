using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SharpSynth.UserInterface.WindowsForms
{
    public partial class frmMainWindow : Form
    {
        private WaveOut waveOut;

        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartStopSineWave();
        }

        private void StartStopSineWave()
        {
            if (waveOut == null)
            {
                var sineWaveProvider = new SineWaveProvider32();
                sineWaveProvider.SetWaveFormat(16000, 1); // 16kHz mono
                sineWaveProvider.Frequency = 1000;
                sineWaveProvider.Amplitude = 0.25f;
                waveOut = new WaveOut();
                waveOut.Init(sineWaveProvider);
                waveOut.Play();
            }
            else
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
        }
    }
}
