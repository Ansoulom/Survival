using UnityEngine;
using UnityEngine.UI;

public class ResourceUI : MonoBehaviour
{
    public Inventory Inventory;
    public string Material;
    

    // Update is called once per frame
    private void Update()
    {
        if (Inventory.Resources.ContainsKey(Material))
            GetComponent<Text>().text = Inventory.Resources[Material].ToString();
    }
}