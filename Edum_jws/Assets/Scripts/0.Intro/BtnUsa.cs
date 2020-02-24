using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnUsa : MonoBehaviour
{
    [SerializeField] GameObject UI_Usa_Desc;

    [SerializeField] AudioSource sound_effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Usa_Desc()
    {
        sound_effect.Play();
        UI_Usa_Desc.SetActive(true);
    }
}
