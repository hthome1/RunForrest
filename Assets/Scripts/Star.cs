using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Star : MonoBehaviour
{
    public AudioSource starSound;
    public TextMeshProUGUI  ScoreBox;
    
    void OnTriggerEnter(){

        ScoreBox.GetComponent<TMP_Text>().text = "1";
        starSound.Play();
        Destroy(gameObject);
    }
}
