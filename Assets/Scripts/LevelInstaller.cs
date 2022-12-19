using UnityEngine;
using Zenject;

public class LevelInstaller : MonoInstaller
{
    [SerializeField]
    private GameObject gameManager;

    public override void InstallBindings()
    {
        Container.Bind<GameManager>().FromComponentOn(gameManager).AsSingle();
      
    }
}