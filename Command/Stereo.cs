using System;

namespace Command
{
    public class Stereo
    {
        public void On()
        {
            System.Console.WriteLine("Stereo turned on");
        }

        public void Off()
        {
            System.Console.WriteLine("Stereo turned off");
        }

        public void SetVolume(int vol)
        {
            System.Console.WriteLine("Volume set to " + vol);
        }

        public void SetCD()
        {
            System.Console.WriteLine("CD is set");
        }
    }
}
