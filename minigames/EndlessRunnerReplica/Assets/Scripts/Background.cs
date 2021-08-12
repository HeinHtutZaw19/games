using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private Vector2 targetPos;
    public float speed;
    public float start, end;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x <= end)
        {
            targetPos = new Vector2(start, transform.position.y);
            transform.position = targetPos;   
        }
    }
}
