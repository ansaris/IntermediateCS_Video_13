using System;

class FieldExample
{
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
        //this.dollars = dollars;
        // ... except...

        // Notice that we have a parameter and a field both called "dollars".
        // This is a common, though somewhat confusing practice. The unqualified
        // "dollars" refers to the parameter.

        // It's a good practice to ensure that every field is initialized,
        // either in its declaration or in a constructor.
    }

    static void Main()
    {
        FieldExample test = new FieldExample(55);
    }
}