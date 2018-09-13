using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{

    public float rayLength;
    public LayerMask layermask;
    public GameObject doorAssist;
    public GameObject door14;
    public GameObject slideToSpawn;

    private void Start()
    {
        doorAssist = GameObject.Find("/BoeingInterior/BP_AirplaneDoor2");
        door14 = GameObject.Find("/BoeingInterior/BP_AirplaneDoor2");
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
                if (hit.collider.name == "BP_AirplaneDoor2")
                {
                    Debug.Log("Something was clicked!");
                    OpenDoor();
                }

            }
        }


    }

    private void OpenDoor()
    {
        door14.transform.position = new Vector3(-3.08f, 1.28f, 1.258f);
        SpawnSlide();
    }

    private void SpawnSlide()
    {
        Debug.Log("Slide is spawned");
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.localScale += new Vector3(5f, -0.1f, 2f);
        cube.AddComponent<Rigidbody>();
        cube.transform.position = new Vector3(-5.83f, 0.2293683f, -0.1403087f);

    }
}



