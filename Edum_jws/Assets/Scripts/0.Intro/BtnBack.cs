using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnBack : MonoBehaviour
{
    [SerializeField] GameObject UI_Help;

    [SerializeField] AudioSource sound_effect;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Btn_Back()
    {
        sound_effect.Play();
        UI_Help.SetActive(false);
    }
}
