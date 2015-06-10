using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

    // Use this for initialization
    public GameObject cueBall;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Balls")
        {
            cueBall.GetComponent<AudioSource>().Play();
        }
    }
}
