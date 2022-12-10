using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
// This is me playing around to figure out how to update the score
public class updateScoreText : MonoBehaviour
{

    
    
    public TMP_Text updateText;
    public int tempScore = 0;
    // Start is called before the first frame update
    void Start()
    {
      updateText = gameObject.GetComponent<TMPro.TextMeshPro>();
            
    }

    // Update is called once per frame
    void Update()
    {
        
        updateText.text = "Your Score: " + tempScore.ToString();
        tempScore = 0;
        
    
        
    }
}
