using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public abstract void Fire();
    public enum WeaponType
    {
        Cannon,
        Laser
    }
}
