using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLevels : MonoBehaviour
{
    void Awake()
    {
        //Gestion son niveaux
        //récupération et destruction du son joué lors du menu
        GameObject[] previousMusicMenu = GameObject.FindGameObjectsWithTag("menumusic");
        if(previousMusicMenu.Length > 0) Destroy(previousMusicMenu[0]);

        //récupération et destruction du son joué lors du garrage
        //TO DO

        GameObject[] tabSound = GameObject.FindGameObjectsWithTag("levelmusic");
        if (tabSound.Length > 1) Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }
}
