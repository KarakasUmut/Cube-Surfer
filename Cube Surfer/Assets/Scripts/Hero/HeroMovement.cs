using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{
    [SerializeField] private HeroInputController heroInputController;

    [SerializeField] private float forwardMovementSpeed;

    [SerializeField] private float horizontalMovementSpeed;

    [SerializeField] private float horizontalLimitValue;

    private float newPositionX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        SetHeroForwardMovement();
        SetHeroHorizontalMovement();
    }

    private void SetHeroForwardMovement()
    {
        transform.Translate(Vector3.forward*forwardMovementSpeed*Time.deltaTime);
    }

    private void SetHeroHorizontalMovement()
    {
        newPositionX = transform.position.x + heroInputController.HorizontalValue * Time.fixedDeltaTime;
        newPositionX = Mathf.Clamp(newPositionX,-horizontalLimitValue,horizontalLimitValue);
        transform.position = new Vector3(newPositionX,transform.position.y,transform.position.z);
    }

}
