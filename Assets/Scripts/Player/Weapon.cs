using UnityEngine;
public abstract class Weapon : MonoBehaviour
{
    public abstract WeaponType weaponType { get; }
    public abstract void Fire();
    public enum WeaponType
    {
        Cannon,
        Laser
    }
}
