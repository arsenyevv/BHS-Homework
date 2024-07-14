using UnityEngine;

namespace BHS
{
    public class border : MonoBehaviour
    {
        [SerializeField]
        private void OnTriggerStay2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {

                other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                other.transform.position = new Vector2(0,2);
            }
        }
    }
}
