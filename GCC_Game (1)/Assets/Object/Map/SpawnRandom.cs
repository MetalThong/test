using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : PlayerPosition
{
    public GameObject enemies;
    public GameObject items;
    public float spawnTime = 1.5f;
    private float currentTime;
    private bool isItem;

    void Start()
    {
        currentTime = spawnTime;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;
        if (currentTime <0) 
        {
            isItem = Random.Range(0,2)==1;
            SpawnObject(enemies);
            if (isItem) SpawnObject(items);
            currentTime = spawnTime;
        }
    }

    void SpawnObject(GameObject obj)
    {
        GetPosition();
        if (transformPlayer != null ) {
            Vector3 pos = new Vector3(
                Random.Range(transformPlayer.position.x+3, transformPlayer.position.x+5),
                Random.Range(transformPlayer.position.y-5, transformPlayer.position.y+5),
                0);
            Instantiate(obj, pos, Quaternion.identity, transform);
        }   
    }
}