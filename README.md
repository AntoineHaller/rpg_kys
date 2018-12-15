# rpg_kys

Le héro monte tous les étages de la tour jusqu'au dernier étage. Dans le but de se suicider.
Les autres employés l'empechent de monter. Ils doient les tuer pour pouvoir passer. 
Boss Final : CEO de la boite.

En fonction du score final.
Soit on fnit paraplegique, soit un fini dans un filet anti-suicide, soit on réussit à se suicider conveablement.

Il y aura des objets à récupérer pour ou récupérer des stats, ou passer des tests directement.

************************************************Les classes de heros: 

-Comptable : HP-> 25 V-> 7 F-> 7 C-> 3 I-> 12 D-> 1     TOT = 55

-Receptionniste :HP-> 25 V-> 11 F-> 7 C-> 8 I-> 3 D-> 1		TOT = 55

-RH: HP-> 25 V-> 5 F-> 5 C-> 12 I-> 7 D-> 1	TOT = 55

-LE DEV : HP-> 35 V-> 2 F-> 8 C-> -1 I-> 8 D-> 3 	TOT =55

-Stagiaire :HP->20 V->10 F-> 18 C-> 1 I-> 5 D-> 1 	TOT=55

//TODO En new game + , création d'un nouveau personnage personnalisable.

**************************************************Les stats : 

-combat : HP, Vitesse, Force, Charisme,Intelligence, Defense

-lore : Nom, Poids, Taille, 

************************************************* Les ennemis : 

4 stats combats : HP, Force, Def, Vit
lore : Nom, Description,

-José le PDG : HP -> 50 Force -> 20 Def -> 10 Vit -> 10

-Random colleague weak : HP -> 5 Force -> 2 Def -> 0 Vit -> 4
-Random colleague fast : HP -> 5 Force -> 2 Def ->0 Vit -> 9
-Random colleague medium : HP -> 10 Force -> 5 Def -> 2 Vit->5
-Random colleague strong : HP -> 20 Force -> 8 Def -> 3 Vit -> 2

************************************************* Les obstacles :

FOTOcopieuse : Thread.Sleep(4 sec);
Console.WriteLine("Une page a été imprimé");
Thread.Sleep(4 sec);
Console.WriteLine("ZzzzZ");
Thread.Sleep(4 sec);
Console.WriteLine("Une autre page a été imprimé");
Thread.Sleep(4 sec);
Console.WriteLine("Et une de plus!");
Thread.Sleep(4 sec);
Console.WriteLine("C'est long ?");
Thread.Sleep(4 sec);
Console.WriteLine("J'espère que c'est bientot fini....");
Thread.Sleep(4 sec);
Console.WriteLine("Vous pouvez y aller.");
Thread.Sleep(4 sec);
Console.WriteLine("....");
Thread.Sleep(4 sec);
Console.WriteLine("Maintenant");

********************************************* Les objets: 
Liste d'objets : 
BETA: "Rareté : de 1 à 5 (relié à une couleur) donc il faudra faire un switch je sais pas ou pour changer les dégats en fonction
de la couleur ^^" 
