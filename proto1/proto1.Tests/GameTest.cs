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

    [Fact]
    public void TestGameTurns(){
       Game g = new();
       g.AddCharacter(new Character(Character.GameRole.pc, "frank"));
       g.AddCharacter(new Character(Character.GameRole.pc,"Bozeman"));
       g.AddCharacter(new Character(Character.GameRole.npc,"Orc"));
       g.AddCharacter(new Character(Character.GameRole.npc, "Wizard"));
       g.AddCharacter(new Character(Character.GameRole.pc,"Conan"));

       g.RunTurns();
       foreach (Character c in g.turnC){
          Console.WriteLine($"{c.Name} {c.CurrentTurnNumber}");
       }
    }
}
