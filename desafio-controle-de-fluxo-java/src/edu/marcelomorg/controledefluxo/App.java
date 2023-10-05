package edu.marcelomorg.controledefluxo;

import java.util.Scanner;

import edu.marcelomorg.controledefluxo.services.Contagem;

public class App {
    public static void main(String[] args) throws Exception {
        Scanner sc = new Scanner(System.in);
        System.out.print("Insira o primeiro numero: ");
        int numberOne = sc.nextInt();
        System.out.print("Insira o segundo numero: ");
        int numberTwo = sc.nextInt();
        sc.close();

        try {
            Contagem.verificar(numberOne, numberTwo);
        } catch (Exception ex) {
            System.err.println(ex.getMessage());
        }
    }
}
