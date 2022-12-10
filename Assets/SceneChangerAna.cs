using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneChangerAna : MonoBehaviour, IArrowHittable
{

    public void Hit(Arrow arrow)
    {
        SceneManager.LoadScene("Winter_Final_Ana");
        

    }
}
