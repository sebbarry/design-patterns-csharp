using System;
using Xunit;
using Patterns;


public class MenuTest
{
    // test method 1
    [Fact]
    public void TestIterator()
    {
        Console.Write("Testing Iterator");

        PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
        DinerMenu dinerMenu = new DinerMenu();
        Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);

        waitress.printMenu();
    }
}
