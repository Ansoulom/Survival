using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ItemSlotUI : MonoBehaviour
{
    private InventorySlot _slot;

    public InventorySlot Slot
    {
        set
        {
            _slot = value;
            if (_slot.Item != null) UpdateImage();
        }
    }


    // Update is called once per frame
    private void Update()
    {
        if (_slot != null &&_slot.Item != null && GetComponent<Image>().sprite != _slot.Item.Icon)
            UpdateImage();
    }


    private void UpdateImage()
    {
        GetComponent<Image>().sprite = _slot.Item.Icon;
    }
}