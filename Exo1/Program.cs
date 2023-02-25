// See https://aka.ms/new-console-template for more information

using CoreData;

var patate = new Item
{
    Name = "Patate",
    Price = 2d,
};

var carotte = new Item
{
    Name = "Carotte",
    Price = 5d,
};

var pimentJalapenoSuperSpicy2000Gamer360NoScope = new Item
{
    Name = "Piment jalapeno super spicy 2000 gamer 360 no scope",
    Price = 100d,
};

var discountPimentPatate = new Discount
{
    NewPrice = 100d,
};

discountPimentPatate.Items.Add(pimentJalapenoSuperSpicy2000Gamer360NoScope, 1);
discountPimentPatate.Items.Add(patate, 1);

var discountAll = new Discount
{
    NewPrice = 110d,
};

discountAll.Items.Add(pimentJalapenoSuperSpicy2000Gamer360NoScope, 1);
discountAll.Items.Add(patate, 2);
discountAll.Items.Add(carotte, 5);

var discountCarotte = new Discount
{
    NewPrice = 100d,
};

discountCarotte.Items.Add(carotte, 60);