using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour
{
    public CountManage coin;
    void Start()
    {
        Destroy (gameObject, 5);
        GameObject coinManager = GameObject.Find("CoinManager");
        if (coinManager != null) coin=coinManager.GetComponent<CountManage>();
    }

    private void OnCollisionEnter2D (Collision2D other) 
    {
        if (coin!=null) {
            if (other.gameObject.tag=="UFO" || other.gameObject.tag=="Rocket") {
                coin.counts++;
                Destroy (gameObject);
            }
        }
    } 
}