using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreen : MonoBehaviour
{

    private void Start()
    {
        SoundManager.Instance.UpdateMusic("menu");
    }
    public void OnPlayButton()
    {
        LevelLoader.Instance.LoadScenes();
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
