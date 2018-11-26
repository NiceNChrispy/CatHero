using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFaces : MonoBehaviour {

    public bool animate;

    public GameObject tophalf;

    public Vector3 startPos;

    public bool active = false;

    GameObject note;

    public Color color;

    private void Awake()
    {
        startPos = tophalf.transform.position;
        color = tophalf.GetComponent<SpriteRenderer>().color;
    }

    public void Animate()
    {
        if (MusicPlayer.instance.mode == MusicPlayer.GameMode.CatHero && !CatPiano.instance.create)
        {
            Destroy(note);
            Scoring.instance.score += 100;
            Scoring.instance.combo += 1;
        }

        if (animate)
        {
            StartCoroutine(Mouth());
        }
        else
            return;
    }

    IEnumerator Mouth()
    {
        iTween.MoveTo(tophalf, iTween.Hash("position", startPos + new Vector3(0,0.5f,0) , "EaseType", iTween.EaseType.easeInOutSine, "time", 0.1f));
        yield return new WaitForSeconds(0.1f);
        iTween.MoveTo(tophalf, iTween.Hash("position", startPos, "EaseType", iTween.EaseType.easeInOutSine, "time", 0.1f));
        yield return null;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        active = true;
        if (col.gameObject.tag == "Note")
            note = col.gameObject;
        Debug.Log("note hit");
    }

    void OnTriggerExit2D(Collider2D col)
    {
        active = false; 
    }

    public void CreateNote(Transform parent, GameObject notePrefab)
    {
        GameObject newnote = Instantiate(notePrefab, transform.position, Quaternion.identity, parent);
        newnote.GetComponent<SpriteRenderer>().color = color;
    }
}
