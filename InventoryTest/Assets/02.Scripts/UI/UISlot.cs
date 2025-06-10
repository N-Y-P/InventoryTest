using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    //UI 구성요소에 연결될 필드 추가
    //아이템 아이콘
    [SerializeField] private Image slotImage;

    //장착 이미지(장착했다면 활성화, 해제했다면 비활성화)
    [SerializeField] private GameObject equip;

    private Item item;
    private Button button;

    void Awake()
    {
        // 슬롯 자체에 붙어 있는 Button 컴포넌트를 가져옴
        button = GetComponent<Button>();
    }

    public void SetItem(Item newItem)
    {
        item = newItem;
        button.onClick.AddListener(ToggleEquip);
        RefreshUI();
    }

    public void RefreshUI()
    {
        if (item != null)
        {
            slotImage.sprite = item.Icon;
            equip.SetActive(item.IsEquipped);
        }
        else
        {
            slotImage.sprite = null;
            equip.SetActive(false);
        }
    }
    private void ToggleEquip()
    {
        if (item == null) return;

        if (item.IsEquipped)
            GameManager.Instance.player.UnEquip(item);
        else
            GameManager.Instance.player.Equip(item);

        RefreshUI();
        UIManager.Instance.uiStatus.SetStatus(GameManager.Instance.player);
    }
}
