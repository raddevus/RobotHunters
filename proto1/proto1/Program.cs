using rh.Model;

Console.WriteLine("Hello, World!");

Character c = new(Character.GameRole.pc);
Equipment e = new();
Room r = new();

Console.WriteLine("Successfully created character, equipment, room.");

Game g = new();
Console.WriteLine("Created new game.");
g.AddCharacter(c);
Console.WriteLine("Added character to game.");

