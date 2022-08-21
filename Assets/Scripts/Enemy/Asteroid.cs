using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public readonly float minSize = 0.5f;
    public readonly float maxSize = 2.0f;
    public float size = 1.0f;
    public float maxLifetime = 30.0f;

    private int chipCount;
    private readonly int chipCountMax = 5;
    private float speed = 0.0005f;
    private float multiply = 10.0f;
    private Vector2 trajectory;

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
        chipCount = Random.Range(2, chipCountMax);
    }
    private void Update()
    {
        Moving();
    }
    private void Moving()
    {
        if (trajectory != null) transform.position = Vector2.Lerp(transform.position, trajectory, speed);
    }
    public void SetTrajectory(Vector2 direction)
    {
        trajectory = direction;

        //asteroidRigidbody.AddForce(direction * speed);

        Destroy(gameObject, maxLifetime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
           if((size * 0.5f) >= minSize)
            {
                for (int i = 0; i < chipCount; i++)
                {
                    CreateSplit();
                }                                
            }
            Destroy(gameObject);
        }
    }
    private void CreateSplit()
    {
        Vector2 position = transform.position;
        position += Random.insideUnitCircle * 0.5f;

        Asteroid chip = Instantiate(this, position, transform.rotation);
        chip.size = this.size * 0.5f;
        chip.SetTrajectory(Random.insideUnitCircle.normalized * multiply);
    }
}
