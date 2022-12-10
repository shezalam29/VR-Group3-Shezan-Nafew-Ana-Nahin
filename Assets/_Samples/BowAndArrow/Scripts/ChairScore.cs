using System;
using UnityEngine;
using UnityEngine.Events;

public class ChairScore : MonoBehaviour, IArrowHittable
{
    public AudioSource playSound;
    public void Hit(Arrow arrow)
    {
        float cpoints = 60;
        ScoreManager.Instance.IncreaseScore(cpoints);
        playSound.Play();
    }
} 

