using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeCamera : MonoBehaviour
{
    [SerializeField] OVRScreenFade fade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("wave"))
        {
            fade.FadeOut();
            Invoke(nameof(SwitchScene), 3.0f);
        }
    }
    public void SwitchScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
