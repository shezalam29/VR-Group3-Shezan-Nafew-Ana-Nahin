using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class ScoreDisplay : MonoBehaviour
// {
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }

using UnityEngine.UI;
using TMPro;
public class ScoreDisplay : MonoBehaviour
{

    public TMP_Text scoreText;
    float score;

     void Start()
    {
      scoreText = gameObject.GetComponent<TMPro.TextMeshPro>();
            
    }
    public void IncreaseScore(float amount)
    {
        score += amount;
        UpdateScoreDisplay();
    }
    public void UpdateScoreDisplay()
    {
        scoreText.text = string.Format("Score: {0:00000}", score);
    }
}
