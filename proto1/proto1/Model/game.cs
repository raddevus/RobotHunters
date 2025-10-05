using System.Text.Json;
// A Game will hold all the resources that are used in the game
// It will have 1 or mor characters, 1 or more rooms, and a catalog of
// items (inventory) which are available in the game.
// Game will also be where game logic exists like rolling dice for battle results etc.
//
namespace rh.Model;

public class Game{
   List<Character> allCharacters = new();
   List<Room> allRooms = new();
   public void AddCharacter(Character c){
      allCharacters.Add(c);
   }
   // A game has a turncount so we can determine how many turns have been played.
   // Probably used to generate a score later, but also helps to keep track of 
   // which turn the player is on so that things take time (monsters will get turns too)
   private int TurnCount;
   public void AddRoom(Room r){
      allRooms.Add(r);
   }

   public void AdvanceTurn(){
      // adding stub for advancing the turncounter
   }

   public void InitiativeCheck(){
      // This will occur at the beginning of a turn
      // to determine if the player or npc gets to 
      // make a move, attack first
      // Will probably set the order of the List<Character> so
      // that when the turn plays out, then each character's action
      // will occur then the AdvanceTurn will occur after all character's 
      // actions have played out.  This helps to insure that all characaters
      // in the game take their turn each time.
      //
      // This brings up two more issues:
      // 1. a PC will face one or more NPCs each turn - 
      // 2. the game must keep track which NPCs are facing the PC
      // 3. NPCs will be added to List<Character> when they are encountered
      // 4. NPCs will be removed from List<Character> when they leave the
      // presenence of PCs or are killed
      //
   }

   public void DisplayStory(){
      var textData = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText("Assets/StoryText.json"));
      Console.WriteLine(textData["ForestIntro"]);
   }

}
