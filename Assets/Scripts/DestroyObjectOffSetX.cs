using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectOffSetX : MonoBehaviour
{
    public float offsetX = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (offsetX >= transform.position.x)
        {
            Destroy(gameObject);
        }   
    }
}
