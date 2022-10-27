using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class flyMove : MonoBehaviour
{

    private InputAction moveAction;
    private PlayerInputAction actions; 
    public float moveSpeed = 10f;
    private CharacterController controller; 

    public Camera cameraPlayer; 
    
    //Define the speed at which the object moves.


    void Start()
    {
        actions = new PlayerInputAction(); 
        moveAction = actions.Player.Move; 
        moveAction.Enable();
        controller = GetComponent<CharacterController>();
        
    }

    void Update()
    {

        Vector2 moveDirection = moveAction.ReadValue<Vector2>();
    
        Vector2 movement = moveDirection * moveSpeed * Time.fixedDeltaTime;

        controller.Move(movement.y *cameraPlayer.transform.forward + movement.x * transform.right); 
        //movement.x c'est pour les flèches gauches et droite
        //movement.y c'est pour les flèches haut et bas
        //cameraPlayer.transform.forward, ça suit le devant de la caméra (ça renvoit un vector3) donc si on multplie par le résultat des flèches du haut, on avance vers là où regarde la caméra
        //transform.right on aurait pu aussi choisir left, (mais c'est plus simple de choisir un vector3 positif) mais c'est pour que ça renvoit les directions latérales du player (ça renvoit aussi un vector3) et on le multplie par les inputs des flèches latérales
        //on additionne les deux pour un déplacement complet. 
    

        
        


        
    }
}
