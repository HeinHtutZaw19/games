using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject fruitSlicedPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Blade"))
        {
            Debug.Log("ok");
            Vector3 direction = (collision.transform.position - transform.position).normalized;

            Quaternion rotation = Quaternion.LookRotation(direction);

            GameObject slicedFruit = Instantiate(fruitSlicedPrefab, transform.position, rotation);
            Destroy(fruitSlicedPrefab,3f);
            Destroy(gameObject);
        }
    }
}
