using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    
    private static GameManager instance;
    public GameObject clearUi;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        Time.timeScale = 1.0f;
    }

    private void Update()
    {
        ;
    }

    public void Clear()
    {
        clearUi.SetActive(true);
        DataManager.Instance.playerData.clearStage = SceneManager.GetActiveScene().buildIndex - 1;
        DataManager.Instance.SavePlayerData();
        Time.timeScale = 0;
    }

    

    public static GameManager Instance
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
