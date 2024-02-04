using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class inherits from the UIelement class and handles the display of the high score
/// </summary>
public class BossHealth : UIelement
{
    [Tooltip("The text UI to use for display")]
    public Text bossHealthText = null;
    /// <summary>
    /// Description:
    /// Changes the high score display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public void DisplayBossHealth()
    {
        if (GameObject.Find("Boss") != null)
        {
            int bh = GameObject.Find("Boss").GetComponent<Health>().currentHealth;
            if (bossHealthText != null)
            {
                bossHealthText.text = "BOSS HEALTH " + bh.ToString();
            }
        }
    }
    private void Update()
    {
        DisplayBossHealth();
    }

    /// <summary>
    /// Description:
    /// Overrides the virtual function UpdateUI() of the UIelement class and uses the DisplayHighScore function to update
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public override void UpdateUI()
    {
        // This calls the base update UI function from the UIelement class
        base.UpdateUI();

        // The remaining code is only called for this sub-class of UIelement and not others
        DisplayBossHealth();
    }
}
