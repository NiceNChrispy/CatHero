using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {

    public static Scoring instance;

    public float combo;
    public float rockAmount;
    public float score;

    public Text comboText;
    public Text scoreText;

    private void Awake()
    {
        instance = this;
    }

    private void FixedUpdate()
    {
        comboText.text = "COMBO - " + combo.ToString();
        scoreText.text = score.ToString();
    }


}
