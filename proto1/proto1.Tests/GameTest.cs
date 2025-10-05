namespace proto1.Tests;

using rh.Model;
public class UnitTest1
{
    [Fact]
    public void TestDisplayOutput()
    {
      Game g = new();
      g.DisplayStory();
    }
}
