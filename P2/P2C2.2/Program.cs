// using System;
using P2C2._2;

// Couleur couleurChoisie = Couleur.Vert;
System.Console.WriteLine("Veuillez choisir une couleur :");
string choixCouleur = Console.ReadLine();
if(choixCouleur == null || !Enum.TryParse(choixCouleur, true, out Couleur couleurChoisie))
{
    couleurChoisie = (Couleur)(-1);
}

// TODO : Remplacer la séquence if/else par une instruction switch équivalente qui fonctionne selon la valeur de couleurChoisie
switch(couleurChoisie)
{
    case Couleur.Bleu:
        System.Console.WriteLine("La couleur est bleue");
        break;

    case Couleur.Vert:
        System.Console.WriteLine("La couleur est Vert");
        break;

    case Couleur.Rouge:
        System.Console.WriteLine("La couleur est Rouge");
        break;

    case Couleur.Jaune:
        System.Console.WriteLine("La couleur est Jaune");
        break;

    default:
        System.Console.WriteLine("Cette couleur n'est pas connue !");
        break;
}