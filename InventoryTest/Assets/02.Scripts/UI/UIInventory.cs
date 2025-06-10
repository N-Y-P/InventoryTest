using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private UISlot slotPrefab;// UISlot Ÿ���� �ʵ� �߰� �� UISlot ������ �߰�
    [SerializeField] private Transform contentParent; //Transform Ÿ���� slot �θ� �߰�

    private List<UISlot> slots = new List<UISlot>(); //UISlot Ÿ���� ����Ʈ �߰�

    private void Start()
    {
        InitInventoryUI();
    }

    public void InitInventoryUI()//UISlot ����Ʈ, for��, Instantiate ��� Ȱ��
    {
        foreach (var s in slots)
            Destroy(s.gameObject);
        slots.Clear();

        // player�� Inventory ����Ʈ�� ������
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
