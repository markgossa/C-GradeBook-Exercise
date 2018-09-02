using System;
using System.Collections.Generic;
using System.Text;

namespace Grades
{
    // Create a new delegate type which references a method that returns void 
    // and takes two strings
    public delegate void NameChangedDelegate(string existingName, string newName);
}
