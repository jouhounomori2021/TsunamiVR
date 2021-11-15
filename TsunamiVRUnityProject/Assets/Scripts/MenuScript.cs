using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{

    void Start()
    {
        AddButtonHandler("Button1", () => {
            GameObject.Find("Button1").GetComponentInChildren<Text>().text = "clicked.";
        });
        AddButtonHandler("Button2", () => {
            GameObject.Find("Button2").GetComponentInChildren<Text>().text = "clicked.";
        });

        ShowMenu(false);
    }

    private void AddButtonHandler(string buttonName, UnityEngine.Events.UnityAction func)
    {
        Button button = GameObject.Find(buttonName).GetComponent<Button>();
        button.onClick.AddListener(func);
    }

    bool _isShowMenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        { // Oculus�R���g���[���[��Back�{�^����Escape�L�[����
            _isShowMenu = !_isShowMenu;
            ShowMenu(_isShowMenu);
        }
    }

    private void ShowMenu(bool isShow)
    {
        _isShowMenu = isShow;

        var canvas = transform.Find("Canvas");
        if (isShow)
        {
            // �����̖ڂ̑O�Ɏ����Ă���(�p�x�͂��������炷)
            Vector3 menuLocalPos = Quaternion.Euler(0f, -30f, 0f) * Vector3.forward * 0.2f;
            Vector3 menuWorldPos = Camera.main.transform.TransformPoint(menuLocalPos);
            transform.position = menuWorldPos;
            // ����������������(�p�x��������)
            //transform.LookAt(Camera.main.transform.position); // �c�c���Ɖ��̂��C�x���g�������Ȃ��Ȃ�
            Vector3 menuAngle = Camera.main.transform.eulerAngles;
            transform.eulerAngles = new Vector3(menuAngle.x, menuAngle.y - 30f, menuAngle.z);
            canvas.gameObject.SetActive(true);
        }
        else
        {
            canvas.gameObject.SetActive(false);
        }

    }

}
