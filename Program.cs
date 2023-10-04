using System;
using System.Collections.Generic;


/*
БИЛЕТ # 7 gen(15:44:36.6697030)
ДО ЗАСУХИ: 13 дней
Колония<черные> популяция: рабочих= 17, воинов= 8, особенных= 1;
Королева<Клеопатра>(здоровье = 29, защита = 7, урон = 28), цикл роста личинок 2-4 дней, может создать 3-4 королев; 
- < продвинутый > РАБОЧИЙ(здоровье = 6, защита = 2) может брать 2 ресурса: 'камушек или веточка' за раз.
      - <элитный спринтер> РАБОЧИЙ(здоровье= 8, защита= 4) может брать 2 ресурса: 'листик и росинка' за раз; не может быть атакован первым.
- <легендарный> ВОИН(здоровье=10, защита = 6, урон = 6) может атаковать 3 цели за раз и наносит 1 укус.
- <легендарный щитоносец> ВОИН(здоровье=10, защита = 6, урон = 6) может атаковать 3 цели за раз и наносит 1 укус; защита увеличена в двое.
Особенное насекомое <трудолюбивый неуязвимый агрессивный трусливый карманник - Стрекоза>(здоровье=29, защита = 8, урон = 7): может брать ресурсы (1 ресурс: камушек); не может быть атакован войнами; атакует врагов(3 цели за раз и наносит 3 укуса); если кто то из союзников получил урон то не атакует; если нет доступного ресурса в куче, может украсть его у врага. 

Колония <рыжие> популяция: рабочих = 18, воинов = 7, особенных = 1;
Королева<Жозефина>(здоровье = 22, защита = 9, урон = 20), цикл роста личинок 2-4 дней, может создать 3-3 королев;
- < легендарный > РАБОЧИЙ(здоровье = 10, защита = 6) может брать 3 ресурса: 'росинка и камушек и камушек' за раз.
      - <легендарный спринтер> РАБОЧИЙ(здоровье= 10, защита= 6) может брать 3 ресурса: 'росинка и росинка и листик' за раз; не может быть атакован первым.
- <легендарный> ВОИН(здоровье=10, защита = 6, урон = 6) может атаковать 3 цели за раз и наносит 1 укус. 
- <элитный щитоносец> ВОИН(здоровье=8, защита = 4, урон = 4) может атаковать 2 цели за раз и наносит 2 укуса; защита увеличена в двое. 
Особенное насекомое <ленивый неуязвимый мирный заботливый - Скарабей>(здоровье=15, защита = 6): не может брать ресурсы; не может быть атакован войнами; зашита всех в походе увеличена в двое.

Колония <красные> популяция: рабочих = 11, воинов = 9, особенных = 1;
Королева<Рогнеда>(здоровье = 17, защита = 5, урон = 28), цикл роста личинок 3-4 дней, может создать 1-5 королев;
- < обычный > РАБОЧИЙ(здоровье = 1, защита = 0) может брать 1 ресурс: 'веточка' за раз.
      - <обычный капризный> РАБОЧИЙ(здоровье= 1, защита= 0) может брать 1 ресурс: 'листик' за раз; игнорирует каждый 2й поход.
- <старший> ВОИН(здоровье=2, защита = 1, урон = 2) может атаковать 1 цель за раз и наносит 1 укус.
- <элитный трусливый> ВОИН(здоровье=8, защита = 4, урон = 4) может атаковать 2 цели за раз и наносит 2 укуса; если кто то из союзников получил урон то не атакует.
Особенное насекомое <трудолюбивый обычный агрессивный сержант марафонец - Пчела>(здоровье=25, защита = 6, урон = 9): может брать ресурсы (3 ресурса: любой); может быть атакован войнами; атакует врагов(2 цели за раз и наносит 3 укуса); если атакует первый в походе, то убивает с одного укуса любое насекомое даже неуязвимое; после смерти все равно доставляет ресурс в колонию.

Список Куч:
Куча 1 ресурсы: веточка: 24; листик: 23; камушек: 45;
Куча 2 ресурсы: веточка: 41; листик: 45; камушек: 14;
Куча 3 ресурсы: веточка: 22; росинка: 26;
Куча 4 ресурсы: веточка: 20; листик: 12; камушек: 22; росинка: 26;
Куча 5 ресурсы: веточка: 35; камушек: 16;

ДОПОЛНИТЕЛЬНОЕ ЗАДАНИЕ
Появляется <Землеройка> на '6' дней c эффектом (происходит один раз в любой день в течении периода): Цикл королев сокращается до 1 дня
-------------------------------------------------------------------------------
*/


namespace AntsProg
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Ant> ants1 = new List<Ant>();
            List<Ant> ants2 = new List<Ant>();
            List<Ant> ants3 = new List<Ant>();
            Colony colony1 = new Colony(1, "черные", ants1);
            Colony colony2 = new Colony(2, "рыжие", ants2);
            Colony colony3 = new Colony(3, "красные", ants3);

            for (int i = 0; i < 17; i++)
            {
                Ant ant = new Worker(colony1.AbleTypesOfWorkers[random.Next(colony1.AbleTypesOfWorkers.Count)]);
                ants1.Add(ant);
            }
            for (int i = 0; i < 8; i++)
            {
                Ant ant = new Soldier(colony1.AbleTypesOfSoldiers[random.Next(colony1.AbleTypesOfSoldiers.Count)]);
                ants1.Add(ant);
            }
            Ant ant1 = new Special("трудолюбивый неуязвимый агрессивный трусливый карманник - Стрекоза");
            Ant ant2 = new QueenAnt("Клеопатра", 29, 7, 28, 2, 4, 3, 4);
            ants1.Add(ant1);
            ants1.Add(ant2);
            for (int i = 0; i < 18; i++)
            {
                Ant ant = new Worker(colony2.AbleTypesOfWorkers[random.Next(colony2.AbleTypesOfWorkers.Count)]);
                ants2.Add(ant);
            }
            for (int i = 0; i < 7; i++)
            {
                Ant ant = new Soldier(colony2.AbleTypesOfSoldiers[random.Next(colony2.AbleTypesOfSoldiers.Count)]);
                ants2.Add(ant);
            }
            Ant ant3 = new Special("ленивый неуязвимый мирный заботливый - Скарабей");
            Ant ant4 = new QueenAnt("Жозефина", 22, 9, 20, 2, 4, 3, 3);
            ants2.Add(ant3);
            ants2.Add(ant4);
            for (int i = 0; i < 11; i++)
            {
                Ant ant = new Worker(colony3.AbleTypesOfWorkers[random.Next(colony3.AbleTypesOfWorkers.Count)]);
                ants3.Add(ant);
            }
            for (int i = 0; i < 9; i++)
            {
                Ant ant = new Soldier(colony3.AbleTypesOfSoldiers[random.Next(colony3.AbleTypesOfSoldiers.Count)]);
                ants3.Add(ant);
            }
            Ant ant5 = new Special("трудолюбивый обычный агрессивный сержант марафонец - Пчела");
            Ant ant6 = new QueenAnt("Рогнеда", 17, 5, 28, 3, 4, 1, 5);
            ants3.Add(ant5);
            ants3.Add(ant6);

            List<Colony> colonies = new List<Colony>();
            colonies.Add(colony1);
            colonies.Add(colony2);
            colonies.Add(colony3);
            Stack stack1 = new Stack(0, 23, 45, 24, 0);
            Stack stack2 = new Stack(1, 45, 14, 41, 0);
            Stack stack3 = new Stack(2, 0, 0, 22, 26);
            Stack stack4 = new Stack(3, 12, 22, 20, 26);
            Stack stack5 = new Stack(4, 0, 16, 35, 0);
            List<Stack> stacks = new List<Stack>();
            stacks.Add(stack1);
            stacks.Add(stack2);
            stacks.Add(stack3);
            stacks.Add(stack4);
            stacks.Add(stack5);
            List<Colony> TempColonies = new List<Colony>();

            int shew = 6;
            int randdayofshew = random.Next(World.dayofdrought);
            while (World.dayscount < World.dayofdrought)
            {
                Console.WriteLine($"До засухи дней: {World.dayofdrought - World.dayscount}");
                int firstattack = 0;
                World.dayscount++;
                if (World.dayscount >= randdayofshew && shew > 0)
                {
                    shew--;
                    Console.WriteLine($"До окончания эффекта землеройки дней: {shew}");
                    foreach (var colony in colonies)
                    {
                        foreach (var ant in colony.ants)
                        {
                            if (ant.Class == "queen")
                            {
                                ((QueenAnt)ant).larvacyclenow = 1;
                            }
                        }
                    }
                }
                var camp = Campaign(colonies, stacks);
                foreach (var colony in colonies)
                {
                    foreach (var ant in colony.ants)
                    {
                        ant.Grab(camp, colony, stacks);
                        if (ant.ifnoneededresinstack == true && ant.stone == 0)
                        {
                            foreach (var col in camp)
                            {
                                foreach (var antie in col.Item2[ant.campstacknum])
                                {
                                    if (antie.stone > 0)
                                    {
                                        antie.stone -= 1;
                                        ant.stone += 1;
                                    }
                                }
                            }
                        }
                    }
                }
                foreach (var colony in colonies)
                {
                    for (int i = 0; i < colony.ants.Count; i++)
                    {
                        firstattack++;
                        if (colony.ants[i].hp > 0 && colony.ants[i].Class != "queen" && colony.ants[i].damage > 0 && !(colony.ants[i].ifallyharmednotattack == true && colony.allyharmed == true))
                        {
                            colony.ants[i].attack(camp, colonies, colony);
                        }
                        if (colony.ants[i].hp <= 0)
                        {
                            int colonyindex;
                            for (int k = 0; k < camp.Count; k++)
                            {
                                if (camp[k].Item1 == colony)
                                {
                                    colonyindex = k;
                                    camp[colonyindex].Item2[colony.ants[i].campstacknum].Remove(colony.ants[i]);
                                }
                            }
                            colony.ants.Remove(colony.ants[i]);
                            i--;
                        }
                    }
                }
                foreach (var colony in colonies)
                {
                    foreach (var ant in colony.ants)
                    {
                        ant.Put(colony);
                    }
                }

                    foreach (var colony in colonies)
                {
                    string QueenName = "XXXXXXXXXXX";
                    int workercount = 0;
                    int soldiercount = 0;
                    int specialcount = 0;
                    foreach (var ant in colony.ants)
                    {
                        if (ant.Class == "queen")
                        {
                            QueenName = ((QueenAnt)ant).QueenName;
                        }
                        else if (ant.Class == "worker")
                        {
                            workercount++;
                        }
                        else if (ant.Class == "soldier")
                        {
                            soldiercount++;
                        }
                        else if (ant.Class == "special")
                        {
                            specialcount++;
                        }
                    }
                    colony.allyharmed = false;
                    Console.WriteLine($"{colony.ColonyColor} королева: {QueenName}  население: {colony.ants.Count} рабочих: {workercount} солдат: {soldiercount} особых: {specialcount}  ресурсов: {colony.leaf + colony.stone + colony.branch + colony.dewdrop}");
                }
                Console.WriteLine("==========================================================");
                camp.Clear();

                foreach (var colony in colonies)
                {
                    Colony tempcolony = (Colony)colony.MemberwiseClone();
                    TempColonies.Add(tempcolony);
                }
                foreach (var colony in colonies)
                {
                    ((QueenAnt)ant2.FindAnt("queen", colony)).NewAnt(colony, TempColonies);
                }
                colonies.Clear();
                foreach (var colony in TempColonies)
                {
                    colonies.Add(colony);
                }
                TempColonies.Clear();
                ChoiceInTheEndOfTheDay(colonies);
            }

            Colony winner = colony3;
            foreach (var colony in colonies)
            {
                if (colony.leaf + colony.stone + colony.branch + colony.dewdrop > winner.leaf + winner.stone + winner.branch + winner.dewdrop)
                {
                    winner = colony;
                }
            }
            Console.WriteLine($"ПОБЕДИЛА КОЛОНИЯ КОРОЛЕВЫ {((QueenAnt)ant2.FindAnt("queen", winner)).QueenName}, у нее {winner.leaf + winner.stone + winner.branch + winner.dewdrop} ресурсов.");
        }
        static public void ChoiceInTheEndOfTheDay(List<Colony> colonies)
        {
            Console.WriteLine("Нажмите 'Enter' чтобы перейти к следующему дню, или 'info' чтобы получить больше информации.");
            string choice = Console.ReadLine();
            if (choice == "info")
            {
                ChoiceInTheEndOfTheDay1(colonies);
            }
            else if (choice != "")
            {
                Console.WriteLine("Я не знаю такой команды, попробуйте еще раз");
                ChoiceInTheEndOfTheDay(colonies);
            }
        }

        static public void ChoiceInTheEndOfTheDay1(List<Colony> colonies)
        {
            Console.WriteLine("Введите номер колонии, о которой хотите узнать");
            Console.WriteLine("Доступные колонии:");
            for (int i = 0; i < colonies.Count; i++)
            {
                Console.Write($"  {i}");
            }
            string choice = Console.ReadLine();
            if (int.Parse(choice) >= 0 && int.Parse(choice) < colonies.Count)
            {
                int colonychoice = int.Parse(choice);
                ChoiceInTheEndOfTheDay2(colonies, int.Parse(choice));
            }
            else
            {
                Console.WriteLine("Такой колонии нет, попробуйте еще раз");
                ChoiceInTheEndOfTheDay1(colonies);
            }
        }

        static public void ChoiceInTheEndOfTheDay2(List<Colony> colonies, int colonychoice)
        {
            Console.WriteLine();
            Console.WriteLine("Введите 'info' чтобы посмотреть информацию о колонии, введите 'worker' чтобы посмотреть информацию о отдельном рабочем, введите 'soldier' чтобы посмотреть информацию о отдельном воине, введите 'special' чтобы посмотреть информацию о специальном насекомомвведите, 'queen' чтобы посмотреть информацию о королеве.");
            Console.WriteLine("Если хотите перейти к новому дню, нажмите 'Enter'");
            string choice = Console.ReadLine();
            int count = 0;
            int antnum = 0;
            switch (choice)
            {
                case "info":
                    colonies[colonychoice].GetInfo();
                    ChoiceInTheEndOfTheDay2(colonies, colonychoice);
                    break;
                case "worker":
                    Console.WriteLine("Доступные рабочие: ");
                    for (int i = 0; i < colonies[colonychoice].ants.Count; i++)
                    {
                        if (colonies[colonychoice].ants[i].Class == "worker")
                        {
                            Console.WriteLine($"   {count}");
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine("Скорее всего в этой колонии не осталось муравьев этого типа, попробуйте что-нибудь еще.");
                        ChoiceInTheEndOfTheDay2(colonies, colonychoice);
                    }
                    else
                    {
                        ChoiceInTheEndOfTheDay3(colonies, colonychoice, choice);
                    }
                    break;
                case "soldier":
                    Console.WriteLine("Доступные воины: ");
                    for (int i = 0; i < colonies[colonychoice].ants.Count; i++)
                    {
                        if (colonies[colonychoice].ants[i].Class == "soldier")
                        {
                            Console.WriteLine($"   {count}");
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine("Скорее всего в этой колонии не осталось муравьев этого типа, попробуйте что-нибудь еще.");
                        ChoiceInTheEndOfTheDay2(colonies, colonychoice);
                    }
                    else
                    {
                        ChoiceInTheEndOfTheDay3(colonies, colonychoice, choice);
                    }
                    break;
                case "special":
                    foreach (var ant in colonies[colonychoice].ants)
                    {
                        if (ant.Class == "special")
                        {
                            count++;
                            ChoiceInTheEndOfTheDay3(colonies, colonychoice, choice);
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine("Скорее всего в этой колонии не осталось муравьев этого типа, попробуйте что-нибудь еще.");
                        ChoiceInTheEndOfTheDay2(colonies, colonychoice);
                    }
                    break;
                case "queen":
                    ChoiceInTheEndOfTheDay3(colonies, colonychoice, "queen");
                    break;
                case "":
                    break;
                default:
                    Console.WriteLine("Я не знаю такой команды, попробуйте еще раз.");
                    ChoiceInTheEndOfTheDay2(colonies, colonychoice);
                    break;
            }
        }
        
        static public void ChoiceInTheEndOfTheDay3(List<Colony> colonies, int colonychoice, string anttype)
        {
            int antnum = 0;
            if (anttype != "special" && anttype != "queen")
            {
                antnum = int.Parse(Console.ReadLine());
            }
            int count = 0;
            for (int i = 0; i < colonies[colonychoice].ants.Count; i++)
            {
                if (colonies[colonychoice].ants[i].Class == anttype)
                {
                    if (count == antnum)
                    {
                        Console.WriteLine();
                        colonies[colonychoice].ants[i].GetInfo(colonies[colonychoice]);
                        ChoiceInTheEndOfTheDay2(colonies, colonychoice);
                    }
                    count++;
                }
            }
        }
        static public List<(Colony colony, List<Ant>[])> Campaign(List<Colony> colonies, List<Stack> stacks)
        {
            Random random = new Random();
            var CampaignGroups = new List<(Colony colony, List<Ant>[])>();
            var stacklist = new List<(Stack stack, List<Ant>)>();

            foreach (var colony in colonies)
            {
                List<Ant>[] eachstack = new List<Ant>[stacks.Count];
                for (int i = 0; i < stacks.Count; i++)
                {
                    eachstack[i] = new List<Ant>();
                }
                foreach (var ant in colony.ants)
                {
                    if (ant.hp > 0 && ant.Class != "queen" && ant.ignoreeverysecondcamp <= 0)
                    {
                        ant.campstacknum = random.Next(stacks.Count);
                        eachstack[ant.campstacknum].Add(ant);
                    }
                    else if (ant.hp <= 0)
                    {
                        colony.ants.Remove(ant);
                    }
                    if (ant.ignoreeverysecondcamp == 0)
                    {
                        ant.ignoreeverysecondcamp = 1;
                    }
                    else if (ant.ignoreeverysecondcamp == 1)
                    {
                        ant.ignoreeverysecondcamp = 0;
                    }
                }
                CampaignGroups.Add(new(colony, eachstack));
            }
            return CampaignGroups;
        }
    }

    public abstract class World : Program
    {
        public List<Colony> colonies;
        public List<Stack> stacks;
        public static int dayscount = 0;
        public static int dayofdrought = 13;

        public World(List<Colony> colonies = null, List<Stack> stacks = null)
        {
            this.colonies = colonies;
            this.stacks = stacks;
        }
    }

    public class Colony : World
    {
        public List<string> AbleTypesOfWorkers = new List<string>();
        public List<string> AbleTypesOfSoldiers = new List<string>();
        public int ColonyID;
        public string ColonyColor;
        private int ColorID;
        public int leaf = 0;
        public int stone = 0;
        public int branch = 0;
        public int dewdrop = 0;
        public List<Ant> ants = new List<Ant>();
        public bool allyharmed = false;
        static string[,,] AllTypesOfAnts = new string[3, 2, 2]
        {
            {
                {"продвинутый", "элитный спринтер"},
                {"легендарный", "легендарный щитоносец"}
            },
            {
                {"легендарный", "легендарный спринтер"},
                {"легендарный", "элитный щитоносец"}
            },
            {
                {"обычный", "обычный капризный"},
                {"старший", "элитный трусливый"}
            },
        };

        public Colony(int ColonyID = 999, string ColonyColor = "NoName", List<Ant> ants = null)
        {
            this.ColonyID = ColonyID;
            this.ColonyColor = ColonyColor;
            this.ants = ants;
            if (ColonyColor == "черные")
            {
                ColorID = 0;
            }
            else if (ColonyColor == "рыжие")
            {
                ColorID = 1;
            }
            else if (ColonyColor == "красные")
            {
                ColorID = 2;
            }
            for (int i = 0; i < AllTypesOfAnts.GetLength(2); i++)
            {
                AbleTypesOfWorkers.Add(AllTypesOfAnts[ColorID, 0, i]);
                AbleTypesOfSoldiers.Add(AllTypesOfAnts[ColorID, 1, i]);
            }
        }
        
        public void GetInfo()
        {
            Console.WriteLine($"Колония: {ColonyColor}");
            foreach (var ant in ants)
            {
                if (ant.Class == "queen")
                {
                    Console.WriteLine($"Королева: <{((QueenAnt)ant).QueenName}>, здоровье:{ant.hp}, защита:{ant.armor}, урон:{ant.damage}");
                }
            }
            Console.WriteLine($"Ресурсы: листики={leaf}, камешки={stone}, веточки={branch}, росинки={dewdrop}");
            Console.WriteLine($"Популяция: " + ants.Count);
            Console.WriteLine("<<<<<<<<<< Рабочие >>>>>>>>>>");
            Console.WriteLine();
            foreach (var type in AbleTypesOfWorkers)
            {
                Console.WriteLine($"Тип: <<{type}>>");
                int count = 0;
                Ant anttemp = new Worker(type);
                foreach (var ant in ants)
                {
                    if (ant.Type == type)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Параметры: здоровье: {anttemp.hp} защита: {anttemp.armor}");
                Console.WriteLine($"Количество: {count}");
                anttemp.GetMods();
                anttemp = null;
            }
            Console.WriteLine("<<<<<<<<<< Воины >>>>>>>>>>");
            Console.WriteLine();
            foreach (var type in AbleTypesOfSoldiers)
            {
                Console.WriteLine($"Тип: <<{type}>>");
                int count = 0;
                Ant anttemp = new Soldier(type);
                foreach (var ant in ants)
                {
                    if (ant.Type == type)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Параметры: здоровье: {anttemp.hp} защита: {anttemp.armor} урон: {anttemp.damage}");
                Console.WriteLine($"Количество: {count}");
                anttemp.GetMods();
                anttemp = null;
            }
            Console.WriteLine("<<<<<<<<<< Особые >>>>>>>>>>");
            Console.WriteLine();
            switch (ColonyColor)
            {
                case "черные":
                    Ant anttemp = new Special("трудолюбивый неуязвимый агрессивный трусливый карманник - Стрекоза");
                    Console.WriteLine($"Тип: <<{anttemp.Type}>>");
                    Console.WriteLine($"Параметры: здоровье: {anttemp.hp} защита: {anttemp.armor} урон: {anttemp.damage}");
                    anttemp.GetMods();
                    anttemp = null;
                    break;
                case "рыжие":
                    Ant anttemp1 = new Special("ленивый неуязвимый мирный заботливый - Скарабей");
                    Console.WriteLine($"Тип: <<{anttemp1.Type}>>");
                    Console.WriteLine($"Параметры: здоровье: {anttemp1.hp} защита: {anttemp1.armor} урон: {anttemp1.damage}");
                    anttemp1.GetMods();
                    anttemp1 = null;
                    break;
                case "красные":
                    Ant anttemp2 = new Special("трудолюбивый обычный агрессивный сержант марафонец - Пчела");
                    Console.WriteLine($"Тип: <<{anttemp2.Type}>>");
                    Console.WriteLine($"Параметры: здоровье: {anttemp2.hp} защита: {anttemp2.armor} урон: {anttemp2.damage}");
                    anttemp2.GetMods();
                    anttemp2 = null;
                    break;
                default:
                    break;
            }
        }
    }
    public class Ant
    {
        public Ant FindAnt(string Class, Colony colony)
        {
            foreach (var ant in colony.ants)
            {
                if (ant.Class == Class)
                {
                    return ant;
                }
            }
            return null;
        }

        public void Grab(List<(Colony colony, List<Ant>[])> camp, Colony colony, List<Stack> stacks)
        {
            if (cangrabsmth == true)
            {
                foreach (var item in cangrab)
                {
                    switch (item.Key)
                    {
                        case "leaf":
                            while (leaf < item.Value && stacks[campstacknum].leaf > 0)
                            {
                                stacks[campstacknum].leaf--;
                                leaf++;
                            }
                            break;
                        case "stone":
                            while (stone < item.Value && stacks[campstacknum].stone > 0)
                            {
                                stacks[campstacknum].stone--;
                                stone++;
                            }
                            break;
                        case "branch":
                            while (branch < item.Value && stacks[campstacknum].branch > 0)
                            {
                                stacks[campstacknum].branch--;
                                branch++;
                            }
                            break;
                        case "dewdrop":
                            while (dewdrop < item.Value && stacks[campstacknum].dewdrop > 0)
                            {
                                stacks[campstacknum].dewdrop--;
                                dewdrop++;
                            }
                            break;
                        case "any":
                            Random random = new Random();
                            while (leaf + stone + branch + dewdrop < item.Value && stacks[campstacknum].leaf + stacks[campstacknum].stone + stacks[campstacknum].branch + stacks[campstacknum].dewdrop > 0)
                            {
                                int randres = random.Next(4);
                                switch (randres)
                                {
                                    case 0:
                                        if (stacks[campstacknum].leaf > 0)
                                        {
                                            stacks[campstacknum].leaf--;
                                            leaf++;
                                        }
                                        break;
                                    case 1:
                                        if (stacks[campstacknum].stone > 0)
                                        {
                                            stacks[campstacknum].stone--;
                                            stone++;
                                        }
                                        break;
                                    case 2:
                                        if (stacks[campstacknum].branch > 0)
                                        {
                                            stacks[campstacknum].branch--;
                                            branch++;
                                        }
                                        break;
                                    case 3:
                                        if (stacks[campstacknum].dewdrop > 0)
                                        {
                                            stacks[campstacknum].dewdrop--;
                                            dewdrop++;
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
                if (afterdeathdelivery == true)
                {
                    colony.leaf += leaf;
                    colony.stone += stone;
                    colony.branch += branch;
                    colony.dewdrop += dewdrop;
                    leaf = 0;
                    stone = 0;
                    branch = 0;
                    dewdrop = 0;
                }
            }
        }
        public void Put(Colony colony)
        {
            colony.leaf += leaf;
            colony.stone += stone;
            colony.branch += branch;
            colony.dewdrop += dewdrop;
        }

        public void attack(List<(Colony colony, List<Ant>[])> camp, List<Colony> colonies, Colony colony, int firstattack = 10)
        {
            Random random = new Random();
            for (int i = 0; i < targets; i++)
            {
                int randcolony = random.Next(colonies.Count);
                int maxcount = colonies.Count;
                int count = 0;
                while ((camp[randcolony].Item2[campstacknum].Count == 0 && count < maxcount) || (camp[randcolony].Item1.ColonyColor == colony.ColonyColor && count < maxcount))
                {
                    randcolony = count;
                    count++;
                }
                if (count < maxcount)
                {
                    int randant = random.Next(camp[randcolony].Item2[campstacknum].Count);
                    Ant enemy = camp[randcolony].Item2[campstacknum][randant];
                    while (enemy.cantbeattackedfirst == true)
                    {
                        enemy.cantbeattackedfirst = false;
                        randant = random.Next(camp[randcolony].Item2[campstacknum].Count);
                        enemy = camp[randcolony].Item2[campstacknum][randant];
                    }
                    count = 0;
                    maxcount = camp[randcolony].Item2[campstacknum].Count;
                    while (enemy.cantbeattackedbysoldiers == true && Class == "soldier" && count < maxcount)
                    {
                        randant = count;
                        enemy = camp[randcolony].Item2[campstacknum][randant];
                        count++;
                    }
                    if (camp[randcolony].Item1.ColonyColor != colony.ColonyColor && enemy.hp > 0 && hp > 0 && !(enemy.cantbeattackedbysoldiers == true && Class == "soldier"))
                    {
                        int HpArmor = hp + armor;
                        int enemyHpArmor = enemy.hp + enemy.armor;
                        foreach (var ant in colony.ants)
                        {
                            if (ant.doublearmorforallies == true)
                            {
                                HpArmor = hp + armor * 2;
                            }
                        }
                        foreach (var ant in camp[randcolony].Item1.ants)
                        {
                            if (ant.doublearmorforallies == true)
                            {
                                enemyHpArmor = hp + armor * 2;
                            }
                        }
                        while (enemyHpArmor > 0 && HpArmor > 0)
                        {
                            if (firstattackkiller == true && firstattack == 1)
                            {
                                enemyHpArmor = 0;
                            }
                            enemyHpArmor -= damage * bites;
                            if (enemyHpArmor > 0)
                            {
                                HpArmor -= enemy.damage * enemy.bites;
                            }
                        }
                        if (enemyHpArmor <= 0)
                        {
                            enemy.hp = 0;
                            enemy.armor = 0;
                            camp[randcolony].Item1.allyharmed = true;
                            if (HpArmor >= hp)
                            {
                                armor = HpArmor - hp;
                            }
                            else
                            {
                                hp = HpArmor;
                                armor = 0;
                                colony.allyharmed = true;
                            }
                            camp[randcolony].Item1.ants.Remove(enemy);
                            camp[randcolony].Item2[campstacknum].Remove(enemy);
                        }
                        else
                        {
                            hp = 0;
                            armor = 0;
                            colony.allyharmed = true;
                            if (enemyHpArmor >= enemy.hp)
                            {
                                enemy.armor = enemyHpArmor - enemy.hp;
                            }
                            else
                            {
                                enemy.hp = enemyHpArmor;
                                enemy.armor = 0;
                                camp[randcolony].Item1.allyharmed = true;
                            }
                        }
                        Console.WriteLine($"здоровье противника = {enemy.hp}, {enemy.Class}");
                        Console.WriteLine($"здоровье атакующего = {hp}, {Class}");
                        Console.WriteLine("==============================");
                    }
                    else if (enemy.hp <= 0 && hp > 0)
                    {
                        attack(camp, colonies, colony);
                    }
                }
            }

        }

        public void GetInfo(Colony colony)
        {
            if (Class == "worker")
            {
                Console.WriteLine($"Имя моей королевы {((QueenAnt)FindAnt("queen", colony)).QueenName}, я ее очень люблю ^-^");
                Console.WriteLine($"я {Type} рабочий, здоровье:{hp}, броня:{armor}, урон:{damage}");
                GetMods();
            }
            else if (Class == "soldier")
            {
                Console.WriteLine($"Имя моей королевы {((QueenAnt)FindAnt("queen", colony)).QueenName}, я ее очень люблю ^-^");
                Console.WriteLine($"я {Type} солдат, здоровье:{hp}, броня:{armor}, урон:{damage}");
                GetMods();
            }
            else if (Class == "special")
            {
                Console.WriteLine($"Имя моей королевы {((QueenAnt)FindAnt("queen", colony)).QueenName}, я ее очень люблю ^-^");
                Console.WriteLine($"я {Type}, здоровье:{hp}, броня:{armor}, урон:{damage}");
                GetMods();
            }
            else if (Class == "queen")
            {
                Console.WriteLine($"Я {((QueenAnt)FindAnt("queen", colony)).QueenName}, королева колонии {colony.ColonyColor}");
                Console.WriteLine($"здоровье:{hp}, броня:{armor}, урон:{damage}");
                GetMods();
            }
        }

        public void GetMods()
        {
            Console.WriteLine("Модификаторы:");
            if (cantbeattackedfirst == true)
            {
                Console.WriteLine("- не может быть атакован первым");
            }
            if (doublearmor == true)
            {
                Console.WriteLine("- увеличивает свою броню в два раза");
            }
            if (ignoreeverysecondcamp == 1)
            {
                Console.WriteLine("- ходит в походы через раз");
            }
            if (doublearmorforallies == true)
            {
                Console.WriteLine("- удваивает броню всех союзников");
            }
            if (cantbeattackedbysoldiers == true)
            {
                Console.WriteLine("- не может быть атакован воином");
            }
            if (ifallyharmednotattack == true)
            {
                Console.WriteLine("- если союзник получил урон, не атакует");
            }
            if (firstattackkiller == true)
            {
                Console.WriteLine("- если атакует первым в походе, убивает с одного укуса");
            }
            if (afterdeathdelivery == true)
            {
                Console.WriteLine("- доносит ресурси в колонию даже мертвым");
            }
            if (ifnoneededresinstack == true)
            {
                Console.WriteLine("- если нету нужного ресурса в куче, ворует его у врага");
            }
            if (bites > 1 || targets > 1)
            {
                Console.WriteLine($"- атакует {targets} противников за раз, делает {bites} укусов за раз");
            }
        }
        public Dictionary<string, int> cangrab;
        public string Class;
        public string Type;
        public int hp;
        public int armor;
        public int damage;
        public int campstacknum;
        public bool cangrabsmth;
        public int leaf = 0;
        public int stone = 0;
        public int branch = 0;
        public int dewdrop = 0;
        public bool cantbeattackedfirst;
        public bool doublearmor;
        public int ignoreeverysecondcamp = -1;
        public bool doublearmorforallies = false;
        public bool cantbeattackedbysoldiers = false;
        public bool ifallyharmednotattack = false;
        public bool firstattackkiller = false;
        public bool afterdeathdelivery = false;
        public bool ifnoneededresinstack = false;
        public int targets = 1;
        public int bites = 1;

        public Ant(string Class, string type, int hp, int armor, int damage, bool cangrabsmth)
        {
            this.Class = Class;
            Type = type;
            this.hp = hp;
            this.armor = armor;
            this.damage = damage;
            this.cangrabsmth = cangrabsmth;
            this.cantbeattackedfirst = false;
            this.doublearmor = false;
            if (doublearmor == true)
            {
                this.armor *= 2;
            }
        }
    }
    public class QueenAnt : Ant
    {
        Random random = new Random();
        public string QueenName;
        public int minlarvacycle;
        public int maxlarvacycle;
        public int larvacyclenow;
        public int mindaughters;
        public int maxdaughters;
        public int MaxOfNewQueens;
        public int CountOfNewQueens;
        public QueenAnt(string QueenName, int hp, int armor, int damage, int minlarvacycle, int maxlarvacycle, int mindaughters = 0, int maxdaughters = 0, string Class = "queen", int CountOfNewQueens = 0, string type = null, bool cangrabsmth = false)
            : base(Class, type, hp, armor, damage, cangrabsmth)
        {
            this.QueenName = QueenName;
            this.Class = Class;
            this.minlarvacycle = minlarvacycle;
            this.maxlarvacycle = maxlarvacycle;
            this.mindaughters = mindaughters;
            this.maxdaughters = maxdaughters;
            this.cangrabsmth = false;
            MaxOfNewQueens = random.Next(mindaughters, maxdaughters);
            larvacyclenow = random.Next(minlarvacycle, maxlarvacycle);
        }
        public void NewAnt(Colony colony, List<Colony> colonies)
        {
            if (World.dayscount % larvacyclenow == 0)
            {
                switch (random.Next(3))
                {
                    case 0:
                        Worker worker = new Worker(colony.AbleTypesOfWorkers[random.Next(colony.AbleTypesOfWorkers.Count)]);
                        colony.ants.Add(worker);
                        break;
                    case 1:
                        Soldier soldier = new Soldier(colony.AbleTypesOfSoldiers[random.Next(colony.AbleTypesOfSoldiers.Count)]);
                        colony.ants.Add(soldier);
                        break;
                    case 2:
                        if (CountOfNewQueens < MaxOfNewQueens)
                        {
                            CountOfNewQueens++;
                            Ant queen = new QueenAnt($"{QueenName}{CountOfNewQueens}", hp, armor, damage, minlarvacycle, maxlarvacycle);
                            List<Ant> ants5 = new List<Ant>();
                            Colony colony1 = new Colony(10000, colony.ColonyColor, ants5);
                            colonies.Add(colony1);
                            colony1.ants.Add(queen);
                        }
                        else
                        {
                            NewAnt(colony, colonies);
                        }
                        break;
                    default:
                        Console.WriteLine("Что-то пошло не так, не знаю кто там родиться должен");
                        break;
                }
                larvacyclenow = random.Next(minlarvacycle, maxlarvacycle + 1);
            }
        }
    }
    public class Worker : Ant
    {
        public Worker(string type, string Class = "worker", int hp = 0, int armor = 0, int damage = 0, bool cangrabsmth = true)
            : base(Class, type, hp, armor, damage, cangrabsmth)
        {
            Type = type;
            if (type == "продвинутый")
            {
                this.hp = 6;
                this.armor = 2;
                cangrab = new Dictionary<string, int> { { "stone", 1 }, { "branch", 1 } };
            }
            else if (type == "элитный спринтер")
            {
                this.hp = 8;
                this.armor = 4;
                cangrab = new Dictionary<string, int> { { "leaf", 1 }, { "dewdrop", 1 } };
                this.cantbeattackedfirst = true;
            }
            else if (type == "легендарный")
            {
                this.hp = 10;
                this.armor = 6;
                cangrab = new Dictionary<string, int> { { "stone", 2 }, { "dewdrop", 1 } };
            }
            else if (type == "легендарный спринтер")
            {
                this.hp = 10;
                this.armor = 6;
                cangrab = new Dictionary<string, int> { { "dewdrop", 2 }, { "leaf", 1 } };
                this.cantbeattackedfirst = true;
            }
            else if (type == "обычный")
            {
                this.hp = 1;
                this.armor = 0;
                cangrab = new Dictionary<string, int> { { "branch", 1 } };
            }
            else if (type == "обычный капризный")
            {
                this.hp = 1;
                this.armor = 0;
                cangrab = new Dictionary<string, int> { { "leaf", 1 } };
                this.ignoreeverysecondcamp = 1;
            }
            else
            {
                Console.WriteLine("Я не знаю такого типа рабочего");
            }
        }
    }
    public class Soldier : Ant
    {
        public Soldier(string type, string Class = "soldier", int hp = 0, int armor = 0, int damage = 0, bool cangrabsmth = false)
            : base(Class, type, hp, armor, damage, cangrabsmth)
        {
            Type = type;
            if (type == "легендарный")
            {
                this.hp = 10;
                this.armor = 6;
                this.damage = 6;
                this.targets = 3;
            }
            else if (type == "легендарный щитоносец")
            {
                this.hp = 10;
                this.armor = 6;
                this.damage = 6;
                this.doublearmor = true;
                this.targets = 2;
                this.bites = 2;
            }
            else if (type == "легендарный")
            {
                this.hp = 10;
                this.armor = 6;
                this.damage = 6;
                this.targets = 3;
            }
            else if (type == "элитный щитоносец")
            {
                this.hp = 8;
                this.armor = 4;
                this.damage = 4;
                this.doublearmor = true;
            }
            else if (type == "старший")
            {
                this.hp = 2;
                this.armor = 1;
                this.damage = 2;
            }
            else if (type == "элитный трусливый")
            {
                this.hp = 8;
                this.armor = 4;
                this.damage = 4;
                this.targets = 2;
                this.bites = 2;
                this.ifallyharmednotattack = true;
            }
            else
            {
                Console.WriteLine("Я не знаю такого типа воина");
            }
        }
    }
    public class Special : Ant
    {
        public Special(string type, string Class = "special", int damage = 0, int hp = 0, int armor = 0, bool cangrabsmth = false)
            : base(Class, type, hp, armor, damage, cangrabsmth)
        {
            Type = type;
            if (type == "трудолюбивый неуязвимый агрессивный трусливый карманник - Стрекоза")
            {
                this.hp = 29;
                this.armor = 8;
                this.damage = 7;
                this.cangrabsmth = true;
                cangrab = new Dictionary<string, int> { { "stone", 1 } };
                this.cantbeattackedbysoldiers = true;
                this.targets = 3;
                this.bites = 3;
                this.ifallyharmednotattack = true;
                this.ifnoneededresinstack = true;
            }
            else if (type == "ленивый неуязвимый мирный заботливый - Скарабей")
            {
                this.hp = 15;
                this.armor = 6;
                this.damage = 0;
                this.doublearmorforallies = true;
                this.cantbeattackedbysoldiers = true;
            }
            else if (type == "трудолюбивый обычный агрессивный сержант марафонец - Пчела")
            {
                this.hp = 25;
                this.armor = 6;
                this.damage = 9;
                this.cangrabsmth = true;
                cangrab = new Dictionary<string, int> { { "any", 3 } };
                this.targets = 2;
                this.bites = 3;
                this.firstattackkiller = true;
                this.afterdeathdelivery = true;
            }
        }
    }
    public class Stack : World
    {
        public int StackNum;
        public int leaf;
        public int stone;
        public int branch;
        public int dewdrop;

        public Stack(int StackNum, int leaf, int stone, int branch, int dewdrop)
        {
            this.StackNum = StackNum;
            this.leaf = leaf;
            this.stone = stone;
            this.branch = branch;
            this.dewdrop = dewdrop;
        }
    }
}