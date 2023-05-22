using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    // Reference Health Script
    public int enemydamage = 1;
    private bool _collided = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player" && _collided == false)
        {
            Health health = col.GetComponent<Health>();
            health.TakeDamage(enemydamage);
            _collided = true;
        }
    }

}
