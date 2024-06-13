using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    // Start is called before the first frame update
    List<string> myList = new List<string>();
    void Start()
    {
        myList.Add("john");
        myList.Add("bob");
        myList.Add("hello");

        for (int i = 0; i < myList.Count; i++)
        {
            Debug.Log("Names : " + myList[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
