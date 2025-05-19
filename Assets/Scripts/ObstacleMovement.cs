using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
   // public float speed = 3f;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!GameManager.instance.GetGameRun())
        {
            return; 
        }

        transform.position += new Vector3(-GameManager.instance.speedObstacles * Time.fixedDeltaTime, 0, 0);
    }
}
