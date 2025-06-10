using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    //�Ϻ� UI ������ҿ� �ش��ϴ� �ʵ��� �߰�

    [Header("���� ��ư")]
    [SerializeField] private Button statusBtn;

    [Header("�κ��丮 ��ư")]
    [SerializeField] private Button inventoryBtn;

    [Header("�ڷΰ��� ��ư")]
    [SerializeField] private Button backBtn;

    [Header("��ư �г�")]
    [SerializeField] private GameObject mainMenuPanel;

    private void Start()
    {
        //��ư Ŭ���� onClick�̺�Ʈ
        statusBtn.onClick.AddListener(OpenStatus);
        inventoryBtn.onClick.AddListener(OpenInventory);
        backBtn.onClick.AddListener(OpenMainMenu);
    }
    public void OpenMainMenu()
    {
        //�ڷΰ��� ��ư�� ������ �� ���θ޴��� ��ư���� ��� Ȱ��ȭ�� �ǰ�
        mainMenuPanel.SetActive(true);
        backBtn.gameObject.SetActive(false);
        UIManager.Instance.uiStatus.gameObject.SetActive(false);
        UIManager.Instance.uiInventory.gameObject.SetActive(false);

    }
    public void OpenStatus()
    {
        //UIManager�� ���� UIStatus�� ������ UI�ѱ�
        UIManager.Instance.uiStatus.gameObject.SetActive(true);
        mainMenuPanel.SetActive(false);
        backBtn.gameObject.SetActive(true);

    }
    public void OpenInventory()
    {
        //UIManager�� ���� UIInventory�� ������ UI�ѱ�
        UIManager.Instance.uiInventory.gameObject.SetActive(true);
        mainMenuPanel.SetActive(false);
        backBtn.gameObject.SetActive(true);
    }
}
