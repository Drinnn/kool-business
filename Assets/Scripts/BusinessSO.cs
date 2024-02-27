using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Business", fileName = "BusinessSO")]
public class BusinessSO : ScriptableObject
{
    [Header("Sprites")]
    public Sprite baseSprite;
    public Sprite middleSprite;
    public Sprite topSprite;

    [Header("Info")]
    public string id;
    public string nameString;
    public Sprite icon;
}