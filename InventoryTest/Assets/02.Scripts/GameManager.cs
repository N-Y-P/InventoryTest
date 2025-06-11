using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //player 프로퍼티 추가
    public Character player;
    public List<Item> playerInventory = new List<Item>();

    // 인벤토리 Sprites
    [SerializeField] private Sprite hammerSprite;
    [SerializeField] private Sprite shieldSprite;

    //싱글톤
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

    //SetData()메서드 만들기
    private void Start()
    {
        SetData();
    }

    public void SetData()
    {
        player = new Character(35, 40, 100, 25);

        //아이템 생성해서 인벤토리에 넣기
        player.AddItem(new Item("Hammer", hammerSprite, 10, 0, 0, 0, false));
        player.AddItem(new Item("Shield", shieldSprite, 0, 8, 0, 0, false));

        UIManager.Instance.uiStatus.SetStatus(player);
        UIManager.Instance.uiInventory.InitInventoryUI();

    }
}
