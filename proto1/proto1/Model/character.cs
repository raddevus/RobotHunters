
namespace rh.Model;

public class Character{
   // health (hitpoints)
   // 
   public enum GameRole { npc, pc};
   private GameRole role;
   public int CurrentTurnNumber{get;set;} = 0;
   public Character (GameRole charType, string name){
      role = charType;
      Name = name;
   }

   private string Name;

   private List<Equipment> inventory = new();

   public void AddEquipment(Equipment e){
      inventory.Add(e);
   }

   public void DisplayEquipmentList(){
      if (inventory.Count() <= 0){
         Console.WriteLine($"{Name} is carrying nothing.");
      }
      else{
         Console.Write($"{Name} is carrying ");
         foreach (var e in inventory){
            Console.Write($"{e.Name}, ");
         }
         Console.WriteLine();
      }
   }
}
