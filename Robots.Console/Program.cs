// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization.Formatters;
using Robots;
using Robots2;
using Robots.CustomExceptions;
using Robots3;

Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");

// Correction du constructeur du Robot
Robot robot = new Robot("R2D2", new Point(0, 0));
Console.WriteLine(robot.Name);
AfficherNomRobot(robot, "ROBOOBO");
Console.WriteLine(robot.Name);
void AfficherNomRobot(Robot robot, string name)
{
    robot.Name = name;
}

var a = 5;
var b = 10;

// Correction de la fonction add en ajoutant le mot clé ref au paramètre a
int add(ref int a, int b)
{
    a = 10;
    return a + b;
}

var result = add(ref a, b);

Console.WriteLine(a);
Console.WriteLine(result);


RobotMobile robotMobile = new RobotMobile("R2D2", new Point(0, 0), 10);
robotMobile.Avancer(10, 10);
Console.WriteLine($"ma vitesse est de {robotMobile.CalculerDuréeDeDéplacement(20, 20)}");
Console.WriteLine(robotMobile.AfficherPosition());
Console.WriteLine(robotMobile.Arrêter());
Console.WriteLine(robot.Démarrer());
robotMobile.Nettoyer();
robotMobile.Déplacer(new Point { X = 30, Y = 30 });

//const int MAX_ROBOTS = 5;

//Robot[] robots = new Robot[MAX_ROBOTS];

//for(int i = 0; i < 3; i++)
//{
//    robots[i] = new Robot($"R2D{i}", (decimal)i);
//}

//decimal vitesseMoyenne = 0;

//for(int i = 0; i < 2; i++)
//{
//    vitesseMoyenne = vitesseMoyenne + robots[i].Vitesse;
//}

//vitesseMoyenne = vitesseMoyenne / 3;

//var VitesseMoyenne = robots.Average(r => r.Vitesse);

//Console.WriteLine($"La vitesse moyenne est de {vitesseMoyenne}");

List<Robot2> robotsList = new List<Robot2>();

// Ajouter au moins 5 robots à la liste
robotsList.Add(new Robot2("RobotA", 2021, 0, 0));
robotsList.Add(new Robot2("RobotB", 2022, 10, 10));
robotsList.Add(new Robot2("RobotC", 2023, 20, 20));
robotsList.Add(new Robot2("RobotD", 2024, 30, 30));
robotsList.Add(new Robot2("RobotE", 2025, 40, 40));

// Afficher les informations des robots dans la console
foreach (var robot2 in robotsList)
{
    Console.WriteLine($"Robot Name: {robot.Name}, Year: {robot2.Year}, Position: ({robot2.X}, {robot2.Y})");
}

// Utiliser LINQ pour récupérer tous les robots dont l'année de construction est supérieure à 2005
var robotsAfter2005 = robotsList.Where(robot => robot.Year > 2005).ToList();

// Utiliser LINQ pour trier les robots par leur année de construction, de la plus ancienne à la plus récente
var sortedRobots = robotsList.OrderBy(robot => robot.Year).ToList();

// Utiliser LINQ pour trouver le robot le plus ancien
var oldestRobot = robotsList.OrderBy(robot => robot.Year).FirstOrDefault();

// Afficher les résultats dans la console
Console.WriteLine("Robots dont l'année de construction est supérieure à 2005:");
foreach (var robot2 in robotsAfter2005)
{
    Console.WriteLine($"Robot Name: {robot2.Name}, Year: {robot2.Year}");
}

Console.WriteLine("\nRobots triés par année de construction (de la plus ancienne à la plus récente):");
foreach (var robot2 in sortedRobots)
{
    Console.WriteLine($"Robot Name: {robot2.Name}, Year: {robot2.Year}");
}

Console.WriteLine($"\nLe robot le plus ancien est : {oldestRobot.Name}, Année : {oldestRobot.Year}");


Console.WriteLine("------------------------------- Troisième jour ------------------------");

List<int> list = new List<int>();


List<NewRobot> NewRobotList = new List<NewRobot>()
{
new NewRobot { Id = 5, Name = "R2D5", Status = "En marche" },
};

NewRobotList.Add(new NewRobot { Id = 1, Name = "R2D2", Status = "En marche" });
NewRobotList.Add(new NewRobot { Id = 2, Name = "R2D3", Status = "En marche" });
NewRobotList.Add(new NewRobot { Id = 3, Name = "R2D4", Status = "En marche" });
NewRobotList.Add(new NewRobot { Id = 4, Name = "R2D5", Status = "En marche" });

Console.WriteLine("List");
foreach (var robotnew in NewRobotList)
{
    Console.WriteLine(robotnew.ToString());
}

Dictionary<int, NewRobot> DictionnaryRobot = new Dictionary<int, NewRobot>();
DictionnaryRobot.Add(1, new NewRobot { Id = 1, Name = "R2D2", Status = "En marche" });

Console.WriteLine("Dictionnary");
foreach (var robotnew in DictionnaryRobot)
{
    Console.WriteLine(robotnew.Value.ToString());
}

var DictionnaryRobot2 = new Dictionary<int, NewRobot>
{
    { 1, new NewRobot { Id = 1, Name = "R2D2", Status = "En marche" } },
    { 2, new NewRobot { Id = 2, Name = "R2D3", Status = "En marche" } },
    { 3, new NewRobot { Id = 3, Name = "R2D4", Status = "En marche" } },
    { 4, new NewRobot { Id = 4, Name = "R2D5", Status = "En marche" } }
};


Console.WriteLine("Dictionnary2");
foreach (var robotnew in DictionnaryRobot2)
{
    Console.WriteLine(robotnew.Value.ToString());
}

var DictionnaryRobot3 = NewRobotList.ToDictionary(r => r.Id, r => r);

Console.WriteLine("Dictionnary3");
foreach (var robotnew in DictionnaryRobot3)
{
    Console.WriteLine(robotnew.Value.ToString());
}

var QueueRobot = new Queue<NewRobot>();
QueueRobot.Enqueue(new NewRobot { Id = 3, Name = "R2D4", Status = "Arret" });
QueueRobot.Enqueue(new NewRobot { Id = 1, Name = "R2D2", Status = "En marche" });
QueueRobot.Enqueue(new NewRobot { Id = 2, Name = "R2D3", Status = "En marche" });

Console.WriteLine("Queue");
foreach (var robotnew in QueueRobot) {
    Console.WriteLine(robotnew.ToString());
}

var StackRobot = new Stack<NewRobot>();
StackRobot.Push(new NewRobot { Id = 1, Name = "R2D2", Status = "En marche" });
StackRobot.Push(new NewRobot { Id = 2, Name = "R2D3", Status = "Arret" });
StackRobot.Push(new NewRobot { Id = 3, Name = "R2D4", Status = "En marche" });

Console.WriteLine("Stack");
foreach (var robotnew in StackRobot)
{
    Console.WriteLine(robotnew.ToString());
}

var LinkedListRobot = new LinkedList<NewRobot>();
LinkedListRobot.AddFirst(new NewRobot { Id = 1, Name = "R2D2", Status = "En marche" });
LinkedListRobot.AddLast(new NewRobot { Id = 2, Name = "R2D3", Status = "Arret" });
LinkedListRobot.AddLast(new NewRobot { Id = 3, Name = "R2D4", Status = "En marche" });

Console.WriteLine("LinkedList");
foreach (var robotnew in LinkedListRobot)
{
    Console.WriteLine(robotnew.ToString());
}

var observableCollectionRobot = new System.Collections.ObjectModel.ObservableCollection<NewRobot>();
observableCollectionRobot.Add(new NewRobot { Id = 1, Name = "R2D2", Status = "En marche" });
observableCollectionRobot.Add(new NewRobot { Id = 2, Name = "R2D3", Status = "Arret" });

Console.WriteLine("ObservableCollection");
foreach (var robotnew in observableCollectionRobot)
{
    Console.WriteLine(robotnew.ToString());
}

var sortedListRobot = new SortedList<int, NewRobot>();
sortedListRobot.Add(2, new NewRobot { Id = 2, Name = "R2D3", Status = "En marche" });
sortedListRobot.Add(1, new NewRobot { Id = 1, Name = "R2D2", Status = "Arret" });

Console.WriteLine("SortedList");
foreach (var robotnew in sortedListRobot)
{
    Console.WriteLine(robotnew.Value.ToString());
}





//supprimer un element de chaque type de liste
NewRobotList.RemoveAt(0);
NewRobotList.Remove(NewRobotList[1]);
DictionnaryRobot.Remove(1);
DictionnaryRobot2.Remove(1);
DictionnaryRobot3.Remove(1);
QueueRobot.Dequeue();
StackRobot.Pop();
LinkedListRobot.RemoveFirst();
observableCollectionRobot.RemoveAt(0);
sortedListRobot.Remove(1);

foreach (var robotnew in NewRobotList)
{
    robotnew.Status = "Arret";
}

bool isArret = NewRobotList.All(x => x.Status == "Arret");
bool isArret2 = NewRobotList.Any(x => x.Status == "Arret");



try
{
    if (isArret)
    {
        Console.WriteLine("Tous les robots sont à l'arret");
        throw new StatusRobotException("Tous les robots ne sont pas à l'arret");

    }
}
catch (StatusRobotException e)
{
    Console.Write("exception Custom :");
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.Write("exception :");
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Fin du programme");
}

List<Robot3> robotsList3 = new List<Robot3>();

// Ajouter au moins 5 robots à la liste
robotsList3.Add(new Robot3("RobotA", 2021, 0, 0));
robotsList3.Add(new Robot3("RobotB", 2022, 10, 10));
robotsList3.Add(new Robot3("RobotC", 2023, 20, 20));
robotsList3.Add(new Robot3("RobotD", 2024, 30, 30));
robotsList3.Add(new Robot3("RobotE", 2025, 40, 40));


// Afficher les informations des robots dans la console
foreach (var robot3 in robotsList3)
{
    Console.WriteLine($"Robot Name: {robot3.Name}, Year: {robot3.Year}, Position: ({robot3.X}, {robot3.Y})");
}

// Utiliser LINQ pour récupérer tous les robots dont l'année de construction est supérieure à 2005
var robots3After2005 = robotsList3.Where(robot => robot.Year > 2005).ToList();

// Utiliser LINQ pour trier les robots par leur année de construction, de la plus ancienne à la plus récente
var sorted3Robots = robotsList3.OrderBy(robot => robot.Year).ToList();

// Utiliser LINQ pour trouver le robot le plus ancien
var oldest3Robot = robotsList3.OrderBy(robot => robot.Year).FirstOrDefault();

// Afficher les résultats dans la console
Console.WriteLine("Robots dont l'année de construction est supérieure à 2005:");
foreach (var robot3 in robots3After2005)
{
    Console.WriteLine($"Robot Name: {robot3.Name}, Year: {robot3.Year}");
}

Console.WriteLine("\nRobots triés par année de construction (de la plus ancienne à la plus récente):");
foreach (var robot3 in sorted3Robots)
{
    Console.WriteLine($"Robot Name: {robot3.Name}, Year: {robot3.Year}");
}

Console.WriteLine($"\nLe robot le plus ancien est : {oldest3Robot.Name}, Année : {oldest3Robot.Year}");

var distances = robotsList3.Select(r => Math.Sqrt(Math.Pow(r.X, 2) + Math.Pow(r.Y, 2))).ToList();

Console.WriteLine("Distances entre chaque robot et le point (0, 0) arrondies à deux décimales :");
foreach (var distance in distances)
{
    Console.WriteLine(distance.ToString("F2"));
}


