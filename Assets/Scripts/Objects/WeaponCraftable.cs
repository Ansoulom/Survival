public class WeaponCraftable : Craftable
{
    public Weapon Weapon;

    protected override void Create(Inventory inv)
    {
        inv.Weapons.Add(Instantiate(Weapon));
    }
}