using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //player ������Ƽ �߰�
    public Character player;
    public List<ItemData> playerInventory = new List<ItemData>();

    //�̱���
    public static GameManager Instance;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    //SetData()�޼��� �����
    private void Start()
    {
        SetData();
    }

    public void SetData()
    {
        player = new Character(35, 40, 100, 25);

        //������ �����ؼ� �κ��丮�� �ֱ�
        foreach (var data in playerInventory)
            player.AddItem(data);

        UIManager.Instance.uiStatus.SetStatus(player);
        UIManager.Instance.uiInventory.InitInventoryUI();

    }
}
