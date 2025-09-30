
namespace rh.Model;

public class Equipment{
   // These are game items that may be used / picked up in the game.
   // list of items the character is carrying
   // may also be used as inventory of a room
   public string description;
   public string Name;
   public Equipment(string name){
      Name = name;
   }
}
