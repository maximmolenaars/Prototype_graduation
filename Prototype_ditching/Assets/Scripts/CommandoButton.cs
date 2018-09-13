using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommandoButton : MonoBehaviour
{
    
    public Button m_YourFirstButton, m_YourSecondButton;
    private GameObject layover;
    private bool toggle;


    private void Start()

    {
        layover = GameObject.Find("layoverCommando");

        //Commando Button
        Button btn1 = m_YourFirstButton.GetComponent<Button>();
        //Close_btn
        Button btn2 = m_YourSecondButton.GetComponent<Button>();

        layover.SetActive(false);
        toggle = false;
        btn1.onClick.AddListener(TaskOnClick);
        btn2.onClick.AddListener(ToggleLayover);
    }

    void TaskOnClick()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button!");
        ToggleLayover();
    }


    private void ToggleLayover()
    {
        if (toggle == false)
        {
            layover.SetActive(true);
            toggle = true;
        }

        else if (toggle == true)
        {
            layover.SetActive(false);
            toggle = false;
        }
    }
}
