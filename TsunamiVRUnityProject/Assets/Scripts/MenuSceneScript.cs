/* MenuSceneに関するスクリプト */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSceneScript : MonoBehaviour
{

    public GameObject menuMainPanel;
    public GameObject optionPanel;
    public GameObject overviewPanel;
    public GameObject creditPanel;

    // Start is called before the first frame update
    void Start()
    {
        menuMainPanel.SetActive(true);
        optionPanel.SetActive(false);
        overviewPanel.SetActive(false);
        creditPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchToOptionPanel()
    {
        menuMainPanel.SetActive(false);
        optionPanel.SetActive(true);
        overviewPanel.SetActive(false);
        creditPanel.SetActive(false);
    }

    public void SwitchToMenuMainPanel()
    {
        menuMainPanel.SetActive(true);
        optionPanel.SetActive(false);
        overviewPanel.SetActive(false);
        creditPanel.SetActive(false);
    }

    public void SwitchToOverviewPanel()
    {
        menuMainPanel.SetActive(false);
        optionPanel.SetActive(false);
        overviewPanel.SetActive(true);
        creditPanel.SetActive(false);
    }

    public void SwitchToCreditPanel()
    {
        menuMainPanel.SetActive(false);
        optionPanel.SetActive(false);
        overviewPanel.SetActive(false);
        creditPanel.SetActive(true);
    }
}
