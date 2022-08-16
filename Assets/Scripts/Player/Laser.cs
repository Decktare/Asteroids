public class Laser : Weapon
{
    public override WeaponType weaponType => WeaponType.Laser;

    public LaserRay laserRayPrefab;    
    public override void Fire()
    {
        LaserRay laserRay = Instantiate(laserRayPrefab, transform.position, transform.rotation);
        laserRay.Shooting();
    }
}
