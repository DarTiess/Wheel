using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[CreateAssetMenu(fileName = "LoadScene", menuName = "LoadScene", order = 51)]
public class LoadScene : ScriptableObject
{
    public List<string> sceneNames;
    private int numScene;
    public void StartGame()
    {
        Loading(1);
    }

    public void LoadStartScene()
    {
        Loading(0);
    }
    
    public void LoadPrivatePolicy()
    {
        Loading(2);
    }

    public void Loading(int numScene)
    {
        int numLoadedScene = numScene;
      
        Debug.Log("Load Scene  " + numLoadedScene);
       
        SceneManager.LoadScene(sceneNames[numLoadedScene]);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
