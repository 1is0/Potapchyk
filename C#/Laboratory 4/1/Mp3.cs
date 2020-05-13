using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace LABA4
{
    class Mp3Player : IDisposable
    { 
        public bool Repeat { get; set; }
        public Mp3Player(string filename)
        {
            const string Format = @"open ""{0}"" type mpegvideo alias MediaFile ";
            string command = String.Format(Format, filename);
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        public void Play()
        {
            string command =" Play MediaFile";
            if (Repeat) command += " Repeat";
            mciSendString(command, null, 0, IntPtr.Zero);
        }
        public void Stop()
        {
            string command = " Stop MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }
        public void SetVolume(int volume)
        {
            string command = "setaudio MediaFile volume to " + volume.ToString();
            mciSendString(command, null, 0, IntPtr.Zero);

        }

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn,
            int iReturnLenght, IntPtr hwndCallback);

        public void Dispose()
        {
            string command = " Close MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }
    }
}
