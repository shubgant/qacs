using OberverVSDelegate;

//Observer
var subject = new Subject();

var observer1 = new ConcreteObserver("A");
var observer2 = new ConcreteObserver("B");

subject.Attach(observer1);
subject.Attach(observer2);

subject.State = 10; // Notifies all observers
subject.State = 20; // Notifies all observers


//Delegate
var subjectWithDelegate = new SubjectWithDelegate();

// Attach observers using delegates
subjectWithDelegate.StateChanged += (newState) =>
{
    Console.WriteLine($"Observer A received update: State is now {newState}");
};

subjectWithDelegate.StateChanged += (newState) =>
{
    Console.WriteLine($"Observer B received update: State is now {newState}");
};

subjectWithDelegate.State = 10; // Notifies all subscribers
subjectWithDelegate.State = 20; // Notifies all subscribers