using System;

namespace Structural
{
    public class Bridge
    {
        public void Run()
        {
            Television tv = new Television();

            // Create a basic remote for the television
            Remote basicRemote = new Remote(tv);

            // Power on the television
            basicRemote.TogglePower();

            // Increase the volume using basic remote
            basicRemote.VolumeUp();

            // Change channel using basic remote
            basicRemote.ChannelUp();

            // Power off the television
            basicRemote.TogglePower();

            // Create an advanced remote for the television
            AdvancedRemote advancedRemote = new AdvancedRemote(tv);

            // Use the advanced remote to control the television
            advancedRemote.Run2();
        }
    }
    // Device interface
    public interface IDevice
    {
        bool IsEnabled();
        void Enable();
        void Disable();
        int GetVolume();
        void SetVolume(int percent);
        int GetChannel();
        void SetChannel(int channel);

    }

    // Concrete implementation of Device
    public class Television : IDevice
    {
        private bool enabled = false;
        private int volume = 50;
        private int channel = 1;

        public bool IsEnabled()
        {
            return enabled;
        }

        public void Enable()
        {
            enabled = true;
            Console.WriteLine("Television enabled.");
        }

        public void Disable()
        {
            enabled = false;
            Console.WriteLine("Television disabled.");
        }

        public int GetVolume()
        {
            return volume;
        }

        public void SetVolume(int percent)
        {
            volume = percent;
            Console.WriteLine($"Television volume set to {volume}.");
        }

        public int GetChannel()
        {
            return channel;
        }

        public void SetChannel(int channel)
        {
            this.channel = channel;
            Console.WriteLine($"Television channel set to {channel}.");
        }
    }

    // Remote abstraction
    public class Remote
    {
        protected IDevice device;

        public Remote(IDevice device)
        {
            this.device = device;
        }

        public void TogglePower()
        {
            if (device.IsEnabled())
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
            device.SetVolume(device.GetVolume() - 10);
        }

        public void VolumeUp()
        {
            device.SetVolume(device.GetVolume() + 10);
        }

        public void ChannelDown()
        {
            device.SetChannel(device.GetChannel() - 1);
        }

        public void ChannelUp()
        {
            device.SetChannel(device.GetChannel() + 1);
        }
    }

    // Advanced remote extending basic remote
    public class AdvancedRemote : Remote
    {
        public AdvancedRemote(IDevice device) : base(device)
        {
        }

        public void Mute()
        {
            device.SetVolume(0);
            Console.WriteLine("Volume muted.");
        }

        public void Run2()
        {
            // Power on the television
            TogglePower();

            // Increase volume using advanced remote
            VolumeUp();

            // Mute the television using advanced remote
            Mute();

            // Change channel using advanced remote
            ChannelDown();

            // Power off the television with advanced remote
            TogglePower();
        }

       
    }


}
