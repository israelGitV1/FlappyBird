using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatingObstacle : MonoBehaviour
{
    public List<GameObject> obstacles;
    public float offsetX = 5f;
    public Vector2 offsetY = new Vector2(-1f, 3f);
    public float speedInstance = 1f;
    private float cooldown = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.GetGameRun())
        {
            return; 
        }

        cooldown += Time.deltaTime;
        if (cooldown >= speedInstance)
        {
            cooldown = 0;
            GameObject obstacle = obstacles[Random.Range(0, obstacles.Count)];
            float x = offsetX;
            float y = Random.Range(offsetY.x, offsetY.y);
            float z = -1.14f;
            Vector3 position = new Vector3(x, y, z);

            Instantiate(obstacle, position, obstacle.transform.rotation);
        }

    }
}
