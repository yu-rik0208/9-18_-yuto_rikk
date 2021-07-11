using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private CharacterController CharacterController;
    private Transform ChracterTransform;
    // Start is called before the first frame update

    public float MovementSpeed;

    void Start()
    {
        CharacterController = GetComponent<CharacterController>();
        ChracterTransform = transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        var tmp_Horizontal = Input.GetAxis("Horizontal");
        var tmp_Vertical = Input.GetAxis("Vertical");
        var tmp_MovementDirection =
        ChracterTransform.TransformDirection(new Vector3(tmp_Horizontal, 0, tmp_Vertical));
        CharacterController.Move(tmp_MovementDirection * MovementSpeed * Time.deltaTime);



    }
}
