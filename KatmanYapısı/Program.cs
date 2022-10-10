// See https://aka.ms/new-console-template for more information

using Business;

CategoryManager cm = new CategoryManager();

foreach (var item in cm.GetAll())
{
    Console.WriteLine("ID: "+item.CategoryId+" "+"KATEGORİ ADI: "+item.CategoryName);
}