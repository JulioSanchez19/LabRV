using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trollDie : MonoBehaviour
{
    public GameObject troll;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        troll.SetActive(false);
    }
}
