using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class inherits from the UIelement class and handles the display of the high score
/// </summary>
public class EnemiesLeftDisplay : UIelement
{
    [Tooltip("The text UI to use for display")]
    public Text enemiesLeftText = null;

    /// <summary>
    /// Description:
    /// Changes the high score display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public void DisplayEnemiesLeft()
    {
        if (enemiesLeftText != null)
        {
            enemiesLeftText.text = "Enemies Remaining: " + GameManager.instance.enemiesLeft.ToString();
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
        DisplayEnemiesLeft();
    }
}
