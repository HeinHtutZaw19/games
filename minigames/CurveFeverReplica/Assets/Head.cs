
using UnityEngine;

public class Head : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 3f;
    public float rotationSpeed = 250f;
    private float horizontal;
    public string inputAxis = "Horizontal";

    // Update is called once per frame

    void Update()
    {
        horizontal = Input.GetAxisRaw(inputAxis);
    }
    void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.fixedDeltaTime);
        transform.Rotate(Vector3.forward * -horizontal * rotationSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("killsPlayer"))
        {
            rotationSpeed = 0;
            speed = 0;
            GameObject.FindObjectOfType<GameManager>().Restart();
        }
    }
}
