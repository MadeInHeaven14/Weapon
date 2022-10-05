// See https://aka.ms/new-console-template for more information
using Weapon;

IMeleeWeapon tAxe = new TwoHandedAxe();
tAxe.Show();
tAxe.Attack();

OneHandedAxe oAxe = new OneHandedAxe();
oAxe.Show();
oAxe.ThrowWeapon();

IThrowWeapon Dart = new Dart();
Dart.Show();
Dart.ThrowWeapon();

oAxe.Attack();
oAxe.Attack();
oAxe.Attack();
oAxe.Attack();


