using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;
    private string tag_wall = "Wall";
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (horizontalInput,0.0f, verticalInput) * speed * Time.deltaTime;
        


        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce (movement);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == tag_wall)
        {
            Debug.Log("Ball is collided with Wall");
            ScoreManeger.instance.AddScore(-1);
        }
    }
}
