using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectStageUi : MonoBehaviour
{
    private static SelectStageUi instance;
    public List<GameObject> stages = new List<GameObject>();
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        for(int i = 0; i < DataManager.Instance.playerData.clearStage + 1; i++)
        {
            stages[i].SetActive(true);
        }
    }

    public void Stage1()
    {
        SceneManager.LoadScene(2);
    }

    public void OtherStage()
    {
        Debug.Log("아직 제작안함 ㅅㄱ");
    }

    public void Return()
    {
        SceneManager.LoadScene(0);
    }
    public static SelectStageUi Instance
    {
        get
        {
            if (instance == null)
            {
                return null;
            }
            return instance;
        }
    }
}
