using System;

namespace AddressBookSystem
{
    class Program
    {
        private static object addressBook;

        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to the Address Book Program");
                Console.WriteLine("Enter what you want to do : \n 1. Create Contacts \n 2. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact details of FirstName, LastName, Address, City, State, Zip, Ph.no, Email : ");
                        Contact contact = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            PhoneNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        break;
                    case 2:
                        Console.WriteLine("Enter the Contact Information to be Add in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                        contact = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            PhoneNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        AddressBook.AddContact(contact);
                        AddressBook.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter the Contact Name to be Edited: ");
                        string name = Console.ReadLine();
                        AddressBook.EditContact(name);
                        AddressBook.Display();
                        break;
                        break;
                    case 4:
                        Console.WriteLine("Enter the Contact Name to be deleted : ");
                        string detail = Console.ReadLine();
                        AddressBook.DeleteContact(detail);
                        AddressBook.Display();
                        break;
                    case 5:
                        Console.WriteLine("Enter the Contact Information to be Add in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                        contact = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            PhoneNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        addressBook.AddContact(contact);
                        addressBook.Display();
                        break;
                    case 6:
                        Console.WriteLine("Enter the Unique Contact to be added: ");
                        string unique = Console.ReadLine();
                        addressBook.AddUniqueContact(unique);
                        addressBook.DisplayUniqueContacts();
                        break;
                    case 7:
                        addressBook.CheckDuplicateEntry();
                        break;
                    case 8:
                        Console.WriteLine("Enter input 1 for City and 2 for State");
                        int result = Convert.ToInt32(Console.ReadLine());
                        if (result == 1)
                        {
                            addressBook.CityList();
                            break;
                        }
                        if (result == 2)
                        {
                            addressBook.StateList();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter correct input");
                        }
                        break;
                    case 9:
                        break;
                    case 10:
                        Console.WriteLine("Enter input 1 for City and 2 for State");
                        int res = Convert.ToInt32(Console.ReadLine());
                        if (res == 1)
                        {
                            addressBook.CityCount();
                            break;
                        }
                        if (res == 2)
                        {
                            addressBook.StateCount();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter correct input");
                        }
                        break;
                    case 11:
                        addressBook.AddressBookSorting();
                        break;
                  
                    case 12:
                        addressBook.SortBy();
                        break;
                    case 13:
                        addressBook.ReadFile();
                        addressBook.WriteUsingStreamWriter();
                        break;
                   
                    case 14:
                        addressBook.ReadWriteAsCsv();
                        break;
                    case 15:
                        flag = false;
                        break;
                }
            }
        }
    }
}