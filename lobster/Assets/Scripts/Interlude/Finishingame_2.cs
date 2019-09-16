﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finishingame_2 : MonoBehaviour
{

    public float time, startTime;
    public static float limit;
    public new GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {    
        gameObject.gameObject.SetActive(false);
        GameManager.instance.sound = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("시간 : " + Time.time);  주석처리
        StopGame();

    }

    void StopGame()
    {

        if (GameManager.instance.life <= 0) //패배
        {       
            Time.timeScale = 0;
            gameObject.gameObject.SetActive(true);
            if (GameManager.instance.sound == false)
            {
                BgmManager.StopSound();
                BgmManager.PlaySound2("end");
                //Debug.Log("플레이됨");
                GameManager.instance.sound = true;
            }
        }


    }
}
