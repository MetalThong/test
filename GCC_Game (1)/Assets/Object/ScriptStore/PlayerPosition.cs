using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public GameObject player;
    protected Transform transformPlayer;
    protected virtual void GetPosition() 
    {
        if (player==null) return;
        if (player.transform.tag == "UFO") 
        {
            transformPlayer = player.transform.Find("UFOPrefab(Clone)");
        }
        else 
        {
            transformPlayer = player.transform.Find("RocketPrefab(Clone)");
        }
    }
}
