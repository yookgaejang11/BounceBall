using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameUi : MonoBehaviour
{
    public GameObject player;
    private static InGameUi instance;
    public GameObject pauseUi;
    public bool isPause = false;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPause)
            {
                Pause();
            }
            else
            {
                No();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space) && isPause)
        {
            Yes();
        }
        
    }

    public void Pause()
    {
        Debug.Log("test");
        isPause = true;
        pauseUi.SetActive(true);
        Time.timeScale = 0;
    }
    public void Yes()
    {
        DataManager.Instance.playerData.currentStage = SceneManager.GetActiveScene().buildIndex - 1;
        DataManager.Instance.SavePlayerData();
        Time.timeScale = 1;
        isPause = false;
        SceneManager.LoadScene(0);
    }

    public void No()
    {
        Time.timeScale = 1;
        isPause = false;
        pauseUi.SetActive(false);
    }

    public static InGameUi Instance
    {
        get
        {
            if(instance == null)
            {
                return null;
            }
            return instance;
        }
    }
}
