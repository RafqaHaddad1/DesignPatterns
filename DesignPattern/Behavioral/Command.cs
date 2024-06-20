using System;
// A request is wrapped under an object as command and passed to invoker object.
// Invoker object looks for the appropriate object which can handle this command and passes the command to the corresponding object which executes the command.
//reference: https://www.geeksforgeeks.org/command-pattern/?ref=lbp#when-to-use-the-command-design-pattern
namespace Behavioral
{
    // Command interface
    public class Command
    {
        public void Run()
        {
            // Receiver
            Light livingRoomLight = new Light();

            // Commands
            ICommand lightOn = new LightOnCommand(livingRoomLight);
            ICommand lightOff = new LightOffCommand(livingRoomLight);

            // Invoker
            RemoteControl remote = new RemoteControl();

            // Turn the light on
            remote.SetCommand(lightOn);
            remote.PressButton();

            // Turn the light off
            remote.SetCommand(lightOff);
            remote.PressButton();


        }
        public interface ICommand
        {
            void Execute();
        }

        // Receiver class
        public class Light
        {
            public void TurnOn()
            {
                Console.WriteLine("Light is ON");
            }

            public void TurnOff()
            {
                Console.WriteLine("Light is OFF");
            }
        }

        // ConcreteCommand for turning on the light
        public class LightOnCommand : ICommand
        {
            private readonly Light _light;

            public LightOnCommand(Light light)
            {
                _light = light;
            }

            public void Execute()
            {
                _light.TurnOn();
            }
        }

        // ConcreteCommand for turning off the light
        public class LightOffCommand : ICommand
        {
            private readonly Light _light;

            public LightOffCommand(Light light)
            {
                _light = light;
            }

            public void Execute()
            {
                _light.TurnOff();
            }
        }

        // Invoker class
        public class RemoteControl
        {
            private ICommand _command;

            public void SetCommand(ICommand command)
            {
                _command = command;
            }

            public void PressButton()
            {
                _command.Execute();
            }
            
        }

    }


}
