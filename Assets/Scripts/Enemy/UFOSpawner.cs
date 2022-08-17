using UnityEngine;

public class UFOSpawner : MonoBehaviour
{
    public float spawnRate = 1.0f;
    public float trajectoryVariance = 15.0f;
    public int spawnAmount = 2;

    private float spawnDistance = 10.0f;

    [SerializeField] private UFO ufoPrefab;
    private void Start()
    {
        StartSpawn();
    }

    private void Spawn()
    {
        for (int i = 0; i < spawnAmount; i++)
        {
            Vector3 spawnDirection = Random.insideUnitCircle.normalized * spawnDistance;
            Vector3 spawnPoint = transform.position + spawnDirection;

            float variance = 0.0f;
            Quaternion rotation = Quaternion.AngleAxis(variance, Vector3.forward);

            UFO UFO = Instantiate(ufoPrefab, spawnPoint, rotation);
        }
    }
    public void StopSpawn()
    {
        CancelInvoke();
    }
    public void StartSpawn()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }
}
