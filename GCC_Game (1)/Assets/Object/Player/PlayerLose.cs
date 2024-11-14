using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLose : MonoBehaviour
{
    public GameObject coinManager;
    public GameObject enemiesManager;
    public GameObject endGamePanel;
    void Update()
    {
        if (gameObject.tag=="Defeated") {
            gameObject.SetActive(false);
            coinManager.SetActive(false);
            enemiesManager.SetActive(false);
            endGamePanel.SetActive(true);
        }
    }
}
