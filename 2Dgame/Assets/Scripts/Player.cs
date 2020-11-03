using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject final;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        print("EnterGate");
        final.SetActive(true);
    }
}
