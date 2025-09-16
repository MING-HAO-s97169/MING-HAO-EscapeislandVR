using UnityEngine;

public class PirateShip : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(new Vector3(0,0,0),new Vector3(0,1,0),-8 * Time.deltaTime);
    }
}
