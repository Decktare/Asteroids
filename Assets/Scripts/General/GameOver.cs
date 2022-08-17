using UnityEngine;
public static class GameOver
{
    private static GameObject[] enemies;
    public static void PlayerDied()
    {
        Access.gameOverPanelStatic.SetActive(true);
        Access.spawnerStatic.GetComponent<AsteroidSpawner>().StopSpawn();
        Access.spawnerStatic.GetComponent<UFOSpawner>().StopSpawn();
        Access.spawnerStatic.SetActive(false);        
        DestroyEnemys();
    }

    public static void Respawn()
    {
        Access.playerShipStatic.transform.position = Vector3.zero;
        Access.playerShipStatic.SetActive(true);
        Access.gameOverPanelStatic.SetActive(false);
        Access.spawnerStatic.SetActive(true);
        Access.spawnerStatic.GetComponent<AsteroidSpawner>().StartSpawn();
        Access.spawnerStatic.GetComponent<UFOSpawner>().StartSpawn();
    }

    private static void DestroyEnemys()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in enemies)
        {
            Object.Destroy(enemy);
        }

        enemies = null;
    }
}
