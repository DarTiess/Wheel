using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   
    [SerializeField]
    private LoadScene loadScene;
    public void LoadStartScene()
    {
        loadScene.LoadStartScene();
       
    }
    public void StartingGame()
    {
        loadScene.StartGame();
       
    } 
    
    public void LoadPrivatePolicy()
    {
        loadScene.LoadPrivatePolicy();
      
    }

    public void RestartScene()
    {
        loadScene.RestartScene();
    }
}
