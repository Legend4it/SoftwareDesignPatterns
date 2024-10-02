// Create plain text
        IText myText = new PlainText("Hello, World!");

        // Decorate with bold
        myText = new BoldDecorator(myText);
        Console.WriteLine(myText.GetContent()); // Output: <b>Hello, World!</b>

        // Decorate with italic
        myText = new ItalicDecorator(myText);
        Console.WriteLine(myText.GetContent()); // Output: <i><b>Hello, World!</b></i>

        // Decorate with underline
        myText = new UnderlineDecorator(myText);
        Console.WriteLine(myText.GetContent()); // Output: <u><i><b>Hello, World!</b></i></u>
    
