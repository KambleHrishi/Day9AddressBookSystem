﻿using System.Collections;

namespace Day9AddressBookSystem
{
    public class Address
    {
        public string firstName, firstName2, lastName, lastName2, address, address2, city, city2, state, state2, zip, zip2, phoneNo, phoneNo2, email, email2;
        public int value;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Address a = new Address();
            ArrayList addbook = new ArrayList();
            choice();
            void choice()
            {
                Console.WriteLine("Enter 1 to Add Details");
                Console.WriteLine("Enter 2 to Add 2nd Person Details");
                Console.WriteLine("Enter 3 to Edit Existing Detail");
                a.value = Convert.ToInt32(Console.ReadLine());
                switch (a.value)
                {
                    case 1:

                        Console.WriteLine("Enter First Name ");
                        a.firstName = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.firstName);
                        Console.WriteLine("Enter Last Name");
                        a.lastName = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.lastName);
                        Console.WriteLine("Enter Address ");
                        a.address = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.address);
                        Console.WriteLine("Enter city");
                        a.city = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.city);
                        Console.WriteLine("Enter state");
                        a.state = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.state);
                        Console.WriteLine("Enter zip");
                        a.zip = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.zip);
                        Console.WriteLine("Enter Phone Number");
                        a.phoneNo = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.phoneNo);
                        Console.WriteLine("Enter Email");
                        a.email = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.email);

                        Console.WriteLine("Given Detail Are : ");
                        Console.WriteLine("First Name = " + addbook[0]);
                        Console.WriteLine("Lastt Name = " + addbook[1]);
                        Console.WriteLine("Address = " + addbook[2]);
                        Console.WriteLine("City = " + addbook[3]);
                        Console.WriteLine("State = " + addbook[4]);
                        Console.WriteLine("Zip = " + addbook[5]);
                        Console.WriteLine("Phone Number = " + addbook[6]);
                        Console.WriteLine("Email = " + addbook[7]);
                        break;
                    case 2:
                        Console.WriteLine("Enter First Name ");
                        a.firstName2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.firstName2);
                        Console.WriteLine("Enter Last Name");
                        a.lastName2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.lastName2);
                        Console.WriteLine("Enter Address ");
                        a.address2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.address2);
                        Console.WriteLine("Enter city");
                        a.city = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.city2);
                        Console.WriteLine("Enter state");
                        a.state2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.state2);
                        Console.WriteLine("Enter zip");
                        a.zip2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.zip2);
                        Console.WriteLine("Enter Phone Number");
                        a.phoneNo2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.phoneNo2);
                        Console.WriteLine("Enter Email");
                        a.email2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.email2);

                        Console.WriteLine("Given new Details Are : ");
                        Console.WriteLine("First Name = " + addbook[8]);
                        Console.WriteLine("Lastt Name = " + addbook[9]);
                        Console.WriteLine("Address = " + addbook[10]);
                        Console.WriteLine("City = " + addbook[11]);
                        Console.WriteLine("State = " + addbook[12]);
                        Console.WriteLine("Zip = " + addbook[13]);
                        Console.WriteLine("Phone Number = " + addbook[14]);
                        Console.WriteLine("Email = " + addbook[15]);
                        break;
                    case 3:
                        Console.WriteLine("Enter the First Name and Last Name of that Person");
                        string fname = Convert.ToString(Console.ReadLine());
                        string lname = Convert.ToString(Console.ReadLine());

                        if ((a.firstName == fname) && (a.lastName == lname))
                        {
                            Console.WriteLine("Enter First Name ");
                            a.firstName = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.firstName);
                            Console.WriteLine("Enter Last Name");
                            a.lastName = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.lastName);
                            Console.WriteLine("Enter Address ");
                            a.address = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.address);
                            Console.WriteLine("Enter city");
                            a.city = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.city);
                            Console.WriteLine("Enter state");
                            a.state = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.state);
                            Console.WriteLine("Enter zip");
                            a.zip = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.zip);
                            Console.WriteLine("Enter Phone Number");
                            a.phoneNo = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.phoneNo);
                            Console.WriteLine("Enter Email");
                            a.email = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.email);
                            Console.WriteLine("Given new Details Are : ");
                            Console.WriteLine("First Name = " + addbook[0]);
                            Console.WriteLine("Lastt Name = " + addbook[1]);
                            Console.WriteLine("Address = " + addbook[2]);
                            Console.WriteLine("City = " + addbook[3]);
                            Console.WriteLine("State = " + addbook[4]);
                            Console.WriteLine("Zip = " + addbook[5]);
                            Console.WriteLine("Phone Number = " + addbook[6]);
                            Console.WriteLine("Email = " + addbook[7]);
                        }
                        else if ((a.firstName2 == fname) && (a.lastName2 == lname))
                        {
                            Console.WriteLine("Enter First Name ");
                            a.firstName2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.firstName2);
                            Console.WriteLine("Enter Last Name");
                            a.lastName2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.lastName2);
                            Console.WriteLine("Enter Address ");
                            a.address2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.address2);
                            Console.WriteLine("Enter city");
                            a.city = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.city2);
                            Console.WriteLine("Enter state");
                            a.state2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.state2);
                            Console.WriteLine("Enter zip");
                            a.zip2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.zip2);
                            Console.WriteLine("Enter Phone Number");
                            a.phoneNo2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.phoneNo2);
                            Console.WriteLine("Enter Email");
                            a.email2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.email2);

                            Console.WriteLine("Given new Details Are : ");
                            Console.WriteLine("First Name = " + addbook[8]);
                            Console.WriteLine("Lastt Name = " + addbook[9]);
                            Console.WriteLine("Address = " + addbook[10]);
                            Console.WriteLine("City = " + addbook[11]);
                            Console.WriteLine("State = " + addbook[12]);
                            Console.WriteLine("Zip = " + addbook[13]);
                            Console.WriteLine("Phone Number = " + addbook[14]);
                            Console.WriteLine("Email = " + addbook[15]);
                        }
                        break;
                }
                choice();
            }
        }
    }
}