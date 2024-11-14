using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMap : PlayerPosition
{
    public float currentDis = 0f;
    public float limitDis = 38.4f;
    public float respawnDis = 57.6f;
    void Start()
    {
        
    }
    void Update()
    {
        GetDistance();
        Spawning();
    }
    private void Spawning () 
    {
        Vector3 pos= transform.position;
        if (Mathf.Abs(currentDis) < limitDis) return;
        else if (currentDis >= limitDis) 
        {
            pos.x += respawnDis;
        }
        else {
            pos.x -= respawnDis;
        }
        transform.position = pos;
    }
    private void GetDistance ()
     {
        GetPosition();
        if (transformPlayer != null) {
            currentDis = transformPlayer.position.x - transform.position.x;
        }
    }
}
