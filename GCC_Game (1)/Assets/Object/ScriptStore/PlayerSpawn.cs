using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    protected int countChild = 0;
    public GameObject typeOfAmmo;
    protected virtual void Spawning () {
        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            Fire();
        }
    }
    protected virtual void Fire () {
        Instantiate(typeOfAmmo, new Vector3(transform.position.x, transform.position.y-0.5f, 0), Quaternion.identity, transform);
    }
}
