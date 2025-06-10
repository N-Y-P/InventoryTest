using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    //하부 UI 구성요소에 해당하는 필드모두 추가

    [Header("스탯 버튼")]
    [SerializeField] private Button statusBtn;

    [Header("인벤토리 버튼")]
    [SerializeField] private Button inventoryBtn;

    [Header("뒤로가기 버튼")]
    [SerializeField] private Button backBtn;

    [Header("버튼 패널")]
    [SerializeField] private GameObject mainMenuPanel;

    private void Start()
    {
        //버튼 클릭시 onClick이벤트
        statusBtn.onClick.AddListener(OpenStatus);
        inventoryBtn.onClick.AddListener(OpenInventory);
        backBtn.onClick.AddListener(OpenMainMenu);
    }
    public void OpenMainMenu()
    {
        //뒤로가기 버튼을 눌렀을 때 메인메뉴의 버튼들이 모두 활성화가 되게
        mainMenuPanel.SetActive(true);
        backBtn.gameObject.SetActive(false);
        UIManager.Instance.uiStatus.gameObject.SetActive(false);
        UIManager.Instance.uiInventory.gameObject.SetActive(false);

    }
    public void OpenStatus()
    {
        //UIManager를 통해 UIStatus에 접근해 UI켜기
        UIManager.Instance.uiStatus.gameObject.SetActive(true);
        mainMenuPanel.SetActive(false);
        backBtn.gameObject.SetActive(true);

    }
    public void OpenInventory()
    {
        //UIManager를 통해 UIInventory에 접근해 UI켜기
        UIManager.Instance.uiInventory.gameObject.SetActive(true);
        mainMenuPanel.SetActive(false);
        backBtn.gameObject.SetActive(true);
    }
}
