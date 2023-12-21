namespace RandomString;

[TestFixture]
public class Tests
{

    [TestCase("edwin")]
    [TestCase("abcde")]
    public void Test1(string S)
    {
        string Output;
        Core core = new Core();
        core.S = S;
        core.A = 10;
        Output = core.GenerateRandomString();
    }
}
