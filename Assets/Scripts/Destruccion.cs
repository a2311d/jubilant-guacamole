using UnityEngine;

public class Destruccion : MonoBehaviour
{
    public string myTag = "";

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Kirby")
        {
            Destroy(other.gameObject);
            Debug.Log(gameObject.name);
        }
    }

}
