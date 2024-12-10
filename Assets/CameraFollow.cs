using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] //Expose in property inspector
    GameObject player;

    [SerializeField]
    float speedOffset;

    [SerializeField]
    Vector2 posOffset;

    [SerializeField]
    float leftLimit;
    [SerializeField]
    float rightLimit;
    [SerializeField]
    float bottomLimit;
    [SerializeField]
    float topLimit;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 startPos = transform.position; //Camera's current position
        Vector3 endPos = player.transform.position; //Player's current position

        endPos.x += posOffset.x;
        endPos.y += posOffset.y;
        endPos.z = -10;

        //linear interpolation
                                                                        //time that has passed from last to current frame
        transform.position = Vector3.Lerp(startPos, endPos, speedOffset * Time.fixedDeltaTime);

                                               //Clamp transform position x to the left and right limit
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, leftLimit, rightLimit), 
                                         Mathf.Clamp(transform.position.y, bottomLimit, topLimit), 
                                         transform.position.z);
    }
}
