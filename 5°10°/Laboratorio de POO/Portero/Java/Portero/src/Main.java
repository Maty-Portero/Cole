import java.util.ArrayList;
import java.util.List;

public class Main {
    static Persona p1;

    public static void main(String[] args) {
        int x;
        List<Persona> personas = new ArrayList<>();

        for (int i = 0; i < 10; i++) {
           p1 = new Persona("Matute", "18/04/2007");
            personas.add(p1);

           p1 = new Persona("Mazza", "20/04/1997");
            personas.add(p1);

            p1 = new Persona("Uni", "18/11/2010");
            personas.add(p1);

            p1 = new Persona("Santutu", "11/09/2001");
            personas.add(p1);
        }

        System.out.println(personas.get(3).nombre + " nació el " + personas.get(3).fecha_nac + " y tiene " + personas.get(3).edad() + " años.");    }
}