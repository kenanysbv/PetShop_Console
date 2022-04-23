namespace PetShop_Console
{
    class UI
    {
        List<string> Items = new List<string>();

        string? title;

        string? titleMain;

        PetShop petShop = new("Default");

        CatHouse catHouse = new("Default");

        Cat cat = new("Default");

        int index = 0;


        public UI(PetShop petShop)
        {
            title = petShop.PetShopName;
            titleMain = title;
            this.petShop = petShop;
        }


        void Show()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{title}\n");
            for (int i = 0; i < Items.Count; i++)
            {
                Console.ForegroundColor = i == index ? ConsoleColor.White : ConsoleColor.DarkGray;
                Console.WriteLine(Items[i]);
            }
            Console.ResetColor();

            GetKey();
        }

        void GetKey()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    index--;
                    CheckKey();
                    Show();
                    break;
                case ConsoleKey.DownArrow:
                    index++;
                    CheckKey();
                    Show();
                    break;
                case ConsoleKey.Enter:
                    CheckKey();
                    break;
                default:
                    break;
            }
        }

        void CheckKey()
        {
            if (index < 0) index = (Items.Count - 1);
            else if (index > Items.Count - 1) index = 0;
        }

        void Start() { Show(); }

        void Center(int len)
        {
            for (int i = 0; i < 15; i++)
                Console.WriteLine();
            for (int i = 0; i < 59 - len; i++)
                Console.Write(" ");
        }

        void Center(int line, int lenLast)
        {
            for (int i = 0; i < 15 - line; i++)
                Console.WriteLine();
            for (int i = 0; i < 59 - lenLast; i++)
                Console.Write(" ");
        }

        void StartPetShop()
        {
            Items.Clear();
            foreach (CatHouse item in petShop.GetCatHouses())
                Items.Add(item.ToString());
            Items.Add("Exit");
            index = 0;
            title = titleMain;
            Start();
            if (index == Items.Count - 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Center(4, 10);
                Console.WriteLine("Exiting...");
                Console.ResetColor();
                return;
            }
            else
            {
                catHouse = petShop.GetCatHouses()[index];
                StartCatHouse();
            }
            index = 0;
        }

        public void StartCatHouse()
        {
            Items.Clear();
            foreach (Cat item in catHouse.GetCats())
                Items.Add(item.GetInfo());
            Items.Add("Back");
            Items.Add("Exit");
            index = 0;
            title = catHouse.HouseName;
            Start();
            if (index == Items.Count - 2)
                StartPetShop();
            else if (index == Items.Count - 1)
                return;
            else
            {
                cat = catHouse.GetCats()[index];
                StartCat();
            }
            index = 0;
        }

        public void StartCat()
        {
            Items.Clear();
            Items.Add("Play");
            Items.Add("Eat");
            Items.Add("Back");
            Items.Add("Exit");
            index = 0;
            bool exit = true;
            while (exit)
            {
                title = cat.GetFullInfo();
                Start();
                if (index == 2) { StartCatHouse(); exit = false; }
                else if (index == 3)
                    return;
                else
                {
                    cat = catHouse.GetCats()[index];
                    switch (index)
                    {
                        case 0:
                            cat.Play();
                            break;
                        case 1:
                            cat.Eat();
                            break;
                        case 2:
                        case 3:
                            exit = false;
                            break;
                    }
                }
            }

        }


        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Center(3, 9);
            Console.WriteLine($"Welcome !\n");
            Center(15, petShop.PetShopName.Length);
            Console.WriteLine(petShop.PetShopName);
            Thread.Sleep(2232);
            StartPetShop();
        }
    }
}
