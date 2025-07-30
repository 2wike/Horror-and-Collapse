using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject inventoryUI;
    private bool isOpen = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            ToggleInventory();
        }
    }

    void ToggleInventory()
    {
        isOpen = !isOpen;
        inventoryUI.SetActive(isOpen);
        Time.timeScale = isOpen ? 0 : 1; // Oyun durur/açýlýr
    }
}
