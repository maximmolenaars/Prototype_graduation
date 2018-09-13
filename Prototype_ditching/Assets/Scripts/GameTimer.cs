using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour {

	float timeLeft = 30.0f;
     
     void Update()
     {
        Debug.Log(timeLeft);
         timeLeft -= Time.deltaTime;
         if(timeLeft < 0)
         {
             Debug.Log("GameOver");
         }
     }
}
