namespace RandomString;

[TestFixture]
public class Tests
{

    [TestCase("edwin")]
    [TestCase("abcde")]
    public void Test1(string S)
    {
        Core core = new Core();
        core.S = S;
        core.GenerateRandomString();
    }
}
