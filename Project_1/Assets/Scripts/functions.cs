using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functions : MonoBehaviour
{
    // Start is called before the first frame update

    //a global variable
    int global;
    void Start()
    {
        //calling function
        add();
        Debug.Log( Add(1,2));
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    //customised finction
    public void add()
    {
        Debug.Log("this is add function");
    }

    public int Add(int i, int a)
    {
        int result = i+a;
        //result is a local variable
        return result;
    }

}
