using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class inherits from the UIelement class and handles the display of the high score
/// </summary>
public class LivesDisplay : UIelement
{
    private Health playerHealth;
    [Tooltip("The text UI to use for display")]
    public Text displayLives = null;
    /// <summary>
    /// Description:
    /// Changes the high score display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public void DisplayLives()
    {
        if (displayLives != null) 
        {
            if (GameManager.instance.player != null)
            {
                playerHealth = GameManager.instance.player.GetComponent<Health>();
                if (playerHealth.currentLives >= 3)
                    displayLives.color = Color.green;
                else if (playerHealth.currentLives > 1)
                    displayLives.color = Color.yellow;
                else
                    displayLives.color = Color.red;
                displayLives.text = "Lives Remaining: " + playerHealth.currentLives.ToString();
            }
        }
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
        DisplayLives();
    }
}
