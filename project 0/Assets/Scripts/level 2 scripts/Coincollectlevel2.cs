using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Coincollectlevel2 : MonoBehaviour
{
    public Text scoretext;
    public Slider slideymcslidey;
    int score = 9;

    private void Start()
    {
        scoretext.text = "score = " + score.ToString();
        //slideymcslidey.value = score;
    }

    private void OnCollisionEnter2D(Collision2D otherObject)
    {
        if (otherObject.gameObject.tag == "coin")
        {
            score++;

            //slideymcslidey.value = score;

            if (score == 16)
            {
                SceneManager.LoadScene("StartScreen");
            }
            else
            {
                scoretext.text = "score = " + score.ToString();
            }

            Destroy(otherObject.gameObject);
            Debug.Log(score);
        }
    }

}