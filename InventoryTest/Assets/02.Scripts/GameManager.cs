using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //player ������Ƽ �߰�
    public Character player;
    public List<Item> playerInventory = new List<Item>();

    // �κ��丮 Sprites
    [SerializeField] private Sprite hammerSprite;
    [SerializeField] private Sprite shieldSprite;

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
        player.AddItem(new Item("Hammer", hammerSprite, 10, 0, 0, 0, false));
        player.AddItem(new Item("Shield", shieldSprite, 0, 8, 0, 0, false));

        UIManager.Instance.uiStatus.SetStatus(player);
        UIManager.Instance.uiInventory.InitInventoryUI();

    }
}
