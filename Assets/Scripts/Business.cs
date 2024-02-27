using UnityEngine;

public class Business : MonoBehaviour
{
    [SerializeField] private BusinessSO bussiness;

    [Header("Sprites")]
    [SerializeField] private SpriteRenderer baseSpriteRenderer;
    [SerializeField] private SpriteRenderer middleSpriteRenderer;
    [SerializeField] private SpriteRenderer topSpriteRenderer;

    private void Start()
    {
        UpdateSprites();
    }

    private void UpdateSprites()
    {
        baseSpriteRenderer.sprite = bussiness.baseSprite;
        middleSpriteRenderer.sprite = bussiness.middleSprite;
        topSpriteRenderer.sprite = bussiness.topSprite;
    }
}