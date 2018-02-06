using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : IMiniGame {
    
    public int contador;
    public int numero = 100;
    public int rand;

    void Update()
    {
        if (contador == numero) {

            Debug.Log("YOU WIN");
        }else
        if (Input.GetKey("Jump")) {

            contador = contador + 1;

            while (contador < numero)
            {
                rand = (1,4);

            }
        }

    }

public override void beginGame()
    {
        throw new NotImplementedException();
    }

    public override void initGame(MiniGameDificulty difficulty, GameManager gm)
    {
        throw new NotImplementedException();
    }
}
