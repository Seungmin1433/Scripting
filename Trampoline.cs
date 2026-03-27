using UnityEngine;

public class Trampoline : MonoBehaviour
{
    // Obtenemos el compoenente salto
    public void OnTriggerEnter(Collider other)
    {
        //Cambiamos salto a 10
        Jump jumpComponent = other.GetComponent<Jump>();
        jumpComponent.jumpStrength = 10;
    }

    
    public void OnTriggerExit(Collider other)
    {
        //Cambiamos salto a 2
        Jump jumpComponent = other.GetComponent<Jump>();
        jumpComponent.jumpStrength = 2;
    }
}
