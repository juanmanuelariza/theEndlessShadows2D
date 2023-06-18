using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Raycast();
    }

    private void Raycast()
    {
        float rayLenght = 4f;
        Ray ray = new Ray(transform.position, Vector2.left);

        Debug.DrawRay(ray.origin, ray.direction * rayLenght, Color.yellow);

        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, rayLenght, layerMask);
        if (hit)
        {
            Debug.Log(hit.collider.name);
            var player = hit.collider.gameObject.GetComponent<PlayerController>();
            if (player != null && !player.isHidden)
            {
                Debug.DrawRay(ray.origin, ray.direction * rayLenght, Color.red);
            }
            else
            {
                Debug.DrawRay(ray.origin, ray.direction * rayLenght, Color.yellow);
            }
        }
    }

}
