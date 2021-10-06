using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSceneScript : MonoBehaviour
{

    public GameObject menuMainPanel;
    public GameObject menuOptionPanel;

    // Start is called before the first frame update
    void Start()
    {
        menuMainPanel.SetActive(true);
        menuOptionPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchMenuOptionPanel()
    {
        menuMainPanel.SetActive(false);
        menuOptionPanel.SetActive(true);
    }

    public void SwitchMenuMainPanel()
    {
        menuMainPanel.SetActive(true);
        menuOptionPanel.SetActive(false);
    }

}
