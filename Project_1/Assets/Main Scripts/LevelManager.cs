using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform instatiatePos;

    public CameraFollow cameraFollow;
    // Start is called before the first frame update
    void Start()
    {
       GameObject go = Instantiate(ballPrefab, instatiatePos.position, Quaternion.identity); 
       cameraFollow.target = go.transform;
    }

    
}
