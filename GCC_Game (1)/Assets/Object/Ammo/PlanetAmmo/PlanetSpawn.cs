using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSpawn : PlayerSpawn
{
    void Update()
    {
        countChild = transform.childCount;
        if (countChild < 4) 
        {
            Spawning ();
        }  
    }
}
