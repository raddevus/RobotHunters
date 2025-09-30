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
}
