using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnBack_4 : MonoBehaviour
{
    [SerializeField] GameObject UI_Current;
    [SerializeField] GameObject UI_Next;

    //[SerializeField] AudioSource ad_jang;
    //[SerializeField] AudioSource ad_buk;
    //[SerializeField] AudioSource ad_guang;
    //[SerializeField] AudioSource ad_jing;

    [SerializeField] AudioSource[] ad_instrument;

    [SerializeField] AudioSource sound_effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btnBack_4()
    {
        sound_effect.Play();

        UI_Current.SetActive(false);
        UI_Next.SetActive(true);

        for (int i = 0; i < 4; i++)
        {
            ad_instrument[i].volume = 1.0f;
            ad_instrument[i].Stop();
        }

        //ad_jang.Stop();
        //ad_buk.Stop();
        //ad_guang.Stop();
        //ad_jing.Stop();
    }
}
