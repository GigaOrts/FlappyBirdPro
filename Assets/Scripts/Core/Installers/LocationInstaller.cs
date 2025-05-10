using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

public class LocationInstaller : MonoInstaller
{

    [SerializeField] private Transform _startPoint;
    [FormerlySerializedAs("_playerPrefab")] [SerializeField] private PlayerView playerViewPrefab;

    public override void InstallBindings()
    {
        PlayerView playerView = Container
            .InstantiatePrefabForComponent<PlayerView>(playerViewPrefab, _startPoint.position, Quaternion.identity, null);

        Container
            .Bind<PlayerView>()
            .FromInstance(playerView)
            .AsSingle();
    }
}