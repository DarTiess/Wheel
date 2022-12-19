using UnityEngine;
using Zenject;

public class WheelInstaller : MonoInstaller
{
    [SerializeField]private GameObject wheelObj;
    public override void InstallBindings()
    {
        Container.Bind<WheelController>().FromComponentOn(wheelObj).AsSingle();
    }
}