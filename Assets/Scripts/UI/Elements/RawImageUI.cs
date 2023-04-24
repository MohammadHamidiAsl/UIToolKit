using UnityEngine;
using UnityEngine.UI;

public class RawImageUI : MonoBehaviour
{
    private RawImage rawImage;

    private void Awake()
    {
        // Get the RawImage component attached to this object
        rawImage = GetComponent<RawImage>();
    }

    public void SetTexture(Texture2D texture)
    {
        // Set the texture of the RawImage component
        rawImage.texture = texture;
    }
}