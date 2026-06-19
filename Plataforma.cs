using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public int speed = 20;
    public Vector3 direction = Vector3.zero;
    public bool isActive = false;

    void Update()
    {
        if (isActive)

        {
            transform.position += direction * speed * Time.deltaTime;

        }


    }
    public void OnTriggerEnter(Collider other)
    {
            print("GustavoFunciona"+ other.tag);
        if (other.tag == "Player")
        {
            isActive = true;
        }
        
        if (other.tag == "GustavoStop")
        {
            direction *= -1;
            isActive = false;
        }
        
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isActive = false;
        }
        
    }
}
