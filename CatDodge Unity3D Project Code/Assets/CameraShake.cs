﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

    public Camera mainCam;

    float shakeAmount = 0;

    void Awake()
    {
        if (mainCam == null)
            mainCam = Camera.main;
    }
    
    public void Shake(float amt, float lenght)
    {
        shakeAmount = amt;
        InvokeRepeating("BeginShake", 0, 0.01f);
        Invoke("StopShake", lenght);
    }

    void BeginShake()
    {
        if (globalnezmiene.shaking != 1) {
            if (shakeAmount > 0)
            {
                Vector3 camPos = mainCam.transform.position;

                float offsetX = Random.value * shakeAmount * 2 - shakeAmount;
                float offsetY = Random.value * shakeAmount * 2 - shakeAmount;

                camPos.x += offsetX;
                camPos.y += offsetY;

                mainCam.transform.position = camPos;
            }
        }
    }

    public void StopShake()
    {
        CancelInvoke("BeginShake");
        mainCam.transform.localPosition = Vector3.zero;
    }

    void Update()
    {
            Shake(0.01f, 0.2f);
    }
}
