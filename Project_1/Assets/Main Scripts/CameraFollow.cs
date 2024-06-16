using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    // Update is called once per frame
    private void Update()
    {
        //position of the camera  = position of target + offset
        transform.position = target.position + offset;
        
    }
}
