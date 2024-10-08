using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class DotItem : MonoBehaviour
{
    public Image image;
    public TextMeshProUGUI text;
    public TextMeshProUGUI moves;
    public bool trackingCondition;
   [SerializeField] public int numberOfCollected;
   [SerializeField] public int requirementDots;
    public SpriteAtlas spriteAtlas;
    private DotType dotType;
    public void InitDot(DotType dot,int requirmentQuantity){
        moves.enabled = false;
        image.sprite = GetDotSprite(dot);
        text.text = $"0/{requirmentQuantity}";
        dotType = dot;
        numberOfCollected = 0;
        requirementDots = requirmentQuantity;
        trackingCondition=false;
    }
    public DotType GetDotType()
    {
        return dotType;
    }
     public void UpdateCollectedQuantity(int collectedQuantity)
    {
        // Assuming the format is "collected/required"
        numberOfCollected+=collectedQuantity;
        text.text = $"{numberOfCollected}/{ requirementDots}";
        if(numberOfCollected >= requirementDots){
            trackingCondition = true;
            text.text = $"{requirementDots}/{ requirementDots}";
        }
    }
    public Color GetDotColor(DotType dot){
      switch (dot) {
        case DotType.Red:
            return Color.red;
        case DotType.Green:
            return Color.green;
        case DotType.Blue:
            return Color.blue;
        case DotType.Yellow:
            return Color.yellow;
        case DotType.Gray: return Color.gray;
        case DotType.Pink: return new Color(1f,0.1f,1f);
        case DotType.Orange: return new Color(1f,0.5f,0f);
        case DotType.PerrasinGreen: return new Color(0f,0.6f,0.6f);
        case DotType.DiscoBallBlue: return new Color(0.1f,0.85f,1f);
        case DotType.Chatreuse: return new Color(0.5f,1f,0f);
        case DotType.Indigo: return new Color(0f,0.27f,0.4f);
        case DotType.Raspberry: return new Color(0.9f,0f,0.45f);
        case DotType.PhtaloBlue: return new Color(0f,0.08f,0.5f);
        case DotType.CersizePink: return new Color(1f,0.2f,0.47f);
        case DotType.DarkMagneta: return new Color(0.5f,0f,0.6f);
        case DotType.Brown: return  new Color(0.6f,0.2f,0f);
        case DotType.TyrianPurple: return new Color(0.5f,0f,0.25f);
        case DotType.OxfordBlue: return new Color(0f,0.1f,0.2f);
        case DotType.CherryBlossomPink: return new Color(1f,0.7f,0.8f);
        case DotType.Chocolate: return new Color(0.5f,0.33f,0f);
        case DotType.BabyBlueEyes: return new Color(0.6f,0.67f,1f);
        default:
            return Color.white; // Default case, if needed
    }
    }
    public Sprite GetDotSprite(DotType dot)
    {
        switch (dot)
        {
            case DotType.Red: return spriteAtlas.GetSprite("egg_1");
            case DotType.Green: return spriteAtlas.GetSprite("egg_2");
            case DotType.Yellow: return spriteAtlas.GetSprite("egg_3");
            case DotType.Pink: return spriteAtlas.GetSprite("egg_4");
            default: return spriteAtlas.GetSprite("egg_1");
        }
    }
}
