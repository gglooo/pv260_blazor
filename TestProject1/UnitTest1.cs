namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var text = "ANO";
        var text2 = "NE";
        
        Assert.That(text2, Is.Not.EqualTo(text));
    }
}