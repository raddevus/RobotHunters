using rh.Model;

Console.WriteLine("Hello, World!");

Character c = new(Character.GameRole.pc);
Inventory i = new();
Room r = new();

Console.WriteLine("Successfully created character, inventory, room.");

Game g = new();
Console.WriteLine("Created new game.");
g.AddCharacter(c);
Console.WriteLine("Added character to game.");

