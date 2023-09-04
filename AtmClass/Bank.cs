

namespace Task_cs.AtmClass
{
    internal partial class Bank
    {
        public User[] users;


        public Bank(User[] users)
        {
            this.users = users;
        }

        public partial User AddUser(User user);
        public partial void UserBalance(int index);
        public partial bool CashMoney(decimal money, int index);
        public partial void UserNameSurname(int index);

        public string UserPin(int index) => users[index].CardPin;
        public string UserPan(int index) => users[index].CardPan;

    }
    internal partial class Bank
    {
        public partial User AddUser(User user)
        {
            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = user;
            return user;
        }
        public partial void UserBalance(int index)
        {
            Console.Write("\n\n\t\t\t\tSizin balansiniz: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(users[index].CardBalance);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public partial bool CashMoney(decimal money, int index)
        {
            if (money <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Mebleg 0 AZN-den boyuk olmalidir!!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Thread.Sleep(1050);
                return false;
            }
            else
            {
                if (users[index].CardBalance - money >= 0)
                {
                    users[index].CreditCard!.BALANS -= money;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Emeliyyat ugurludur!!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    return true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Secdiyiniz mebleg limiti kecir!!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(1050);
                    return false;
                }
            }
        }
        public partial void UserNameSurname(int index)
        {
            Console.Write("\n\n\t\t\t\t\t" + users[index].Name + " " + users[index].Surname);
        }
    }
}

