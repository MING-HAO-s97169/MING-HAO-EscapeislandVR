using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController characterController;
    private float movespeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        movespeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            characterController.SimpleMove(transform.forward * movespeed);
        }
    }
}
