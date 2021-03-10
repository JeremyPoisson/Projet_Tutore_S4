using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicGarrage : MonoBehaviour
{
    void Awake()
    {
        //Gestion son menu principal
        //récupération et destruction du son joué lors du menu
        GameObject[] previousMusicMenu = GameObject.FindGameObjectsWithTag("menumusic");
        if (previousMusicMenu.Length > 0) Destroy(previousMusicMenu[0]);

        //récupération et destruction du son joué lors des niveaux
        GameObject[] previousMusicLevel = GameObject.FindGameObjectsWithTag("levelmusic");
        if (previousMusicLevel.Length > 0) Destroy(previousMusicLevel[0]);

        //TO DO
    }
}
