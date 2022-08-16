using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public readonly float minSize = 0.5f;
    public readonly float maxSize = 2.0f;
    public float size = 1.0f;

    private SpriteRenderer asteroidSprite;
    private Rigidbody2D asteroidRigidbody;

    [SerializeField] private Sprite[] asteroidSprites;
    private void Awake()
    {
        asteroidSprite = GetComponent<SpriteRenderer>();
        asteroidRigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        asteroidSprite.sprite = asteroidSprites[Random.Range(0, asteroidSprites.Length)];

        transform.eulerAngles = new Vector3(0.0f, 0.0f, Random.value * 360.0f);
        transform.localScale = Vector3.one * size;

        asteroidRigidbody.mass = size;
    }
}
