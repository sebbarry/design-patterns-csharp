using System;
using Xunit;
using Patterns;


public class MenuTest
{
    // test method 1
    [Fact]
    public void TestMethod()
    {
        Console.Write("testing...");

        PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
        DinerMenu dinerMenu = new DinerMenu();
        Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);

        waitress.printMenu();
    }
}
