using TMPro;
using UnityEngine;

public class Enhorabuena : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI myText;

    private void OnCollisionEnter(Collision collision)
    {
        myText.text = "¡Enhorabuena!";
        Debug.Log(gameObject.name);
    }
}