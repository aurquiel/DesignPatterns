// See https://aka.ms/new-console-template for more information
using ConsoleAppDesignPatterns.AbstractFactory;
using ConsoleAppDesignPatterns.Factory;
using ConsoleAppDesignPatterns.Observer;
using ConsoleAppDesignPatterns.Strategy;

Console.WriteLine("Strategy Pattern");

Numbers numbers = new Numbers();
numbers.NumbersList = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
Console.WriteLine("Linear Search runtime");
numbers.Search = new LinearSearch();
Console.WriteLine(numbers.Search.ElementInList(numbers.NumbersList, 7));
Console.WriteLine("Binary Search runtime");
numbers.Search = new LinearSearch();
Console.WriteLine(numbers.Search.ElementInList(numbers.NumbersList, 7));

Console.WriteLine();
Console.WriteLine("Observer Pattern");
StockGrabber stockGrabber = new StockGrabber();
StockObserver stockObserver = new StockObserver(stockGrabber);
stockGrabber.IbmPrice = 100.64;     //each time the stock changes notify to the observer.
stockGrabber.AaplePrice = 780.45;
stockGrabber.GoogPrice = 400.03;
stockGrabber.Unregister(stockObserver);

Console.WriteLine();
Console.WriteLine("Factory Pattern");
var equip1 = EquipmentFactory.CreateEquipment(EquipmentFactory.SELECTOR.Shield);
var equip2 = EquipmentFactory.CreateEquipment(EquipmentFactory.SELECTOR.Bow);
var equip3 = EquipmentFactory.CreateEquipment(EquipmentFactory.SELECTOR.Sword);
equip1.Attack();
equip2.Attack();
equip3.Attack();
equip1.Defense();
equip2.Defense();
equip3.Defense();

Console.WriteLine();
Console.WriteLine("Absctract Factory Pattern");

EnemyShipBuilding MakeUFOs = new UFOEnemyShipBuilding();

EnemyShip theGrunt = MakeUFOs.orderTheShip("UFO");
Console.WriteLine(theGrunt);

EnemyShip theBoss = MakeUFOs.orderTheShip("UFO");
Console.WriteLine(theBoss);
