using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnSelect : MonoBehaviour
{
    [SerializeField] GameObject UI_Country;

    [SerializeField] AudioSource sound_effect;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Btn_Select()
    {
        sound_effect.Play();
        UI_Country.SetActive(true);
    }
}
