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
        Console.WriteLine("Test : {0}, Input : {1}, Output : {2}",TestContext.CurrentContext.Test.FullName, S, Output);
    }


    [TestCase("edwin")]
    [TestCase("abcde")]
    public void Test2(string S)
    {
        string Output;
        Core core = new Core();
        core.S = S;
        core.A = 10;
        Output = core.GenerateRandomStringUsingRandomClass();
        Console.WriteLine("Test : {0}, Input : {1}, Output : {2}", TestContext.CurrentContext.Test.FullName, S, Output);
    }
}
