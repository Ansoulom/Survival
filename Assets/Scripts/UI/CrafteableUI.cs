using UnityEngine;
using UnityEngine.UI;

public class CrafteableUI : MonoBehaviour
{
    public Craftable Item;
    public Inventory Inventory;
    public Color CanCraftColor, CanNotCraftColor;

    private bool _canCraft;


	// Use this for initialization
	private void Start ()
    {
        transform.Find("Name").GetComponent<Text>().text = Item.Name;
        transform.Find("WoodCost").GetComponent<Text>().text = Item.WoodCost.ToString();
        transform.Find("StoneCost").GetComponent<Text>().text = Item.StoneCost.ToString();
        transform.Find("IronCost").GetComponent<Text>().text = Item.IronCost.ToString();

        ChangeEnabled();
    }

    public void CraftItem()
    {
        Item.Craft(Inventory);
    }
	

	// Update is called once per frame
	private void Update ()
    {
        if (Item.CanCraft(Inventory) != _canCraft)
        {
            ChangeEnabled();
        }
	}


    private void ChangeEnabled()
    {
        _canCraft = Item.CanCraft(Inventory);
        GetComponent<Image>().color = _canCraft ? CanCraftColor : CanNotCraftColor;
        transform.Find("CraftButton").GetComponent<Button>().interactable = _canCraft;
    }
}
