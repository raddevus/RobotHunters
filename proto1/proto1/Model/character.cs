
namespace rh.Model;

public class Character{
   // health (hitpoints)
   // 
   public enum GameRole { npc, pc};
   private GameRole role;
   public Character (GameRole charType){
      role = charType;
   }

}
