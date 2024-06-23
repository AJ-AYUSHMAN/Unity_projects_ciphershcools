using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //add score by usibg scoremanager script
            ScoreManeger.instance.AddScore(1);
            //this code is used for destroy the collectable obj. and float is used to control time
            Invoke("DestroyCollectables", 0.1f);
        }
    }

    void DestroyCollectables()
    {
        Destroy(this.gameObject);
    }
}
