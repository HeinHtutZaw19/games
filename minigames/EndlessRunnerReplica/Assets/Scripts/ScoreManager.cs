using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int points;
    public Text scoreDisplay;
    public PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = points.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (player.health > 0 && collision.CompareTag("Obstacle"))
        {
            points += 1;
        }
    }
}
