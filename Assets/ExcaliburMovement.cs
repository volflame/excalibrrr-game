using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Unity.Cinemachine;
using UnityEditor.Callbacks;

public class ExcaliburMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(0, moveSpeed, 0);
            // gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -1f, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.rotation = Quaternion.Euler(0, 0, 45);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        Vector2 pos = rb.position;
        pos.y = Mathf.Clamp(pos.y, -17.1f, 100);
        rb.position = pos;
    }

    void OnCollisionEnter2D()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -moveSpeed, 0);
    }
}
