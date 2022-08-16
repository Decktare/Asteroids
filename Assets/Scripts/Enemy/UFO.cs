using UnityEngine;

public class UFO : MonoBehaviour
{
    private float speed = 0.005f;
    private void FixedUpdate()
    {
        Moving();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    private void Moving()
    {
        transform.position = Vector2.Lerp(transform.position, PlayerShip.position, speed);
    }
}
