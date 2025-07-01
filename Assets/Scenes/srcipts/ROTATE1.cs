using UnityEngine;

public class ROTATE1 : MonoBehaviour
{
    // declaring a variable to setect the rotation target
    public Transform target;
    public int speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate Around the first parameter target position
        //Rotate Around needs secound parameter about the axis or rotation
        //Rotate Around third parameter needed is the speed  of rotation
        transform.RotateAround(target.transform.position, target.transform.up, speed *Time.deltaTime);
    }
}
