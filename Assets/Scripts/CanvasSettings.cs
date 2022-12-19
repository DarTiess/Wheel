using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class CanvasSettings : MonoBehaviour
{
    [SerializeField] private Button startBtn;
    [SerializeField] private Button policyBtn;
    [SerializeField] private Button backBtn;
  

    [Inject]
    private GameManager gameManager;

      // Start is called before the first frame update
    void Start()
    {
        backBtn.onClick.AddListener(BackToStartPanel);
        startBtn.onClick.AddListener(StartingGame);
        policyBtn.onClick.AddListener(GetPolicy);
       
    }

    private void BackToStartPanel()
    {
        gameManager.LoadStartScene();
       
    }

    private void GetPolicy()
    {
        gameManager.LoadPrivatePolicy();
       
    }

    private void StartingGame()
    {
        gameManager.StartingGame();
    }

   
}
