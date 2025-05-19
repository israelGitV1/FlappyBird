using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerControles : MonoBehaviour
{
    private Rigidbody thisRigidbody;
    public float jumpPower = 5f;
    public float junpInterval = 2f;
    private float junpCooldown = 0;


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
        // update cooldown
        junpCooldown -= Time.deltaTime;
        bool canJunp = junpCooldown <= 0;

        // Junp
        if (canJunp)
        {
            bool junpInput = Input.GetKey(KeyCode.Space);
            if (junpInput)
            {
                Junp();
            }   
        }
    }

    private void Junp()
    {
        junpCooldown = junpInterval;
        thisRigidbody.velocity = Vector3.zero;
        thisRigidbody.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
    }
}

