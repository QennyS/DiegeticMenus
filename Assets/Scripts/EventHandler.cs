using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{

    public GameObject tablet;
    public GameObject startPanel;
    public GameObject optionPanel;
    public GameObject musicPanel;
    public Canvas offHandCanvas;
    public GameObject playingPanel;
    public AudioSource audioSource;
    private float musicVolume = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = musicVolume;
    }

    public void StartMenu()
    {
        //Panel.gameObject.SetActive(false);
        if (startPanel.activeSelf)
        {
            startPanel.gameObject.SetActive(false);
        }
        if (!optionPanel.activeSelf)
        {
            optionPanel.gameObject.SetActive(true);
        }
    }

    public void Return()
    {
        if (tablet.activeSelf)
        {
            tablet.gameObject.SetActive(false);
        }
        offHandCanvas.gameObject.SetActive(true);
    }

    public void Active()
    {
        offHandCanvas.gameObject.SetActive(false);
        tablet.gameObject.SetActive(true);
    }

    public void ReturnTop()
    {
        if (optionPanel.activeSelf)
        {
            optionPanel.gameObject.SetActive(false);
        }
        startPanel.gameObject.SetActive(true);
    }

    public void ReturnSecond()
    {
        if (musicPanel.activeSelf)
        {
            musicPanel.gameObject.SetActive(false);
        }
        optionPanel.gameObject.SetActive(true);
    }

    public void OptionMenu()
    {
        if (optionPanel.activeSelf)
        {
            optionPanel.gameObject.SetActive(false);
        }
        if (!musicPanel.activeSelf)
        {
            musicPanel.gameObject.SetActive(true);
        }
    }

    public void MusicMenu()
    {
        if (musicPanel.activeSelf)
        {
            musicPanel.gameObject.SetActive(false);
        }
        if (!playingPanel.activeSelf)
        {
            playingPanel.gameObject.SetActive(true);
        }
    }

    public void ReturnThird()
    {
        if (playingPanel.activeSelf)
        {
            playingPanel.gameObject.SetActive(false);
        }
        musicPanel.gameObject.SetActive(true);
    }

    public void Play()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    public void Pause()
    {
        audioSource.Pause();
    }

    public void Volume(float value)
    {
        musicVolume = value;
    }
    
}