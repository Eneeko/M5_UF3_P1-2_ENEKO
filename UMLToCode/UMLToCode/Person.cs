using System;
using System.Collections.Generic;

public class Person
{
    public int ID;
    public string Name;
    public string Phone;
    public string Email;
}

public class Customer : Person
{
    public DateTime Regristation;
    public int CreditScore;
}

public class Employee : Person
{
    public enum Department { };
    public float Salary;

}
