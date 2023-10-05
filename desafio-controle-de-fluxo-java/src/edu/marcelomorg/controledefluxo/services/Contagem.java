package edu.marcelomorg.controledefluxo.services;

import edu.marcelomorg.controledefluxo.exceptions.ParametroInvalidoException;

public class Contagem{
    public static void verificar(int numberOne, int numberTwo) throws Exception {
        if (numberOne > numberTwo) {
            throw new ParametroInvalidoException("O segundo parâmetro deve ser maior que o primeiro.");
        } else {
            System.out.println("Imprimindo numero(s):");
            for (int i = 0; i <= numberTwo - numberOne; i++) {
                System.out.print(i + " ");
            }
            System.out.println("");
        }
    }
}