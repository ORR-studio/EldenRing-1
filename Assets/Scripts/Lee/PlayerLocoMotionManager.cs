using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SG
{

    public class PlayerLocoMotionManager : MonoBehaviour
    {
        PlayerManger player;

        public float verticalMovement;
        public float horizontalMovement;
        public float moveAmount;

        private Vector3 moveDirection;

        public void HandleAllMovement()
        {
            // �⺻������

            // ���� ������ 

        }
        void HandleGroundedMovement()
        {
            // �÷��̾� ���󰡴� ī�޶� ������ 
            moveDirection = PlayerCamera.instance.transform.forward * verticalMovement;
            moveDirection = moveDirection + PlayerCamera.instance.transform.right * horizontalMovement;
            moveDirection.Normalize();
            moveDirection.y = 0;

            //if()
            //{

            //}
        }

    }


}