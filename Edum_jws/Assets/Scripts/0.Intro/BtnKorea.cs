using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnKorea : MonoBehaviour
{
    [SerializeField] GameObject UI_Korea_Desc;

    [SerializeField] AudioSource sound_effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Korea_Desc()
    {
        sound_effect.Play();
        UI_Korea_Desc.SetActive(true);
    }
}
