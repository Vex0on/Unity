using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticInvDisplay : InvDisplay
{
    [SerializeField] private InvHolder inventoryHolder;
    [SerializeField] private InvSlot_UI[] slots;

    protected override void Start()
    {
        base.Start();

        if (inventoryHolder != null)
        {
            inventorySystem = inventoryHolder.InventorySystem;
            inventorySystem.OnInventorySlotChanged += UpdateSlot;
        }
        else Debug.LogWarning($" No inventory assigned to {this.gameObject}");

        AssignSlot(inventorySystem);
    }
    public override void AssignSlot(Inventory invToDisplay)
    {
        slotDictionary = new Dictionary<InvSlot_UI, InventorySlot>();

        if (slots.Length != inventorySystem.InventorySize) Debug.Log($"Inventory slots out of sync on {this.gameObject}");
        
        for (int i = 0; i < inventorySystem.InventorySize; i++)
        {
            slotDictionary.Add(slots[i], inventorySystem.InventorySlots[i]);
            slots[i].Init(inventorySystem.InventorySlots[i]);
        }
    }
}
