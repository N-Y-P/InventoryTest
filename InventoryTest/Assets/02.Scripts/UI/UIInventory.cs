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

    }
}
