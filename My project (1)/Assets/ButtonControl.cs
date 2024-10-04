using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    public Button myButton;
    public GameObject parentPrefabInstance;

    void Start()
    {
        myButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        // Nested Prefab과 상호 작용
        Debug.Log("Nuclear launch detected.");

        // 예: 부모 프리팹 활성화 또는 특정 함수 호출
        parentPrefabInstance.SetActive(true);
    }
}


