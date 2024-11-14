using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UIElements;

public class PlanetMove : MonoBehaviour
{
    public float timeExist = 10f;
    public float scale = 0.001f;
    public Transform m_transform;
    void Start()
    {
        m_transform = GetComponent<Transform>();
        Destroy (gameObject, timeExist);
    }
    void Update() {
        m_transform.localScale += new Vector3 (scale, scale, 0);
    }
    private void OnCollisionEnter2D (Collision2D other) 
    {
        if (other.gameObject.tag=="Enemies") 
        {
            Destroy(gameObject);
        }
    }
}