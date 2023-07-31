// See https://aka.ms/new-console-template for more information
using ConsoleAppDesignPatterns.AbstractFactory;
using ConsoleAppDesignPatterns.Adapter;
using ConsoleAppDesignPatterns.Bridge;
using ConsoleAppDesignPatterns.Builder;
using ConsoleAppDesignPatterns.ChainOfResponsibility;
using ConsoleAppDesignPatterns.Command;
using ConsoleAppDesignPatterns.Decorator;
using ConsoleAppDesignPatterns.Facade;
using ConsoleAppDesignPatterns.Factory;
using ConsoleAppDesignPatterns.Memento;
using ConsoleAppDesignPatterns.Observer;
using ConsoleAppDesignPatterns.Prototype;
using ConsoleAppDesignPatterns.Singleton;
using ConsoleAppDesignPatterns.Strategy;
using ConsoleAppDesignPatterns.Template;
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
Console.WriteLine("Chain of Responsibility Pattern");

Chain chainCalc1 = new AddNumbers();
Chain chainCalc2 = new SubtractNumbers();
Chain chainCalc3 = new MultNumbers();
Chain chainCalc4 = new DivideNumbers();

chainCalc1.SetNextChain(chainCalc2);
chainCalc2.SetNextChain(chainCalc3);
chainCalc3.SetNextChain(chainCalc4);

NumbersOperation reequest = new NumbersOperation(4, 2, "add");
chainCalc1.Calculate(reequest);

Console.WriteLine();
Console.WriteLine("Prototype Pattern");

Person p = new Person(1, "Edgar", DateTime.Now, new Address { Id = 1, HouseNumber = 24, Street = "Calle Quebec" });
var a = p.DeepCopy();
a.Name = "Luis";
a.Address.HouseNumber = 48;
Console.WriteLine(p + " " + p.GetHashCode());
Console.WriteLine(a + " " + a.GetHashCode());

Console.WriteLine();
Console.WriteLine("Decorator Pattern");

IPizza basicPizza = new TomatoSauce(new Mozzarella(new PlainPizza()));
Console.WriteLine(basicPizza.GetDescription());
Console.WriteLine(basicPizza.GetCost());

Console.WriteLine();
Console.WriteLine("Command Pattern");

IElectronicDevice electronicDevice = TVRemote.GetDevice();
ICommand onCommand = new TurnTVOn(electronicDevice);
DeviceButton onPressed = new DeviceButton(onCommand);
onPressed.Press();

ICommand offCommand = new TurnTVOff(electronicDevice);
onPressed = new DeviceButton(offCommand);
onPressed.Press();

ICommand volUpCommand = new TurnTVUp(electronicDevice);
onPressed = new DeviceButton(volUpCommand);
onPressed.Press();
onPressed.Press();
onPressed.Press();

IElectronicDevice theTv = new Televison();
IElectronicDevice theRadio = new Radio();
List<IElectronicDevice> allDevices = new() { theTv, theRadio };
ICommand turnItAllOFf = new TurnItAllOff(allDevices);
DeviceButton turnThemOff = new DeviceButton(turnItAllOFf);
turnThemOff.Press();

turnThemOff.PressUndo();

Console.WriteLine();
Console.WriteLine("Adapter Pattern");

EnemyTank rx7Tank = new();
EnemyRobot fred = new();
IEnemyAttacker robotAdpater = new EnemyRobotAdpater(fred);

Console.WriteLine("The Robot");

fred.ReactToHuman("Paul");
fred.WalkForward();
fred.SmashWithHands();

Console.WriteLine("The Enemy Tank");

rx7Tank.AssignDriver("Frank");
rx7Tank.DriverForward();
rx7Tank.FireWeapon();

Console.WriteLine("The Robot with Adpater");

robotAdpater.AssignDriver("Mark");
robotAdpater.DriverForward();
robotAdpater.FireWeapon();

Console.WriteLine();
Console.WriteLine("Facade Pattern");

BankAccountFacade accessingBank = new BankAccountFacade(12345678, 1234);
accessingBank.WithdrawCash(50.00);
accessingBank.WithdrawCash(900.00);
accessingBank.DepositCash(200.00);

Console.WriteLine();
Console.WriteLine("Bridge Pattern");

RemoteButton theTV = new TvRemoteMute(new TvDevice(1, 200));
RemoteButton theTV2 = new TvRemoteMute(new TvDevice(1, 200));

Console.WriteLine("Test TV with Mute");
theTV.ButtonFivePressed();
theTV.ButtonSixPressed();
theTV.ButtonNinePressed();

Console.WriteLine("Test TV with Pause");
theTV2.ButtonFivePressed();
theTV2.ButtonSixPressed();
theTV2.ButtonSixPressed();
theTV2.ButtonSixPressed();
theTV2.ButtonSixPressed();
theTV2.ButtonNinePressed();
theTV2.DeviceFeedBack();

Console.WriteLine();
Console.WriteLine("Template Pattern");

Hoagie cust12Hoagie = new ItalianHoagie();
cust12Hoagie.MakeSandwich();

Hoagie cust13Hoagie = new VeggeiHoagie();
cust13Hoagie.MakeSandwich();