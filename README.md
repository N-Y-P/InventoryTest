# 🧳 InventoryTest

<br>

## 📝 프로젝트 개요  
간단한 인벤토리 시스템을 Unity로 구현한 테스트 프로젝트입니다.  
UI 버튼으로 인벤토리와 스탯 창을 열 수 있으며, 장비를 장착하면 스탯이 변경되고 장착 여부가 표시됩니다.  

<br>

## 🖼️ 이미지  
| 스탯 UI | 장비 장착 시 표시 |
|:--:|:--:|
| ![Image](https://github.com/user-attachments/assets/c33069de-b412-4ebb-8f2a-392fb7dec029)| ![Image](https://github.com/user-attachments/assets/b11ed6ed-b504-4baf-8d7d-69987f732200)|

<br>

## ⚙️ 주요 기능
-  버튼 클릭으로 **스탯 창 / 인벤토리 창**을 열 수 있음  
- **인벤토리 슬롯**이 아이템 수에 따라 **동적으로 생성**  
- **장비 장착 / 해제 가능**, 장착 시 **슬롯에 (E)** 표시  
- **장착한 장비에 따라 스탯 수치 변경**

<br>

## 📂 구조

```swift
Assets/
│
├── Scripts/
│   ├── ItemData.cs            # ScriptableObject: 아이템 기본 정보 & 스탯 보너스 정의
│   ├── Character.cs           # 캐릭터 기본스탯 · 인벤토리 · Equip/UnEquip 로직
│   ├── GameManager.cs         # 플레이어·인벤토리 데이터 세팅
│   ├── UIManager.cs           # 싱글톤: UIMainMenu · UIStatus · UIInventory 연결
│   ├── UIMainMenu.cs          # 메인 메뉴 버튼 처리 (상태창·인벤토리)
│   ├── UIStatusPanel.cs       # 캐릭터 스탯 표시 (SetStatus)
│   ├── UIInventory.cs         # 인벤토리 패널 컨트롤러 (UISlot 동적 생성)
│   └── UISlot.cs              # 개별 슬롯: 아이템 바인딩 · 장착 토글 · UI 갱신
│
├── Prefabs/
│   └── UISlot.prefab          # UISlot 프리팹 (아이콘 · 장착 표시 포함)
│
└── ScriptableObjects/
    ├── Sword.asset           
    └── Shield.asset           
```
<br>

## 🛠️ 사용 버전
- Unity 2022.3.17f

---
