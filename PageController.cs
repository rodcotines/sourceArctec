using UnityEngine;
using UnityEngine.UI;

public class PageController : MonoBehaviour
{
    public GameObject coverModel;          // Assign the cover model in the inspector
    public GameObject[] pageModels;        // Assign the models for each page in the inspector
    public Button[] pageButtons;           // Assign the buttons in the inspector
    public Sprite[] activeSprites;         // Assign the active sprites for each button in the inspector
    public Sprite[] inactiveSprites;       // Assign the inactive sprites for each button in the inspector

    void Start()
    {
        // Ensure the cover model is initially visible
        coverModel.SetActive(true);

        // Ensure all page models are initially hidden
        foreach (GameObject model in pageModels)
        {
            model.SetActive(false);
        }

        // Add listeners to each button to call ShowPageModel with the corresponding index
        for (int i = 0; i < pageButtons.Length; i++)
        {
            int index = i;  // Capture the current value of i
            pageButtons[i].onClick.AddListener(() => ShowPageModel(index));
        }
    }

    public void ShowPageModel(int pageIndex)
    {
        // Hide the cover model
        coverModel.SetActive(false);

        // Hide all page models first
        foreach (GameObject model in pageModels)
        {
            model.SetActive(false);
        }

        // Show the model for the selected page
        if (pageIndex >= 0 && pageIndex < pageModels.Length)
        {
            pageModels[pageIndex].SetActive(true);
        }

        // Update the button images
        UpdateButtonImages(pageIndex);
    }

    public void ResetToCoverModel()
    {
        // Hide all page models
        foreach (GameObject model in pageModels)
        {
            model.SetActive(false);
        }

        // Show the cover model
        coverModel.SetActive(true);

        // Reset button images
        ResetButtonImages();
    }

    private void UpdateButtonImages(int activeIndex)
    {
        for (int i = 0; i < pageButtons.Length; i++)
        {
            Image buttonImage = pageButtons[i].GetComponent<Image>();
            if (buttonImage != null)
            {
                if (i == activeIndex)
                {
                    buttonImage.sprite = activeSprites[i];
                }
                else
                {
                    buttonImage.sprite = inactiveSprites[i];
                }
            }
        }
    }

    private void ResetButtonImages()
    {
        for (int i = 0; i < pageButtons.Length; i++)
        {
            Image buttonImage = pageButtons[i].GetComponent<Image>();
            if (buttonImage != null)
            {
                buttonImage.sprite = inactiveSprites[i];
            }
        }
    }
}
