using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisionspikeslevel1 : MonoBehaviour {


    
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Trap")
            {
                SceneManager.LoadScene("level 1");
            }
        }






    }







