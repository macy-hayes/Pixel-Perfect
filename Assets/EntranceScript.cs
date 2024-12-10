using UnityEngine;
using UnityEngine.SceneManagement;

public class EntranceScript : MonoBehaviour
{
    public int sceneBuildIndex;
    public bool isInteracting = false;
    public bool isInDoorway = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (tag == "House1")
            sceneBuildIndex = 1;
        else if (tag == "House2")
            sceneBuildIndex = 2;
        else if (tag == "House3")
            sceneBuildIndex = 3;
        else if (tag == "House4")
            sceneBuildIndex = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            isInteracting = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isInteracting = false;
        }

        if (isInDoorway)
        {
            if (isInteracting)
            {
                SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            isInDoorway = true;
            //SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);  
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isInDoorway = false;
        }
    }
}
