using UnityEngine;

public class Target : MonoBehaviour, IArrowHittable
{
    public float forceAmount = 1.0f;
    public Material otherMaterial = null;

    public GameObject giant;

    public AudioSource playSound;

    public void Hit(Arrow arrow)
    {

        ApplyMaterial();
        ApplyForce(arrow.transform.forward);
        playSound.Play();

    }

    //private void danceGiant()
    //{
    //    giant = GameObject.Find("castle_guard_01@Twist Dance");
    //    Animation anim = giant.GetComponent<Animation>();
    //    anim.Play("defeated");
    //}

    //private void stopGiant()
    //{
    //    giant = GameObject.Find("castle_guard_01@Twist Dance");
    //    Animation anim = giant.GetComponent<Animation>();
    //    anim.Play("Twist Dance");
    //}
           
    private void ApplyMaterial()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = otherMaterial;
    }

    private void ApplyForce(Vector3 direction)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(direction * forceAmount);
        float points = 100;
        ScoreManager.Instance.IncreaseScore(points);
    }
}