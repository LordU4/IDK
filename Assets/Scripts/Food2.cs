using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food2 : Food
{
    public string FattAmount;

    public virtual void PrintInfo4()
    {
        Debug.Log(FattAmount);
    }
}