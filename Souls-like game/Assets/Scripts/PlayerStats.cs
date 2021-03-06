using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoulsGame
{
    public class PlayerStats : MonoBehaviour
    {
        public int healthLevel = 10;
        public int maxHealth;
        public int currentHealth;

        public HealthBar healthBar;
        AnimationHandler animationHandler;

        private void Awake() 
        {
            animationHandler = GetComponentInChildren<AnimationHandler>();
        }
        private void Start() 
        {
            maxHealth = SetMaxHealthFromHealthLevel();
            currentHealth = maxHealth;
            healthBar.SetMaxHealth( maxHealth );
        }

        private int SetMaxHealthFromHealthLevel()
        {
            maxHealth = healthLevel * 10;
            return maxHealth;
        }

        public void TakeDamage( int damage )
        {
            currentHealth = currentHealth - damage;
            healthBar.SetCurrentHealth( currentHealth );
            animationHandler.PlayerTargetAnimation("Damage", true);

            if( currentHealth <= 0)
            {
                currentHealth = 0;
                animationHandler.PlayerTargetAnimation("Death", true);
            }

        }

    }
}

