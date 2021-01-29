using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class SimpleControl : MonoBehaviour
{
    Animator miAnimator;
    bool Salto;

    void Start()
    {
        miAnimator = GetComponent<Animator>();
    }
    private void OnFire(InputValue movementValue)
    {
        Debug.Log("Estoy en OnFire");
        miAnimator.SetBool("Salto", true);
    }

        }
