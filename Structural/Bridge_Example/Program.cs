using System;

namespace Bridge_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDevice(new Radio());
            TestDevice(new TV());
        }

        private static void TestDevice(IDevice device)
        {
            SampleRemote sampleRemote = new SampleRemote(device);
            sampleRemote.Power();
            sampleRemote.ChannelUp();
            sampleRemote.VolumeUp();
            Console.WriteLine(device.Status);

            AdvancedRemote advancedRemote = new AdvancedRemote(device);
            advancedRemote.Mute();
            Console.WriteLine(device.Status);
        }
    }

    public interface IDevice
    {
        int Volume { get; set; }
        int Channel { get; set; }
        bool IsEnabled { get; }
        void Enable();
        void Disable();
        string Status { get; }
    }

    public class Radio : IDevice
    {
        private bool on = false;
        public int Volume { get; set; }
        public int Channel { get; set; }

        public bool IsEnabled => on;

        public string Status => $"Radio is {(on ? "on" : "off")}, volume: {Volume}, channel: {Channel}";

        public void Disable()
        {
            on = false;
        }

        public void Enable()
        {
            on = true;
        }
    }

    public class TV : IDevice
    {
        private bool on = false;
        public int Volume { get; set; }
        public int Channel { get; set; }

        public bool IsEnabled => on;
        public string Status => $"TV is {(on ? "on" : "off")}, volume: {Volume}, channel: {Channel}";

        public void Disable()
        {
            on = false;
        }

        public void Enable()
        {
            on = true;
        }
    }

    public interface IRemote
    {
        void Power();
        void VolumeDown();
        void VolumeUp();
        void ChannelDown();
        void ChannelUp();
    }

    public class SampleRemote : IRemote
    {
        protected IDevice device;

        public SampleRemote(IDevice device)
        {
            this.device = device;
        }

        public void ChannelDown()
        {
            device.Channel--;
        }

        public void ChannelUp()
        {
            device.Channel++;
        }

        public void Power()
        {
            if (device.IsEnabled)
            {
                device.Disable();
            }
            else
            {
                device.Enable();
            }
        }

        public void VolumeDown()
        {
            this.device.Volume--;
        }

        public void VolumeUp()
        {
            this.device.Volume++;
        }
    }

    public class AdvancedRemote : SampleRemote
    {
        public AdvancedRemote(IDevice device) : base(device)
        {
        }

        public void Mute()
        {
            base.device.Volume = 0;
        }
    }
}
