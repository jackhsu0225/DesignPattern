﻿using DesignPattern.VisitorPattern.Example1;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new HtmlDocument();
            document.Add(new HeadingNode());
            document.Add(new AnchorNode());
            document.Execute(new HighlightOperation());
        }
    }
}
