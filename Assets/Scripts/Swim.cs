using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swim : MonoBehaviour
{
    // Movement speed
    private float speed = 2;

    // Swim - stroke force
    [SerializeField] private float force = 300;
    
    // Use this for initialization
    void Start()
    {
        // Swim towards the right
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        // Swim
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force, ForceMode2D.Impulse);
    }
}
