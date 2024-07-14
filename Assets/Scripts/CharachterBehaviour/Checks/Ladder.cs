using UnityEngine;

namespace BHS
{
    public class Ladder : MonoBehaviour
    {
        [SerializeField, Range(0, 5)] private int speed = 5;

        private void OnTriggerStay2D(Collider2D other)
        {
            other.GetComponent<Rigidbody2D>().gravityScale = 0;
            if (other.gameObject.CompareTag("Player"))
            {
                if (Input.GetKey(KeyCode.W))
                {
                    other.GetComponent<Rigidbody2D>().velocity = new Vector2(0,speed);
                }
                    else if (Input.GetKey(KeyCode.S))
                    {
                    other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
                    }   
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
  
            other.GetComponent<Rigidbody2D>().gravityScale = 1;
        }

    }
}
