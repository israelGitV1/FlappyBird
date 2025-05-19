using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }
    public float forceJumpBird = 8f;
    public float speedObstacles = 5f;
    public int statusPoints = 0;
    public int MaxPoints = 0;
    //[HideInInspector]
    private bool gameRun = true;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if (!gameRun)
        {
            //Pause
            TogglePause();

            //Restart
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameRun = true;
                //start
                TogglePause();

                //LoadScene
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

                //Delay 2s
                StartCoroutine(ReloadScene(2));
                
            }
        }
    }

    void TogglePause()
    {
        Time.timeScale = gameRun ? 1f : 0f;
    }

    public bool GetGameRun()
    {
        return gameRun;
    }
    public void GameOver()
    {
        // Game stop
        instance.gameRun = false;

        //status
        if (instance.statusPoints > instance.MaxPoints)
        {
            instance.MaxPoints = instance.statusPoints;
        }

        //Message
        Debug.Log("End Game !!! Rank: " + instance.statusPoints + " Rank: " + instance.MaxPoints);
        instance.statusPoints = 0;

    }

    private IEnumerator ReloadScene(float delay)
    {
        // Esperar 2 segundos (delay)
            yield return new WaitForSeconds(delay);
        // Recarregar a cena
            Debug.Log("teste delay 2s Ok");

    }
}
