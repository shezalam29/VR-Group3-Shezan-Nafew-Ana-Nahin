using UnityEngine;
using UnityEngine.Playables;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;
    private ScoreManager scoreManager;
    float previousScore = 0;

    bool isUpping = false;

    void Start()
    {
        // Get the Animator component on the character
        animator = GetComponent<Animator>();

        // Get the ScoreManager singleton instance
        scoreManager = ScoreManager.Instance;
        float previousScore = scoreManager.score;
    }

    private void OnTriggerEnter(Collider collision)
    {
        animator.Play("defeated");
        animator.Play("New State");
    }
}