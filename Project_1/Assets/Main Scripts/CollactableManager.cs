using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollactableManager : MonoBehaviour
{
    int childCount = 0;

    [HideInInspector] public bool allCoinsCollected = false;
    [SerializeField] private int x;

    // Start is called before the first frame update
    void Start()
    {
        childCount = transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount < childCount)
        {
            Debug.Log("A body has been destroyed");
            childCount = transform.childCount;
            if (childCount == 0)
            {
                allCoinsCollected = true;
            }
        }
    }
}
