using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    bool isGameover = false;
    public GameObject Completelevelu1;
 public void EndGame()
 {
     if(isGameover==false)
     {
    Debug.Log("Game is Over");
    isGameover = true;
    Invoke("Restart",2f);
     }
 }
 public void Restart()
 {
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
 }
 public void Completelevel1()
 {
     //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     Completelevelu1.SetActive(true); 
     Debug.Log("LEVEL WON");
 }
}
