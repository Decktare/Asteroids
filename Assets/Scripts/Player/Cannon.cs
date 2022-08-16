public class Cannon : Weapon
{
    public readonly WeaponType weaponType = WeaponType.Cannon;

    public Bullet bulletPrefab;
    public override void Fire()
    {
        print("Выстре пушки");
        Bullet bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        bullet.Shooting(transform.up);
    }
}
