using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ifelse : MonoBehaviour
{
    public int age;
    // Start is called before the first frame update
    void Start()
    {
        if (age >= 18)
        {
            Debug.Log("You can vote");
        }
        else {
            Debug.Log("You are too young");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
