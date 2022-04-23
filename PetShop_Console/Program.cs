using PetShop_Console;

Cat c1 = new("Name1", CatGender.Male, 12, 3);
Cat c2 = new("name2", CatGender.Male, 12, 3);
Cat c3 = new("Name3", CatGender.Male, 12, 3);
Cat c4 = new("Name4", CatGender.Male, 12, 3);
Cat c5 = new("Name5", CatGender.Male, 12, 3);
Cat c6 = new("Name6", CatGender.Male, 12, 3);
Cat c7 = new("Name7", CatGender.Female, 12, 3);
CatHouse catHouse = new("CatHouse-1");
CatHouse catHouse2 = new("CatHouse-2");
CatHouse catHouse3 = new("CatHouse-3");
catHouse.AddCat(c1);
catHouse.AddCat(c2);
catHouse2.AddCat(c3);
catHouse2.AddCat(c4);
catHouse2.AddCat(c5);
catHouse3.AddCat(c6);
catHouse3.AddCat(c7);

PetShop petShop = new("PetSHop-1");
petShop.AddHouse(catHouse);
petShop.AddHouse(catHouse2);
petShop.AddHouse(catHouse3);
petShop.AddHouse(catHouse2);

UI uI = new(petShop);
uI.Run();




