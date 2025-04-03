using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class FireInteract : MonoBehaviour
{
    [SerializeField] private ParticleSystem fireParticle;

    void OnInteract()
    {
        if (fireParticle.isPlaying)
        {
            fireParticle.Stop();
        }
        else
        {
            fireParticle.Play();
        }
    }
}
