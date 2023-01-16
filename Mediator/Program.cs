using Mediator;

ClassMediator mediator = new ClassMediator();
var p1 = new Participant(mediator);
var p2 = new Participant(mediator);
p1.Say(2);
Console.WriteLine(p2.Value);