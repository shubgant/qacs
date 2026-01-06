using CommandPatternVsDelegate;

//Command Pattern
var invoker = new CommandInvoker();

// Create commands
var addCommand = new AddCommand(5, 3);
var multiplyCommand = new MultiplyCommand(5, 3);

// Add commands to invoker
invoker.AddCommand(addCommand);
invoker.AddCommand(multiplyCommand);

// Execute all commands
invoker.ExecuteAll();


// Func Delegate
// Define a list of operations using Func
List<Func<string>> operations = new List<Func<string>>();

// Add operations
operations.Add(() =>
{
    int a = 5, b = 3;
    return $"Result of addition: {a + b}";
});

operations.Add(() =>
{
    int a = 5, b = 3;
    return $"Result of multiplication: {a * b}";
});

// Execute all operations
foreach (var operation in operations)
{
    Console.WriteLine(operation());
}
