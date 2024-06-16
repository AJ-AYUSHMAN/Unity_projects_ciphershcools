using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Invoke("DestroyCollectables", 0.2f);
        }
    }

    void DestroyCollectables()
    {
        Destroy(this.gameObject);
    }
}
