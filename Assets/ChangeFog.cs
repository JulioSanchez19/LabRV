using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeFog : MonoBehaviour
{
    //public Button m_YourFirstButton;
    // Start is called before the first frame update
    void Start()
    {
        //m_YourFirstButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeFogEvent()
    {
        RenderSettings.fogDensity = 0.0f;
        RenderSettings.fogColor = Color.blue;
        RenderSettings.fog = false;
        // if(RenderSettings.fog == false){
        //     RenderSettings.fog = true;
        // }
        // else{
        //     RenderSettings.fog = false;
        // }
    }

}
