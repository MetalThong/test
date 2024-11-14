using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : PlayerPosition
{
    public Vector3 cameraOffset = new Vector3(2.5f, 0, -10);
    void Start()
    {
        transformPlayer = player.transform;
    }
    
    void Update()
    {   
        GetPosition();
        CameraFollow();
    }
    private void CameraFollow () {
        if (transformPlayer != null) {
            transform.position = transformPlayer.position + cameraOffset;
        }
    }
}