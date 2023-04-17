using System;
using System.Collections.Generic;
using System.Text;


public class Transaction : Account
{
    public string From;
    public string To;
    public float Amount;
    public DateTime Request;

    public override bool transaction(string path)
    {
        throw new NotImplementedException();
    }
}