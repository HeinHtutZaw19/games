using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Collidable"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);d
        }
    }
}
