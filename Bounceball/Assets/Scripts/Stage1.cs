using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage1 : MonoBehaviour
{
    public Text[] WhatLevel = new Text[9];
    public Text[] Levels = new Text[9];
    private Text CheckText;
    public int NumChecker;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void BtnLevelOne()
    {
        NumChecker = 1;
        CheckIn();
    } public void BtnLevelTwo()
    {
        NumChecker = 2;
        CheckIn();
    } 
    public void BtnLevelNOn()
    {
        NumChecker = 1;
        CheckIn();
    }

    private void CheckIn()
    {
        switch (NumChecker)
        {
            case 1:
                if (WhatLevel[0].text == "1")
                {
                    DataManager.Instance.playerData.clearStage = 1;
                    SceneManager.LoadScene(3);
                }
                else
                {
                    Debug.Log("이전 레벨을 클리어 하고 오세요!");
                }
                break;
            case 2:
                if(WhatLevel[0].text == "2")
                {
                    DataManager.Instance.playerData.clearStage = 2;
                    Debug.Log("베타rpd");
                }
                else
                {
                    Debug.Log("이전 레벨을 클리어 하고 오세요!");
                }
                break;
        }
    }


    void Update()
    {
        LevelCheck();
    }
    public void LevelCheck()
    {
        for (int i = 0; i < Levels.Length; i++)
        {
            if (DataManager.Instance.playerData.clearStage >= 1)
            {
                switch (i)
                {
                    case 0:
                        Levels[i].text = "1";
                        continue;
                    case 1:
                        Levels[i].text = "2";
                        continue;
                    default:
                        break;
                }
                
            }
        }
    }
    
}
