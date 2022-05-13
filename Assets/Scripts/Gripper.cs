using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gripper : MonoBehaviour
{
    public GameObject plat;
    public GameObject player;


    void OnTriggerEnter(){
        player.transform.parent = plat.transform;

    }
    void onTriggerExit(){
        player.transform.parent = null;
    }
}
