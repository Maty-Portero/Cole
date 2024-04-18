import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    static Persona p2;

    public static void main(String[] args) {
        List<Persona> personas = new ArrayList<>();
        String entradaTeclado = "";
        String entradaTecladofecha = "";

        Scanner entradaEscaner = new Scanner(System.in);
        for (int i = 0; i < 3; i++) {
            System.out.println("Ingrese su nombre:");
            entradaTeclado = entradaEscaner.nextLine();

            System.out.println("Ingrese su fecha de nacimiento:");
            entradaTecladofecha = entradaEscaner.nextLine();

            p2 = new Persona(entradaTeclado, entradaTecladofecha);
            personas.add(p2);
        }

        for (int i = 0; i < 3; i++) {
            p2 = personas.get(i);
            System.out.println(p2.nombre + " nacio el " + p2.fecha_nac);
        }
    }
}