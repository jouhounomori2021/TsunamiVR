/* �{�^���ɂ���ʑJ��(Scene��)�Ɋւ���X�N���v�g */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* MenuScene�ֈڍs����{�^���̓��� */
    public void ToMenuButton()
    {
        SceneManager.LoadScene("MenuScene");
    }

    /* MapScene�ֈڍs����{�^���̓��� */
    public void ToMapButton()
    {
        SceneManager.LoadScene("MapScene");
    }

    /* MainScene�ֈڍs����{�^���̓��� */
    public void ToMainButton()
    {
        SceneManager.LoadScene("MainScene");
    }

}
