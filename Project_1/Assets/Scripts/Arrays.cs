using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    // Start is called before the first frame update
    public int[] arr = new int[4];

    void Start()
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log("value: " + arr[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
