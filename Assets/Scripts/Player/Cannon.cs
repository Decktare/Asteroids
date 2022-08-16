public class Cannon : Weapon
{
    public readonly WeaponType weaponType = WeaponType.Cannon;

    public override void Fire()
    {
        print("Выстре пушки");
    }

    private void Update()
    {

    }
}
