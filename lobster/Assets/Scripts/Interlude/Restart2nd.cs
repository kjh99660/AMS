﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart2nd : Finishgame
{
    // Start is called before the first frame update


    // Update is called once per frame


    void OnClick_RestartAgainButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        time = startTime;
        Time.timeScale = 1;
    }

}
