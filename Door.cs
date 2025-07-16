using FivePrototypes;

namespace FivePrototypes
{
    enum DoorStatus { Open, Closed, Locked}
    internal class Door
    {
        // Fields
        private int _passCode;
        private DoorStatus _currentStatus;
        // Properties
        
        public DoorStatus CurrentStatus {
            get { return _currentStatus; }
        }
        // Constructor
        public Door(int passCode)
        {
            _passCode = passCode;
        }
        // Methods
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

        public void Lock()
        {   if (_currentStatus != DoorStatus.Locked)
            {
                _currentStatus = DoorStatus.Locked;
                Console.WriteLine("The door was locked.");
            } else
            {
                Console.WriteLine("The door is already locked.");
            }
        }

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

        // Public method to run your menu loop
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
