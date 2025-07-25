using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

public class Comment
{
    public string _personName;
    public string _text;

    public Comment(string personName, string text)
    {
        _personName = personName;
        _text = text;
        Console.WriteLine($"name: {_personName}; message: {_text}");
    }
}