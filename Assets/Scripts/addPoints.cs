using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addPoints : MonoBehaviour
{

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("addPoints") && GameManager.instance.GetGameRun())
        {
            GameManager.instance.statusPoints++;
            Debug.Log("Pontos: " + GameManager.instance.statusPoints);
        }

    }

    void OnCollisionEnter()
    {
        GameManager.instance.GameOver();
    }

}

