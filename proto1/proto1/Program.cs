using rh.Model;

Console.WriteLine("Hello, World!");

Character c = new(Character.GameRole.pc, "Adam");
Equipment e = new("shovel");
c.AddEquipment(e);
Room r = new();

Console.WriteLine("Successfully created character, equipment, room.");

Game g = new();
Console.WriteLine("Created new game.");
g.AddCharacter(c);
Console.WriteLine("Added character to game.");
c.DisplayEquipmentList();

