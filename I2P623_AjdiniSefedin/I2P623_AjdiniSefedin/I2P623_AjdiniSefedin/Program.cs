// See https://aka.ms/new-console-template for more information
using I2P623_AjdiniSefedin;
using System.Net.Security;

Console.WriteLine("Etat des feux :");
Console.WriteLine("---------------");

Feu FeuRouge = new Feu(" 1001", " Rouge");
Feu Feu2 = new Feu("007", " Vert");


Console.WriteLine(FeuRouge.AfficheEtat());
Console.WriteLine(Feu2.AfficheEtat());

Console.WriteLine();
Console.WriteLine("Changement d'état :");
Console.WriteLine("-------------------");

if (FeuRouge.Couleur == " Rouge")
{
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine(FeuRouge.AfficheChangementEtatVert());
        Console.WriteLine(FeuRouge.AfficheChangementEtatOrange());
        Console.WriteLine(FeuRouge.AfficheEtat());
    }
}
else if (FeuRouge.Couleur == " Orange")
{
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine(FeuRouge.AfficheEtat());
        Console.WriteLine(FeuRouge.AfficheChangementEtatVert());
        Console.WriteLine(FeuRouge.AfficheChangementEtatOrange());
    }
}
else
{
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine(FeuRouge.AfficheChangementEtatOrange());
        Console.WriteLine(FeuRouge.AfficheEtat());
        Console.WriteLine(FeuRouge.AfficheChangementEtatVert());
    }
}


Console.WriteLine();
Console.WriteLine(Feu2.AfficheChangementEtat());
Console.WriteLine(Feu2.AfficheChangementEtatOrange());
Console.WriteLine("----------------------------------");
Console.WriteLine();

Console.WriteLine("Feu clignotant :");
Console.WriteLine("---------------");

for (int i = 0; i < 3; i++)
{
    if (Feu2.Couleur == " Vert")
    {
        Console.WriteLine(Feu2.ClignotantAllume());
        Console.WriteLine(Feu2.ClignotantEteint());
    }
    else
    {
        Console.WriteLine(Feu2.ClignotantEteint());
        Console.WriteLine(Feu2.ClignotantAllume());
    }
}