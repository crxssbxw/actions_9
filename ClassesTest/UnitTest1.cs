using Classes;

namespace ClassesTest;

public class UnitTest1
{
    private static DuckLake duckLake = new();

    [Fact]
    public void AddingTest()
    {
        MallardDuck mallardDuck = new("Тука");

        duckLake.AddDuck(mallardDuck);

        Assert.Single(duckLake.Ducks);
    }

    [Fact]
    public void RemovingTest()
    {
        MallardDuck mallardDuck = new("Тука");

        duckLake.RemoveDuck(mallardDuck);

        Assert.Empty(duckLake.Ducks);
    }

    [Fact]
    public void PerformFlyLakeTest()
    {
        duckLake.ClearLake();

        MallardDuck mallardDuck = new("Утка");
        DecoyDuck decoyDuck = new("Фальшивка");

        duckLake.AddDuck(mallardDuck);
        duckLake.AddDuck(decoyDuck);

        string expected = "Летает\nНе летает\n";

        Assert.Equal(expected, duckLake.PerformFlyLake());
    }
}