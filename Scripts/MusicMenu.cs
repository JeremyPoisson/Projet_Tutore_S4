using System.Collections;
using UnityEngine;

public class MusicMenu : MonoBehaviour
{
    void Awake()
    {
        //Gestion son menu principal
        //récupération et destruction du son joué lors des niveaux
        GameObject[] previousMusicLevel = GameObject.FindGameObjectsWithTag("levelmusic");
        if (previousMusicLevel.Length > 0) Destroy(previousMusicLevel[0]);

        //récupération et destruction du son joué lors du garrage
        //TO DO

        GameObject[] tabSound = GameObject.FindGameObjectsWithTag("menumusic");
        if (tabSound.Length > 1) Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }
}
