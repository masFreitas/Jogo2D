using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaguinhoScript : MonoBehaviour
{
    public float velocity;
    public float jump;
    private float inicialPosition;
    private SpriteRenderer spriteRenderer;
    // private int nVezes;
    // Start is called before the first frame update
    void Start()
    {
        // nVezes = 0;
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        Debug.Log("O Maguinho está na área!");
        inicialPosition = this.transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(string.Format("O Maguinho está se atualizando! {0} vezes!", ++nVezes));
        float inputKeyHorizontal = Input.GetAxis("Horizontal");
        float inputKeyVertical = Input.GetAxis("Vertical");
        float x = this.transform.position.x;
        float y = this.transform.position.y;
        float x2 = this.transform.position.x;
        float y2 = this.transform.position.y;

        Debug.Log(string.Format("A posição horizontal é {0}", inputKeyHorizontal));
        Debug.Log(string.Format("A posição vertical é {0}", inputKeyVertical));

        // Se o movimento for para frente, então somar na posição X
        // Caso contrário, se o movimento for para trás, então subtrair na posição X 
        // Caso contrário, então faça nada.

        // if (inputKey > 0)
        // {
        //     this.transform.position = new Vector2(x + velocity, y);
        //     this.spriteRenderer.flipX = false;
        // }
        // else if (inputKey < 0)
        // {
        //     this.transform.position = new Vector2(x - velocity, y);
        //     this.spriteRenderer.flipX = true;
        // }

        // Se o movimento for para cima, então somar na posição Y
        // Após o movimento ser para cima, voltar a posição original 
        // Caso contrário, então faça nada.

        if (inputKeyVertical > 0)
        {
            this.transform.position = new Vector2(x2, jump);

            if (inputKeyHorizontal > 0)
            {
                this.transform.position = new Vector2(x + velocity, jump);
                this.spriteRenderer.flipX = false;
            }
            else if (inputKeyHorizontal < 0)
            {
                this.transform.position = new Vector2(x - velocity, jump);
                this.spriteRenderer.flipX = true;
            }
        }
        else if (inputKeyVertical == 0)
        {
            this.transform.position = new Vector2(x2, inicialPosition);

            if (inputKeyHorizontal > 0)
            {
                this.transform.position = new Vector2(x + velocity, inicialPosition);
                this.spriteRenderer.flipX = false;
            }
            else if (inputKeyHorizontal < 0)
            {
                this.transform.position = new Vector2(x - velocity, inicialPosition);
                this.spriteRenderer.flipX = true;
            }
        }
        else if (inputKeyVertical > 0)
        {
            this.transform.position = new Vector2(x2, inicialPosition);
            if (inputKeyHorizontal > 0)
            {
                this.transform.position = new Vector2(x + velocity, inicialPosition);
                this.spriteRenderer.flipX = false;
            }
            else if (inputKeyHorizontal < 0)
            {
                this.transform.position = new Vector2(x - velocity, inicialPosition);
                this.spriteRenderer.flipX = true;
            }
        }

    }
}
