using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{


    public AudioSource effect;

    public void PlayGame(){

        effect.Play();
        SceneManager.LoadScene(1);

    }
}
