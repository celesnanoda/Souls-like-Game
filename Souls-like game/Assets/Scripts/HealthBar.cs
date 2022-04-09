using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SoulsGame
{
    public class HealthBar : MonoBehaviour
    {
        
       public Slider slider;
       public void SetMaxHealth( int maxHealth )
       {
           slider.maxValue = maxHealth;
           slider.value = maxHealth;
       }

       public void SetCurrentHealth( int currentHealth )
       {
           slider.value = currentHealth;
       }
    }
}


