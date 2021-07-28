using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 5f;
    float spd;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spd = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        Vector2 v = GetComponent<Rigidbody2D>().velocity;
        v.x = spd * movementSpeed;
        GetComponent<Rigidbody2D>().velocity = v;
    }
}
