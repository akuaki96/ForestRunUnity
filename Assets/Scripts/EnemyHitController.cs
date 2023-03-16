using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityChan;
using UnityEngine.SceneManagement;

public class EnemyHitController : MonoBehaviour
{
    public GameObject player;
    public GameObject text;
 
    private bool isGameOver = false;

    void Update()
    {
        if(isGameOver && Input.GetMouseButton(0))
        {
            Restart();
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == player.name)
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
