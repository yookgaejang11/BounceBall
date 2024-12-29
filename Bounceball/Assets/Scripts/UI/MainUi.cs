using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUi : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    private void Start()
    {
        if (DataManager.Instance.playerData == null)
        {
            tmp.text = "CurrentStage:0";
        }
        else
        {
            tmp.text = "CurrentStage:" + DataManager.Instance.playerData.currentStage;
        }
    }
    public void SelectBtn()
    {
        SceneManager.LoadScene(1);
    }

    public void CurrentStage()
    {
        if(DataManager.Instance.playerData.currentStage == 0)
        {
            Debug.Log("저장된 데이터가 없습니다!!");
        }
        else
        {
            SceneManager.LoadScene(DataManager.Instance.playerData.currentStage + 1);
            
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
