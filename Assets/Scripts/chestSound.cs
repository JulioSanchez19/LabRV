using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestSound : MonoBehaviour
{

    public AudioSource chest;
    public AudioSource openingChest;

    void Start() {
        //chest = GetComponent<AudioSource>();
        //openingChest = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "lefthand" || other.gameObject.tag == "righthand") {
            chest.Stop();
            openingChest.Play();
        }
    }
}
