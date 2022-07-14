using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;
    public Text timeText;
    public Text recordText;

    private float surviveTime;
    public bool isGameOver;

    void Start()
    {
        surviveTime = 0;
        isGameOver = false;
    }

    void Update()
    {
        if(!isGameOver) // ������������ �� �ð��� �ö󰡴� ���� �����ش�.
        {
            surviveTime += Time.deltaTime;
            timeText.text = "Time: " + (int)surviveTime;
        }
        else // ������ ����Ǿ����� ���ý��� �����ش�.
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void EndGame()
    {
        isGameOver = true;
        gameoverText.SetActive(true);

        int bestTime = PlayerPrefs.GetInt("BestTime");
        if(surviveTime > bestTime)
        {
            bestTime = (int)surviveTime;
            PlayerPrefs.SetInt("BestTime", bestTime);
        }
        recordText.text = "Best : " + (int) bestTime;
    }
}
