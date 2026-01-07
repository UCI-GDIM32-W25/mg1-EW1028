using UnityEngine;
using TMPro;


public class PlantCountUI : MonoBehaviour
{
    public int seedsLeft;
    public int seedsPlanted;
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        _remainingText.text = seedsLeft.ToString();
        _plantedText.text = seedsPlanted.ToString();
    } 
}