using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
        // Start is called before the first frame update

    // Update is called once per frame
    public float moveSpeed = 5f;
    public Camera cam;
    public float minX = -10f;
    public float maxX = 10f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector2 pos = rb.position;
        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        rb.position = pos;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);
    }
}
