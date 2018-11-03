using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickItem : MonoBehaviour
{
    public GameObject mainCamera;
    public EventSystem eventSystem;

    //レイ
    public Ray ray;
    public Ray rayItem;
    public RaycastHit hit;
    public GameObject selectedGameObject;

    //アイテム
    public GameObject item_key;

    public string standName;//現在の立ち位置


    void Start()
    {
        standName = "centerN";
        eventSystem = GameObject.Find("EventSystem").GetComponent<EventSystem>();
        item_key = GameObject.Find("item_key2");
        item_key.SetActive(false);
    }

    void Update()
    {
        ClickedItem();

    }

    public void ClickedItem()
    {
        selectedGameObject = null;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 1000000, 1 << 8))
        {
            selectedGameObject = hit.collider.gameObject;
            switch (selectedGameObject.name)
            {
                case "redSwich":
                    Debug.Log("clicked redSwitch");
                    item_key.SetActive(true);
                    break;
            }
        }
    }

}
