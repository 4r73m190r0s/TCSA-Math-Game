using TCSA_MathGame;

var menu = new Menu();

string name = Helpers.GetName();
var date = DateTime.UtcNow;

menu.ShowMenu(name, date);
