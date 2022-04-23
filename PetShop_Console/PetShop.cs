namespace PetShop_Console
{

    class PetShop
    {
        private List<CatHouse> Shop { get; set; } = new List<CatHouse>();

        public string PetShopName { get; set; }



        public PetShop(string petShopName)
        {
            PetShopName = petShopName;
        }


        private bool SearchCatHouse(CatHouse catHouse)
        {
            foreach (CatHouse item in Shop)
            {
                if (item.ToString() == catHouse.ToString())
                    return true;
            }
            return false;
        }
        private bool SearchCatHouse(string nickname)
        {
            foreach (CatHouse item in Shop)
            {
                if (item.ToString() == nickname)
                    return true;
            }
            return false;
        }

        public void AddHouse(CatHouse catHouse)
        {
            if (SearchCatHouse(catHouse))
                return;
            Shop.Add(catHouse);
        }

        public void RemoveHouse(CatHouse catHouse) => Shop.Remove(catHouse);

        public List<CatHouse> GetCatHouses() => Shop;



    }

}