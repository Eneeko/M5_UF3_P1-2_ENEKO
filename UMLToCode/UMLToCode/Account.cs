using System;
using System.Collections.Generic;
using System.Text;

public abstract class Account : Customer
{
    public string IBAN;
    public float Amount;
    public abstract bool transaction (string path);
}

public abstract class Investing : Account
{
    public float Interest;
    public string ApplyInterest;
}

public abstract class Savings : Account
{
    public float ProtectedAmount;
    public string LiberateSaving;
}