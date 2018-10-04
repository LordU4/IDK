using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public string DisplayName;
    public float weight;
    public float cost;

    public float getpriceperweight()
    {
        return cost / weight;
    }
    public override string ToString()
    {
        return "This is a " + DisplayName + " and weights in kg " + weight + " and it costs in kr " + cost + " so the price per kg is " + getpriceperweight();
    }
    public  virtual void OnMouseEnter()
    {
        print(ToString());
    }
}
