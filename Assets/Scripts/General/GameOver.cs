using UnityEngine;
public static class GameOver
{
    private static PlayerShip playerShip = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerShip>();

    public static void PlayerDied()
    {

    }

    private static void Respawn()
    {
        playerShip.transform.position = Vector3.zero;
        playerShip.gameObject.SetActive(true);
    }
}
