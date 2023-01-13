// See https://aka.ms/new-console-template for more information
using Weapon;


Warrior warrior1 = new Warrior();
Warrior warrior2 = new Warrior();
BlackSmith smith = new BlackSmith();
OneHandedAxe axe = new OneHandedAxe();
Dart dart = new Dart();
Human ne = new Warrior();
//warrior.Attack(axe, ne);
//warrior.ThrowWeapon(axe, ne);
//smith.Upgrade(axe);
//axe.Show();
//smith.Upgrade(axe);
//axe.Show();
//smith.Fix(axe);
//axe.Show();
//warrior.ThrowWeapon(dart, ne);
Task task1 = new Task(() => warrior1.AttackHuman(axe, warrior2));
Task task2 = new Task(() => warrior2.ThrowWeaponInHuman(dart, warrior1));

task1.Start();
task1.Wait();
task2.Start();
task2.Wait();





