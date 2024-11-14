using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountManage : MonoBehaviour
{
    public int counts = 0;
    public TextMeshProUGUI coinText;
    void Start()
    {
        
    }

    void Update()
    {
        coinText.text = counts.ToString();
    }
}
