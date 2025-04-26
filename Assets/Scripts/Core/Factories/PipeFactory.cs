using UnityEngine;

public class PipeFactory : MonoBehaviour
{
    [SerializeField] private PipeHazard _pipePrefab; 

    [SerializeField] private float _spawnYMin = -2f; 
    [SerializeField] private float _spawnYMax = 2f; 
    [SerializeField] private float _spawnInterval = 2f; 

    private void Start()
    {
        InvokeRepeating(nameof(SpawnPipe), 0f, _spawnInterval); 
    }

    private void SpawnPipe()
    {
        float randomY = Random.Range(_spawnYMin, _spawnYMax);
        int xPosition = 4;
        Vector3 spawnPosition = new Vector3(xPosition, randomY, 0f); 

        Instantiate(_pipePrefab, spawnPosition, Quaternion.identity); 
    }
}
