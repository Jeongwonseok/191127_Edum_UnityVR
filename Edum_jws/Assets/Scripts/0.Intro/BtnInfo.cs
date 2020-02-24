using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnInfo : MonoBehaviour
{
    [SerializeField] GameObject UI_Info;

    [SerializeField] AudioSource sound_effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Btn_Info()
    {
        sound_effect.Play();
        UI_Info.SetActive(true);
    }
}
