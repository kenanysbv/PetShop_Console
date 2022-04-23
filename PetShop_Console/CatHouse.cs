namespace PetShop_Console
{

    class CatHouse
    {
        private List<Cat> Cats { get; set; } = new List<Cat>();

        public string HouseName { get; set; }

        public CatHouse(string houseName)
        {
            HouseName = houseName;
        }

        public CatHouse(List<Cat> cats, string houseName)
        {
            Cats = cats;
            HouseName = houseName;
        }



        public bool SearchCat(Cat cat)
        {
            foreach (Cat item in Cats)
            {
                if (item.ToString() == cat.ToString())
                    return true;
            }
            return false;
        }
        public bool SearchCat(string nickname)
        {
            foreach (Cat item in Cats)
            {
                if (item.ToString() == nickname)
                    return true;
            }
            return false;
        }

        public void AddCat(Cat cat)
        {
            if (Cats.Contains(cat))
                return;
            Cats.Add(cat);
        }
        public void AddCat(string nickname)
        {
            if (Cats.Contains(new Cat(nickname)))
                return;
            Cats.Add(new Cat(nickname));
        }

        public void RemoveCat(string nickname) => Cats.Remove(new Cat(nickname));
        public void RemoveCat(Cat cat) => Cats.Remove(cat);

        public void ShowCats()
        {
            Console.WriteLine($"\n~~{HouseName}");
            foreach (Cat cat in Cats)
                Console.WriteLine(cat);
            Console.WriteLine();
        }

        public List<Cat> GetCats() => Cats;

        public override string ToString() => $"{HouseName}";

    }

}