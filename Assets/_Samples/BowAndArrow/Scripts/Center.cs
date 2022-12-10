using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Center : MonoBehaviour, IArrowHittable
{
    public AudioSource playSound;
    public void Hit(Arrow arrow)
    {
        float points = 100;
        ScoreManager.Instance.IncreaseScore(points);
        playSound.Play();
    }

}
