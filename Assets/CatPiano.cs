using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatPiano : MonoBehaviour {

    public static CatPiano instance;

    public AudioClip catMeow;

    public CatFaces[] catFaces;

    public AudioSource pianoSource;

    public Transform noteHolder;

    public GameObject note;

    public bool create;

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            pianoSource.pitch = 0.5f;
            pianoSource.PlayOneShot(catMeow);
            catFaces[0].Animate();
            //active = false;
            if (create)
                catFaces[0].CreateNote(noteHolder, note);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            pianoSource.pitch = 0.6f;
            pianoSource.PlayOneShot(catMeow);
            catFaces[1].Animate();

            if (create)
                catFaces[1].CreateNote(noteHolder, note);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            catFaces[2].Animate();
            pianoSource.pitch = 0.7f;
            pianoSource.PlayOneShot(catMeow);
            if (create)
                catFaces[2].CreateNote(noteHolder, note);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            catFaces[3].Animate();
            pianoSource.pitch = 0.8f;
            pianoSource.PlayOneShot(catMeow);
            if (create)
                catFaces[3].CreateNote(noteHolder, note);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            catFaces[4].Animate();
            pianoSource.pitch = 0.9f;
            pianoSource.PlayOneShot(catMeow);
            if (create)
                catFaces[4].CreateNote(noteHolder, note);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            catFaces[5].Animate();
            pianoSource.pitch = 1f;
            pianoSource.PlayOneShot(catMeow);
            if (create)
                catFaces[5].CreateNote(noteHolder, note);
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            catFaces[6].Animate();
            pianoSource.pitch = 1.1f;
            pianoSource.PlayOneShot(catMeow);
            if (create)
                catFaces[6].CreateNote(noteHolder, note);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            catFaces[7].Animate();
            pianoSource.pitch = 1.3f;
            pianoSource.PlayOneShot(catMeow);
            if (create)
                catFaces[7].CreateNote(noteHolder, note);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            catFaces[8].Animate();
            pianoSource.pitch = 1.4f;
            pianoSource.PlayOneShot(catMeow);
            if (create)
                catFaces[8].CreateNote(noteHolder, note);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            pianoSource.pitch = 1.6f;
            pianoSource.PlayOneShot(catMeow);
            catFaces[9].Animate();

            if (create)
                catFaces[9].CreateNote(noteHolder, note);
        }
    }
}
