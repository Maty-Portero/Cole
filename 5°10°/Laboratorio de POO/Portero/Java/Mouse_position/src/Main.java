import java.awt.*;
import javax.swing.*;
import java.lang.Thread;
import java.lang.InterruptedException;

public class Main extends JPanel {
    public static void main(String[] args) {

        // Crea una nueva ventana
        JFrame frame = new JFrame("Asterisco en Pantalla");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        // Crea un panel personalizado para dibujar el asterisco
        JPanel panel = new JPanel() {
            @Override
            protected void paintComponent(Graphics g) {
                int n = 3;

                super.paintComponent(g);
                // Dibuja el asterisco en las coordenadas especificadas
                for (int i = 0; i < n; i++){
                    g.clearRect(1, 1, 300, 300);
                    try {
                        Thread.sleep(100);
                    } catch (Exception e){
                        System.out.println(e);
                    }
                    g.drawString("*", 100, 100);

                }
            }
        };

        frame.add(panel);
        frame.setSize(300, 300);
        frame.setVisible(true);
    }
}