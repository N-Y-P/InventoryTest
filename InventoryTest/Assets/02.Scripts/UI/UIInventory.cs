using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private UISlot slotPrefab;// UISlot 타입의 필드 추가 → UISlot 프리팹 추가
    [SerializeField] private Transform contentParent; //Transform 타입의 slot 부모 추가

    private List<UISlot> slots = new List<UISlot>(); //UISlot 타입의 리스트 추가

    private void Start()
    {
        InitInventoryUI();
    }

    public void InitInventoryUI()//UISlot 리스트, for문, Instantiate 등등 활용
    {
        foreach (var s in slots)
            Destroy(s.gameObject);
        slots.Clear();

        // player의 Inventory 리스트를 가져와
        var items = GameManager.Instance.player.Inventory;

        for (int i = 0; i < items.Count; i++)
        {
            var it = items[i];
            var slot = Instantiate(slotPrefab, contentParent);
            slot.SetItem(it);
            slots.Add(slot);
        }
    }
}
