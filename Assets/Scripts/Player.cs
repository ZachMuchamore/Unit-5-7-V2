using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("a") == true)
        {
            transform.localScale = new Vector3(-3, 3, 3);
            transform.position = new Vector2(transform.position.x - (speed * Time.deltaTime), transform.position.y);
        }
        if (Input.GetKey("d") == true)
        {
            transform.localScale = new Vector3(3, 3, 3);
            transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y);
        }
    }
}
