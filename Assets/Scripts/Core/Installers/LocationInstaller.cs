using UnityEngine;
using Zenject;

public class LocationInstaller : MonoInstaller
{

    [SerializeField] private Transform _startPoint;
    [SerializeField] private Player _playerPrefab;

    public override void InstallBindings()
    {
        Player player = Container
            .InstantiatePrefabForComponent<Player>(_playerPrefab, _startPoint.position, Quaternion.identity, null);

        Container
            .Bind<Player>()
            .FromInstance(player)
            .AsSingle();
    }
}