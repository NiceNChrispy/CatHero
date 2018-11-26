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
            //pianoSource.pitch = 0.1f;
            //pianoSource.PlayOneShot(catMeow);
            catFaces[0].Animate();
            //active = false;
            if (create)
                catFaces[0].CreateNote(noteHolder, note);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            catFaces[1].Animate();

            if (create)
                catFaces[1].CreateNote(noteHolder, note);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            catFaces[2].Animate();

            if (create)
                catFaces[2].CreateNote(noteHolder, note);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            catFaces[3].Animate();

            if (create)
                catFaces[3].CreateNote(noteHolder, note);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            catFaces[4].Animate();

            if (create)
                catFaces[4].CreateNote(noteHolder, note);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            catFaces[5].Animate();

            if (create)
                catFaces[5].CreateNote(noteHolder, note);
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            catFaces[6].Animate();

            if (create)
                catFaces[6].CreateNote(noteHolder, note);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            catFaces[7].Animate();

            if (create)
                catFaces[7].CreateNote(noteHolder, note);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            catFaces[8].Animate();

            if (create)
                catFaces[8].CreateNote(noteHolder, note);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            catFaces[9].Animate();

            if (create)
                catFaces[9].CreateNote(noteHolder, note);
        }
    }
}
