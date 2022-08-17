using UnityEngine;

public class Access : MonoBehaviour
{
    public static GameObject playerShipStatic;
    public static GameObject gameOverPanelStatic;
    public static GameObject spawnerStatic;

    [SerializeField] private GameObject playerShip;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject spawner;

    private void Start()
    {
        playerShipStatic = playerShip;
        gameOverPanelStatic = gameOverPanel;
        spawnerStatic = spawner;
    }
}
