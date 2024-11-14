using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Animations;
using UnityEditor.Callbacks;
using UnityEngine;

public class StarMove : MonoBehaviour
{
    public float speed = 7f;
    public float scale = 0.005f;
    private Rigidbody2D m_rigidbody2D;
    void Start()
    {
        m_rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        m_rigidbody2D.velocity = new Vector3 (speed, 0, 0);
        transform.localScale += new Vector3 (scale, scale, 0);
    }

    private void OnCollisionEnter2D (Collision2D other) 
    {
        if (other.gameObject.tag=="Enemies" || other.gameObject.tag=="Items") 
        {
            Destroy(gameObject);
        }
    }
    private void OnBecameInvisible() 
    {
        Destroy(gameObject);
    }
}