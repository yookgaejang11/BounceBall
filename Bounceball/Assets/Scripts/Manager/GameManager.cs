using System.Collections;
using System.Collections.Generic;
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

    public void Clear()
    {
        DataManager.Instance.playerData.playerPosition = new Vector3(0, 0, 0);
        DataManager.Instance.playerData.clearStage = SceneManager.GetActiveScene().buildIndex - 1;
        DataManager.Instance.SavePlayerData();
        StartCoroutine(GoHome());
    }

    IEnumerator GoHome()
    {
        clearUi.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
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
