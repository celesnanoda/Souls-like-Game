using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoulsGame
{
   public class PlayerAttacker : MonoBehaviour
    {

        AnimationHandler animationHandler;

        private void Awake() 
        {
            animationHandler = GetComponentInChildren<AnimationHandler>();
        }

        public void HandleLightAttack( WeaponItem weapon )
        {
            animationHandler.PlayerTargetAnimation( weapon.OH_Light_Attack_1, true );
        }

        public void HandleHeavyAttack( WeaponItem weapon )
        {
            animationHandler.PlayerTargetAnimation( weapon.OH_Heavy_Attack_1, true );
        }

    } 
}

