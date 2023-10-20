using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public int exp = 0;

    public Character() // constructor
    {
        name = "Not assigned";
    }

    public Character(string name) // constructor overloading
    {
        this.name = name;
    }

    public virtual void PrintStatsInfo()
    {
        Debug.LogFormat("Hero: {0} - {1} EXP", name, exp);
    }
}
