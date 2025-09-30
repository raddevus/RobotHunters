
namespace rh.Model;

public class Equipment{
   // These are game items that may be used / picked up in the game.
   // list of items the character is carrying
   // may also be used as inventory of a room
   public string description;
   public string Name;
   // An item should have a Value associated with it so if the player 
   // needs to buy or sell it we can easily calculate how much he pays / receives
   public decimal Value;
   // An item needs to have a Weight associated with it so that various characters 
   // can carry more or less depending upon their strength
   public float Weight;
   public Equipment(string name){
      Name = name;
   }
}
