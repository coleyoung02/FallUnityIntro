using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Rigidbody2D rb;
    [SerializeField] int moveSpeed = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movementVector = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            movementVector = movementVector + new Vector2(0, 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            movementVector = movementVector + new Vector2(-1, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            movementVector = movementVector + new Vector2(0, -1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            movementVector = movementVector + new Vector2(1, 0);
        }
        rb.velocity = movementVector * moveSpeed;
    }
}
