using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class WinGame : MonoBehaviour
{
    public GameObject Music;
    public AudioSource Win;
    public GameObject  msg;


    void OnTriggerEnter(){
       Music.SetActive(false);
       Win.Play();
       StartCoroutine(GO());
    }


    IEnumerator GO(){

        msg.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}
