using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Death : MonoBehaviour
{

    public GameObject  msg;

    public GameObject SoundTrack;

    public AudioSource Bomb;


    void OnTriggerEnter(){
        StartCoroutine(GO());

        
    }


    IEnumerator GO(){

        SoundTrack.SetActive(false);
        Bomb.Play();
        msg.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }
}
