using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityChan;
using UnityEngine.SceneManagement;

public class DropManager : MonoBehaviour
{
    public GameObject player;
    public GameObject text;
    
    private bool isGameOver = false;

    void Update()
    {
        if (isGameOver && Input.GetMouseButton(0))
        {
            Restart();
        }

        if(player.transform.position.y < 10)
        {

            text.GetComponent<Text>().text = "GameOver...";
            text.SetActive(true);
 
            player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
            player.GetComponent<Animator>().enabled = false;
 
            isGameOver = true;
 
           
        }

    }

    private void Restart()
    {
    Scene loadScene = SceneManager.GetActiveScene();
    SceneManager.LoadScene(loadScene.name);
    }
}
