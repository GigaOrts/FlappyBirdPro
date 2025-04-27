using UnityEngine;
using Zenject;

public class PipeFactoryInstaller : MonoInstaller<PipeFactoryInstaller>
{
    [SerializeField] private PipeHazard pipePrefab;

    public override void InstallBindings()
    {
        // Привязываем префаб к контейнеру
        Container
            .Bind<PipeHazard>()
            .FromInstance(pipePrefab)
            .AsSingle();

        // Здесь связываем префаб с Factory
        Container
            .BindFactory<PipeHazard, PipeFactory>()
            .To<PipeHazard>()
            .FromComponentInNewPrefab(pipePrefab); // (замена .To<PipeHazard>())
    }
}
