using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    public GameObject UFO;
    public GameObject Rocket;
    public GameObject Smoke;
    private GameObject currentPlayer;
    void Start()
    {
        currentPlayer = Instantiate (UFO, transform.position, Quaternion.identity, transform);
        transform.tag = "UFO";
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) 
        {
            Switch();
        }
    }
    private void Switch() 
    {
        if (currentPlayer != null)
        {
            Vector3 currentTransform = currentPlayer.transform.position;
            Destroy(currentPlayer);
            StartCoroutine(SwitchPlayer(currentTransform));
        }
    }

    IEnumerator SwitchPlayer(Vector3 position) 
    {
        GameObject smokeEffect = Instantiate(Smoke, position, Quaternion.identity, transform);
        yield return new WaitForSeconds(0.5f);
        Destroy(smokeEffect);
        if (transform.tag == "UFO") 
        {
            currentPlayer = Instantiate(Rocket, position, Quaternion.identity, transform);
            transform.tag = "Rocket";
        } 
        else 
        {
            currentPlayer = Instantiate(UFO, position, Quaternion.identity, transform);
            transform.tag = "UFO";
        }
    }
}
