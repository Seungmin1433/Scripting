using UnityEngine;

public class Transport : MonoBehaviour
{
    public Transform target;
    public void OnTriggerEnter(Collider other)
    {
        Transform transformComponent = other.GetComponent<Transform>();
        transformComponent.position = target.position;

    }

    public void OnTriggerExit(Collider other)
    {

    }
}
