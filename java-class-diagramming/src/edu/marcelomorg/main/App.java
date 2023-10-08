package edu.marcelomorg.main;

import edu.marcelomorg.main.interfaces.IMusicPlayer;
import edu.marcelomorg.main.models.SmartPhone;

public class App {
    public static void main(String[] args) throws Exception {
        SmartPhone sp1 = new SmartPhone("Sansung", "S23");
        sp1.allFunctions();

        SmartPhone sp2 = new SmartPhone("Iphone", "15 pro");
        sp2.allFunctions();


        //Object only receives methods of the declared type, in this case the IMusicPlayer interface,
        //even though the instance is a class with more inherited interfaces.
        IMusicPlayer mpl = new SmartPhone("Xiomi", "X3");
        System.out.println("\n\n--- Device only IMusicPlayer interface ----");
        mpl.musicSelect();                                           
        mpl.play();
        mpl.pause();
    }
}
