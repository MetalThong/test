using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float horiDirection;
    private float vertiDirection;
    public int speed=4;
    private Rigidbody2D m_rigidbody2D;
    void Start()
    {
        m_rigidbody2D= GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horiDirection= Input.GetAxis("Horizontal");
        if (transform.tag=="UFO") 
        {
            m_rigidbody2D.velocity= new Vector2(horiDirection*speed, m_rigidbody2D.velocity.y);
        }
        else 
        {
            vertiDirection= Input.GetAxis("Vertical");
            m_rigidbody2D.velocity= new Vector2(horiDirection*speed, vertiDirection*speed);
        }
    }

    private void OnCollisionEnter2D (Collision2D other) 
    {
        if (other.gameObject.tag=="Enemies") 
        {
            transform.parent.tag = "Defeated";
            Destroy(gameObject);
        }
    }
}
