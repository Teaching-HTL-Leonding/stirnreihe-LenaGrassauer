﻿namespace Stirnreihe.Data;

public class LineOfPersons
{
    public Node? First {get; set;}
    public void AddToFront(Person person)
    {
        var node = new Node(person);
        node.Next = First;
        First = node;
    }

    public void Clear()
    {
        First = null;
    }
}
