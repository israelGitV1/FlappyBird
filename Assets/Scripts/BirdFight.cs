using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BirdFight : MonoBehaviour
{
    private Rigidbody thisRigidbody ;

    // Start is called before the first frame update
    void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.GetGameRun())
        {
            return; 
        }

        bool spaceDown = Input.GetKeyDown(KeyCode.Space);
        //bool spaceUp = Input.GetKeyUp(KeyCode.Space);
        if (spaceDown)
        {
            /*
            if(thisRigidbody.velocity.y < -5f)
            {
             print(thisRigidbody.velocity);
            thisRigidbody.velocity = new Vector3(0f, -4f, 0f);
            }*/
            thisRigidbody.velocity = Vector3.zero;
            thisRigidbody.AddForce(new Vector3(0, GameManager.instance.forceJumpBird, 0), ForceMode.Impulse);
        }/*
        if (spaceUp)
        {
            thisRigidbody.AddForce(new Vector3(0, -(GameManager.instance.forceJumpBird *0.5f), 0), ForceMode.Impulse);
            print(thisRigidbody.velocity.y);
        }*/
    }
}
