namespace PetShop_Console
{


    public enum CatGender { Male, Female }

    public class Cat
    {
        public string Nickname { get; set; }

        public CatGender Gender { get; init; } = CatGender.Male;

        public short Price { get; set; } = 0;

        private int age = 1;

        public int MealQuantity { get; private set; } = 0;

        private short energy = 100;

        public int Age { get => age; set => age = (value > 0 && value <= 20) ? value : 1; }

        public short Energy { get => energy; set => energy = (short)((value >= 0 && value <= 100) ? value : 0); }




        public Cat(string nickname, CatGender gender, short price, short mealQuantity, int age, short energy)
        {
            Nickname = nickname;
            Gender = gender;
            Price = price;
            MealQuantity = mealQuantity;
            Energy = energy;
            Age = age;
        }

        public Cat(string nickname) => Nickname = nickname;

        public Cat(string nickname, CatGender gender, short price, int age)
        {
            Nickname = nickname;
            Gender = gender;
            Price = price;
            Age = age;
        }




        public void Eat()
        {
            MealQuantity += 30;
            energy += (short)((energy >= 100) ? 0 : 20);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine($"{Nickname} \n Eating...");
            Thread.Sleep(632);

        }

        public void Sleep()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine($"{Nickname} \n Sleep...");
            Thread.Sleep(632);
            energy = 100;

        }

        public void Play()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine($"{Nickname} \n Playing...");
            Thread.Sleep(570);
            energy -= 20;
            if (energy <= 0) Sleep();

        }

        public string GetInfo() =>
            $"Nicname: {Nickname}  ~~~ Age: {Age} ~~~ Price: {Price}";
        public string GetFullInfo() =>
            $"Nicname: {Nickname}  ~~~ Age: {Age} ~~~ Price: {Price} ~~ Gender: {Gender} ~~~ Energy: {energy} ~~~ MealQuantity: {MealQuantity}";

        public override string ToString() => $"{Nickname}";

    }




}
