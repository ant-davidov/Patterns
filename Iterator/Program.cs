
using Iterator;

var node = new Node<char>('a', 
        new Node<char>('b',
        new Node<char>('c'),
        new Node<char>('d')),
        new Node<char>('e'));

foreach (var item in node.PreOrder)
{
    Console.WriteLine(item);
}