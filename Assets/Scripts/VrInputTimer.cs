﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrInputTimer : MonoBehaviour
{
    public GameObject ActivatorStuff;
    bool timeractive;
    float currenttime;
    public float MinutesToCount = 0.17f;
    void Start()
    {
        currenttime = MinutesToCount * 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeractive){
            currenttime = currenttime - Time.deltaTime;
        }
        if (currenttime <= 0){
            DoTheJob();
            timeractive = false;
            currenttime = MinutesToCount * 60;
        }
        Debug.Log(currenttime);
    }
    public void OnEnter(){
        timeractive = true;
    }
    public void OnExit(){
        timeractive = false;
        currenttime = MinutesToCount * 60;
    }
    public void DoTheJob(){
        Debug.Log("TimerFinished");
    }
}