using System;
using System.Collections.Generic;

public class Contact
{
  public string Name;
  public string Phone;
  public string Address;
}

class Program
{
  public static void Main()
  {
    Contact hendrix = new Contact();
    hendrix.Name = "Jimi Hendrix";
    hendrix.Phone = "503-826-9371";
    hendrix.Address = "208 SW 5th St. Portland, OR 97204";

    Contact elvis = new Contact();
    elvis.Name = "Elvis Presley";
    elvis.Phone = "617-356-3571";
    elvis.Address = "Graceland, TN";

    Contact einstein= new Contact();
    einstein.Name = "Albert Einstein";
    einstein.Phone = "415-738-4935";
    einstein.Address = "3718 MLK Blvd. Oakland, CA 94609";

    Contact marie = new Contact();
    marie.Name = "Marie Curie";
    marie.Phone = "432-154-3523";
    marie.Address = "1911 West 1st Ave. Fictional, OR 44556";

    Contact janis = new Contact();
    janis.Name = "Janis Joplin";
    janis.Phone = "415-124-2445";
    janis.Address = "Haight Ashbury, San Francisco, CA 94117";

    List<Contact> AddressBook = new List<Contact>() { hendrix, elvis, einstein };
    AddressBook.Add(marie);
    AddressBook.Add(janis);
    
    foreach (Contact person in AddressBook)
    {
      Console.WriteLine("Name: " + person.Name);
      Console.WriteLine("Phone number: " + person.Phone);
      Console.WriteLine("Address: " + person.Address + "\n");
    }
  }
}
