using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food1 : Food
{
    public string TimeLeft;

    public virtual void printinfo3()
    {
        Debug.Log(TimeLeft);
    }
}
