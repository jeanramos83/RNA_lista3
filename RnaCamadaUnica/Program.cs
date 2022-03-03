// See https://aka.ms/new-console-template for more information
using RnaCamadaUnica;
using System;
using System.Collections.Generic;
//base de treinamento
Entrada e1 = new Entrada(113, 6.8, 1);
Entrada e2 = new Entrada(122, 4.7, 0);
Entrada e3 = new Entrada(107, 5.2, 1);
Entrada e4 = new Entrada(98, 3.6, 1);
Entrada e5 = new Entrada(115, 2.9, 0);
Entrada e6 = new Entrada(120, 4.2, 0);

List<Entrada> baseTreinamento = new List<Entrada>();
baseTreinamento.Add(e1);
baseTreinamento.Add(e2);
baseTreinamento.Add(e3);
baseTreinamento.Add(e4);
baseTreinamento.Add(e5);
baseTreinamento.Add(e6);

//declarar o neuronio
Perceptron p1 = new Perceptron(0.5);
int epoca = 100;
for (int i = 0; i < epoca; i++)
{
    
    p1.Treinamento(baseTreinamento);

}



