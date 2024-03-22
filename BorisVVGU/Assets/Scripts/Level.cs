using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    int experience = 0;
    int level = 1;
    [SerializeField] ExperienceBar experienceBar;
    [SerializeField] UpgradePanelManager upgradePanel;
    int TO_LEVEL_UP {
        get {
            return level * 1000;
        }
    }
    
    private void Start() {
        experienceBar.UpdateExperienceSlider(experience, TO_LEVEL_UP);
        experienceBar.SetLevelText(level);
    }
    public void AddExperience(int amount) {
        experience += amount;
        CheckLevelUp();
        experienceBar.UpdateExperienceSlider(experience, TO_LEVEL_UP);
    }
    public void CheckLevelUp() {
        if (experience >= TO_LEVEL_UP) {
            LevelUp();
        }
    }
    private void LevelUp() {
        upgradePanel.OpenPanel();
        experience -= TO_LEVEL_UP;
        level += 1;
        experienceBar.SetLevelText(level);
    }
}