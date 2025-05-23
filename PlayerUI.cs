using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;
    public Mana mana;
    
    void Update()
    {
        healthSlider.maxValue = player.maxHealth;
        healthSlider.value = player.health;
        coinsCounterText.text = player.coins.ToString();
        manaSlider.maxValue = mana.maxMana;
        manaSlider.value = mana.mana;
    }
}
