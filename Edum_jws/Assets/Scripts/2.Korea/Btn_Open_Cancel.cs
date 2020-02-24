using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_Open_Cancel : MonoBehaviour
{
    [SerializeField] GameObject[] go_open;
    [SerializeField] GameObject[] go_cancel;

    [SerializeField] AudioSource[] sound_Listen;

    [SerializeField] AudioSource sound_effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btn_open_cancel()
    {
        sound_effect.Play();

        for (int i = 0; i < go_open.Length; i++)
        {
            go_open[i].SetActive(true);
        }

        for (int i = 0; i < go_cancel.Length; i++)
        {
            go_cancel[i].SetActive(false);
        }

        for(int i=0; i < sound_Listen.Length; i++)
        {
            sound_Listen[i].Stop();
        }

    }
}
