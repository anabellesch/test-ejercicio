namespace Library.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FechaCorrecta()
    {
        const string input = "23/04/2023";
        const string expected = "23-04-2023";
        string actual = DateFormatter.ChangeFormat(input);
    }
    public void FechaIncorrecta()
    {
        const string input = "24-04-2023";
        const string expected = "24/04/2023";
        string actual = DateFormatter.ChangeFormat(input);


    }
    public void FechaVacia()
    {
        const string input = "";
        const string expected = "Error";
        string actual = DateFormatter.ChangeFormat(input);

    }
}
