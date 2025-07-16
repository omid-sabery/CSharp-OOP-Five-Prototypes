using FivePrototypes;

namespace FivePrototypes
{
    // Possible door states
    enum DoorStatus { Open, Closed, Locked }

    // Simulates a door with passcode protection and state management
    internal class Door
    {
        private int _passCode;
        private DoorStatus _currentStatus;

        // Current status of the door
        public DoorStatus CurrentStatus {
            get { return _currentStatus; }
        }

        // Initialize door with a passcode
        public Door(int passCode)
        {
            _passCode = passCode;
        }

        // Change the passcode if the current one is correct
        public void ResetPassCode(int currentPassCode, int newPassCode)
        {
            if (currentPassCode == _passCode)
            {
                _passCode = newPassCode;
            } else
            {
                Console.WriteLine("The passcode entered was wrong!");
            }
        }

        // Close the door if not locked
        public void Close()
        {
            if (_currentStatus != DoorStatus.Locked)
            {
                _currentStatus = DoorStatus.Closed;
                Console.WriteLine("The door was closed.");
            }
            else
            {
                Console.WriteLine("The door is locked!");
            }
        }

        // Open the door if not locked
        public void Open()
        {
            if (_currentStatus != DoorStatus.Locked)
            {
                _currentStatus = DoorStatus.Open;
                Console.WriteLine("The door was opened.");
            }
            else
            {
                Console.WriteLine("The door is locked!");
            }
        }

        // Lock the door
        public void Lock()
        {   
            if (_currentStatus != DoorStatus.Locked)
            {
                _currentStatus = DoorStatus.Locked;
                Console.WriteLine("The door was locked.");
            } else
            {
                Console.WriteLine("The door is already locked.");
            }
        }

        // Unlock the door if passcode is correct
        public void Unlock(int currentPassCode)
        {
            if (_currentStatus != DoorStatus.Locked)
            {
                Console.WriteLine("The door is not locked!");
            }
            else if (currentPassCode == _passCode)
            {
                _currentStatus = DoorStatus.Closed;
                Console.WriteLine("Unlocked successfully.");
            } else
            {
                Console.WriteLine("The passcode was wrong.");
            }
        }

        // Interactive menu for door operations
        public void Run()
        {
            while (true)
            {
                Console.WriteLine($"\nCurrent Door Status: {_currentStatus}");
                Console.WriteLine("1-Open\t2-Close\t3-Lock\t4-Unlock\t5-Reset Passcode\t6-Exit");
                Console.Write("Command: ");
                string command = Console.ReadLine()?.Trim() ?? "";

                switch (command)
                {
                    case "1":
                        Open();
                        break;
                    case "2":
                        Close();
                        break;
                    case "3":
                        Lock();
                        break;
                    case "4":
                        Console.Write("Enter passcode: ");
                        if (int.TryParse(Console.ReadLine(), out int unlockCode))
                            Unlock(unlockCode);
                        else
                            Console.WriteLine("Invalid input.");
                        break;
                    case "5":
                        Console.Write("Enter current passcode: ");
                        if (!int.TryParse(Console.ReadLine(), out int currentCode)) break;

                        Console.Write("Enter new passcode: ");
                        if (!int.TryParse(Console.ReadLine(), out int newCode)) break;

                        ResetPassCode(currentCode, newCode);
                        break;
                    case "6":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
            }
        }
    }
}
