using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{

    public float rayLength;
    public LayerMask layermask;
    public GameObject doorAssist;
    public GameObject door14;

    private void Start()
    {
        doorAssist = GameObject.Find("/Door_14/Friendly");
        door14 = GameObject.Find("Door_14");
        Debug.Log("hello there");
    }


    public void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLength, layermask))
            {
                Debug.Log(hit.collider.name);
                if (hit.collider.name == "Friendly")
                {
                    Debug.Log("Something was clicked!");
                    OpenDoor();
                }

            }
        }


    }

    private void OpenDoor()
    {
        door14.transform.position = new Vector3(0.0f, 1.5f, 0.0f);
    }
}



