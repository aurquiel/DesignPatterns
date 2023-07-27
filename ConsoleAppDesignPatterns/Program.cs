// See https://aka.ms/new-console-template for more information
using ConsoleAppDesignPatterns.AbstractFactory;
using ConsoleAppDesignPatterns.Builder;
using ConsoleAppDesignPatterns.ChainOfResponsibility;
using ConsoleAppDesignPatterns.Factory;
using ConsoleAppDesignPatterns.Momento;
using ConsoleAppDesignPatterns.Observer;
using ConsoleAppDesignPatterns.Singleton;
using ConsoleAppDesignPatterns.Strategy;
using ConsoleAppDesignPatterns.Visitor;

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
Console.WriteLine(theGrunt.ToString());

EnemyShip theBoss = MakeUFOs.orderTheShip("UFO");
Console.WriteLine(theBoss.ToString());

Console.WriteLine();
Console.WriteLine("Singleton Pattern");

Singleton singleton = Singleton.GetInstance;
Console.WriteLine(singleton.GetHashCode());
singleton = Singleton.GetInstance;
Console.WriteLine(singleton.GetHashCode());

Console.WriteLine();
Console.WriteLine("Builder Pattern");

var builder = new ConcreteBuilder();
Product product = builder.Step1().Step2().Step3().Build();

Console.WriteLine();
Console.WriteLine("Visitor Pattern");

TaxVisitor taxVisitor = new TaxVisitor();
TaxHolidayVisitor taxHolidayVisitor = new TaxHolidayVisitor();

Liquor vodka = new Liquor(12.4);
Tabacco camel = new Tabacco(6.4);
Necessity milk = new Necessity(8.5);

Console.WriteLine(vodka.accept(taxVisitor));
Console.WriteLine(camel.accept(taxVisitor));
Console.WriteLine(milk.accept(taxVisitor));

Console.WriteLine(vodka.accept(taxHolidayVisitor));
Console.WriteLine(camel.accept(taxHolidayVisitor));
Console.WriteLine(milk.accept(taxHolidayVisitor));

Console.WriteLine();
Console.WriteLine("Momento Pattern");

Caretaker caretaker = new Caretaker();
Originator originator = new Originator();

string text = "test1";
originator.Article = text;
caretaker.AddMemento(originator.StoreInMemento());

string text2 = "test2";
originator.Article = text2;
caretaker.AddMemento(originator.StoreInMemento());

string textRestore = originator.RestoreFromMemento(caretaker.GetMemento(0));
Console.WriteLine(textRestore);

Console.WriteLine();
Console.WriteLine("Chain of Responsibility");

Chain chainCalc1 = new AddNumbers();
Chain chainCalc2 = new SubtractNumbers();
Chain chainCalc3 = new MultNumbers();
Chain chainCalc4 = new DivideNumbers();

chainCalc1.SetNextChain(chainCalc2);
chainCalc2.SetNextChain(chainCalc3);
chainCalc3.SetNextChain(chainCalc4);

NumbersOperation reequest = new NumbersOperation(4, 2, "add");
chainCalc1.Calculate(reequest);