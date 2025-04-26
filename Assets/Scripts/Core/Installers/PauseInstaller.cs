using UnityEngine;
using Zenject;

public class PauseInstaller : MonoInstaller
{
    [SerializeField] private GamePause _gamePausePrefab;

    public override void InstallBindings()
    {
        Container
            .Bind<GamePause>()
            .FromComponentInNewPrefab(_gamePausePrefab)
            .AsSingle()
            .NonLazy();
    }
}