/* �{�^���ɂ���ʑJ��(Scene��)�Ɋւ���X�N���v�g */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManagerScript : MonoBehaviour
{

    //�����t�@�C���i�[�p�ϐ�
    public AudioSource sound01;

    // Start is called before the first frame update
    void Start()
    {
        sound01 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* MenuScene�ֈڍs����{�^���̓��� */
    public void ToMenuButton()
    {
        sound01.PlayOneShot(sound01.clip);
        SceneManager.LoadScene("MenuScene");
    }

    /* MapScene�ֈڍs����{�^���̓��� */
    public void ToMapButton()
    {
        sound01.PlayOneShot(sound01.clip);
        SceneManager.LoadScene("MapScene");
    }

    /* MainScene�ֈڍs����{�^���̓��� */
    public void ToMainButton()
    {
        sound01.PlayOneShot(sound01.clip);
        SceneManager.LoadScene("MainScene");
    }

}
