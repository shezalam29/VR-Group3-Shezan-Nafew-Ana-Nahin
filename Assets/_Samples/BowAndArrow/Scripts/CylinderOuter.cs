using System;
using UnityEngine;
using UnityEngine.Events;


public class CylinderOuter : MonoBehaviour, IArrowHittable
{
    public AudioSource playSound;
    public void Hit(Arrow arrow)
    {
        float cpoints = 50;
        ScoreManager.Instance.IncreaseScore(cpoints);
        playSound.Play();
    }

}
