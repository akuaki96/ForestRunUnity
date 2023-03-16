using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityChan;
 
public class DeadWallController : MonoBehaviour
{
    public float speed = 0.05f;
    public float max_z = 10.0f;
    
    public GameObject player;
    public GameObject text;
 
    private bool isGameOver = false;
 
    void Update()
    {
        
        this.gameObject.transform.Translate(0, 0, speed);
 
        if (this.gameObject.transform.position.z > max_z || this.gameObject.transform.position.z < (-max_z))
        {
            speed *= -1;
        }
 
        if(isGameOver && Input.GetMouseButton(0))
        {
            Restart();
        }
    }
 
    private void OnCollisionEnter(Collision other)
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
