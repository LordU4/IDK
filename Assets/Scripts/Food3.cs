using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food3 : Food
{
    public string Tastynes;

    public virtual void printinfo5()
    {
        Debug.Log(Tastynes);
    }
}
