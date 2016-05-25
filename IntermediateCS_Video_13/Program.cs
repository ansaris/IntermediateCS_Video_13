using System;

class FieldExample
{
    public const int MyConstant = 123;
    
    // A field declaration is like a local variable declaration...

    string name = "Eric";

    // but the "var" syntax, unfortunately, is not supported for fields.
    //var birthday = new DateTime(1972, 11, 30);

    // can only be changed when initialized or with a constructor, nowhere else.
    readonly decimal dollars = 123.45m;

    // A field initializer may not access "this" because experience has show that
    // practice to be a common cause of bugs.

    // int length = this.name.Length;

    // Fields are by default "instance" fields. A "static" field is a variable
    // associated with the class, not an instance of the class.
    static int count = 0;

    public FieldExample(decimal dollars)
    {
        // Field initializers are optional; the initializer provides the
        // field value *before* the constructor runs.

        // Fields that are not initialized automatically get a default

        Console.WriteLine(this.dollars);

        // ... except...

        // Notice that we have a parameter and a field both called "dollars".
        // This is a common, though somewhat confusing practice. The unqualified
        // "dollars" refers to the parameter.

        // It's a good practice to ensure that every field is initialized,
        // either in its declaration or in a constructor.

        this.dollars = dollars; // field <-- value of parameter

        // A static field can be accessed through the name of hte type:

        Console.WriteLine(FieldExample.count);

        // but again, that is optional when inside the type:
        count = count + 1;

        // A static field may not be accessed through "this" because it is not
        // associated with the instance:

        // Console.WriteLine(this.count);
    }
}

class Program
{ 
    static void Main(string[] args)
    {
        var example = new FieldExample(123.45m);

        // By default, fields may not be accessed from outside the class:

        //Console.WriteLine(example.name);
        //Console.WriteLine(FieldExample.count);

        // We'll look at how to change the accessibility in a future video, but
        // fields are almost always left inaccessible. This is part of the
        // "encapsulation" strategy of OOP.

        // Let's create a second instance variable:

        var another = new FieldExample(456.78m);

        // Though we cannot access the fields from outside the class, the debugger can.

        // Constant fields are not variables. They must be intialized, and the initialization
        // must itself be entirely constants. Constant fields are automatically static.

        // Constants are sometimes accessible from outside the class.

        Console.WriteLine(FieldExample.MyConstant);

        Console.WriteLine(Math.PI);

        // Using ALL CAPS was an error here; Java uses ALL CAPS for constants but C# does not.

        // Readonly fields are variables but they can only be written in an intializer
        // or in the constructor.
    }
}