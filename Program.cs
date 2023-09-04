using Task_cs.AtmClass;
using Task_cs;

void Menu(byte choose, Bank bank, int index)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    bank.UserNameSurname(index);
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine($" xos gelmisiniz,\n\t\t\t\t zehmet olmasa emeliyyatlardan birini secin;\n");
    
    if (choose == 1)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n\t\t\t\t\t=>1.Balans");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\t\t\t\t\t2.Nagd pul");
        Console.WriteLine("\t\t\t\t\t3.Kartdan karta kocurme ");
        Console.WriteLine("\t\t\t\t\t4.Edilen emeliyyatlar");
        Console.WriteLine("\t\t\t\t\t5.Geri");
    }
    else if (choose == 2)
    {
        Console.WriteLine("\n\t\t\t\t\t1.Balans");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\t\t\t\t\t=>2.Nagd pul");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\t\t\t\t\t3.Kartdan karta kocurme ");
        Console.WriteLine("\t\t\t\t\t4.Edilen emeliyyatlar");
        Console.WriteLine("\t\t\t\t\t5.Geri");
    }
    else if (choose == 3)
    {
        Console.WriteLine("\n\t\t\t\t\t1.Balans");
        Console.WriteLine("\t\t\t\t\t2.Nagd pul");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\t\t\t\t\t=>3.Kartdan karta kocurme ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\t\t\t\t\t4.Edilen emeliyyatlar");
        Console.WriteLine("\t\t\t\t\t5.Geri");
    }
    else if (choose == 4)
    {
        Console.WriteLine("\n\t\t\t\t\t1.Balans");
        Console.WriteLine("\t\t\t\t\t2.Nagd pul");
        Console.WriteLine("\t\t\t\t\t3.Kartdan karta kocurme ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\t\t\t\t\t=>4.Edilen emeliyyatlar");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\t\t\t\t\t5.Geri");
    }
    else if (choose == 5)
    {
        Console.WriteLine("\n\t\t\t\t\t1.Balans");
        Console.WriteLine("\t\t\t\t\t2.Nagd pul");
        Console.WriteLine("\t\t\t\t\t3.Kartdan karta kocurme ");
        Console.WriteLine("\t\t\t\t\t4.Edilen emeliyyatlar");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\t\t\t\t\t=>5.Geri");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}

void MenuNagdPul(byte choose,ref Bank bank, int index)
{
    Console.Clear();
    bank.UserBalance(index);

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\n\t\t\t\t\tMebleg secin;");
    Console.ForegroundColor = ConsoleColor.Gray;
    if (choose == 1)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n\t\t\t\t\t=>1.10 AZN");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\t\t\t\t\t2.20 AZN");
        Console.WriteLine("\t\t\t\t\t3.50 AZN ");
        Console.WriteLine("\t\t\t\t\t4.100 AZN");
        Console.WriteLine("\t\t\t\t\t5.Diger");
    }
    else if (choose == 2)
    {
        Console.WriteLine("\n\t\t\t\t\t1.10 AZN");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\t\t\t\t\t=>2.20 AZN");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\t\t\t\t\t3.50 AZN ");
        Console.WriteLine("\t\t\t\t\t4.100 AZN");
        Console.WriteLine("\t\t\t\t\t5.Diger");
    }
    else if (choose == 3)
    {
        Console.WriteLine("\n\t\t\t\t\t1.10 AZN");
        Console.WriteLine("\t\t\t\t\t2.20 AZN");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\t\t\t\t\t=>3.50 AZN ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\t\t\t\t\t4.100 AZN");
        Console.WriteLine("\t\t\t\t\t5.Diger");
    }
    else if (choose == 4)
    {
        Console.WriteLine("\n\t\t\t\t\t1.10 AZN");
        Console.WriteLine("\t\t\t\t\t2.20 AZN");
        Console.WriteLine("\t\t\t\t\t3.50 AZN ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\t\t\t\t\t=>4.100 AZN");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\t\t\t\t\t5.Diger");
    }
    else if (choose == 5)
    {
        Console.WriteLine("\n\t\t\t\t\t1.10 AZN");
        Console.WriteLine("\t\t\t\t\t2.20 AZN");
        Console.WriteLine("\t\t\t\t\t3.50 AZN ");
        Console.WriteLine("\t\t\t\t\t4.100 AZN");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\t\t\t\t\t=>5.Diger");
        Console.ForegroundColor = ConsoleColor.Gray;
    }

}



/// Main()

User[] users = new User[]
{
    new User("Nezrin","Quliyeva",new Card("Kapital","1234567890123456","1234","123",new DateTime(2025,9,15),125.63M)),
    new User("Ali","Aliyev",new Card("Kapital","1212121212121212","2222","222",new DateTime(2025,9,15),100.32M)),
    new User("Aynur","Abbasova",new Card("Kapital","1234123412341234","3333","333",new DateTime(2025,9,15),134.63M)),
    new User("Ulvi","Esedzade",new Card("Kapital","7845784578457845","5555","555",new DateTime(2025,9,15),94.25M)),
    new User("Akif","Veliyev",new Card("Kapital","2356235623562356","7777","777",new DateTime(2025,9,15),79.45M)),
};

Bank bank = new Bank(users);
bank.AddUser(new User("Sema", "Tehmezova", new Card("Kapital", "1234567890123456", "1111", "123", new DateTime(2025, 9, 15), 154.56M)));


dynamic select_1, select_2,SelectNagd;
string? pin;
byte choose = 1,ChooseNagd=1;
int saveIndex = 0;
bool checkPin, check_1,CheckNagd;
List<string> processList=new List<string>();//emeliyyatlarin siyahisi
while (true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write("\n\n\t\t\t\t\tPIN kodu daxil edin:");
    pin = Console.ReadLine();
    checkPin = false;
    for (int i = 0; i < bank.users.Length; i++)
    {
        if (pin == bank.UserPin(i))
        {
            saveIndex = i;
            checkPin = true;
            break;
        }
    }
    if (!checkPin)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("PIN yanlisdir!!");
        Thread.Sleep(1200);
        continue;

    }
    Menu(choose, bank, saveIndex);
    check_1 = true;
    while (check_1)
    {
        select_1 = Console.ReadKey();
        if (select_1.Key == ConsoleKey.UpArrow)
        {
            if (choose == 1) choose = 5;
            else choose--;
            Menu(choose, bank, saveIndex);
        }
        else if (select_1.Key == ConsoleKey.DownArrow)
        {
            if (choose == 5) choose = 1;
            else choose++;
            Menu(choose, bank, saveIndex);
        }
        else if (select_1.Key == ConsoleKey.Enter)
        {

            if (choose == 5)//geri
            {
                check_1 = false;
                processList.Clear();    
                break;
            }

            if (choose == 1)//balans
            {
                Console.Clear();
                bank.UserBalance(saveIndex);
                processList.Add("Balansa baxis"+"       "+DateTime.Now.ToString());
            }
            else if (choose == 2)//nagd pul
            {
                CheckNagd = true;
                MenuNagdPul(ChooseNagd,ref bank,saveIndex);
                while (CheckNagd)
                {
                    SelectNagd = Console.ReadKey();
                    if(SelectNagd.Key == ConsoleKey.UpArrow)
                    {
                        if(ChooseNagd == 1) ChooseNagd = 5;
                        else ChooseNagd--;
                        MenuNagdPul(ChooseNagd, ref bank, saveIndex);
                    }
                    else if (SelectNagd.Key == ConsoleKey.DownArrow)
                    {
                        if(ChooseNagd==5) ChooseNagd=1;
                        else ChooseNagd++;
                        MenuNagdPul(ChooseNagd, ref bank, saveIndex);
                    }
                    else if(SelectNagd.Key == ConsoleKey.Enter)
                    {
                        if (ChooseNagd == 1) bank.CashMoney(10, saveIndex);//10 AZN cix
                        else if (ChooseNagd == 2) bank.CashMoney(20, saveIndex);// 20 AZN cix
                        else if (ChooseNagd == 3) bank.CashMoney(50, saveIndex);//50 AZN cix
                        else if (ChooseNagd == 4) bank.CashMoney(100, saveIndex);//100 AZN cix
                        else if (ChooseNagd == 5)
                        {
                            Console.Clear();
                            bank.UserBalance(saveIndex);
                            Console.Write("\n\t\t\t\t\tMebleg daxil edin: ");
                            decimal other = Convert.ToDecimal(Console.ReadLine());
                            bank.CashMoney(other, saveIndex);
                        }
                        CheckNagd = false;
                    }
                }
                processList.Add("Nagd pul " + "       " + DateTime.Now.ToString());
            }
            else if (choose == 3)//kartdan karta
            {
                 bool checkPan,CardToCard=true;
                while (CardToCard)
                {
                    checkPan = false;
                    Console.Clear();bank.UserBalance(saveIndex);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    
                    Console.Write("\n\t\t\t\t\tSizin kartiniz: ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(bank.UserPan(saveIndex));
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n\t\t\t\t\tKocurme edeceyiniz kartin nomresi: ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    string? pan = Console.ReadLine();
                    //PAN yoxlamaq- yanlis olarsa yeniden yazilsin
                    int save=0;
                    for (int i = 0; i < bank.users.Length; i++)
                    {
                        if (bank.UserPan(i) == pan)
                        {
                            save = i;
                            checkPan = true;
                            break;
                        }
                    }
                    if (!checkPan)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Istifadeci tapilmadi!!");
                        Thread.Sleep(1200);
                        continue;
                    }
                    //Mebleg yanlis olarsa yeniden yazilsin
                    decimal other;
                    while (true)
                    {
                        Console.Clear();bank.UserBalance(saveIndex);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        
                        Console.Write("\n\t\t\t\t\tSizin kartiniz: ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(bank.UserPan(saveIndex));
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\n\t\t\t\t\tKocurme edeceyiniz kartin nomresi: ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(pan);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\n\t\t\t\t\tMebleg daxil edin: ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                         other = Convert.ToDecimal(Console.ReadLine());
                        bool Cash=bank.CashMoney(other, saveIndex);
                        if (Cash) break;
                    }
                    bank.users[save].CreditCard!.BALANS += other;
                    CardToCard = false;
                }
                processList.Add("Kartdan karta kocurulme" + "       " + DateTime.Now.ToString());
            }
            else if (choose == 4)//emeliyyatlar
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("-- Emelliyyatlarin siyahisi --");
                Console.ForegroundColor = ConsoleColor.Yellow;
                foreach (var item in processList)
                {
                    Console.WriteLine(item);
                }
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine("\nGeri qayitmaq ucun ENTER secin...");
            select_2 = Console.ReadKey();
            if (select_2.Key == ConsoleKey.Enter) Menu(choose, bank, saveIndex);

        }

    }




}