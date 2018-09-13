using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class EquipmentSelection : MonoBehaviour
{

    public float rayLength;
    public LayerMask layermask;
 

    private void Start()
    {
        
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
                if (hit.collider.name == name)
                {
                    Debug.Log("Something was clicked!");

                }

            }
        }


    }

}



