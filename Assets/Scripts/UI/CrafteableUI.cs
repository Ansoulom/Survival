using UnityEngine;
using UnityEngine.UI;

public class CrafteableUI : MonoBehaviour
{
    public Craftable Item;
    public Inventory Inventory;

    private bool _canCraft;


	// Use this for initialization
	private void Start ()
    {
        transform.Find("Name").GetComponent<Text>().text = Item.Name;
        transform.Find("WoodCost").GetComponent<Text>().text = Item.WoodCost.ToString();
        transform.Find("StoneCost").GetComponent<Text>().text = Item.StoneCost.ToString();
        transform.Find("IronCost").GetComponent<Text>().text = Item.IronCost.ToString();
        transform.Find("WaterCost").GetComponent<Text>().text = Item.WaterCost.ToString();

        _canCraft = Item.CanCraft(Inventory);
        GetComponent<Image>().color = _canCraft ? new Color(0x52, 0x52, 0x52, 0x64) : new Color(0xB6, 0xB6, 0xB6, 0x64);
    }
	

	// Update is called once per frame
	private void Update ()
    {
        if (Item.CanCraft(Inventory) != _canCraft)
        {
            _canCraft = Item.CanCraft(Inventory);
            GetComponent<Image>().color = _canCraft ? new Color(0x52, 0x52, 0x52, 0x64) : new Color(0xB6, 0xB6, 0xB6, 0x64);
        }
	}
}
