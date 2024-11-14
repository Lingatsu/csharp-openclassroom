//TODO : Créer une boucle for et while qui affiche à 5 reprises la phrase, « Je m'amuse comme un fou ! ».
// Partie 1
/*
for(int i=0; i<5; i++)
{
    System.Console.WriteLine("Je m'amuse comme un fou !");
}
*/

// Partie 2
// Changez votre boucle « for » par une boucle « while ». Était-ce une bonne idée ?
/*
int i = 0;
while(i<5)
{
    i += 1;
    System.Console.WriteLine("Je m'amuse comme un fou !");
}
*/

// Partie 3
// Sautez l'affichage de la quatrième boucle.
int i = 0;
while(i<5)
{
    i += 1;
    if(i==4)
    {
        continue;
    }
    System.Console.WriteLine("Je m'amuse comme un fou !");
}