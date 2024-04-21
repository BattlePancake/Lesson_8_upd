//----------------------------Task 1-------------------------------
using Homework_8;

//Triangle tr1 = new Triangle()
//{
//};
//Triangle tr2 = new Triangle()
//{
//};
//Rectangle rc1 = new Rectangle()
//{
//};
//Rectangle rc2 = new Rectangle()
//{
//};
//Circle crc1 = new Circle()
//{
//};

//Figure[] fgrs = { tr1, rc1, crc1, tr2, rc2 };

//double p1 = fgrs[0].SquareCalculation(5, 4.33);
//double p2 = fgrs[3].SquareCalculation(5, 4.33);
//double p3 = fgrs[1].SquareCalculation(5, 6);
//double p4 = fgrs[4].SquareCalculation(6, 7);
//double p5 = fgrs[2].SquareCalculation(5, 3.14);

//double perimeterSum = p1 + p2 + p3 + p4 + p5;
//Console.WriteLine(perimeterSum);



//----------------------------Task 2-------------------------------
Product unit1 = new Product()
{
    Name = "Water",
    Price = 0.5m,
    ProdDate = new DateTime(2023, 04, 15),
    ExpDate = new DateTime(2024, 04, 15)
};
Product unit2 = new Product()
{
    Name = "Water1",
    Price = 0.5m,
    ProdDate = new DateTime(2024, 04, 15),
    ExpDate = new DateTime(2025, 04, 15)
};
Product unit3 = new Product()
{
    Name = "Water2",
    Price = 0.7m,
    ProdDate = new DateTime(2024, 04, 15),
    ExpDate = new DateTime(2026, 04, 15)
};
Product unit4 = new Product()
{
    Name = "Water3",
    Price = 1m,
    ProdDate = new DateTime(2023, 04, 15),
    ExpDate = new DateTime(2027, 04, 15)
};
Batch bunit1 = new Batch()
{
    Name = "WaterBatch",
    Price = 50,
    Amount = 100,
    ProdDate = new DateTime(2023, 04, 15),
    ExpDate = new DateTime(2024, 04, 14)
};
Set sunit1 = new Set()
{
    Name = "WaterGift",
    Price = 3,
    Prod = new Product()
    {
        Name = "Water",
    }
};

unit1.DisplayInfo();
unit1.ExpirationSearch();

bunit1.DisplayInfo();
bunit1.ExpirationSearch();

sunit1.DisplayInfo();

Product[] prds = { unit1, unit2, unit3, unit4 };

foreach (Product a in prds)
{
    a.ExpirationSearch();
}
