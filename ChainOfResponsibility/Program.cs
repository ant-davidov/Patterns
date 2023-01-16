using ChainOfResponsibility.BrokerChain;
using ChainOfResponsibility.ChainOfResponsibility;
using Creature = ChainOfResponsibility.ChainOfResponsibility.Creature;
using ChainOfResponsibility.BrokerChain.Modifiers;
var choiceFolder = true;

if (!choiceFolder)
{
    var goblin = new Creature("Goblin", 1, 1);
    Console.WriteLine(goblin);
    var root = new CreatureModifier(goblin);
    //root.Add(new NoBonusesModifier(goblin)); 
    root.Add(new DoubleAttackModifier(goblin));
    root.Add(new DoubleAttackModifier(goblin));
    root.Add(new IncreaseDefenseModifier(goblin));
    root.Handle();
    Console.WriteLine(goblin);
}
else
{
    var game = new Game();
    var goblin = new NewCreature(game, "Strong Goblin", 2, 2);
    Console.WriteLine(goblin);

    using (new NewDoubleAttackModifier(game, goblin))
    {
        Console.WriteLine(goblin);
        using (new NewIncreaseDefenseModifier(game, goblin))
        {
            Console.WriteLine(goblin);
        }
    }

    Console.WriteLine(goblin);
}