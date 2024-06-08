// See https://aka.ms/new-console-template for more information
using Evolution_Chapter6;

Console.WriteLine("Hello, World!");

static void DisplayPerson(Person person)
{
    Console.WriteLine($"Name: {person.Name}");
    Console.WriteLine($"Middle Name: { person.MiddleName ?? "Not provided"}");
}

var person = new Person("John");
DisplayPerson(person);  // Middle name outputs "Not provided"


// interface implementation example
ILogger logger = new ConsoleLogger();
logger.LogWarning("Low Disk Space.");

// using switch expression
AnimalClassifier animalClassifier = new AnimalClassifier();
var animalName = "crocodile";
var resultingClassification = animalClassifier.ClassifyAnimal(animalName); // Output: Dog
Console.WriteLine($"A {animalName} is a {resultingClassification}");

// asynchronous streaming (added these example on the end of the file since market data goes on forever)

var asyncStreamExample = new AsycStreamSimpleExample();
await asyncStreamExample.DisplayAsyncNumbers(); // Output: 0, 1, 2, 3, 4

var consumer = new MarketDataConsumer();
await consumer.DisplayMarketDataAsync();


