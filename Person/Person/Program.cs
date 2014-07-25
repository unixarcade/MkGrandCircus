using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    private string myName = "N/A";
    private int myAge = 0;

    // Declare name property type string

    public string Name
    {
        get
        {
            return myName;
        }
        set
        {
            myName = value;
        }
    }
    // Declare an Age property
    public int Age
    {
        get
        {
            return myAge;
        }
        set
        {
            myAge = value;
        }
    }

    public override string ToString()
    {
        return "Name = " + Name + ", Age = " + Age;
    }
public static void Main()
    {
        Console.WriteLine("Simple Properties");
    // Create a new person object
        Person person = new Person();
    // Print out the name and the age association
        Console.WriteLine("Details of a person - {0}", person);
    // Set some values on the person object:
        person.Name = "MRK";
        person.Age = 117293;
        Console.WriteLine("Person details - {0}", person);

    // Increment the age
        person.Age += 1;
        Console.WriteLine("Person details - {0}", person);

    Person person2 = new Person();
    Console.WriteLine("Details of person2 - {0}", person );
    person2.Name = "Family";
    person2.Age = 11111111;
    person2.Age += 1;
    Console.WriteLine("Person details 2 - {0}", person);



    }
}

