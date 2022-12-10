using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneChangerNahin: MonoBehaviour, IArrowHittable
{

    public void Hit(Arrow arrow)
    {
        SceneManager.LoadScene("nahinfinalscene");
        

    }
}

