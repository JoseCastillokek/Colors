﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinCollect : MonoBehaviour
{
    public Text scoretext;
    public Slider slideymcslidey;
    int score = 0;

    private void Start()
    {
        scoretext.text = "score = " + score.ToString();
        //slideymcslidey.value = score;
    }

    private void OnCollisionEnter2D(Collision2D otherObject)
    {
        if (otherObject.gameObject.tag == "coin") {
            score++;

            //slideymcslidey.value = score;

            if (score == 4) {
                SceneManager.LoadScene("level 1");
            } else {
                scoretext.text = "score = " + score.ToString();
            }

            Destroy(otherObject.gameObject);
            Debug.Log(score);
        }
    }

}
