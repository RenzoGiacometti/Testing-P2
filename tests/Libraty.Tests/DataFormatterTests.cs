using TestDateFormat;

namespace Libraty.Tests;

public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectFormat()
    {
        string testDate="11/10/2003";
        Assert.AreEqual(DateFormatter.ChangeFormat(testDate),"2003-10-11");
    }

    [Test]
    public void IncorrectFormat()
    {
        string testDate="2003/10/11";
        Assert.AreEqual(DateFormatter.ChangeFormat(testDate),"Formato Inválido");
    }

    [Test]
    public void NoDate()
    {
        string testDate="";
        Assert.AreEqual(DateFormatter.ChangeFormat(testDate),"Formato Inválido");
    }
}