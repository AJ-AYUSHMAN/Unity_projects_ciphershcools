using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DataTypes : MonoBehaviour
{
    int i = 3;
    float f = 2.2f;
    bool b = false;
    // Start is called before the first frame update
    public string mystring;
    void Start()
    {   
        Debug.Log("The value of integer is :" +  i);
        Debug.Log("The value of float is : " +  f);
        Debug.Log("The value of boolean is :" + b);
        Debug.Log("The value of string is :"+ mystring);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
