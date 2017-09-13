using UnityEngine;

[CreateAssetMenu(menuName = "Craftable/Item")]
public class ItemCraftable : Craftable
{
    public UsableItem UsableItem;

    protected override void Create(Inventory inv)
    {
        inv.Items.Add(Instantiate(UsableItem));
    }
}