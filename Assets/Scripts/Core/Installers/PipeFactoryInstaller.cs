using UnityEngine;
using Zenject;

public class PipeFactoryInstaller : MonoInstaller<PipeFactoryInstaller>
{
    [SerializeField] private PipeHazard pipePrefab;

    public override void InstallBindings()
    {
        // ����������� ������ � ����������
        Container
            .Bind<PipeHazard>()
            .FromInstance(pipePrefab)
            .AsSingle();

        // ����� ��������� ������ � Factory
        Container
            .BindFactory<PipeHazard, PipeFactory>()
            .To<PipeHazard>()
            .FromComponentInNewPrefab(pipePrefab); // (������ .To<PipeHazard>())
    }
}
