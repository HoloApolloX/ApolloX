using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonExplorationManager : MonoBehaviour {

    public static MoonExplorationManager Instance { get; private set; }

    public GameObject bootPrintGB;
    public GameObject leafGB;
    public GameObject SiliconDiskGB;
    public GameObject StickerGB;
    public GameObject FlagGB;
    public GameObject SSEPGB;
    public GameObject LRRGB;
    public GameObject PlaqueGB;

    public AudioClip audioClipBreath;
    public AudioSource audioSourceBreath;

    public GameObject scoreText;
    public static float collected = 0.0f;
    public static int state = 0;
    void Start() {
        //bootPrintGB.SetActive(false);
        //leafGB.SetActive(false);
        //SiliconDiskGB.SetActive(false);
        //StickerGB.SetActive(false);
        //FlagGB.SetActive(false);
        //SSEPGB.SetActive(false);
        //LRRGB.SetActive(false);
        //PlaqueGB.SetActive(false);

        audioSourceBreath.PlayOneShot(audioClipBreath);

    }

    void Awake()
    {
        Instance = this;
    }
    
    void Update() {
        //Debug.Log(state);

        if (collected == 25.0f)
            scoreText.GetComponent<TextMesh>().text = string.Format("25.1 kg {0}Congratulations!{0}You can go home {0}now.", Environment.NewLine);
        else
            scoreText.GetComponent<TextMesh>().text = string.Format("Collected: {0} kg", collected);

        //if ((int)State.BootPrint == state)
        //{
        //    bootPrintGB.SetActive(true);
        //}
        //else if ((int)State.Flag == state)
        //{
        //    FlagGB.SetActive(true);
        //}
        //else if ((int)State.SecondAstronaut == state)
        //{

        //}
        //else if ((int)State.DropOff1 == state)
        //{
        //    leafGB.SetActive(true);
        //}
        //else if ((int)State.DropOff2 == state)
        //{
        //    SiliconDiskGB.SetActive(false);
        //}
        //else if ((int)State.DropOff3 == state)
        //{
        //    SSEPGB.SetActive(false);
        //}
        //else if ((int)State.DropOff4 == state)
        //{
        //    LRRGB.SetActive(false);
        //}
        //else if ((int)State.DropOff5 == state)
        //{
        //    PlaqueGB.SetActive(false);
        //}
        //else if ((int)State.DropOff6 == state)
        //{
        //    StickerGB.SetActive(false);
        //}
        //else if ((int)State.CollectRocks == state)
        //{

        //}
    }


    public static void ChangeState()
    {
        state = state + 1;
    }
    public static void CollectRocks()
    {
        collected = collected + 2.5f;
    }
    private enum State {Initial, BootPrint, Flag, SecondAstronaut, DropOff1, DropOff2, DropOff3, DropOff4, DropOff5, DropOff6, CollectRocks };
}
