using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnJandan3 : MonoBehaviour
{
    [SerializeField] AudioSource Sound_jang_1;
    [SerializeField] AudioSource Sound_buk_1;
    [SerializeField] AudioSource Sound_guang_1;
    [SerializeField] AudioSource Sound_jing_1;

    [SerializeField] AudioSource Sound_jang_2;
    [SerializeField] AudioSource Sound_buk_2;
    [SerializeField] AudioSource Sound_guang_2;
    [SerializeField] AudioSource Sound_jing_2;

    [SerializeField] AudioSource Sound_jang_3;
    [SerializeField] AudioSource Sound_buk_3;
    [SerializeField] AudioSource Sound_guang_3;
    [SerializeField] AudioSource Sound_jing_3;

    [SerializeField] GameObject UI_Current;
    [SerializeField] GameObject UI_Jandan3;

    [SerializeField] AudioSource sound_effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playJangDan3()
    {
        sound_effect.Play();

        UI_Current.SetActive(false);
        UI_Jandan3.SetActive(true);

        Sound_jang_1.Stop();
        Sound_buk_1.Stop();
        Sound_guang_1.Stop();
        Sound_jing_1.Stop();

        Sound_jang_2.Stop();
        Sound_buk_2.Stop();
        Sound_guang_2.Stop();
        Sound_jing_2.Stop();

        Sound_jang_3.Play();
        Sound_buk_3.Play();
        Sound_guang_3.Play();
        Sound_jing_3.Play();
    }
}
