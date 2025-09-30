
namespace rh.Model;

public class Room{
   // will contain an inventory list
   // description
   // possibly a location
   //
   public string description;
   // Need the concept of location for a room
   // so we can also add a location to the character 
   // then at any time the game can determine things like
   // character's location on map (is char in the room)
   // and determine how far (how many turns it will take) 
   // the character is from the room
   // In the prototype this will probably just be simple grid location
   // think of graph paper and character is in column D & row 5 or something
}
