﻿IDictionary<string, int> mois = new Dictionary<string, int>();

// TODO : Remplacer les noms par des constantes de type chaine de caractères
const string Juin = "Juin";
const string Septembre = "Septembre";
const string Mars = "Mars";

mois.Add(Juin, 6);
mois.Add(Septembre, 9);
mois.Add(Mars, 5);

// TODO : Corriger la valeur de Mars avec (3)
mois[Mars]=3;

// TODO : Retirer Juin
mois.Remove(Juin);

// Afficher le contenu du dictionnaire
Console.WriteLine("La liste des mois est :");
foreach (KeyValuePair<string, int> clePaire in mois)
{
    Console.WriteLine(clePaire.Value + " est le numéro du mois de " + clePaire.Key.ToString() + " de l'année ");
}