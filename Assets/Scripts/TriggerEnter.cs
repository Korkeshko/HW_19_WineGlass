using UnityEngine;

public class TriggerEnter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.attachedRigidbody.isKinematic = true;
    }
}