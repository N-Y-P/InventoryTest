using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    //UI ������ҿ� ����� �ʵ� �߰�
    //������ ������
    [SerializeField] private Image slotImage;

    //���� �̹���(�����ߴٸ� Ȱ��ȭ, �����ߴٸ� ��Ȱ��ȭ)
    [SerializeField] private GameObject equip;

    private Item item;
    private Button button;

    void Awake()
    {
        // ���� ��ü�� �پ� �ִ� Button ������Ʈ�� ������
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
