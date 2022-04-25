using NUnit.Framework;

namespace TestDateFormat;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ChangeFormatTest()
    {
        Assert.AreEqual("2002-10-09", DateFormat.ChangeFormat("09/10/2002"));
    }

    [Test]
    public void ChangeFormatTest2()
    {
        Assert.AreEqual("09·10·2002", DateFormat.ChangeToOtherFormat("09/10/2002"));
        
    }
}