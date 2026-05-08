using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool _hasPackage;
    SpriteRenderer spriteRenderer;
    [SerializeField] float distoryTime = 0.0f;
    [SerializeField] Color32 packageDriverColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPakckageDriverColor = new Color32(1, 1, 1, 1);
    public bool HasPackage { get { return _hasPackage; } }

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package" && !_hasPackage)
        {
            Debug.Log("패키지 픽업!");
            _hasPackage = true;
            spriteRenderer.color = packageDriverColor;
            Destroy(other.gameObject, distoryTime);
        }
        else if(other.tag == "Package" && _hasPackage)
        {
            Debug.Log("동일 종류의 패키지가 있습니다!");
        }

        if (other.tag == "Customer" && _hasPackage)
        {
            Debug.Log("배달 완료!");
            _hasPackage = false;
            spriteRenderer.color = noPakckageDriverColor;
        }
        else if(other.tag == "Customer" && !_hasPackage)
        {
            Debug.Log("패키지가 없습니다.");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }
}
