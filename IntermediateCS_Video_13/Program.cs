using System;

class FieldExample
{
    // A field declaration is like a local variable declaration...

    string name = "Eric";

    // but the "var" syntax, unfortunately, is not supported for fields.
    // var birthday = new DateTime(1972, 11, 30);

    readonly decimal dollars;

    // A field initializer may not access "this" because experience has show that
    // practice to be a common cause of bugs.

    // int length = this.name.Length;

    // Fields are by default "instance" fields. A "static" field is a variable
    // associated with the class, not an instance of the class.
    static int count = 0;

}