/* ボタンによる画面遷移(Scene間)に関するスクリプト */

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

    /* MenuSceneへ移行するボタンの動作 */
    public void ToMenuButton()
    {
        SceneManager.LoadScene("MenuScene");
    }

    /* MapSceneへ移行するボタンの動作 */
    public void ToMapButton()
    {
        SceneManager.LoadScene("MapScene");
    }

    /* MainSceneへ移行するボタンの動作 */
    public void ToMainButton()
    {
        SceneManager.LoadScene("MainScene");
    }

}
