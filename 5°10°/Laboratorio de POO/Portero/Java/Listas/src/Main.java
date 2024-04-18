import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    static List<Persona> personas = new ArrayList<>();
    static int n = 3, promedi = 0;
    static Persona p2;

    static Persona mayor(){
        p2 = personas.get(0);
        for (int i = 1; i < n; i++){
            if(p2.edad() > personas.get(i).edad()){
                p2 = personas.get(0);
            }
            else {
                p2 = personas.get(i);
            }
        }
        return p2;
    }

    static Persona menor(){
        p2 = personas.get(0);
        for (int i = 1; i < n; i++){
            if(p2.edad() < personas.get(i).edad()){
                p2 = personas.get(0);
            }
            else {
                p2 = personas.get(i);
            }
        }
        return p2;
    }

    static int promedio(){
        int prom = 0;
        for (int i = 0; i < n; i++){
            p2 = personas.get(i);
            prom += p2.edad();
        }
        int promedi = prom/n;
        return promedi;
    }

    public static void main(String[] args) {

        String entradaTeclado = "";
        String entradaTecladofecha = "";

        Scanner entradaEscaner = new Scanner(System.in);
        for (int i = 0; i < n; i++) {
            System.out.println("Ingrese su nombre:");
            entradaTeclado = entradaEscaner.nextLine();

            System.out.println("Ingrese su fecha de nacimiento:");
            entradaTecladofecha = entradaEscaner.nextLine();

            p2 = new Persona(entradaTeclado, entradaTecladofecha);
            personas.add(p2);
        }

        p2 = mayor();
        System.out.println("El mayor es " + p2.nombre);
        p2 = menor();
        System.out.println("El menor es " + p2.nombre);
        promedi = promedio();
        System.out.println("El promedio es " + promedi);

    }
}