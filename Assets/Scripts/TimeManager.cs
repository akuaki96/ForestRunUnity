using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityChan;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public Text timeText;
    public float limit = 30.0f;
    public GameObject text;
    public GameObject player;

    private bool isGameOver = false;
 
    void Start()
    {
        timeText.text = "残り時間:" + limit + "秒";
    }
 
    void Update()
    {

        if (isGameOver && Input.GetMouseButton(0))
        {
            Restart();
        }
 
        if(limit < 0)
        {
            text.GetComponent<Text>().text = "GameOver...";
            text.SetActive(true);
            player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
            player.GetComponent<Animator>().enabled = false;
            isGameOver = true;
            return;
        }
        limit -= Time.deltaTime;
        timeText.text = "残り時間:" + limit.ToString("f1") + "秒";

    }
    private void Restart()
    {
        Scene loadScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadScene.name);
    }
}
