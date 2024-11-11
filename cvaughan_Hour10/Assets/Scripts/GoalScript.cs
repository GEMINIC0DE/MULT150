using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isSolved = false;
    public ParticleSystem collisionParticleSystem;
    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            var em = collisionParticleSystem.emission;

            isSolved = true;
            GetComponent<Light>().enabled = false;
            Destroy(collidedWith);
            em.enabled = true;
            collisionParticleSystem.Play();
        }
    }
}
