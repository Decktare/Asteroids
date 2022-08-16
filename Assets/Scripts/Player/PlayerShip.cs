
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    private Weapon firstWeapon;
    private Weapon secondWeapon;
    private Rigidbody2D shipRigidBody;

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
        shipRigidBody = GetComponent<Rigidbody2D>();
    }

    private void ShipMoving()
    {
        shipRigidBody.AddForce(GetDirestionToLookAt(), ForceMode2D.Force);
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
}
