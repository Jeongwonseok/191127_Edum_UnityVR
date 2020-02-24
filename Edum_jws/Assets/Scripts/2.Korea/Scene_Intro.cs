using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Intro : MonoBehaviour
{
    [SerializeField] AudioSource sound_effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Scene_intro()
    {
        
        SceneManager.LoadScene("0.Intro");
        sound_effect.Play();
    }
}
