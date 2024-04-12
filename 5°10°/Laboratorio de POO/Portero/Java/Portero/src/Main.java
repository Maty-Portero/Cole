public class Main {
    static Persona p1, p2;

    public static void main(String[] args) {
        p1 = new Persona("Matute", "18/04/2007");
        System.out.println(p1.nombre + " nació el " + p1.fecha_nac + " y tiene " + p1.edad() + " años.");

        p2 = new Persona("Juan", "15/05/1980");
        System.out.println(p2.nombre + " nació el " + p2.fecha_nac + " y tiene " + p2.edad() + " años.");
    }
}