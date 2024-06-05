using Unity.VisualScripting;
using UnityEngine;

public class Break : MonoBehaviour
{
    [SerializeField] GameObject fullGlass;
    [SerializeField] GameObject brokenGlass;

    BoxCollider boxCollider;
    Rigidbody rb;
    
    private void Awake()
    {
        fullGlass.SetActive(true);
        brokenGlass.SetActive(false);

        boxCollider = GetComponent<BoxCollider>();
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        BreakGlass();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        BreakGlass();
    }

    public void BreakGlass()
    {
        rb.isKinematic = true;
        boxCollider.enabled = false;
        fullGlass.SetActive(false);
        brokenGlass.SetActive(true);
    }
}
