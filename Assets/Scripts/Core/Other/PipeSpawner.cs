using UnityEngine;
using Zenject;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private PipeHazard _pipePrefab;
    [SerializeField] private Transform _spawnPoint;

    [SerializeField] private float _spawnYMin = -2f;
    [SerializeField] private float _spawnYMax = 2f;
    [SerializeField] private float _spawnInterval = 2f;

    private PipeFactory _pipeFactory;

    [Inject]
    private void Construct(PipeFactory pipeFactory)
    {
        _pipeFactory = pipeFactory;
    }

    private void Start()
    {
        InvokeRepeating(nameof(SpawnPipe), 0f, _spawnInterval);
    }

    private void SpawnPipe()
    {
        Vector3 spawnPosition = RandomizePositionY();

        PipeHazard pipeHazard = _pipeFactory.Create();
        pipeHazard.transform.position = spawnPosition;
    }

    private Vector3 RandomizePositionY()
    {
        float randomY = Random.Range(_spawnYMin, _spawnYMax);
        Vector3 spawnPosition = new Vector3(_spawnPoint.position.x, randomY, 0f);
        return spawnPosition;
    }
}
