// using UnityEngine;
// using UnityEngine.UI;
// using TMPro;
// public class ScoreManager : MonoBehaviour
// {
//     public static ScoreManager Instance { get; private set; }
//     public float Score { get; private set; }
//     private void Awake()
//     {
//         Instance = this;
//     }

//     public float score;
//     public float transitionSpeed = 100;
//     float displayScore;
//     public TMP_Text scoreText;

//     void Start()
//     {
//       scoreText = gameObject.GetComponent<TMPro.TextMeshPro>();
//     }

//     private void Update()
//     {
//         displayScore = Mathf.MoveTowards(displayScore, score, transitionSpeed * Time.deltaTime);
//         UpdateScoreDisplay();
//     }

//     public void IncreaseScore(float amount)
//     {
//         score += amount;
//     }
//     public void UpdateScoreDisplay()
//     {
//         scoreText.text = string.Format("Your Score Is: {0:00000}", displayScore);
//     }
// }
