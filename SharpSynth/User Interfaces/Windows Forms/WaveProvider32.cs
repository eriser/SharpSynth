using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpSynth.UserInterface.WindowsForms
{
    public abstract class WaveProvider32 : IWaveProvider
    {
        private WaveFormat waveFormat;

        public WaveFormat WaveFormat
        {
            get
            {
                return waveFormat;
            }
        }

        public WaveProvider32(int sampleRate, int channels)
        {
            SetWaveFormat(sampleRate, channels);
        }

        public WaveProvider32()
            : this(41000, 1)
        {

        }

        public void SetWaveFormat(int sampleRate, int channels)
        {
            waveFormat = WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, channels);
        }

        public abstract int Read(float[] buffer, int offset, int sampleCount);

        public int Read(byte[] buffer, int offset, int count)
        {
            WaveBuffer waveBuffer = new WaveBuffer(buffer);
            int samplesRequired = count / 4;
            int samplesRead = Read(waveBuffer.FloatBuffer, offset / 4, samplesRequired);
            return samplesRead * 4;
        }
    }
}
