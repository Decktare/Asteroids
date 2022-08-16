public class Cannon : Weapon
{
    public override WeaponType weaponType => WeaponType.Cannon;

    public Bullet bulletPrefab;
    public override void Fire()
    {
        Bullet bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        bullet.Shooting(transform.up);
    }
}
