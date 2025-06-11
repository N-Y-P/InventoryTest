using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [Header("할당된 아이템 데이터")]
    [SerializeField] private ItemData itemData; 

    [Header("UI 구성 요소")]
    [SerializeField] private Image slotImage;
    [SerializeField] private GameObject equipIcon;

    private Button button;

    void Awake()
    {
        // 슬롯 자체에 붙어 있는 Button 컴포넌트를 가져옴
        button = GetComponent<Button>();
    }

    public void SetItem(ItemData newItem)
    {
        itemData = newItem;

        button.onClick.AddListener(ToggleEquip);
        RefreshUI();
    }

    public void RefreshUI()
    {
        if (itemData != null)
        {
            slotImage.sprite = itemData.Icon;
            equipIcon.SetActive(itemData.IsEquipped);
        }
        else
        {
            slotImage.sprite = null;
            equipIcon.SetActive(false);
        }
    }
    private void ToggleEquip()
    {
        if (itemData == null) return;

        var player = GameManager.Instance.player;
        if (itemData.IsEquipped)
            player.UnEquip(itemData);
        else
            player.Equip(itemData);

        RefreshUI();
        UIManager.Instance.uiStatus.SetStatus(GameManager.Instance.player);
    }
}
