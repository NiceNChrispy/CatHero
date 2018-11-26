using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{
    public static MusicPlayer instance;

    public enum GameMode {Piano, CatHero }
    public GameMode mode;

    public AudioSource source;

    public AudioClip[] trackList;

    public bool playingTrack;
    public bool panelOpen;

    public GameObject PlayerPanel;

    public Transform openPos;
    public Transform closePos;

    public int trackNum;

    public Text songName;
    public Text playButtonText;

    public Image arrow;

    public GameObject[] heroTracks;

    private void Awake()
    {
        OpenPlayer();
        instance = this;
    }

    #region TrackPlaying

    public void PlayPause()
    {
        if (playingTrack)
            StopTrack();
        else
            PlayTrack();
    }

    void PlayTrack()
    {
        source.PlayOneShot(trackList[trackNum]);
        playingTrack = true;
        playButtonText.text = "Pause";
    }

    void StopTrack()
    {
        source.Stop();
        playingTrack = false;
        playButtonText.text = "Play";
    }

    #endregion

    #region Track Changing

    public void Next()
    {
        trackNum++;
        if (trackNum > trackList.Length - 1)
            trackNum = 0;
    }

    public void Previous()
    {
        trackNum--;
        if (trackNum < 0)
            trackNum = trackList.Length - 1;
    }

    #endregion

    #region Panel Open Close

    public void OpenClose()
    {
        if (panelOpen)
            ClosePlayer();
        else
            OpenPlayer();
    }

    void OpenPlayer()
    {
        iTween.MoveTo(PlayerPanel, iTween.Hash("position", openPos.position, "EaseType","time", 0.5f , iTween.EaseType.easeInOutSine));
        panelOpen = true;
        arrow.transform.localEulerAngles = new Vector3(0,0,-90f);
    }

    void ClosePlayer()
    {
        iTween.MoveTo(PlayerPanel, iTween.Hash("position", closePos.position, "EaseType", "time", 0.5f, iTween.EaseType.easeInOutSine));
        panelOpen = false;
        arrow.transform.localEulerAngles = new Vector3(0, 0, 90f);
    }

    #endregion

    public void ChangeCatHeroTrack()
    {

    }

}
