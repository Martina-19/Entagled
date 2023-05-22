using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swim : MonoBehaviour
{
    // Movement speed
    private float speed = 2;

    // Swim - stroke force
    [SerializeField] private float force = 300;

    private Rigidbody2D _rigidbody2D;
    
    // Use this for initialization
    void Start()
    {
        // Swim towards the right
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Swim
        if (Input.GetKeyDown(KeyCode.Space))
            _rigidbody2D.AddForce(Vector2.up * force, ForceMode2D.Impulse);

        // Keeps seal moving across the x-axis continously
        Vector2 v = _rigidbody2D.velocity;
        v.x = speed;
        _rigidbody2D.velocity = v;

        _rigidbody2D.rotation = Mathf.Lerp(_rigidbody2D.rotation, _rigidbody2D.velocity.y * 5, Time.deltaTime * 10f);
    }
}
