import java.awt.BorderLayout;
import java.awt.GridLayout;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;

import java.awt.*;
import java.applet.*;
import java.awt.*;
public class Cylinder3D extends Applet
{

public void paint(Graphics g)
{

int x[]={100,100,150,150};
int y[]={100,149,149,100};
g.setColor(Color.gray);
g.fillPolygon(x,y,4);

g.setColor(Color.gray);
g.fillOval(74,100,50,50);
g.setColor(Color.black);

g.setColor(Color.black);
g.fillOval(124,100,50,50);

g.setColor(Color.black);
g.drawLine(100,100,150,100);

g.setColor(Color.black);
g.drawLine(100,149,150,149);

}

public static void main(String[] args) {
   
   Cylinder3D c  = new Cylinder3D();
   JFrame f = new JFrame();
   f.add(c);
   f.setSize(300, 300);
   f.setVisible(true);  
}
}