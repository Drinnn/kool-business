using UnityEngine;

public class Business : MonoBehaviour
{
    [SerializeField] private BusinessSO bussiness;

    [Header("Sprites")]
    [SerializeField] private SpriteRenderer baseSpriteRenderer;
    [SerializeField] private SpriteRenderer middleSpriteRenderer;
    [SerializeField] private SpriteRenderer topSpriteRenderer;

    private int _moneyPerSecond = 1;

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
    
    public void GenerateMoney()
    {
        EconomyManager.Instance.AddMoney(_moneyPerSecond);
    }
}