﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LevelSelect(int level){
        if (level == 1){
            SceneManager.LoadScene("Level01");
        }else if(level == 2){
            SceneManager.LoadScene("Level02");
        }else if(level == 3){
            SceneManager.LoadScene("Level03");
        }
    }
}
