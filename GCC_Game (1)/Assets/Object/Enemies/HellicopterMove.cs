using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellicopterMove : PlayerPosition
{
    public CountManage hellicopter;
    public float speed = 5f;
    private int checkMove;
    public float moveTime = 1f;
    private float currentTime;
    void Start()
    {
        GameObject enemiesManager = GameObject.Find("EnemiesManager");
        if (enemiesManager != null) hellicopter = enemiesManager.GetComponent<CountManage>();
        player = GameObject.Find("Player");
        currentTime = moveTime;
    }

    void Update()
    {
        Moving();
        Delete();
        
    }
    private void Moving ()
    {
        currentTime -= Time.deltaTime;
        if (currentTime <0) 
        {
            checkMove = Random.Range(-3, 3);
            speed = Random.Range(1, 4);
            currentTime = moveTime;
        }
        if (checkMove == -1) transform.position -= new Vector3 (speed*Time.deltaTime, 0, 0);
        else if (checkMove == 1) transform.position += new Vector3 (speed*Time.deltaTime, 0, 0);
        else if (checkMove != 0) transform.position += checkMove* new Vector3 (speed*Time.deltaTime, Time.deltaTime, 0);
    }
    private void Delete () 
    {
        GetPosition();
        if (transformPlayer != null) {
            if (Vector3.Distance(transformPlayer.position, transform.position) >= 15) 
            {
                Destroy(gameObject);
            }
        }
    }
    private void OnCollisionEnter2D (Collision2D other) 
    {
        if (hellicopter!=null) {
            if (other.gameObject.tag == "Ground" || other.gameObject.tag == "UFO" || other.gameObject.tag == "Rocket") 
            {
                hellicopter.counts++;
                Destroy (gameObject);
            }
        }
    }
    
}