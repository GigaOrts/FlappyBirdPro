using UnityEngine;
using Zenject;

public class PipeFactoryInstaller : MonoInstaller
{
    [SerializeField] private PipeHazard pipePrefab; 

    public override void InstallBindings()
    {
        Container.Bind<PipeFactory>().FromComponentInHierarchy().AsSingle();
        Container.Bind<PipeHazard>().FromComponentInNewPrefab(pipePrefab).AsTransient(); 
    }
}
