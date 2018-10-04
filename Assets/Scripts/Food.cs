using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public string FoodName;

    public virtual void PrintInfo()
    {
        Debug.Log(FoodName);
    }

    public string Value;

    public virtual void PrintInfo1()
    {
        Debug.Log(Value);
    }

    public string Weight;

    public virtual void PrintInfo2()
    {
        Debug.Log(Weight);
    }
}
