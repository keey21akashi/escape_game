using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TurnCamera : MonoBehaviour {
    public GameObject gameCamera;
    public EventSystem eventSystem;// eventSystem==GameObject.Find("EventSystem")

    // Use this for initialization
    void Start () {
        if (eventSystem != null)
        {
            eventSystem = eventSystem.GetComponent<EventSystem>();
        }
        gameCamera.transform.rotation = Quaternion.Euler(0, 90, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}


