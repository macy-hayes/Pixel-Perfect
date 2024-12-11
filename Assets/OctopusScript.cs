using UnityEngine;
using UnityEngine.SceneManagement;

public class OctopusScript : MonoBehaviour
{
    public bool isOnOcto = false;
    public bool isInteracting = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isInteracting = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isInteracting = false;
        }

        if (isOnOcto)
        {
            if (isInteracting)
            {
                //Write dialogue code
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            isOnOcto = true;  
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isOnOcto = false;
        }
    }
}
