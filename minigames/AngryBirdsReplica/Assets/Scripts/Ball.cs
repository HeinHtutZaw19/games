using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    private bool isPressed = false;
    public Rigidbody2D rb;
    public Rigidbody2D hook;
    public GameObject nextBall;
    private float maxDistance = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            Vector2 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector3.Distance(mouseposition, hook.position) > maxDistance){
                rb.position = hook.position + (mouseposition - hook.position).normalized * maxDistance;
            }
            else
            {
                rb.position = mouseposition;
            }
        }
    }

    private IEnumerator Release()
    {
        yield return new WaitForSeconds(0.15f);
        GetComponent<SpringJoint2D>().enabled = false;
        this.enabled = false;

        yield return new WaitForSeconds(2f);
        if (nextBall == null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        else
        {
            nextBall.SetActive(true);
        }
    }
    void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
        Debug.Log("Clicked");
    }
    void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;
        StartCoroutine(Release());
        Debug.Log("Unclicked");
    }

    
}
