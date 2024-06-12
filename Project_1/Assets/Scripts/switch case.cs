using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class switchcase : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    void Start()
    {
        switch(score)
    {   case 5:
            Debug.Log("Score is half");
            break;
        case 10:
            Debug.Log("Score is perfect");
            break;

        default:
            Debug.Log("The score is not good");
            break; 
    }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
