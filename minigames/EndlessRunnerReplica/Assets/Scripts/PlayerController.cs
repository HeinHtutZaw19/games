using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Vector2 targetPos;
    public float speed;
    public int health = 5;
    public GameObject effect;
    public Text healthDisplay;
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        healthDisplay.text = health.ToString();
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if(health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
            
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && targetPos.y<3)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + 3);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow) && targetPos.y>-3)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - 3);
        }
    }
}
