﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void LateUpdate()
    {
        if (GameManager.instance.stage_level == 2)
        {
            transform.position = new Vector3(11.51f, 15.35f, -10);

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
