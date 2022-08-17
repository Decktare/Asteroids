using UnityEngine;
public class PlayerShip : MonoBehaviour
{

    public static Vector2 position;
    private Weapon firstWeapon;
    private Weapon secondWeapon;
    private Rigidbody2D shipRigidbody;

    private void Start()
    {
        Initialization();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            firstWeapon.Fire();
        }
        if (Input.GetMouseButtonDown(1))
        {
            secondWeapon.Fire();
        }
        ShipRotation();
        Position();
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ShipMoving();
        }
    }
    private void Initialization()
    {
        firstWeapon = GetComponent<Cannon>();
        secondWeapon = GetComponent<Laser>();
        shipRigidbody = GetComponent<Rigidbody2D>();
    }
    private void Position()
    {
        position = transform.position;
    }
    private void ShipMoving()
    {
        shipRigidbody.AddForce(GetDirestionToLookAt(), ForceMode2D.Force);
    }
    private void ShipRotation()
    {
        transform.up = GetDirestionToLookAt();
    }
    private Vector2 GetDirestionToLookAt()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 directionToLookAt = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
            );
        return directionToLookAt;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            shipRigidbody.velocity = Vector3.zero;
            shipRigidbody.angularVelocity = 0.0f;

            gameObject.SetActive(false);

            GameOver.PlayerDied();
        }
    }
}
