using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeFogMedium : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeFogEvent()
    {
        RenderSettings.fogDensity = 0.18f;
        RenderSettings.fog = true;
    }

}
