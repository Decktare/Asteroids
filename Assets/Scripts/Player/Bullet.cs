using UnityEngine;
public class Bullet : MonoBehaviour
{
    private float speed = 1000.0f;
    private float maxLifetime = 2.0f;
    private Rigidbody2D bulletRigidbody;
    
    private void Awake()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();
    }
    public void Shooting(Vector2 direction)
    {
        bulletRigidbody.AddForce(direction * speed);

        Destroy(gameObject, maxLifetime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
