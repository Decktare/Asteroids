public class Laser : Weapon
{
    public readonly WeaponType weaponType = WeaponType.Laser;

    public override void Fire()
    {
        print("Выстрел лазера");
    }
}
