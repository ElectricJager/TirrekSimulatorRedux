using System;

namespace TirrekSimulatorRedux
{
    class Program
    {
        static Random rand = new Random();

        static int health = 10, maxHealth = 20, hunger = 11, thirst = 11, kekoluk = 0, maxKekoluk = 100, day = 0;
        static double money = 5;
        static bool endDay = false;

        static void Main(string[] args)
        {
            SplashScreen();
            while (true)
            {
                endDay = false;
                NewDay();
                Check.Hunger();
                Check.Thirst();
                while (true)
                {
                    if (endDay)
                        break;
                    switch (Selection())
                    {
                        case 1:
                            Stroll.Start();
                            break;
                        case 2:
                            Squat();
                            break;
                        case 3:
                            Stores.Bim();
                            break;
                        case 4:
                            Stores.Donerci();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        
        static void SplashScreen()
        {
            Console.WriteLine("Tirrek Simulator Redux\nElectricJager 2021\n");
        }

        static void NewDay()
        {
            
            day++;
            hunger--;
            thirst--;

            Check.StatusVerbose();
            Console.WriteLine("\nBugün ne bok yicen?");
        }
        
        static int Selection()
        {
            while (true)
            {
                Console.WriteLine("[1] Yürü, [2] Semt oturuşu yap, [3] Bim'e git, [4] Dönerciye git");
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.KeyChar)
                {
                    case '1':
                        return 1;
                    case '2':
                        return 2;
                    case '3':
                        return 3;
                    case '4':
                        return 4;
                    default:
                        Console.WriteLine("\nNe dion amk");
                        break;
                }
            }
        }
        
        static void Squat()
        {
            Console.WriteLine("\nSemt oturuşu yaptın\n+2 Can");
            health += 2;
            Check.Health();
            endDay = true;
        }
        class Stroll
        {
            internal static void Start()
            {
                Console.WriteLine("\n");
                int bias = (kekoluk / 5) + 30;
                int rng = rand.Next(0, 101);
                if (rng < 30)
                {
                    Encounter.Rich();
                }
                else if (rng >= bias && rng < 70)
                {
                    Encounter.Stranger();
                }
                else
                {
                    Encounter.Keko();
                }
                endDay = true;
            }

            class Encounter
            {
                internal static void Keko()
                {
                    Console.WriteLine("Yanından bir keko geçiyor\nNe yapacaksın?");
                    while (true)
                    {
                        Console.WriteLine("[1] Yanından yürü, [2] 50 kuruş iste, [3] Tüm parasını al");
                        ConsoleKeyInfo input = Console.ReadKey();
                        Console.WriteLine("\n");
                        switch (input.KeyChar)
                        {
                            case '1':
                                Console.WriteLine("Kekonun yanından geçtin");
                                return;
                            case '2':
                                Console.WriteLine("Kekodan 50 kuruş istenir mi amk suıdhguıjlsdg");
                                return;
                            case '3':
                                FightOutcome(0);
                                return;
                            default:
                                Console.WriteLine("Ne dion amk");
                                break;
                        }
                    }
                }

                internal static void Stranger()
                {
                    Console.WriteLine("Yanından biri geçiyor\nNe yapacaksın?");
                    while (true)
                    {
                        Console.WriteLine("[1] Yanından yürü, [2] 50 kuruş iste, [3] Tüm parasını al");
                        ConsoleKeyInfo input = Console.ReadKey();
                        Console.WriteLine("\n");
                        switch (input.KeyChar)
                        {
                            case '1':
                                Console.WriteLine("Adamın yanından geçtin");
                                return;
                            case '2':
                                if (rand.Next(0, 2) == 0)
                                {
                                    Console.WriteLine("50 Kuruş kazandın");
                                    money += 0.5;
                                }
                                else
                                    TakeMoney();
                                return;
                            case '3':
                                FightOutcome(1);
                                return;
                            default:
                                Console.WriteLine("Ne dion amk");
                                break;
                        }
                    }
                }

                internal static void Rich()
                {
                    Console.WriteLine("Yanından zengin biri geçiyor\nNe yapacaksın?");
                    while (true)
                    {
                        Console.WriteLine("[1] Yanından yürü, [2] 50 kuruş iste, [3] Tüm parasını al");
                        ConsoleKeyInfo input = Console.ReadKey();
                        Console.WriteLine("\n");
                        switch (input.KeyChar)
                        {
                            case '1':
                                Console.WriteLine("Adamın yanından geçtin");
                                return;
                            case '2':
                                    Console.WriteLine("50 Kuruş kazandın");
                                    money += 0.5;
                                return;
                            case '3':
                                FightOutcome(2);
                                return;
                            default:
                                Console.WriteLine("Ne dion amk");
                                break;
                        }
                    }
                }

                static bool KnifeChance(int opponent)
                {
                    int bias = 5;
                    if (opponent == 0)
                        bias = 2;
                    switch (rand.Next(0, bias))
                    {
                        case 0:
                            return true;
                        default:
                            return false;
                    }
                }

                static void FightOutcome(int opponent)
                {
                    bool knife = KnifeChance(opponent);
                    if (Run(knife))
                        return;
                    int bias = (kekoluk / 5) + 70;
                    if (knife)
                        bias -= 50;
                    if (opponent == 0)
                        bias -= 10;
                    if (rand.Next(0, 101) > bias)
                    {
                        if (knife)
                        {
                            Console.WriteLine("Bıçaklandın\n-10 Can");
                            health -= 10;
                            Check.Health();
                        }
                        else
                        {
                            Console.WriteLine("Dayak yedin\n-2 Can");
                            health -= 2;
                            Check.Health();
                        }
                    }
                    else
                    {
                        int maxMoney = 50;
                        int minMoney = 5;
                        int moneyEarned;
                        if (opponent == 0)
                            maxMoney = 20;
                        else if (opponent == 2)
                        {
                            maxMoney = 200;
                            minMoney = 20;
                        }
                        moneyEarned = rand.Next(minMoney, maxMoney + 1);
                        Console.WriteLine($"{moneyEarned}TL kazandın");
                        money += moneyEarned;
                    }
                }

                static void TakeMoney()
                {
                    Console.WriteLine("Çocuk: \"Abi minibüs param :( Lütfen alma\"");
                    while (true)
                    {
                        Console.WriteLine("[1] Çocuğa acı parayı alma, [2] Piçlik yap parayı al");
                        ConsoleKeyInfo input = Console.ReadKey();
                        Console.WriteLine("\n");
                        switch (input.KeyChar)
                        {
                            case '1':
                                Console.WriteLine("Adamsın lan bak gözlerim doldu");
                                return;
                            case '2':
                                Console.WriteLine("Yazık değilmi çocuğa amk kekosu al bu 50 krsu götüne sok");
                                money += 0.5;
                                return;
                            default:
                                Console.WriteLine("Ne dion amk");
                                break;
                        }
                    }
                }

                static bool Run(bool knife)
                {
                    
                    while (true)
                    {
                        if (knife)
                            Console.WriteLine("Adam Bıçak çekti\nNe yapacaksın");
                        else
                            Console.WriteLine("Adam kavgaya hazırlanıyor\nNe yapacaksın");
                        Console.WriteLine("[1] Kavga et, [2] Özür dile ve uzaklaş");
                        ConsoleKeyInfo input = Console.ReadKey();
                        Console.WriteLine("\n");
                        switch (input.KeyChar)
                        {
                            case '1':
                                return false;
                            case '2':
                                return true;
                            default:
                                Console.WriteLine("Ne dion amk");
                                break;
                        }
                    }
                }
            }
        }
        class Stores
        {
            internal static void Bim()
            {
                Console.WriteLine("\nBim'e gittin\n");
                while (true)
                {
                    Console.WriteLine("[1] Topkek 3TL\n(+1 Açlık)\n\n[2] Çiğküfte 3TL\n(+2 Açlık -1 Can)\n\n[3] Şişe su 3TL (oha amk)\n(+1 Susuzluk)\n\n[4]Bim'den çık");
                    ConsoleKeyInfo input = Console.ReadKey();
                    switch (input.KeyChar)
                    {
                        case '1':
                            if (Check.Money(3))
                            {
                                Console.WriteLine("\nTopkek alındı");
                                money -= 3;
                                hunger++;
                                Check.Status();
                            }
                            break;
                        case '2':
                            if (Check.Money(3))
                            {
                                Console.WriteLine("\nÇiğküfte alındı");
                                money -= 3;
                                hunger += 2;
                                health--;
                                Check.Health();
                                Check.Status();
                            }
                            break;
                        case '3':
                            if (Check.Money(3))
                            {
                                Console.WriteLine("\nŞişe su alındı");
                                money -= 3;
                                thirst++;
                                Check.Status();
                            }
                            break;
                        case '4':
                            Console.WriteLine("\nBim'den çıktın");
                            return;
                        default:
                            Console.WriteLine("\nNe dion amk");
                            break;
                    }
                }
            }

            internal static void Donerci()
            {
                Console.WriteLine("\nDönerciye gittin\n");
                while (true)
                {
                    Console.WriteLine("[1] Tavuk döner 6TL\n(+2 Açlık, +1 Can)\n\n[2] Et döner 9TL\n(+3 Açlık +2 Can)\n\n" +
                        "[3] Ayran 6TL\n(+2 Susuzluk, +1 Can)\n\n[4] Şıra 9TL\n(+3 Susuzluk, +2 Can)\n\n[5]Dönerciden çık");
                    ConsoleKeyInfo input = Console.ReadKey();
                    switch (input.KeyChar)
                    {
                        case '1':
                            if (Check.Money(6))
                            {
                                Console.WriteLine("\nTavuk döner alındı");
                                money -= 6;
                                hunger += 2;
                                health++;
                                Check.Health();
                                Check.Status();
                            }
                            break;
                        case '2':
                            if (Check.Money(9))
                            {
                                Console.WriteLine("\nEt Döner alındı");
                                money -= 9;
                                hunger += 3;
                                health += 2;
                                Check.Health();
                                Check.Status();
                            }
                            break;
                        case '3':
                            if (Check.Money(6))
                            {
                                Console.WriteLine("\nAyran alındı");
                                money -= 6;
                                thirst += 2;
                                health++;
                                Check.Health();
                                Check.Status();
                            }
                            break;
                        case '4':
                            if (Check.Money(9))
                            {
                                Console.WriteLine("\nŞıra alındı");
                                money -= 9;
                                thirst += 3;
                                health += 2;
                                Check.Health();
                                Check.Status();
                            }
                            break;
                        case '5':
                            Console.WriteLine("\nDönerciden çıktın");
                            return;
                        default:
                            Console.WriteLine("\nNe dion amk");
                            break;
                    }
                }
            }
        }
        class Check
        {
            internal static void Health()
            {
                if (health > maxHealth)
                    health = maxHealth;
                else if (health <= 0)
                    Death();
            }

            internal static void Hunger()
            {
                if (hunger <= 0)
                    Death();
            }

            internal static void Thirst()
            {
                if (thirst <= 0)
                    Death();
            }
            internal static bool Money(int x)
            {
                if (money - x < 0)
                {
                    Console.WriteLine($"\nAmk fakiri {money} liran var sdjahguıdashg");
                    return false;
                }
                return true;
            }

            internal static void Status()
            {
                Console.WriteLine($"\n{money} liran var\nCanın: {health}/{maxHealth}\nAçlık: {hunger}\nSusuzluk: {thirst}\n");
            }

            internal static void StatusVerbose()
            {
                Console.WriteLine($"{day}. gün  {money} liran var\nCanın: {health}/{maxHealth}\nAçlık: {hunger}\nSusuzluk: {thirst}\nKekoluk seviyen: {kekoluk}");
            }

            static void Death()
            {
                Console.WriteLine("Öldün mk\nF\nÇıkmak için herhangi bir tuşa bas");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
        }
    }
}
