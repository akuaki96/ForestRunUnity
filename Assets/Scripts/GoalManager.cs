using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoalManager : MonoBehaviour
{
    public GameObject player;
    public GameObject text;
    public Text timeText;

    private bool isGoal = false;

    void Update()
    {
        if(isGoal && Input.GetMouseButton(0))
        {
            Restart();
        }   
        
    }


    //当たり判定関数
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == player.name)
        {
            text.GetComponent<Text>().text = "Goal!!!";
            text.SetActive(true);
            isGoal = true;

            return;
        }
    }

    private void Restart()
    {
        Scene loadScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadScene.name);
    }


}
