using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    public BtnController action;
    private float horizontalMove;
    public float speed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        MovementPlayer();

        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);

        Vector3 posicion = transform.position;
        posicion.x = Mathf.Clamp(posicion.x, -2.5f, 2.5f);
        posicion.y = Mathf.Clamp(posicion.y, -3, 3);
        transform.position = posicion;
    }

    private void MovementPlayer()
    {
        if (action.moveLeft || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            horizontalMove = -speed;
            //gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (action.moveRight || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            horizontalMove = speed;
            //gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            horizontalMove = 0;
        }
    }
}
